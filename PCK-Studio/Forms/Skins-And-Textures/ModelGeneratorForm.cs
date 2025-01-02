using OMI.Formats.Pck;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using PckStudio.Extensions;
using PckStudio.Internal;
using PckStudio.Renderer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PckStudio.Forms {
	public partial class ModelGeneratorForm : Form {
		private Image _previewImage;
		public Image PreviewImage => _previewImage;

		private PckAsset _asset;
		private SkinANIM _ANIM;

		private static Color _backgroundColor = Color.FromArgb(0xff, 0x50, 0x50, 0x50);
		private static GraphicsConfig _graphicsConfig = new GraphicsConfig() {
			InterpolationMode = InterpolationMode.NearestNeighbor,
			PixelOffsetMode = PixelOffsetMode.HighQuality,
		};

		private static readonly string[] ValidModelBoxTypes = new string[]
		{
			// Base 64x32 Parts
			"HEAD",
			"BODY",
			"ARM0",
			"ARM1",
			"LEG0",
			"LEG1",

			// 64x64 Overlay Parts
			"HEADWEAR",
			"JACKET",
			"SLEEVE0",
			"SLEEVE1",
			"WAIST",
			"PANTS0",
			"PANTS1",

			// Armor Parts
			"BODYARMOR",
			"ARMARMOR0",
			"ARMARMOR1",
			"BELT",
			"LEGGING0",
			"LEGGING1",
			"SOCK0",
			"SOCK1",
			"BOOT0",
			"BOOT1"
		};

		private static readonly string[] ValidModelOffsetTypes = new string[]
		{
			// Body Offsets
			"HEAD",
			"BODY",
			"ARM0",
			"ARM1",
			"LEG0",
			"LEG1",

			// Armor Offsets
			"HELMET",
			"CHEST", "BODYARMOR",
			"SHOULDER0", "ARMARMOR0",
			"SHOULDER1", "ARMARMOR0",
			"BELT",
			"LEGGING0",
			"LEGGING1",
			"SOCK0", "BOOT0",
			"SOCK1", "BOOT1",

			"TOOL0",
			"TOOL1",
		};

		SkinBOX selectedBox;
		List<SkinBOX> modelBoxes = new List<SkinBOX>();
		List<ModelOffset> modelOffsets = new List<ModelOffset>();

		private class ModelOffset {
			public string Name;
			public float YOffset;

			public ModelOffset(string name, float yOffset) {
				Name = name;
				YOffset = yOffset;
			}
			public (string, string) ToProperty() {
				string value = $"{Name} Y {YOffset}";
				return ("OFFSET", value.Replace(',', '.'));
			}
		}

		public ModelGeneratorForm(PckAsset asset) {
			InitializeComponent();
			_asset = asset;
			if(asset.Size > 0) {
				using(var ms = new MemoryStream(asset.Data)) {
					bitmap = new Bitmap(Image.FromStream(ms));
					uvPictureBox.Image = Image.FromStream(ms);
				}
			}
			comboParent.Items.Clear();
			comboParent.Items.AddRange(ValidModelBoxTypes);
			LoadData(asset);
		}

		private static readonly Regex sWhitespace = new Regex(@"\s+");
		public static string ReplaceWhitespace(string input, string replacement) {
			return sWhitespace.Replace(input, replacement);
		}

		private void LoadData(PckAsset asset) {
			comboParent.Enabled = asset.GetMultipleProperties("BOX").All(kv => {
				var box = SkinBOX.FromString(kv.Value);
				if(ValidModelBoxTypes.Contains(box.Type)) {
					modelBoxes.Add(box);
					return true;
				}
				return false;
			});
			asset.GetMultipleProperties("OFFSET").All(kv => {
				string[] offset = ReplaceWhitespace(kv.Value, ",").TrimEnd('\n', '\r', ' ').Split(',');
				if(offset.Length < 3)
					return false;
				string name = offset[0];
				if(offset[1] != "Y")
					return false;
				float value = float.Parse(offset[2]);
				if(ValidModelOffsetTypes.Contains(name)) {
					modelOffsets.Add(new ModelOffset(name, value));
					return true;
				}
				return false;
			});

			_ANIM = asset.GetProperty("ANIM", SkinANIM.FromString);
			UpdateListView();
			Rerender();
		}

		//Rename model part/item
		private void renameSkinBox(object sender, EventArgs e) {
			listViewBoxes.SelectedItems[0].BeginEdit();
		}

		private void Rerender([CallerMemberName] string caller = default!) {
			Debug.WriteLine($"Call from {caller}", category: nameof(Rerender));
			if(generateTextureCheckBox.Checked)
				GenerateUVTextureMap();
		}

		#region GL rendering using OpenTK

		// TODO: line drawing in OpenGL for armor & guidelines, floor grid
		private Timer glTimer;
		private GLShader shader;
		private Bitmap bitmap;
		private GLTexture skin;
		private GLHumanoidModel model;
		private GLCamera camera;
		private double time;

		private string vertShader = @"#version 330 core
layout (location = 0) in vec3 aPosition;
layout (location = 1) in vec2 aTexCoord;
layout (location = 2) in vec3 aNormal;

uniform mat4 model;
uniform mat4 view;
uniform mat4 projection;

uniform vec2 textureSize;
uniform vec2 uvOffset;

out vec2 TexCoord;
out vec3 Normal;

void main(){
	gl_Position = projection * view * model * vec4(aPosition, 1.0);
	TexCoord = (aTexCoord + uvOffset) / textureSize;
	Normal = ( ( model * vec4(aPosition + aNormal, 1.0) ) - ( model * vec4(aPosition, 1.0) ) ).xyz;
}";
		private string fragShader = @"#version 330 core
out vec4 FragColor;
in vec2 TexCoord;
in vec3 Normal;
uniform vec4 mixColor;
uniform sampler2D skinTexture;
vec3 lightDir = normalize(vec3(1.0, 1.0, 1.0));
vec3 ambientColor = vec3(0.25, 0.25, 0.25);

void main(){
	vec4 color = texture(skinTexture, TexCoord);
	if(color.a <= 0.0)
		discard;
	FragColor = color * vec4(ambientColor * dot(normalize(Normal), lightDir) + (vec3(1.0)-ambientColor), 1.0);
}";

		private void GLInit() {
			mainView.Resize += GLResized;
			mainView.Paint += GLPaint;

			GLResized(mainView, EventArgs.Empty);

			time = 0.0d;
			glTimer = new Timer();
			glTimer.Tick += (sender, e) => {
				time += 0.0166f;
				GLRender(sender, e);
			};
			glTimer.Interval = 16; // 60fps
			glTimer.Start();

			// Object creation
			skin = new GLTexture(bitmap);
			shader = new GLShader(vertShader, fragShader);
			camera = new GLCamera(new Vector3(0.0f, 0.0f, 24.0f), new Vector3(0.0f, 0.0f, 0.0f));
			model = new GLHumanoidModel(skin);
		}

		private void GLResized(object sender, EventArgs e) {
			GL.Viewport(0, 0, mainView.Width, mainView.Height);
		}

		private void GLPaint(object sender, EventArgs e) {
			GLRender(sender, e);
		}

		private void GLEnableZoom(object sender, EventArgs e) {
			mainView.Focus();
		}

		private void GLZoom(object sender, MouseEventArgs e) {
			camera.Zoom(e.Delta);
		}

		private void GLStartPanning(object sender, MouseEventArgs e) {
			camera.StartPanning(new Vector2(e.X, e.Y));
		}

		private void GLPan(object sender, MouseEventArgs e) {
			camera.Pan(new Vector2(e.X, e.Y));
		}

		private void GLStopPanning(object sender, MouseEventArgs e) {
			camera.StopPanning();
		}

		private void GLRender(object sender, EventArgs e) {
			// Context and clear
			mainView.MakeCurrent();
			GL.ClearColor(Color4.AliceBlue);
			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			GL.Enable(EnableCap.Blend);
			GL.Enable(EnableCap.DepthTest);
			GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
			// View matrix
			model.Tick(time);
			// Projection
			Matrix4 projection = Matrix4.CreatePerspectiveFieldOfView(
				MathHelper.DegreesToRadians(45.0f),
				(float)mainView.Width / (float)mainView.Height,
				0.1f, 100.0f
			);
			// Use texture
			skin.Use();
			// Setup shader
			shader.Use();
			shader.SetMat4("view", camera.GetMatrix());
			shader.SetMat4("projection", projection);
			model.Render(shader, camera.Position);
			// Display output
			mainView.SwapBuffers();
		}
		private void GLDeinit(object sender, EventArgs e) {
			mainView.Resize -= GLResized;
			mainView.Paint -= GLPaint;
			glTimer.Stop();
			model.Dispose();
			shader.Dispose();
		}

		#endregion

		private void GenerateUVTextureMap() {
			Random rng = new Random();
			using(Graphics graphics = Graphics.FromImage(uvPictureBox.Image)) {
				graphics.ApplyConfig(_graphicsConfig);
				foreach(SkinBOX part in modelBoxes) {
					float width = part.Size.X * 2;
					float height = part.Size.Y * 2;
					float length = part.Size.Z * 2;
					float u = part.UV.X * 2;
					float v = part.UV.Y * 2;
					int argb = rng.Next(-16777216, -1); // 0xFF000000 - 0xFFFFFFFF
					var color = Color.FromArgb(argb);
					Brush brush = new SolidBrush(color);
					graphics.FillRectangle(brush, u + length, v, width, length);
					graphics.FillRectangle(brush, u + length + width, v, width, length);
					graphics.FillRectangle(brush, u, length + v, length, height);
					graphics.FillRectangle(brush, u + length, v + length, width, height);
					graphics.FillRectangle(brush, u + length + width, v + length, width, height);
					graphics.FillRectangle(brush, u + length + width * 2, v + length, length, height);
				}
			}
			uvPictureBox.Invalidate();
		}

		// TODO: call this and PopulateGLBoxes when the user edits
		private void EmptyGLBoxes() {
			if(model != null) {
				for(int i = model.Boxes.Count-1; i >= 0; i--) {
					GLBox box = model.Boxes[i];
					box.Dispose();
					model.Boxes.RemoveAt(i);
				}
			}
		}

		// This also converts 4J's BOX format to our custom OpenGL format
		// TODO: fix offset for when a skin uses thinner arms e.g. Kazooie/Birthday#2
		private void PopulateGLBoxes() {
			if(model != null) {
				for(int i = modelBoxes.Count-1; i >= 0; i--) {
					// GLBox (our Box)
					// starts at the center.
					// SkinBOX (4J's Box)
					// starts at the top left back corner.
					SkinBOX skinBox = modelBoxes[i];
					GLBox glBox = new GLBox(model.Skin);
					glBox.Size = new Vector3(skinBox.Size.X, skinBox.Size.Y, skinBox.Size.Z);
					glBox.Offset = new Vector2(skinBox.UV.X, skinBox.UV.Y);
					switch(skinBox.Type) {
						case "HEAD":
							glBox.Parent = model.Head;
							break;
						case "BODY":
							glBox.Parent = model.Body;
							break;
						case "ARM0":
							glBox.Parent = model.LeftArm;
							break;
						case "ARM1":
							glBox.Parent = model.RightArm;
							break;
						case "LEG0":
							glBox.Parent = model.LeftLeg;
							break;
						case "LEG1":
							glBox.Parent = model.RightLeg;
							break;
					}
					// move to the bottom, something corner
					if(glBox.Parent != null) {
						// There seems to be a really, really
						// weird case where the Head has it correct like this:
						if(skinBox.Type == "HEAD") {
							// ...where we move the box to the bottom corner.
							glBox.Transform.Position = new Vector3(
								0,
								-glBox.Parent.Size.Y/2.0f,
								0
							);
						} else if(skinBox.Type == "ARM0") {
							// For arms, towards shoulder????
							glBox.Transform.Position = new Vector3(
								(glBox.Parent.Size.X/2.0f - 1.0f),
								glBox.Parent.Size.Y/2.0f - 2.0f,
								0
							);
						} else if(skinBox.Type == "ARM1") {
							// For arms, towards shoulder????
							glBox.Transform.Position = new Vector3(
								-(glBox.Parent.Size.X/2.0f - 1.0f),
								glBox.Parent.Size.Y/2.0f - 2.0f,
								0
							);
						} else {
							// Anywhere else, it's the top corner?
							glBox.Transform.Position = new Vector3(
								0,
								glBox.Parent.Size.Y/2.0f,
								0
							);
						}
					}
					glBox.Transform.Position += new Vector3(
						glBox.Size.X/2.0f,
						-glBox.Size.Y/2.0f,
						-glBox.Size.Z/2.0f
					);
					// apply 4J's position on top of it
					// 4J's Y and Z seem to be negative compared to ours?
					glBox.Transform.Position += new Vector3(
						skinBox.Pos.X,
						-skinBox.Pos.Y,
						-skinBox.Pos.Z
					);
					model.Boxes.Add(glBox);
				}
			}
		}

		private void formLoaded(object sender, EventArgs e) {
			//if (Screen.PrimaryScreen.Bounds.Height >= 780 && Screen.PrimaryScreen.Bounds.Width >= 1080)
			//    return;
			//
			//Rerender();
			GLInit();
			PopulateGLBoxes();
		}

		private void createSkinBox(object sender, EventArgs e) {
			modelBoxes.Add(SkinBOX.Empty);
			UpdateListView();
			Rerender();
		}

		//Changes Item Model Class
		private void parentChanged(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				part.Type = comboParent.Text;
				importButton.Enabled = true;
				exportButton.Enabled = true;
				SizeXUpDown.Enabled = true;
				SizeYUpDown.Enabled = true;
				SizeZUpDown.Enabled = true;
				PosXUpDown.Enabled = true;
				PosYUpDown.Enabled = true;
				PosZUpDown.Enabled = true;
				UVXUpDown.Enabled = true;
				UVYUpDown.Enabled = true;
			}
			Rerender();
		}

		private void xSizeChanged(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				part.Size.X = (float)SizeXUpDown.Value;
			}
			UpdateListView();
			Rerender();
		}

		private void ySizeChanged(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				part.Size.Y = (float)SizeYUpDown.Value;
			}
			UpdateListView();
			Rerender();
		}

		private void zSizeChanged(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				part.Size.Z = (float)SizeZUpDown.Value;
			}
			UpdateListView();
			Rerender();
		}

		private void xPosChanged(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				part.Pos.X = (float)PosXUpDown.Value;
			}
			UpdateListView();
			Rerender();
		}


		private void yPosChanged(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				part.Pos.Y = (float)PosYUpDown.Value;
			}
			UpdateListView();
			Rerender();
		}

		private void zPosChanged(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				part.Pos.Z = (float)PosZUpDown.Value;
			}
			UpdateListView();
			Rerender();
		}


		//Sets Texture X-Offset
		private void uCoordChanged(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				part.UV.X = (int)UVXUpDown.Value;
			}
			UpdateListView();
			Rerender();
		}


		//Sets texture Y-Offset
		private void vCoordChanged(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				part.UV.Y = (int)UVYUpDown.Value;
			}
			UpdateListView();
			Rerender();
		}


		//Export Current Skin Texture
		private void exportSkinTexture(object sender, EventArgs e) {
			// Not all skins are 64x64.
			Bitmap bitmap = new Bitmap(uvPictureBox.Image);
			using SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "PNG Image Files | *.png";
			if(saveFileDialog.ShowDialog(this) == DialogResult.OK) {
				bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
			}
		}


		//Imports Skin Texture
		private void importSkinTexture(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "PNG Image Files | *.png";
			openFileDialog.Title = "Select Skin Texture";

			if(openFileDialog.ShowDialog(this) == DialogResult.OK) // skins can only be a 1:1 ratio (base 64x64) or a 2:1 ratio (base 64x32)
			{
				using(var img = Image.FromFile(openFileDialog.FileName)) {
					if((img.Width == img.Height || img.Height == img.Width / 2)) {
						generateTextureCheckBox.Checked = false;
						using(Graphics graphics = Graphics.FromImage(uvPictureBox.Image)) {
							graphics.ApplyConfig(_graphicsConfig);
							graphics.DrawImage(img, 0, 0, img.Width, img.Height);
						}
						uvPictureBox.Invalidate();
						Rerender();
					} else {
						MessageBox.Show(this, "Not a valid skin file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		// Creates Model Data and Finalizes
		private void finished(object sender, EventArgs e) {
			foreach(SkinBOX part in modelBoxes) {
				_asset.AddProperty("BOX", part);
			}

			//Bitmap bitmap2 = new Bitmap(64, 64);
			//using (Graphics graphics = Graphics.FromImage(bitmap2))
			//{
			//    graphics.ApplyConfig(_graphicsConfig);
			//    graphics.DrawImage(uvPictureBox.Image, 0, 0, 64, 64);
			//}
			_previewImage = new Bitmap(mainView.Width, mainView.Height);
			Close();
		}

		// Renders model after texture change
		private void textureChanged(object sender, EventArgs e) {
			Rerender();
		}

		//Re-renders head with updated x-offset
		private void headOffsetChanged(object sender, EventArgs e) {
			Rerender();
		}


		//Re-renders body with updated x-offset
		private void bodyOffsetChanged(object sender, EventArgs e) {
			Rerender();
		}
		
		//Re-renders tool with updated x-offset
		private void toolOffsetChanged(object sender, EventArgs e) {
			Rerender();
		}

		//Re-renders helmet with updated x-offset
		private void helmetOffsetChanged(object sender, EventArgs e) {
			Rerender();
		}

		//Re-renders pants with updated x-offset
		private void pantsOffsetChanged(object sender, EventArgs e) {
			Rerender();
		}

		//Re-renders leggings with updated x-offset
		private void leggingsOffsetChanged(object sender, EventArgs e) {
			Rerender();
		}

		//Re-renders boots with updated x-offset
		private void bootsOffsetChanged(object sender, EventArgs e) {
			Rerender();
		}

		//Loads in model template(Steve)
		private void generateTemplate(object sender, EventArgs e) {
			modelBoxes.Add(SkinBOX.FromString("HEAD -4 -8 -4 8 8 8 0 0 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("BODY -4 0 -2 8 12 4 16 16 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("ARM0 -3 -2 -2 4 12 4 40 16 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("ARM1 -1 -2 -2 4 12 4 40 16 0 1 0"));
			modelBoxes.Add(SkinBOX.FromString("LEG0 -2 0 -2 4 12 4 0 16 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("LEG1 -2 0 -2 4 12 4 0 16 0 1 0"));
			comboParent.Enabled = true;
			UpdateListView();
			Rerender();
		}

		private void UpdateListView() {
			listViewBoxes.Items.Clear();
			foreach(SkinBOX part in modelBoxes) {
				ListViewItem listViewItem = new ListViewItem(part.Type);
				listViewItem.Tag = part;
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, part.Pos.X.ToString()));
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, part.Pos.Y.ToString()));
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, part.Pos.Z.ToString()));
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, part.Size.X.ToString()));
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, part.Size.Y.ToString()));
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, part.Size.Z.ToString()));
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, part.UV.X.ToString()));
				listViewItem.SubItems.Add(new ListViewItem.ListViewSubItem(listViewItem, part.UV.Y.ToString()));
				listViewBoxes.Items.Add(listViewItem);
			}
		}

		private void cloneSkinBox(object sender, EventArgs e) {
			try {
				ListViewItem listViewItem = new ListViewItem();
				ListViewItem selected = listViewBoxes.SelectedItems[0];
				listViewItem.Text = selected.Text;
				listViewItem.Tag = selected.Tag;
				int num = 0;
				foreach(ListViewItem.ListViewSubItem subItem in selected.SubItems) {
					if(num > 0)
						listViewItem.SubItems.Add(subItem.Text);
					++num;
				}
				listViewBoxes.Items.Add(listViewItem);
			} catch(Exception ex) {
				Console.WriteLine(ex.Message);
				MessageBox.Show(this, "Please Select a Part");
			}
		}

		private void deleteSkinBox(object sender, EventArgs e) {
			if(listViewBoxes.SelectedItems[0] == null)
				return;
			listViewBoxes.SelectedItems[0].Remove();
			Rerender();
		}

		private void changeSkinBoxDisplayColor(object sender, EventArgs e) {
			ColorDialog colorDialog = new ColorDialog();
			if(colorDialog.ShowDialog(this) == DialogResult.OK)
				listViewBoxes.SelectedItems[0].ForeColor = colorDialog.Color;
			Rerender();
		}

		private void skinBoxSelected(object sender, EventArgs e) {
			selectedBox = null;
			if(
				listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0] != null &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				selectedBox = part;
			}
			refreshValues();
			Rerender();
		}
		private void refreshValues() {
			bool exists = selectedBox != null;
			changeColorToolStripMenuItem.Visible = exists;
			SizeXUpDown.Enabled = exists;
			SizeYUpDown.Enabled = exists;
			SizeZUpDown.Enabled = exists;
			PosXUpDown.Enabled = exists;
			PosYUpDown.Enabled = exists;
			PosZUpDown.Enabled = exists;
			UVXUpDown.Enabled = exists;
			UVYUpDown.Enabled = exists;
			comboParent.Enabled = exists;
			if(exists) {
				comboParent.Text = selectedBox.Type;
				PosXUpDown.Value = (decimal)selectedBox.Pos.X;
				PosYUpDown.Value = (decimal)selectedBox.Pos.Y;
				PosZUpDown.Value = (decimal)selectedBox.Pos.Z;
				SizeXUpDown.Value = (decimal)selectedBox.Size.X;
				SizeYUpDown.Value = (decimal)selectedBox.Size.Y;
				SizeZUpDown.Value = (decimal)selectedBox.Size.Z;
				UVXUpDown.Value = (decimal)selectedBox.UV.X;
				UVYUpDown.Value = (decimal)selectedBox.UV.Y;
				Rerender();
			}
		}

		//currently scrapped
		private void formClosing(object sender, FormClosingEventArgs e) {
			GLDeinit(sender, e);
			/*
			if (MessageBox.Show("You done here?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
			{
				e.Cancel = true;
				return;
			}
			e.Cancel = false;*/
		}

		private void listViewKeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Delete && listViewBoxes.SelectedItems.Count != 0 &&
				listViewBoxes.SelectedItems[0].Tag is SkinBOX part) {
				if(modelBoxes.Remove(part))
					listViewBoxes.SelectedItems[0].Remove();
				Rerender();
			}
		}
	}
}