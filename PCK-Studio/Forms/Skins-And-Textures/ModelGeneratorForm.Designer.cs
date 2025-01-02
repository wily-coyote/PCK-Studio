using System.Windows.Forms;

namespace PckStudio.Forms {
	partial class ModelGeneratorForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelGeneratorForm));
			this.boxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cloneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonDone = new System.Windows.Forms.Button();
			this.offsetGroup = new System.Windows.Forms.GroupBox();
			this.tabOffsets = new System.Windows.Forms.TabControl();
			this.tabArmor = new System.Windows.Forms.TabPage();
			this.tabBody = new System.Windows.Forms.TabPage();
			this.bodyLayout = new System.Windows.Forms.TableLayoutPanel();
			this.offsetArms = new System.Windows.Forms.TextBox();
			this.armsLabel = new System.Windows.Forms.Label();
			this.offsetBody = new System.Windows.Forms.TextBox();
			this.offsetLegs = new System.Windows.Forms.TextBox();
			this.headLabel = new System.Windows.Forms.Label();
			this.legsLabel = new System.Windows.Forms.Label();
			this.offsetHead = new System.Windows.Forms.TextBox();
			this.bodylabel = new System.Windows.Forms.Label();
			this.comboParent = new System.Windows.Forms.ComboBox();
			this.exportButton = new System.Windows.Forms.Button();
			this.importButton = new System.Windows.Forms.Button();
			this.buttonTemplate = new System.Windows.Forms.Button();
			this.generateTextureCheckBox = new System.Windows.Forms.CheckBox();
			this.showGuidelinesCheckBox = new System.Windows.Forms.CheckBox();
			this.showArmorCheckBox = new System.Windows.Forms.CheckBox();
			this.SizeXUpDown = new System.Windows.Forms.NumericUpDown();
			this.SizeYUpDown = new System.Windows.Forms.NumericUpDown();
			this.SizeZUpDown = new System.Windows.Forms.NumericUpDown();
			this.UVXUpDown = new System.Windows.Forms.NumericUpDown();
			this.UVYUpDown = new System.Windows.Forms.NumericUpDown();
			this.PosZUpDown = new System.Windows.Forms.NumericUpDown();
			this.PosYUpDown = new System.Windows.Forms.NumericUpDown();
			this.PosXUpDown = new System.Windows.Forms.NumericUpDown();
			this.Part = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._Width = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this._Height = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.U = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.V = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.listViewBoxes = new System.Windows.Forms.ListView();
			this.positionGroup = new System.Windows.Forms.GroupBox();
			this.positionGroupLayout = new System.Windows.Forms.TableLayoutPanel();
			this.sizeGroup = new System.Windows.Forms.GroupBox();
			this.sizeGroupLayout = new System.Windows.Forms.TableLayoutPanel();
			this.uvGroup = new System.Windows.Forms.GroupBox();
			this.uvGroupLayout = new System.Windows.Forms.TableLayoutPanel();
			this.optionsLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			this.texturePreviewGroup = new System.Windows.Forms.GroupBox();
			this.texturePreviewLayout = new System.Windows.Forms.TableLayoutPanel();
			this.uvPictureBox = new PckStudio.ToolboxItems.InterpolationPictureBox();
			this.mainView = new OpenTK.GLControl();
			this.parentGroup = new System.Windows.Forms.GroupBox();
			this.optionsGroup = new System.Windows.Forms.GroupBox();
			this.toggleAnimationCheckBox = new System.Windows.Forms.CheckBox();
			this.boxContextMenu.SuspendLayout();
			this.offsetGroup.SuspendLayout();
			this.tabOffsets.SuspendLayout();
			this.tabBody.SuspendLayout();
			this.bodyLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SizeXUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeYUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeZUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UVXUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UVYUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PosZUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PosYUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PosXUpDown)).BeginInit();
			this.positionGroup.SuspendLayout();
			this.positionGroupLayout.SuspendLayout();
			this.sizeGroup.SuspendLayout();
			this.sizeGroupLayout.SuspendLayout();
			this.uvGroup.SuspendLayout();
			this.uvGroupLayout.SuspendLayout();
			this.optionsLayout.SuspendLayout();
			this.layout.SuspendLayout();
			this.texturePreviewGroup.SuspendLayout();
			this.texturePreviewLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uvPictureBox)).BeginInit();
			this.parentGroup.SuspendLayout();
			this.optionsGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// boxContextMenu
			// 
			this.boxContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.boxContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.cloneToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changeColorToolStripMenuItem});
			this.boxContextMenu.Name = "contextMenuStrip1";
			resources.ApplyResources(this.boxContextMenu, "boxContextMenu");
			// 
			// createToolStripMenuItem
			// 
			resources.ApplyResources(this.createToolStripMenuItem, "createToolStripMenuItem");
			this.createToolStripMenuItem.Name = "createToolStripMenuItem";
			this.createToolStripMenuItem.Click += new System.EventHandler(this.createSkinBox);
			// 
			// cloneToolStripMenuItem
			// 
			resources.ApplyResources(this.cloneToolStripMenuItem, "cloneToolStripMenuItem");
			this.cloneToolStripMenuItem.Name = "cloneToolStripMenuItem";
			this.cloneToolStripMenuItem.Click += new System.EventHandler(this.cloneSkinBox);
			// 
			// deleteToolStripMenuItem
			// 
			resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
			this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteSkinBox);
			// 
			// changeColorToolStripMenuItem
			// 
			resources.ApplyResources(this.changeColorToolStripMenuItem, "changeColorToolStripMenuItem");
			this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
			this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeSkinBoxDisplayColor);
			// 
			// buttonDone
			// 
			resources.ApplyResources(this.buttonDone, "buttonDone");
			this.buttonDone.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Click += new System.EventHandler(this.finished);
			// 
			// offsetGroup
			// 
			resources.ApplyResources(this.offsetGroup, "offsetGroup");
			this.offsetGroup.Controls.Add(this.tabOffsets);
			this.offsetGroup.Name = "offsetGroup";
			this.offsetGroup.TabStop = false;
			// 
			// tabOffsets
			// 
			this.tabOffsets.Controls.Add(this.tabArmor);
			this.tabOffsets.Controls.Add(this.tabBody);
			resources.ApplyResources(this.tabOffsets, "tabOffsets");
			this.tabOffsets.Name = "tabOffsets";
			this.tabOffsets.SelectedIndex = 0;
			// 
			// tabArmor
			// 
			resources.ApplyResources(this.tabArmor, "tabArmor");
			this.tabArmor.Name = "tabArmor";
			// 
			// tabBody
			// 
			this.tabBody.Controls.Add(this.bodyLayout);
			resources.ApplyResources(this.tabBody, "tabBody");
			this.tabBody.Name = "tabBody";
			// 
			// bodyLayout
			// 
			resources.ApplyResources(this.bodyLayout, "bodyLayout");
			this.bodyLayout.Controls.Add(this.offsetArms, 1, 3);
			this.bodyLayout.Controls.Add(this.armsLabel, 0, 3);
			this.bodyLayout.Controls.Add(this.offsetBody, 1, 1);
			this.bodyLayout.Controls.Add(this.offsetLegs, 1, 2);
			this.bodyLayout.Controls.Add(this.headLabel, 0, 0);
			this.bodyLayout.Controls.Add(this.legsLabel, 0, 2);
			this.bodyLayout.Controls.Add(this.offsetHead, 1, 0);
			this.bodyLayout.Controls.Add(this.bodylabel, 0, 1);
			this.bodyLayout.Name = "bodyLayout";
			// 
			// offsetArms
			// 
			resources.ApplyResources(this.offsetArms, "offsetArms");
			this.offsetArms.Name = "offsetArms";
			this.offsetArms.TextChanged += new System.EventHandler(this.headOffsetChanged);
			// 
			// armsLabel
			// 
			resources.ApplyResources(this.armsLabel, "armsLabel");
			this.armsLabel.Name = "armsLabel";
			// 
			// offsetBody
			// 
			resources.ApplyResources(this.offsetBody, "offsetBody");
			this.offsetBody.Name = "offsetBody";
			this.offsetBody.TextChanged += new System.EventHandler(this.headOffsetChanged);
			// 
			// offsetLegs
			// 
			resources.ApplyResources(this.offsetLegs, "offsetLegs");
			this.offsetLegs.Name = "offsetLegs";
			this.offsetLegs.TextChanged += new System.EventHandler(this.headOffsetChanged);
			// 
			// headLabel
			// 
			resources.ApplyResources(this.headLabel, "headLabel");
			this.headLabel.Name = "headLabel";
			// 
			// legsLabel
			// 
			resources.ApplyResources(this.legsLabel, "legsLabel");
			this.legsLabel.Name = "legsLabel";
			// 
			// offsetHead
			// 
			resources.ApplyResources(this.offsetHead, "offsetHead");
			this.offsetHead.Name = "offsetHead";
			this.offsetHead.TextChanged += new System.EventHandler(this.headOffsetChanged);
			// 
			// bodylabel
			// 
			resources.ApplyResources(this.bodylabel, "bodylabel");
			this.bodylabel.Name = "bodylabel";
			// 
			// comboParent
			// 
			resources.ApplyResources(this.comboParent, "comboParent");
			this.comboParent.FormattingEnabled = true;
			this.comboParent.Items.AddRange(new object[] {
            resources.GetString("comboParent.Items"),
            resources.GetString("comboParent.Items1"),
            resources.GetString("comboParent.Items2"),
            resources.GetString("comboParent.Items3"),
            resources.GetString("comboParent.Items4"),
            resources.GetString("comboParent.Items5")});
			this.comboParent.Name = "comboParent";
			this.comboParent.SelectedValueChanged += new System.EventHandler(this.parentChanged);
			// 
			// exportButton
			// 
			resources.ApplyResources(this.exportButton, "exportButton");
			this.exportButton.Name = "exportButton";
			this.exportButton.Click += new System.EventHandler(this.exportSkinTexture);
			// 
			// importButton
			// 
			resources.ApplyResources(this.importButton, "importButton");
			this.importButton.Name = "importButton";
			this.importButton.Click += new System.EventHandler(this.importSkinTexture);
			// 
			// buttonTemplate
			// 
			resources.ApplyResources(this.buttonTemplate, "buttonTemplate");
			this.buttonTemplate.Name = "buttonTemplate";
			this.buttonTemplate.Click += new System.EventHandler(this.generateTemplate);
			// 
			// generateTextureCheckBox
			// 
			resources.ApplyResources(this.generateTextureCheckBox, "generateTextureCheckBox");
			this.generateTextureCheckBox.Name = "generateTextureCheckBox";
			// 
			// showGuidelinesCheckBox
			// 
			resources.ApplyResources(this.showGuidelinesCheckBox, "showGuidelinesCheckBox");
			this.showGuidelinesCheckBox.Name = "showGuidelinesCheckBox";
			// 
			// showArmorCheckBox
			// 
			resources.ApplyResources(this.showArmorCheckBox, "showArmorCheckBox");
			this.showArmorCheckBox.Name = "showArmorCheckBox";
			// 
			// SizeXUpDown
			// 
			resources.ApplyResources(this.SizeXUpDown, "SizeXUpDown");
			this.SizeXUpDown.DecimalPlaces = 1;
			this.SizeXUpDown.Name = "SizeXUpDown";
			this.SizeXUpDown.ValueChanged += new System.EventHandler(this.xSizeChanged);
			// 
			// SizeYUpDown
			// 
			resources.ApplyResources(this.SizeYUpDown, "SizeYUpDown");
			this.SizeYUpDown.DecimalPlaces = 1;
			this.SizeYUpDown.Name = "SizeYUpDown";
			this.SizeYUpDown.ValueChanged += new System.EventHandler(this.ySizeChanged);
			// 
			// SizeZUpDown
			// 
			resources.ApplyResources(this.SizeZUpDown, "SizeZUpDown");
			this.SizeZUpDown.DecimalPlaces = 1;
			this.SizeZUpDown.Name = "SizeZUpDown";
			this.SizeZUpDown.ValueChanged += new System.EventHandler(this.zSizeChanged);
			// 
			// UVXUpDown
			// 
			resources.ApplyResources(this.UVXUpDown, "UVXUpDown");
			this.UVXUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.UVXUpDown.Name = "UVXUpDown";
			this.UVXUpDown.ValueChanged += new System.EventHandler(this.uCoordChanged);
			// 
			// UVYUpDown
			// 
			resources.ApplyResources(this.UVYUpDown, "UVYUpDown");
			this.UVYUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.UVYUpDown.Name = "UVYUpDown";
			this.UVYUpDown.ValueChanged += new System.EventHandler(this.vCoordChanged);
			// 
			// PosZUpDown
			// 
			resources.ApplyResources(this.PosZUpDown, "PosZUpDown");
			this.PosZUpDown.DecimalPlaces = 1;
			this.PosZUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.PosZUpDown.Name = "PosZUpDown";
			this.PosZUpDown.ValueChanged += new System.EventHandler(this.zPosChanged);
			// 
			// PosYUpDown
			// 
			resources.ApplyResources(this.PosYUpDown, "PosYUpDown");
			this.PosYUpDown.DecimalPlaces = 1;
			this.PosYUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.PosYUpDown.Name = "PosYUpDown";
			this.PosYUpDown.ValueChanged += new System.EventHandler(this.yPosChanged);
			// 
			// PosXUpDown
			// 
			resources.ApplyResources(this.PosXUpDown, "PosXUpDown");
			this.PosXUpDown.DecimalPlaces = 1;
			this.PosXUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.PosXUpDown.Name = "PosXUpDown";
			this.PosXUpDown.ValueChanged += new System.EventHandler(this.xPosChanged);
			// 
			// Part
			// 
			resources.ApplyResources(this.Part, "Part");
			// 
			// X
			// 
			resources.ApplyResources(this.X, "X");
			// 
			// Y
			// 
			resources.ApplyResources(this.Y, "Y");
			// 
			// Z
			// 
			resources.ApplyResources(this.Z, "Z");
			// 
			// _Width
			// 
			resources.ApplyResources(this._Width, "_Width");
			// 
			// _Height
			// 
			resources.ApplyResources(this._Height, "_Height");
			// 
			// Length
			// 
			resources.ApplyResources(this.Length, "Length");
			// 
			// U
			// 
			resources.ApplyResources(this.U, "U");
			// 
			// V
			// 
			resources.ApplyResources(this.V, "V");
			// 
			// listViewBoxes
			// 
			resources.ApplyResources(this.listViewBoxes, "listViewBoxes");
			this.listViewBoxes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listViewBoxes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Part,
            this.X,
            this.Y,
            this.Z,
            this._Width,
            this._Height,
            this.Length,
            this.U,
            this.V});
			this.listViewBoxes.ContextMenuStrip = this.boxContextMenu;
			this.listViewBoxes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewBoxes.HideSelection = false;
			this.listViewBoxes.LabelEdit = true;
			this.listViewBoxes.MultiSelect = false;
			this.listViewBoxes.Name = "listViewBoxes";
			this.layout.SetRowSpan(this.listViewBoxes, 3);
			this.listViewBoxes.UseCompatibleStateImageBehavior = false;
			this.listViewBoxes.View = System.Windows.Forms.View.Details;
			this.listViewBoxes.SelectedIndexChanged += new System.EventHandler(this.skinBoxSelected);
			this.listViewBoxes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listViewKeyDown);
			// 
			// positionGroup
			// 
			resources.ApplyResources(this.positionGroup, "positionGroup");
			this.positionGroup.Controls.Add(this.positionGroupLayout);
			this.positionGroup.Name = "positionGroup";
			this.positionGroup.TabStop = false;
			// 
			// positionGroupLayout
			// 
			resources.ApplyResources(this.positionGroupLayout, "positionGroupLayout");
			this.positionGroupLayout.Controls.Add(this.PosXUpDown, 0, 0);
			this.positionGroupLayout.Controls.Add(this.PosYUpDown, 0, 1);
			this.positionGroupLayout.Controls.Add(this.PosZUpDown, 0, 1);
			this.positionGroupLayout.Name = "positionGroupLayout";
			// 
			// sizeGroup
			// 
			resources.ApplyResources(this.sizeGroup, "sizeGroup");
			this.sizeGroup.Controls.Add(this.sizeGroupLayout);
			this.sizeGroup.Name = "sizeGroup";
			this.sizeGroup.TabStop = false;
			// 
			// sizeGroupLayout
			// 
			resources.ApplyResources(this.sizeGroupLayout, "sizeGroupLayout");
			this.sizeGroupLayout.Controls.Add(this.SizeZUpDown, 0, 0);
			this.sizeGroupLayout.Controls.Add(this.SizeYUpDown, 0, 1);
			this.sizeGroupLayout.Controls.Add(this.SizeXUpDown, 0, 2);
			this.sizeGroupLayout.Name = "sizeGroupLayout";
			// 
			// uvGroup
			// 
			resources.ApplyResources(this.uvGroup, "uvGroup");
			this.uvGroup.Controls.Add(this.uvGroupLayout);
			this.uvGroup.Name = "uvGroup";
			this.uvGroup.TabStop = false;
			// 
			// uvGroupLayout
			// 
			resources.ApplyResources(this.uvGroupLayout, "uvGroupLayout");
			this.uvGroupLayout.Controls.Add(this.UVYUpDown, 0, 0);
			this.uvGroupLayout.Controls.Add(this.UVXUpDown, 0, 0);
			this.uvGroupLayout.Name = "uvGroupLayout";
			// 
			// optionsLayout
			// 
			resources.ApplyResources(this.optionsLayout, "optionsLayout");
			this.optionsLayout.Controls.Add(this.generateTextureCheckBox);
			this.optionsLayout.Controls.Add(this.showGuidelinesCheckBox);
			this.optionsLayout.Controls.Add(this.showArmorCheckBox);
			this.optionsLayout.Controls.Add(this.toggleAnimationCheckBox);
			this.optionsLayout.Name = "optionsLayout";
			// 
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(this.texturePreviewGroup, 2, 0);
			this.layout.Controls.Add(this.buttonTemplate, 0, 5);
			this.layout.Controls.Add(this.buttonDone, 2, 5);
			this.layout.Controls.Add(this.listViewBoxes, 0, 0);
			this.layout.Controls.Add(this.mainView, 1, 0);
			this.layout.Controls.Add(this.offsetGroup, 2, 4);
			this.layout.Controls.Add(this.uvGroup, 2, 1);
			this.layout.Controls.Add(this.positionGroup, 2, 3);
			this.layout.Controls.Add(this.sizeGroup, 2, 2);
			this.layout.Controls.Add(this.parentGroup, 0, 3);
			this.layout.Controls.Add(this.optionsGroup, 0, 4);
			this.layout.Name = "layout";
			// 
			// texturePreviewGroup
			// 
			resources.ApplyResources(this.texturePreviewGroup, "texturePreviewGroup");
			this.texturePreviewGroup.Controls.Add(this.texturePreviewLayout);
			this.texturePreviewGroup.Name = "texturePreviewGroup";
			this.texturePreviewGroup.TabStop = false;
			// 
			// texturePreviewLayout
			// 
			resources.ApplyResources(this.texturePreviewLayout, "texturePreviewLayout");
			this.texturePreviewLayout.Controls.Add(this.importButton, 0, 1);
			this.texturePreviewLayout.Controls.Add(this.exportButton, 1, 1);
			this.texturePreviewLayout.Controls.Add(this.uvPictureBox, 0, 0);
			this.texturePreviewLayout.Name = "texturePreviewLayout";
			// 
			// uvPictureBox
			// 
			this.uvPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.texturePreviewLayout.SetColumnSpan(this.uvPictureBox, 2);
			resources.ApplyResources(this.uvPictureBox, "uvPictureBox");
			this.uvPictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			this.uvPictureBox.Name = "uvPictureBox";
			this.uvPictureBox.TabStop = false;
			// 
			// mainView
			// 
			resources.ApplyResources(this.mainView, "mainView");
			this.mainView.BackColor = System.Drawing.Color.Black;
			this.mainView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mainView.Name = "mainView";
			this.layout.SetRowSpan(this.mainView, 6);
			this.mainView.TabStop = false;
			this.mainView.VSync = false;
			this.mainView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GLStartPanning);
			this.mainView.MouseEnter += new System.EventHandler(this.GLEnableZoom);
			this.mainView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GLPan);
			this.mainView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GLStopPanning);
			this.mainView.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.GLZoom);
			// 
			// parentGroup
			// 
			resources.ApplyResources(this.parentGroup, "parentGroup");
			this.parentGroup.Controls.Add(this.comboParent);
			this.parentGroup.Name = "parentGroup";
			this.parentGroup.TabStop = false;
			// 
			// optionsGroup
			// 
			resources.ApplyResources(this.optionsGroup, "optionsGroup");
			this.optionsGroup.Controls.Add(this.optionsLayout);
			this.optionsGroup.Name = "optionsGroup";
			this.optionsGroup.TabStop = false;
			// 
			// toggleAnimationCheckBox
			// 
			resources.ApplyResources(this.toggleAnimationCheckBox, "toggleAnimationCheckBox");
			this.toggleAnimationCheckBox.Checked = true;
			this.toggleAnimationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toggleAnimationCheckBox.Name = "toggleAnimationCheckBox";
			this.toggleAnimationCheckBox.UseVisualStyleBackColor = true;
			this.toggleAnimationCheckBox.CheckedChanged += new System.EventHandler(this.toggleAnimationChanged);
			// 
			// ModelGeneratorForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.Name = "ModelGeneratorForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
			this.Load += new System.EventHandler(this.formLoaded);
			this.boxContextMenu.ResumeLayout(false);
			this.offsetGroup.ResumeLayout(false);
			this.tabOffsets.ResumeLayout(false);
			this.tabBody.ResumeLayout(false);
			this.bodyLayout.ResumeLayout(false);
			this.bodyLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SizeXUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeYUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeZUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UVXUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UVYUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PosZUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PosYUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PosXUpDown)).EndInit();
			this.positionGroup.ResumeLayout(false);
			this.positionGroupLayout.ResumeLayout(false);
			this.sizeGroup.ResumeLayout(false);
			this.sizeGroupLayout.ResumeLayout(false);
			this.uvGroup.ResumeLayout(false);
			this.uvGroupLayout.ResumeLayout(false);
			this.optionsLayout.ResumeLayout(false);
			this.optionsLayout.PerformLayout();
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.texturePreviewGroup.ResumeLayout(false);
			this.texturePreviewLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uvPictureBox)).EndInit();
			this.parentGroup.ResumeLayout(false);
			this.optionsGroup.ResumeLayout(false);
			this.optionsGroup.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private ContextMenuStrip boxContextMenu;
		private ToolStripMenuItem createToolStripMenuItem;
		private ToolStripMenuItem cloneToolStripMenuItem;
		private ToolStripMenuItem deleteToolStripMenuItem;
		private ToolStripMenuItem changeColorToolStripMenuItem;
		private Button buttonDone;
		private PckStudio.ToolboxItems.InterpolationPictureBox uvPictureBox;
		private Button importButton;
		private Button exportButton;
		private ComboBox comboParent;
		private GroupBox offsetGroup;
		private TabControl tabOffsets;
		private TabPage tabBody;
		private TableLayoutPanel bodyLayout;
		private TextBox offsetArms;
		private Label armsLabel;
		private TextBox offsetBody;
		private TextBox offsetLegs;
		private Label headLabel;
		private Label legsLabel;
		private TextBox offsetHead;
		private Label bodylabel;
		private TabPage tabArmor;
		private Button buttonTemplate;
		private CheckBox generateTextureCheckBox;
		private CheckBox showGuidelinesCheckBox;
		private CheckBox showArmorCheckBox;
		private NumericUpDown SizeXUpDown;
		private NumericUpDown SizeYUpDown;
		private NumericUpDown SizeZUpDown;
		private NumericUpDown UVXUpDown;
		private NumericUpDown UVYUpDown;
		private NumericUpDown PosZUpDown;
		private NumericUpDown PosYUpDown;
		private NumericUpDown PosXUpDown;
		private ColumnHeader Part;
		private ColumnHeader X;
		private ColumnHeader Y;
		private ColumnHeader Z;
		private ColumnHeader _Width;
		private ColumnHeader _Height;
		private ColumnHeader Length;
		private ColumnHeader U;
		private ColumnHeader V;
		private ListView listViewBoxes;
		private GroupBox positionGroup;
		private TableLayoutPanel positionGroupLayout;
		private GroupBox sizeGroup;
		private TableLayoutPanel sizeGroupLayout;
		private GroupBox uvGroup;
		private TableLayoutPanel uvGroupLayout;
		private FlowLayoutPanel optionsLayout;
		private TableLayoutPanel texturePreviewLayout;
		private TableLayoutPanel layout;
		private GroupBox texturePreviewGroup;
		private GroupBox parentGroup;
		private GroupBox optionsGroup;
		private OpenTK.GLControl mainView;
		private CheckBox toggleAnimationCheckBox;
	}
}