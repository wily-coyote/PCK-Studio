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
			this.UVYUpDown = new System.Windows.Forms.NumericUpDown();
			this.PosZUpDown = new System.Windows.Forms.NumericUpDown();
			this.PosYUpDown = new System.Windows.Forms.NumericUpDown();
			this.PosXUpDown = new System.Windows.Forms.NumericUpDown();
			this.positionGroup = new System.Windows.Forms.GroupBox();
			this.sizeGroup = new System.Windows.Forms.GroupBox();
			this.uvGroup = new System.Windows.Forms.GroupBox();
			this.toggleAnimationCheckBox = new System.Windows.Forms.CheckBox();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			this.texturePreviewGroup = new System.Windows.Forms.GroupBox();
			this.texturePreviewLayout = new System.Windows.Forms.TableLayoutPanel();
			this.mainView = new OpenTK.GLControl();
			this.parentGroup = new System.Windows.Forms.GroupBox();
			this.optionsGroup = new System.Windows.Forms.GroupBox();
			this.skinBoxList = new System.Windows.Forms.DataGridView();
			this.uvPictureBox = new PckStudio.ToolboxItems.InterpolationPictureBox();
			this.sizeGroupLayout = new System.Windows.Forms.TableLayoutPanel();
			this.uvGroupLayout = new System.Windows.Forms.TableLayoutPanel();
			this.UVXUpDown = new System.Windows.Forms.NumericUpDown();
			this.positionGroupLayout = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.boxContextMenu.SuspendLayout();
			this.offsetGroup.SuspendLayout();
			this.tabOffsets.SuspendLayout();
			this.tabBody.SuspendLayout();
			this.bodyLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SizeXUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeYUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeZUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.UVYUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PosZUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PosYUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PosXUpDown)).BeginInit();
			this.positionGroup.SuspendLayout();
			this.sizeGroup.SuspendLayout();
			this.uvGroup.SuspendLayout();
			this.layout.SuspendLayout();
			this.texturePreviewGroup.SuspendLayout();
			this.texturePreviewLayout.SuspendLayout();
			this.parentGroup.SuspendLayout();
			this.optionsGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.skinBoxList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uvPictureBox)).BeginInit();
			this.sizeGroupLayout.SuspendLayout();
			this.uvGroupLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UVXUpDown)).BeginInit();
			this.positionGroupLayout.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
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
			this.createToolStripMenuItem.Click += new System.EventHandler(this.addSkinBox);
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
			this.deleteToolStripMenuItem.Click += new System.EventHandler(this.removeSkinBox);
			// 
			// changeColorToolStripMenuItem
			// 
			resources.ApplyResources(this.changeColorToolStripMenuItem, "changeColorToolStripMenuItem");
			this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
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
			this.offsetGroup.Controls.Add(this.tabOffsets);
			resources.ApplyResources(this.offsetGroup, "offsetGroup");
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
			this.tabArmor.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.tabArmor, "tabArmor");
			this.tabArmor.Name = "tabArmor";
			// 
			// tabBody
			// 
			this.tabBody.BackColor = System.Drawing.SystemColors.Control;
			this.tabBody.Controls.Add(this.bodyLayout);
			resources.ApplyResources(this.tabBody, "tabBody");
			this.tabBody.Name = "tabBody";
			// 
			// bodyLayout
			// 
			resources.ApplyResources(this.bodyLayout, "bodyLayout");
			this.bodyLayout.BackColor = System.Drawing.Color.Transparent;
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
			this.comboParent.SelectedIndexChanged += new System.EventHandler(this.formChangeSkinBox);
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
			this.SizeXUpDown.DecimalPlaces = 2;
			this.SizeXUpDown.Name = "SizeXUpDown";
			this.SizeXUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// SizeYUpDown
			// 
			resources.ApplyResources(this.SizeYUpDown, "SizeYUpDown");
			this.SizeYUpDown.DecimalPlaces = 2;
			this.SizeYUpDown.Name = "SizeYUpDown";
			this.SizeYUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// SizeZUpDown
			// 
			resources.ApplyResources(this.SizeZUpDown, "SizeZUpDown");
			this.SizeZUpDown.DecimalPlaces = 2;
			this.SizeZUpDown.Name = "SizeZUpDown";
			this.SizeZUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
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
			this.UVYUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// PosZUpDown
			// 
			resources.ApplyResources(this.PosZUpDown, "PosZUpDown");
			this.PosZUpDown.DecimalPlaces = 2;
			this.PosZUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.PosZUpDown.Name = "PosZUpDown";
			this.PosZUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// PosYUpDown
			// 
			resources.ApplyResources(this.PosYUpDown, "PosYUpDown");
			this.PosYUpDown.DecimalPlaces = 2;
			this.PosYUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.PosYUpDown.Name = "PosYUpDown";
			this.PosYUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// PosXUpDown
			// 
			resources.ApplyResources(this.PosXUpDown, "PosXUpDown");
			this.PosXUpDown.DecimalPlaces = 2;
			this.PosXUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.PosXUpDown.Name = "PosXUpDown";
			this.PosXUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// positionGroup
			// 
			resources.ApplyResources(this.positionGroup, "positionGroup");
			this.positionGroup.Controls.Add(this.positionGroupLayout);
			this.positionGroup.Name = "positionGroup";
			this.positionGroup.TabStop = false;
			// 
			// sizeGroup
			// 
			resources.ApplyResources(this.sizeGroup, "sizeGroup");
			this.sizeGroup.Controls.Add(this.sizeGroupLayout);
			this.sizeGroup.Name = "sizeGroup";
			this.sizeGroup.TabStop = false;
			// 
			// uvGroup
			// 
			resources.ApplyResources(this.uvGroup, "uvGroup");
			this.uvGroup.Controls.Add(this.uvGroupLayout);
			this.uvGroup.Name = "uvGroup";
			this.uvGroup.TabStop = false;
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
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(this.texturePreviewGroup, 2, 0);
			this.layout.Controls.Add(this.buttonTemplate, 0, 5);
			this.layout.Controls.Add(this.buttonDone, 2, 5);
			this.layout.Controls.Add(this.mainView, 1, 0);
			this.layout.Controls.Add(this.offsetGroup, 2, 4);
			this.layout.Controls.Add(this.uvGroup, 2, 1);
			this.layout.Controls.Add(this.positionGroup, 2, 3);
			this.layout.Controls.Add(this.sizeGroup, 2, 2);
			this.layout.Controls.Add(this.parentGroup, 0, 3);
			this.layout.Controls.Add(this.optionsGroup, 0, 4);
			this.layout.Controls.Add(this.skinBoxList, 0, 0);
			this.layout.Name = "layout";
			// 
			// texturePreviewGroup
			// 
			this.texturePreviewGroup.Controls.Add(this.texturePreviewLayout);
			resources.ApplyResources(this.texturePreviewGroup, "texturePreviewGroup");
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
			this.optionsGroup.Controls.Add(this.tableLayoutPanel1);
			resources.ApplyResources(this.optionsGroup, "optionsGroup");
			this.optionsGroup.Name = "optionsGroup";
			this.optionsGroup.TabStop = false;
			// 
			// skinBoxList
			// 
			this.skinBoxList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.skinBoxList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			resources.ApplyResources(this.skinBoxList, "skinBoxList");
			this.skinBoxList.Name = "skinBoxList";
			this.layout.SetRowSpan(this.skinBoxList, 3);
			this.skinBoxList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.summonContextMenu);
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
			// sizeGroupLayout
			// 
			resources.ApplyResources(this.sizeGroupLayout, "sizeGroupLayout");
			this.sizeGroupLayout.Controls.Add(this.SizeXUpDown, 0, 0);
			this.sizeGroupLayout.Controls.Add(this.SizeYUpDown, 0, 1);
			this.sizeGroupLayout.Controls.Add(this.SizeZUpDown, 0, 2);
			this.sizeGroupLayout.Name = "sizeGroupLayout";
			// 
			// uvGroupLayout
			// 
			resources.ApplyResources(this.uvGroupLayout, "uvGroupLayout");
			this.uvGroupLayout.Controls.Add(this.UVXUpDown, 0, 0);
			this.uvGroupLayout.Controls.Add(this.UVYUpDown, 1, 0);
			this.uvGroupLayout.Name = "uvGroupLayout";
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
			this.UVXUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// positionGroupLayout
			// 
			resources.ApplyResources(this.positionGroupLayout, "positionGroupLayout");
			this.positionGroupLayout.Controls.Add(this.PosZUpDown, 0, 2);
			this.positionGroupLayout.Controls.Add(this.PosYUpDown, 0, 1);
			this.positionGroupLayout.Controls.Add(this.PosXUpDown, 0, 0);
			this.positionGroupLayout.Name = "positionGroupLayout";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.generateTextureCheckBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.toggleAnimationCheckBox, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.showGuidelinesCheckBox, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.showArmorCheckBox, 0, 2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
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
			this.tabBody.PerformLayout();
			this.bodyLayout.ResumeLayout(false);
			this.bodyLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SizeXUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeYUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SizeZUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.UVYUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PosZUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PosYUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PosXUpDown)).EndInit();
			this.positionGroup.ResumeLayout(false);
			this.positionGroup.PerformLayout();
			this.sizeGroup.ResumeLayout(false);
			this.sizeGroup.PerformLayout();
			this.uvGroup.ResumeLayout(false);
			this.uvGroup.PerformLayout();
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.texturePreviewGroup.ResumeLayout(false);
			this.texturePreviewLayout.ResumeLayout(false);
			this.parentGroup.ResumeLayout(false);
			this.optionsGroup.ResumeLayout(false);
			this.optionsGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.skinBoxList)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uvPictureBox)).EndInit();
			this.sizeGroupLayout.ResumeLayout(false);
			this.uvGroupLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UVXUpDown)).EndInit();
			this.positionGroupLayout.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
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
		private NumericUpDown UVYUpDown;
		private NumericUpDown PosZUpDown;
		private NumericUpDown PosYUpDown;
		private NumericUpDown PosXUpDown;
		private GroupBox positionGroup;
		private GroupBox sizeGroup;
		private GroupBox uvGroup;
		private TableLayoutPanel texturePreviewLayout;
		private TableLayoutPanel layout;
		private GroupBox texturePreviewGroup;
		private GroupBox parentGroup;
		private GroupBox optionsGroup;
		private OpenTK.GLControl mainView;
		private CheckBox toggleAnimationCheckBox;
		private DataGridView skinBoxList;
		private TableLayoutPanel sizeGroupLayout;
		private TableLayoutPanel uvGroupLayout;
		private TableLayoutPanel positionGroupLayout;
		private NumericUpDown UVXUpDown;
		private TableLayoutPanel tableLayoutPanel1;
	}
}