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
	/** <summary>A form that allows editing of BOX properties with a 3D view, used for custom skin models.</summary> **/
	public partial class ModelGeneratorForm : Form {
		/** <summary>The .NET image used for the model. Used in GL rendering.</summary> **/
		private Bitmap bitmap;

		private Image previewImage;
		public Image PreviewImage => previewImage;

		/** <summary>The <see cref="PckAsset"/> this form is editing a model for.</summary> **/
		private PckAsset pckAsset;

		/** <summary>The <see cref="SkinANIM"/> property associated with this model, taken from <see cref="pckAsset"/>.</summary> **/
		private SkinANIM skinAnim;

		/** <summary>The currently selected SkinBOX. This should always be either an element of <see cref="modelBoxes"/> or null.</summary> **/
		private SkinBOX selectedBox;
		
		private List<SkinOFFSET> modelOffsets;

		/** <summary>A list of <see cref="SkinBOX"/>es used in the model. This is bound to <see cref="skinBoxList"/>, a <see cref="DataGridView"/>.</summary> **/
		private BindingList<SkinBOX> modelBoxes;

		/** <summary>Prevents the form's controls from updating the current SkinBOX.</summary> **/
		private bool noUpdate;
		
		/** <summary>Creates a model editor form with <paramref name="asset"/>. For devs, put internal data-related stuff here.</summary> **/
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
			DialogResult = DialogResult.None;
		}

		/** <summary>Called when the form loads. Put external data-related stuff here.</summary> **/
		private void FormLoaded(object sender, EventArgs e) {
			GLInit();
			modelBoxes.AddingNew += new AddingNewEventHandler(SkinBoxAdding);
			modelBoxes.ListChanged += new ListChangedEventHandler(SkinBoxChanged);
			LoadData(pckAsset);
			skinBoxList.DataSource = modelBoxes;
			skinBoxList.SelectionChanged += SelectionChanged;
			skinBoxList.ClearSelection();
			ApplyAnimFlags();
			RefreshForm();
		}

		/** <summary>Changes model depending on SkinAnim flags.</summary> **/
		private void RefreshForm() {
			noUpdate = true;
			bool exists = selectedBox != null;
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
			selectBox.Visible = exists;
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
				selectBox.UpdateFromSkinBox(model, selectedBox);
			}
			noUpdate = false;
		}

		/** <summary>Changes model depending on SkinAnim flags.</summary> **/
		private void ApplyAnimFlags() {
			if(skinAnim != null) {
				// base
				model.Head.Visible =		!skinAnim.GetFlag(SkinAnimFlag.HEAD_DISABLED);
				model.Body.Visible =		!skinAnim.GetFlag(SkinAnimFlag.BODY_DISABLED);
				model.LeftArm.Visible =		!skinAnim.GetFlag(SkinAnimFlag.LEFT_ARM_DISABLED);
				model.RightArm.Visible =	!skinAnim.GetFlag(SkinAnimFlag.RIGHT_ARM_DISABLED);
				model.LeftLeg.Visible =		!skinAnim.GetFlag(SkinAnimFlag.LEFT_LEG_DISABLED);
				model.RightLeg.Visible =	!skinAnim.GetFlag(SkinAnimFlag.RIGHT_LEG_DISABLED);
				model.Hat.Visible =		!skinAnim.GetFlag(SkinAnimFlag.HEAD_OVERLAY_DISABLED);
				// layers
				model.LaterModel =		skinAnim.GetFlag(SkinAnimFlag.RESOLUTION_64x64);
				if(model.LaterModel){
					model.Jacket.Visible =		!skinAnim.GetFlag(SkinAnimFlag.BODY_OVERLAY_DISABLED);
					model.LeftSleeve.Visible =	!skinAnim.GetFlag(SkinAnimFlag.LEFT_ARM_OVERLAY_DISABLED);
					model.RightSleeve.Visible =	!skinAnim.GetFlag(SkinAnimFlag.RIGHT_ARM_OVERLAY_DISABLED);
					model.LeftPant.Visible =	!skinAnim.GetFlag(SkinAnimFlag.LEFT_LEG_OVERLAY_DISABLED);
					model.RightPant.Visible =	!skinAnim.GetFlag(SkinAnimFlag.RIGHT_LEG_OVERLAY_DISABLED);
				} else {
					model.Jacket.Visible = false;
					model.LeftSleeve.Visible = false;
					model.RightSleeve.Visible = false;
					model.LeftPant.Visible = false;
					model.RightPant.Visible = false;
				}
			} else {
				model.Head.Visible = true;
				model.Body.Visible = true;
				model.LeftArm.Visible = true;
				model.RightArm.Visible = true;
				model.LeftLeg.Visible = true;
				model.RightLeg.Visible = true;
				model.Hat.Visible = true;
				model.LaterModel = false;
			}
		}

		/** <summary>Supposed to show up when right clicking on the DataGridView.</summary> **/
		private void ShowContextMenu(object sender, MouseEventArgs e) {
			if(e.Button == MouseButtons.Right) {
				var hit = skinBoxList.HitTest(e.X, e.Y);
				skinBoxList.ClearSelection();
				if(hit.RowIndex != -1) {
					skinBoxList.Rows[hit.RowIndex].Selected = true;
				}
				SelectionChanged(sender, EventArgs.Empty);
				boxContextMenu.Show(this, new Point(e.X, e.Y));
			}
		}

		/** <summary>Adds a new SkinBOX to the end of the list.</summary> **/
		private void SkinBoxAdding(object sender, AddingNewEventArgs e) {
			e.NewObject = SkinBOX.Empty;
		}

		/** <summary>Adds a new SkinBOX to the end of the list.</summary> **/
		private void SkinBoxAdded(object sender, EventArgs e) {
			modelBoxes.AddNew();
		}

		/** <summary>Removes the currently selected SkinBOX.</summary> **/
		private void SkinBoxRemoved(object sender, EventArgs e) {
			if(selectedBox != null) {
				modelBoxes.Remove(selectedBox);
			}
		}

		/** <summary>Creates a copy of the currently selected SkinBOX and places it immediately after the latter.</summary> **/
		private void SkinBoxCloned(object sender, EventArgs e) {
			if(selectedBox != null) {
				modelBoxes.Insert(modelBoxes.IndexOf(selectedBox)+1, (SkinBOX)selectedBox.Clone());
			}
		}

		/** <summary>Called when the SkinBOX list is interacted with.</summary> **/
		private void SkinBoxChanged(object sender, ListChangedEventArgs e) {
			switch(e.ListChangedType) {
				case ListChangedType.ItemDeleted:
					model.Boxes.RemoveAt(e.NewIndex);
					break;
				case ListChangedType.ItemChanged:
					RecalculateGLBox(modelBoxes[e.NewIndex], model.Boxes[e.NewIndex]);
					if(selectedBox != null)
						selectBox.UpdateFromSkinBox(model, selectedBox);
					break;
				case ListChangedType.ItemAdded:
					SkinBOX skinBox = modelBoxes[e.NewIndex];
					GLBox glBox = CreateGLBox(skinBox);
					model.Boxes.Insert(e.NewIndex, glBox);
					break;
			}
		}

		/** <summary>Called when the form's controls change: used to change the current SkinBOX accordingly.</summary> **/
		private void FormChangeSkinBox(object sender, EventArgs e) {
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
		
		/** <summary>Called when the DataGridView changes selection.</summary> **/
		private void SelectionChanged(object sender, EventArgs e) {
			selectedBox = null;
			var cells = skinBoxList.SelectedCells;
			if(cells.Count > 0) {
				selectedBox = cells[0].OwningRow.DataBoundItem as SkinBOX;
				RefreshForm();
			}
		}

		/** <summary>Loads <paramref name="asset"/>'s data into the form. Data includes BOX properties, OFFSET properties and ANIM properties.</summary> **/
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

		// TODO: line drawing in OpenGL for armor & guidelines, floor grid, current selection
		private Timer glTimer;
		private GLShader boxShader;
		private GLShader wireShader;
		private GLTexture skin;
		private GLHumanoidModel model;
		// TODO: this is where the selection box goes
		// also, let the texture for GLBox be nullable
		// and make it render above everything else by clearing
		// the depth bit after rendering everything
		// and also find out a way to render it in
		// wireframe
		private GLCamera camera;
		private GLWireBox selectBox;
		private double time;

		/** <summary>Initializes the 3D OpenTK view.</summary> **/
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
			boxShader = GLShaderSources.BoxShader();
			wireShader = GLShaderSources.WireShader();
			camera = new GLCamera(new Vector3(0.0f, 0.0f, 24.0f), new Vector3(0.0f, 0.0f, 0.0f));
			model = new GLHumanoidModel(skin);
			selectBox = new GLWireBox();
			selectBox.Color = new Vector4(1.0f, 1.0f, 0.0f, 1.0f);
		}

		/** <summary>Changes the viewport when the form is resized.</summary> **/
		private void GLResized(object sender, EventArgs e) {
			GL.Viewport(0, 0, mainView.Width, mainView.Height);
		}

		/** <summary>Run when the form receives WM_PAINT.</summary> **/
		private void GLPaint(object sender, EventArgs e) {
			GLRender(sender, e);
		}

		/** <summary>This is so scroll wheel events work.</summary> **/
		private void GLEnableZoom(object sender, EventArgs e) {
			mainView.Focus();
		}

		/** <summary>Zooms in and out depending on the mouse wheel.</summary> **/
		private void GLZoom(object sender, MouseEventArgs e) {
			camera.Zoom(e.Delta);
		}

		/** <summary>Begins panning upon mouse down.</summary> **/
		private void GLStartPanning(object sender, MouseEventArgs e) {
			camera.StartPanning(new Vector2(e.X, e.Y));
		}

		/** <summary>Pans when moving the mouse.</summary> **/
		private void GLPan(object sender, MouseEventArgs e) {
			camera.Pan(new Vector2(e.X, e.Y));
		}

		/** <summary>Stops panning on mouse release.</summary> **/
		private void GLStopPanning(object sender, MouseEventArgs e) {
			camera.StopPanning();
		}

		/** <summary>Render the 3D view on the form. This should happen every 1/60th of a second.</summary> **/
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
			// Setup boxShader
			boxShader.Use();
			boxShader.SetMat4("view", camera.GetMatrix());
			boxShader.SetMat4("projection", projection);
			model.Render(boxShader, camera.Position);
			// Clear depth for z-agnostic elements
			GL.Clear(ClearBufferMask.DepthBufferBit);
			wireShader.Use();
			wireShader.SetMat4("view", camera.GetMatrix());
			wireShader.SetMat4("projection", projection);
			selectBox.SetShader(wireShader);
			selectBox.Render();
			// Display output
			mainView.SwapBuffers();
		}

		/** <summary>Cleans up OpenTK objects, stops the animation timer and detaches rendering events.</summary> **/
		private void GLDeinit(object sender, EventArgs e) {
			mainView.Resize -= GLResized;
			mainView.Paint -= GLPaint;
			glTimer.Stop();
			model.Dispose();
			boxShader.Dispose();
			wireShader.Dispose();
			selectBox.Dispose();
		}

		#endregion
		
		/** <summary>Recalculates position values for a given <see cref="SkinBOX"/> and <see cref="GLBox"/>. If the GLBox evaluates to null, a new GLBox is created.</summary> **/
		private GLBox RecalculateGLBox(SkinBOX skinBox, GLBox glBox) {
			if(glBox == null)
				glBox = new GLBox(model.Skin);
			return glBox.UpdateFromSkinBox(model, skinBox);
		}
		
		/** <summary>Wrapper function around <see cref="GLBox.FromSkinBox"/>.</summary> **/
		private GLBox CreateGLBox(SkinBOX skinBox) {
			return GLBox.FromSkinBox(skin, model, skinBox);
		}

		/** <summary>Exports the skin texture.</summary> **/
		private void ExportImage(object sender, EventArgs e) {
			// Not all skins are 64x64.
			using SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Portable Network Graphics | *.png";
			if(saveFileDialog.ShowDialog(this) == DialogResult.OK) {
				bitmap.Save(saveFileDialog.FileName, ImageFormat.Png);
			}
		}

		/** <summary>Imports the skin texture.</summary> **/
		private void ImportImage(object sender, EventArgs e) {
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

		/** <summary>Creates the BOX property data for <see cref="pckAsset"/> and closes the form.</summary> **/
		private void FinishModel(object sender, EventArgs e) {
			pckAsset.RemoveProperties("BOX");
			foreach(SkinBOX part in modelBoxes) {
				pckAsset.AddProperty("BOX", part);
			}
			previewImage = new Bitmap(mainView.Width, mainView.Height);
			DialogResult = DialogResult.OK;
			Close();
		}

		/** <summary>Generates <see cref="SkinBOX"/>es based on the default Steve skin.</summary> **/
		private void GenerateTemplate(object sender, EventArgs e) {
			modelBoxes.Add(SkinBOX.FromString("HEAD -4 -8 -4 8 8 8 0 0 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("BODY -4 0 -2 8 12 4 16 16 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("ARM0 -3 -2 -2 4 12 4 40 16 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("ARM1 -1 -2 -2 4 12 4 40 16 0 1 0"));
			modelBoxes.Add(SkinBOX.FromString("LEG0 -2 0 -2 4 12 4 0 16 0 0 0"));
			modelBoxes.Add(SkinBOX.FromString("LEG1 -2 0 -2 4 12 4 0 16 0 1 0"));
		}

		/** <summary>Runs when the form closes. Used to clean up OpenTK.</summary> **/
		private void Exiting(object sender, FormClosingEventArgs e) {
			GLDeinit(sender, e);
		}
		
		/** <summary>Toggles animation on the model.</summary> **/
		private void AnimationToggled(object sender, EventArgs e) {
			model.Animate = toggleAnimationCheckBox.Checked;
		}

		/** <summary>Turns on "What's This?" mode from Win32.</summary> **/
		private void DoContextHelp(object sender, EventArgs e) {
			// WM_SYSCOMMAND SC_CONTEXTHELP
			Utilities.SendMessage(this.Handle, 0x0112, 0xf180, 0x0);
		}
		
		/** <summary>Closes the form without creating any property data for the asset.</summary> **/
		private void CancelModel(object sender, EventArgs e) {
			Close();
		}
	}
}
