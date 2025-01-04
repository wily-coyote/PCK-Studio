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
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PckStudio.Forms {
	public partial class ModelGeneratorForm : Form {

		// TODO: This and ReplaceWhiteSpace should be in an util class instead of just being here.

		/** <summary>The .NET image used for the model. Used in GL rendering.</summary> **/
		private Bitmap bitmap;

		private Image previewImage;
		public Image PreviewImage => previewImage;

		/** <summary>The <see cref="PckAsset"/> this form is editing a model for.</summary> **/
		private PckAsset pckAsset;

		/** <summary>The <see cref="SkinANIM"/> property associated with this model, taken from <see cref="pckAsset"/>.</summary> **/
		private SkinANIM skinAnim;

		/** <summary>The currently selected SkinBOX. This should always be either an element of <see cref="modelBoxes"/> or null.</summary> **/
		SkinBOX selectedBox;
		
		List<SkinOFFSET> modelOffsets;

		/** <summary>A list of <see cref="SkinBOX"/>es used in the model. This is bound to <see cref="skinBoxList"/>, a <see cref="DataGridView"/>.</summary> **/
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
		}

		private void formLoaded(object sender, EventArgs e) {
			GLInit();
			modelBoxes.AddingNew += new AddingNewEventHandler(addingSkinBox);
			modelBoxes.ListChanged += new ListChangedEventHandler(changeSkinBox);
			LoadData(pckAsset);
			skinBoxList.DataSource = modelBoxes;
			skinBoxList.SelectionChanged += changeSelection;
			skinBoxList.ClearSelection();
			applyFlags();
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
			armorCheckBox.Enabled = exists;
			mirrorCheckBox.Enabled = exists;
			InflateUpDown.Enabled = exists;
			cloneToolStripMenuItem.Enabled = exists;
			deleteToolStripMenuItem.Enabled = exists;
			changeColorToolStripMenuItem.Enabled = exists;
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
				armorCheckBox.Checked = selectedBox.ArmorFlag;
				mirrorCheckBox.Checked = selectedBox.Mirror;
				InflateUpDown.Value = (decimal)selectedBox.Scale;
			}
			noUpdate = false;
		}

		private void applyFlags() {
			if(skinAnim != null) {
				model.Head.Visible =		!skinAnim.GetFlag(SkinAnimFlag.HEAD_DISABLED);
				model.Body.Visible =		!skinAnim.GetFlag(SkinAnimFlag.BODY_DISABLED);
				model.LeftArm.Visible =		!skinAnim.GetFlag(SkinAnimFlag.LEFT_ARM_DISABLED);
				model.RightArm.Visible =	!skinAnim.GetFlag(SkinAnimFlag.RIGHT_ARM_DISABLED);
				model.LeftLeg.Visible =		!skinAnim.GetFlag(SkinAnimFlag.LEFT_LEG_DISABLED);
				model.RightLeg.Visible =	!skinAnim.GetFlag(SkinAnimFlag.RIGHT_LEG_DISABLED);
				model.Hat.Visible =			!skinAnim.GetFlag(SkinAnimFlag.HEAD_OVERLAY_DISABLED);
			} else {
				model.Head.Visible = true;
				model.Body.Visible = true;
				model.LeftArm.Visible = true;
				model.RightArm.Visible = true;
				model.LeftLeg.Visible = true;
				model.RightLeg.Visible = true;
				model.Hat.Visible = true;
			}
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
					model.Boxes.RemoveAt(e.NewIndex);
					break;
				case ListChangedType.ItemChanged:
					RecalculateGLBox(modelBoxes[e.NewIndex], model.Boxes[e.NewIndex]);
					break;
				case ListChangedType.ItemAdded:
					SkinBOX skinBox = modelBoxes[e.NewIndex];
					GLBox glBox = CreateGLBox(skinBox);
					model.Boxes.Insert(e.NewIndex, glBox);
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
				selectedBox.ArmorFlag = armorCheckBox.Checked;
				selectedBox.Mirror = mirrorCheckBox.Checked;
				selectedBox.Scale = (float)InflateUpDown.Value;
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
				string[] offset = Utilities.ReplaceWhitespace(kv.Value, ",").TrimEnd('\n', '\r', ' ').Split(',');
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
		
		/** <summary>Converts a SkinBOX to a GLBox. If the GLBox evaluates to null, a new GLBox is created.</summary> **/
		private GLBox RecalculateGLBox(SkinBOX skinBox, GLBox glBox) {
			if(glBox == null)
				glBox = new GLBox(model.Skin);
			return glBox.UpdateFromSkinBox(model, skinBox);
		}
		
		private GLBox CreateGLBox(SkinBOX skinBox) {
			return GLBox.FromSkinBox(skin, model, skinBox);
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
					} else {
						MessageBox.Show(this, "This is not a skin file. Are you sure this is a 64x64 or 64x32 image?", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		// Creates Model Data and Finalizes
		private void finished(object sender, EventArgs e) {
			pckAsset.RemoveProperties("BOX");
			foreach(SkinBOX part in modelBoxes) {
				pckAsset.AddProperty("BOX", part);
			}
			previewImage = new Bitmap(mainView.Width, mainView.Height);
			Close();
		}

		//Loads in model template(Steve)
		private void generateTemplate(object sender, EventArgs e) {
			modelBoxes.Add(SkinBOX.FromString("HEAD -4 -8 -4 8 8 8 0 0 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("BODY -4 0 -2 8 12 4 16 16 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("ARM0 -3 -2 -2 4 12 4 40 16 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("ARM1 -1 -2 -2 4 12 4 40 16 0 1 0"));
			modelBoxes.Add(SkinBOX.FromString("LEG0 -2 0 -2 4 12 4 0 16 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("LEG1 -2 0 -2 4 12 4 0 16 0 1 0"));
		}

		private void formClosing(object sender, FormClosingEventArgs e) {
			GLDeinit(sender, e);
		}

		private void toggleAnimationChanged(object sender, EventArgs e) {
			model.Animate = toggleAnimationCheckBox.Checked;
		}

		private void doHelp(object sender, EventArgs e) {
			// WM_SYSCOMMAND SC_CONTEXTHELP
			Utilities.SendMessage(this.Handle, 0x0112, 0xf180, 0x0);
		}

		private void cancel(object sender, EventArgs e) {
			Close();
		}
	}
}