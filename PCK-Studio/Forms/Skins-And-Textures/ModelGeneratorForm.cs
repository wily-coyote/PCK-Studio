using OMI.Formats.Pck;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using PckStudio.Extensions;
using PckStudio.Internal;
using PckStudio.Renderer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PckStudio.Forms {
	public partial class ModelGeneratorForm : Form {

		// TODO: This and ReplaceWhiteSpace should be in an util class instead of just being here.
		private static readonly Regex sWhitespace = new Regex(@"\s+");

		/** <summary>The skin texture used for the model. Used in GL rendering.</summary> **/
		private Bitmap bitmap;

		private Image previewImage;
		public Image PreviewImage => previewImage;

		/** <summary>The PckAsset this form is editing a model for.</summary> **/
		private PckAsset pckAsset;

		/** <summary>The ANIM property associated with this model, taken from <see cref="ModelGeneratorForm.pckAsset"/>.</summary> **/
		private SkinANIM skinAnim;

		private static GraphicsConfig _graphicsConfig = new GraphicsConfig() {
			InterpolationMode = InterpolationMode.NearestNeighbor,
			PixelOffsetMode = PixelOffsetMode.HighQuality,
		};
		
		/** <summary>The currently selected SkinBOX. This should always be either an element of <see cref="ModelGeneratorForm.modelBoxes"/> or null.</summary> **/
		SkinBOX selectedBox;
		
		List<SkinOFFSET> modelOffsets;

		/** <summary>A list of SkinBOXes used in the model. This is bound to <see cref="ModelGeneratorForm.skinBoxList"/>, a <see cref="DataGridView"/>.</summary> **/
		BindingList<SkinBOX> modelBoxes;

		/** <summary>Prevents the form's controls from updating the current SkinBOX.</summary> **/
		private bool noUpdate;
		
		public ModelGeneratorForm(PckAsset asset) {
			modelOffsets = new List<SkinOFFSET>();
			modelBoxes = new BindingList<SkinBOX>();
			modelBoxes.AllowNew = true;
			modelBoxes.AllowEdit = true;
			modelBoxes.AllowRemove = true;
			modelBoxes.RaiseListChangedEvents = true;
			InitializeComponent();
			pckAsset = asset;
			if(asset.Size > 0) {
				using(var ms = new MemoryStream(asset.Data)) {
					bitmap = new Bitmap(Image.FromStream(ms));
					uvPictureBox.Image = bitmap;
				}
			}
			comboParent.Items.Clear();
			comboParent.Items.AddRange(Enum.GetNames(typeof(BOXType)));
			LoadData(asset);
		}

		private void formLoaded(object sender, EventArgs e) {
			GLInit();
			PopulateGLBoxes();
			modelBoxes.AddingNew += new AddingNewEventHandler(addingSkinBox);
			modelBoxes.ListChanged += new ListChangedEventHandler(changeSkinBox);
			skinBoxList.DataSource = modelBoxes;
			skinBoxList.SelectionChanged += changeSelection;
			skinBoxList.ClearSelection();
			refreshValues();
		}

		private void refreshValues() {
			noUpdate = true;
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
				comboParent.Text = selectedBox.Type.ToString();
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
			noUpdate = false;
		}

		private void summonContextMenu(object sender, MouseEventArgs e) {
			if(e.Button == MouseButtons.Right) {
				var hit = skinBoxList.HitTest(e.X, e.Y);
				skinBoxList.ClearSelection();
				if(hit.RowIndex != -1) {
					skinBoxList.Rows[hit.RowIndex].Selected = true;
				}
				changeSelection(sender, EventArgs.Empty);
				boxContextMenu.Show(this, new Point(e.X, e.Y));
			}
		}

		private void addingSkinBox(object sender, AddingNewEventArgs e) {
			e.NewObject = SkinBOX.Empty;
		}

		private void addSkinBox(object sender, EventArgs e) {
			modelBoxes.AddNew();
		}

		private void removeSkinBox(object sender, EventArgs e) {
			if(selectedBox != null) {
				modelBoxes.Remove(selectedBox);
			}
		}

		private void cloneSkinBox(object sender, EventArgs e) {
			if(selectedBox != null) {
				modelBoxes.Insert(modelBoxes.IndexOf(selectedBox)+1, selectedBox);
			}
		}

		private void changeSkinBox(object sender, ListChangedEventArgs e) {
			switch(e.ListChangedType) {
				case ListChangedType.ItemDeleted:
					break;
				case ListChangedType.ItemChanged:
					break;
			}
		}

		private void formChangeSkinBox(object sender, EventArgs e) {
			if(selectedBox != null && !noUpdate) {
				selectedBox.Type =
					(BOXType)Enum.Parse(typeof(BOXType), (string)comboParent.SelectedItem);
				selectedBox.U = (float)UVXUpDown.Value;
				selectedBox.V = (float)UVYUpDown.Value;
				selectedBox.PosX = (float)PosXUpDown.Value;
				selectedBox.PosY = (float)PosYUpDown.Value;
				selectedBox.PosZ = (float)PosZUpDown.Value;
				selectedBox.SizeX = (float)SizeXUpDown.Value;
				selectedBox.SizeY = (float)SizeYUpDown.Value;
				selectedBox.SizeZ = (float)SizeZUpDown.Value;
			}
		}

		private void changeSelection(object sender, EventArgs e) {
			selectedBox = null;
			var cells = skinBoxList.SelectedCells;
			if(cells.Count > 0) {
				selectedBox = cells[0].OwningRow.DataBoundItem as SkinBOX;
				refreshValues();
			}
		}

		public static string ReplaceWhitespace(string input, string replacement) {
			return sWhitespace.Replace(input, replacement);
		}

		private void LoadData(PckAsset asset) {
			foreach(var kv in asset.GetMultipleProperties("BOX")) {
				try {
					modelBoxes.Add(SkinBOX.FromString(kv.Value));
				} catch(ArgumentException) {
					// do nothing and don't add it
				}
			}
			foreach(var kv in asset.GetMultipleProperties("OFFSET")) {
				// Was the .All() really necessary if you're not gonna use
				// the return value?
				string[] offset = ReplaceWhitespace(kv.Value, ",").TrimEnd('\n', '\r', ' ').Split(',');
				if(offset.Length >= 3 && offset[1] == "Y") {
					string name = offset[0];
					float value = float.Parse(offset[2]);
					if(Enum.IsDefined(typeof(OFFSETType), name)) {
						modelOffsets.Add(
							new SkinOFFSET((OFFSETType)Enum.Parse(typeof(OFFSETType), name),
						value));
					}
				}
			}
			skinAnim = asset.GetProperty("ANIM", SkinANIM.FromString);
		}

		// TODO: deprecate this (the GL renderer will pick up on any changes immediately)
		private void Rerender([CallerMemberName] string caller = default!) {
			Debug.WriteLine($"Call from {caller}", category: nameof(Rerender));
			if(generateTextureCheckBox.Checked)
				GenerateUVTextureMap();
		}

		#region GL rendering using OpenTK

		// TODO: line drawing in OpenGL for armor & guidelines, floor grid
		private Timer glTimer;
		private GLShader shader;
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
				0.1f, 1000.0f
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
		
		// TODO: deprecate this and use a second GLControl
		// to visualize UV mapping
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

		// TODO: is this necessary?
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
		// TODO: model hiding based on the ANIM property
		// TODO: synchronize our BindingList<SkinBOX> with GLHumanoidModel's List<GLBox>
		private void PopulateGLBoxes() {
			if(model != null) {
				for(int i = modelBoxes.Count-1; i >= 0; i--) {
					// GLBox (our Box)
					// starts at the center.
					// SkinBOX (4J's Box)
					// starts at the top left back corner.
					SkinBOX skinBox = modelBoxes[i];
					GLBox glBox = new GLBox(model.Skin);
					glBox.Size = new Vector3(skinBox.SizeX, skinBox.SizeY, skinBox.SizeZ);
					glBox.Offset = new Vector2(skinBox.U, skinBox.V);
					switch(skinBox.Type) {
						case BOXType.HEAD:
							glBox.Parent = model.Head;
							break;
						case BOXType.BODY:
							glBox.Parent = model.Body;
							break;
						case BOXType.ARM0:
							glBox.Parent = model.LeftArm;
							break;
						case BOXType.ARM1:
							glBox.Parent = model.RightArm;
							break;
						case BOXType.LEG0:
							glBox.Parent = model.LeftLeg;
							break;
						case BOXType.LEG1:
							glBox.Parent = model.RightLeg;
							break;
					}
					// move to the bottom, something corner
					if(glBox.Parent != null) {
						// There seems to be a really, really
						// weird case where the Head has it correct like this:
						if(skinBox.Type == BOXType.HEAD) {
							// ...where we move the box to the bottom corner.
							glBox.Transform.Position = new Vector3(
								0,
								-glBox.Parent.Size.Y/2.0f,
								0
							);
						} else if(skinBox.Type == BOXType.ARM0) {
							// For arms, towards shoulder????
							glBox.Transform.Position = new Vector3(
								(glBox.Parent.Size.X/2.0f - 1.0f),
								glBox.Parent.Size.Y/2.0f - 2.0f,
								0
							);
						} else if(skinBox.Type == BOXType.ARM1) {
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
						skinBox.PosX,
						-skinBox.PosY,
						-skinBox.PosZ
					);
					model.Boxes.Add(glBox);
				}
			}
		}

		//Export Current Skin Texture
		private void exportSkinTexture(object sender, EventArgs e) {
			// Not all skins are 64x64.
			using SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Portable Network Graphics | *.png";
			if(saveFileDialog.ShowDialog(this) == DialogResult.OK) {
				bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
			}
		}


		//Imports Skin Texture
		private void importSkinTexture(object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "Portable Network Graphics | *.png";
			openFileDialog.Title = "Select Skin Texture";
			// skins can only be a 1:1 ratio (base 64x64) or a 2:1 ratio (base 64x32)
			if(openFileDialog.ShowDialog(this) == DialogResult.OK) {
				using(Image img = Image.FromFile(openFileDialog.FileName)) {
					if(img.Width == img.Height || img.Height == img.Width / 2) {
						// Just the check is fine. It really didn't need to do all of the other stuff.
						bitmap = new Bitmap(img);
						uvPictureBox.Image = bitmap;
						Rerender();
					} else {
						MessageBox.Show(this, "This is not a skin file. Are you sure this is a 64x64 or 64x32 image?", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		// Creates Model Data and Finalizes
		private void finished(object sender, EventArgs e) {
			foreach(SkinBOX part in modelBoxes) {
				pckAsset.AddProperty("BOX", part);
			}
			previewImage = new Bitmap(mainView.Width, mainView.Height);
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
			Rerender();
		}

		private void formClosing(object sender, FormClosingEventArgs e) {
			GLDeinit(sender, e);
		}

		private void toggleAnimationChanged(object sender, EventArgs e) {
			model.Animate = toggleAnimationCheckBox.Checked;
		}
	}
}