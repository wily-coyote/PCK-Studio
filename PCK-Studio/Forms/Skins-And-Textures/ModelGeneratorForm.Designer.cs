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
			this.positionGroupLayout = new System.Windows.Forms.TableLayoutPanel();
			this.sizeGroup = new System.Windows.Forms.GroupBox();
			this.sizeGroupLayout = new System.Windows.Forms.TableLayoutPanel();
			this.uvGroup = new System.Windows.Forms.GroupBox();
			this.uvGroupLayout = new System.Windows.Forms.TableLayoutPanel();
			this.UVXUpDown = new System.Windows.Forms.NumericUpDown();
			this.toggleAnimationCheckBox = new System.Windows.Forms.CheckBox();
			this.rightLayout = new System.Windows.Forms.TableLayoutPanel();
			this.texturePreviewGroup = new System.Windows.Forms.GroupBox();
			this.texturePreviewLayout = new System.Windows.Forms.TableLayoutPanel();
			this.uvPictureBox = new PckStudio.ToolboxItems.InterpolationPictureBox();
			this.mainView = new OpenTK.GLControl();
			this.partGroup = new System.Windows.Forms.GroupBox();
			this.partLayout = new System.Windows.Forms.TableLayoutPanel();
			this.mirrorCheckBox = new System.Windows.Forms.CheckBox();
			this.armorCheckBox = new System.Windows.Forms.CheckBox();
			this.InflateUpDown = new System.Windows.Forms.NumericUpDown();
			this.optionsGroup = new System.Windows.Forms.GroupBox();
			this.optionsLayout = new System.Windows.Forms.TableLayoutPanel();
			this.skinBoxList = new System.Windows.Forms.DataGridView();
			this.layout = new System.Windows.Forms.SplitContainer();
			this.leftLayout = new System.Windows.Forms.TableLayoutPanel();
			this.layout2 = new System.Windows.Forms.SplitContainer();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadTemplateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.finishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpProvider = new System.Windows.Forms.HelpProvider();
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
			this.positionGroupLayout.SuspendLayout();
			this.sizeGroup.SuspendLayout();
			this.sizeGroupLayout.SuspendLayout();
			this.uvGroup.SuspendLayout();
			this.uvGroupLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UVXUpDown)).BeginInit();
			this.rightLayout.SuspendLayout();
			this.texturePreviewGroup.SuspendLayout();
			this.texturePreviewLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uvPictureBox)).BeginInit();
			this.partGroup.SuspendLayout();
			this.partLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.InflateUpDown)).BeginInit();
			this.optionsGroup.SuspendLayout();
			this.optionsLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.skinBoxList)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
			this.layout.Panel1.SuspendLayout();
			this.layout.Panel2.SuspendLayout();
			this.layout.SuspendLayout();
			this.leftLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layout2)).BeginInit();
			this.layout2.Panel1.SuspendLayout();
			this.layout2.Panel2.SuspendLayout();
			this.layout2.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// boxContextMenu
			// 
			this.boxContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.boxContextMenu.Name = "contextMenuStrip1";
			this.helpProvider.SetShowHelp(this.boxContextMenu, ((bool)(resources.GetObject("boxContextMenu.ShowHelp"))));
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
			this.helpProvider.SetHelpString(this.buttonDone, resources.GetString("buttonDone.HelpString"));
			this.buttonDone.Name = "buttonDone";
			this.helpProvider.SetShowHelp(this.buttonDone, ((bool)(resources.GetObject("buttonDone.ShowHelp"))));
			this.buttonDone.Click += new System.EventHandler(this.finished);
			// 
			// offsetGroup
			// 
			this.offsetGroup.Controls.Add(this.tabOffsets);
			resources.ApplyResources(this.offsetGroup, "offsetGroup");
			this.helpProvider.SetHelpString(this.offsetGroup, resources.GetString("offsetGroup.HelpString"));
			this.offsetGroup.Name = "offsetGroup";
			this.helpProvider.SetShowHelp(this.offsetGroup, ((bool)(resources.GetObject("offsetGroup.ShowHelp"))));
			this.offsetGroup.TabStop = false;
			// 
			// tabOffsets
			// 
			this.tabOffsets.Controls.Add(this.tabArmor);
			this.tabOffsets.Controls.Add(this.tabBody);
			resources.ApplyResources(this.tabOffsets, "tabOffsets");
			this.tabOffsets.Name = "tabOffsets";
			this.tabOffsets.SelectedIndex = 0;
			this.helpProvider.SetShowHelp(this.tabOffsets, ((bool)(resources.GetObject("tabOffsets.ShowHelp"))));
			// 
			// tabArmor
			// 
			this.tabArmor.BackColor = System.Drawing.Color.Transparent;
			resources.ApplyResources(this.tabArmor, "tabArmor");
			this.tabArmor.Name = "tabArmor";
			this.helpProvider.SetShowHelp(this.tabArmor, ((bool)(resources.GetObject("tabArmor.ShowHelp"))));
			// 
			// tabBody
			// 
			this.tabBody.BackColor = System.Drawing.SystemColors.Control;
			this.tabBody.Controls.Add(this.bodyLayout);
			resources.ApplyResources(this.tabBody, "tabBody");
			this.tabBody.Name = "tabBody";
			this.helpProvider.SetShowHelp(this.tabBody, ((bool)(resources.GetObject("tabBody.ShowHelp"))));
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
			this.helpProvider.SetShowHelp(this.bodyLayout, ((bool)(resources.GetObject("bodyLayout.ShowHelp"))));
			// 
			// offsetArms
			// 
			resources.ApplyResources(this.offsetArms, "offsetArms");
			this.offsetArms.Name = "offsetArms";
			this.helpProvider.SetShowHelp(this.offsetArms, ((bool)(resources.GetObject("offsetArms.ShowHelp"))));
			// 
			// armsLabel
			// 
			resources.ApplyResources(this.armsLabel, "armsLabel");
			this.armsLabel.Name = "armsLabel";
			this.helpProvider.SetShowHelp(this.armsLabel, ((bool)(resources.GetObject("armsLabel.ShowHelp"))));
			// 
			// offsetBody
			// 
			resources.ApplyResources(this.offsetBody, "offsetBody");
			this.offsetBody.Name = "offsetBody";
			this.helpProvider.SetShowHelp(this.offsetBody, ((bool)(resources.GetObject("offsetBody.ShowHelp"))));
			// 
			// offsetLegs
			// 
			resources.ApplyResources(this.offsetLegs, "offsetLegs");
			this.offsetLegs.Name = "offsetLegs";
			this.helpProvider.SetShowHelp(this.offsetLegs, ((bool)(resources.GetObject("offsetLegs.ShowHelp"))));
			// 
			// headLabel
			// 
			resources.ApplyResources(this.headLabel, "headLabel");
			this.headLabel.Name = "headLabel";
			this.helpProvider.SetShowHelp(this.headLabel, ((bool)(resources.GetObject("headLabel.ShowHelp"))));
			// 
			// legsLabel
			// 
			resources.ApplyResources(this.legsLabel, "legsLabel");
			this.legsLabel.Name = "legsLabel";
			this.helpProvider.SetShowHelp(this.legsLabel, ((bool)(resources.GetObject("legsLabel.ShowHelp"))));
			// 
			// offsetHead
			// 
			resources.ApplyResources(this.offsetHead, "offsetHead");
			this.offsetHead.Name = "offsetHead";
			this.helpProvider.SetShowHelp(this.offsetHead, ((bool)(resources.GetObject("offsetHead.ShowHelp"))));
			// 
			// bodylabel
			// 
			resources.ApplyResources(this.bodylabel, "bodylabel");
			this.bodylabel.Name = "bodylabel";
			this.helpProvider.SetShowHelp(this.bodylabel, ((bool)(resources.GetObject("bodylabel.ShowHelp"))));
			// 
			// comboParent
			// 
			resources.ApplyResources(this.comboParent, "comboParent");
			this.comboParent.FormattingEnabled = true;
			this.helpProvider.SetHelpString(this.comboParent, resources.GetString("comboParent.HelpString"));
			this.comboParent.Items.AddRange(new object[] {
            resources.GetString("comboParent.Items"),
            resources.GetString("comboParent.Items1"),
            resources.GetString("comboParent.Items2"),
            resources.GetString("comboParent.Items3"),
            resources.GetString("comboParent.Items4"),
            resources.GetString("comboParent.Items5")});
			this.comboParent.Name = "comboParent";
			this.helpProvider.SetShowHelp(this.comboParent, ((bool)(resources.GetObject("comboParent.ShowHelp"))));
			this.comboParent.SelectedIndexChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// exportButton
			// 
			resources.ApplyResources(this.exportButton, "exportButton");
			this.helpProvider.SetHelpString(this.exportButton, resources.GetString("exportButton.HelpString"));
			this.exportButton.Name = "exportButton";
			this.helpProvider.SetShowHelp(this.exportButton, ((bool)(resources.GetObject("exportButton.ShowHelp"))));
			this.exportButton.Click += new System.EventHandler(this.exportSkinTexture);
			// 
			// importButton
			// 
			resources.ApplyResources(this.importButton, "importButton");
			this.helpProvider.SetHelpString(this.importButton, resources.GetString("importButton.HelpString"));
			this.importButton.Name = "importButton";
			this.helpProvider.SetShowHelp(this.importButton, ((bool)(resources.GetObject("importButton.ShowHelp"))));
			this.importButton.Click += new System.EventHandler(this.importSkinTexture);
			// 
			// buttonTemplate
			// 
			resources.ApplyResources(this.buttonTemplate, "buttonTemplate");
			this.helpProvider.SetHelpString(this.buttonTemplate, resources.GetString("buttonTemplate.HelpString"));
			this.buttonTemplate.Name = "buttonTemplate";
			this.helpProvider.SetShowHelp(this.buttonTemplate, ((bool)(resources.GetObject("buttonTemplate.ShowHelp"))));
			this.buttonTemplate.Click += new System.EventHandler(this.generateTemplate);
			// 
			// generateTextureCheckBox
			// 
			resources.ApplyResources(this.generateTextureCheckBox, "generateTextureCheckBox");
			this.helpProvider.SetHelpString(this.generateTextureCheckBox, resources.GetString("generateTextureCheckBox.HelpString"));
			this.generateTextureCheckBox.Name = "generateTextureCheckBox";
			this.helpProvider.SetShowHelp(this.generateTextureCheckBox, ((bool)(resources.GetObject("generateTextureCheckBox.ShowHelp"))));
			// 
			// showGuidelinesCheckBox
			// 
			resources.ApplyResources(this.showGuidelinesCheckBox, "showGuidelinesCheckBox");
			this.helpProvider.SetHelpString(this.showGuidelinesCheckBox, resources.GetString("showGuidelinesCheckBox.HelpString"));
			this.showGuidelinesCheckBox.Name = "showGuidelinesCheckBox";
			this.helpProvider.SetShowHelp(this.showGuidelinesCheckBox, ((bool)(resources.GetObject("showGuidelinesCheckBox.ShowHelp"))));
			// 
			// showArmorCheckBox
			// 
			resources.ApplyResources(this.showArmorCheckBox, "showArmorCheckBox");
			this.helpProvider.SetHelpString(this.showArmorCheckBox, resources.GetString("showArmorCheckBox.HelpString"));
			this.showArmorCheckBox.Name = "showArmorCheckBox";
			this.helpProvider.SetShowHelp(this.showArmorCheckBox, ((bool)(resources.GetObject("showArmorCheckBox.ShowHelp"))));
			// 
			// SizeXUpDown
			// 
			resources.ApplyResources(this.SizeXUpDown, "SizeXUpDown");
			this.SizeXUpDown.DecimalPlaces = 2;
			this.SizeXUpDown.Name = "SizeXUpDown";
			this.helpProvider.SetShowHelp(this.SizeXUpDown, ((bool)(resources.GetObject("SizeXUpDown.ShowHelp"))));
			this.SizeXUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// SizeYUpDown
			// 
			resources.ApplyResources(this.SizeYUpDown, "SizeYUpDown");
			this.SizeYUpDown.DecimalPlaces = 2;
			this.SizeYUpDown.Name = "SizeYUpDown";
			this.helpProvider.SetShowHelp(this.SizeYUpDown, ((bool)(resources.GetObject("SizeYUpDown.ShowHelp"))));
			this.SizeYUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// SizeZUpDown
			// 
			resources.ApplyResources(this.SizeZUpDown, "SizeZUpDown");
			this.SizeZUpDown.DecimalPlaces = 2;
			this.SizeZUpDown.Name = "SizeZUpDown";
			this.helpProvider.SetShowHelp(this.SizeZUpDown, ((bool)(resources.GetObject("SizeZUpDown.ShowHelp"))));
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
			this.helpProvider.SetShowHelp(this.UVYUpDown, ((bool)(resources.GetObject("UVYUpDown.ShowHelp"))));
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
			this.helpProvider.SetShowHelp(this.PosZUpDown, ((bool)(resources.GetObject("PosZUpDown.ShowHelp"))));
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
			this.helpProvider.SetShowHelp(this.PosYUpDown, ((bool)(resources.GetObject("PosYUpDown.ShowHelp"))));
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
			this.helpProvider.SetShowHelp(this.PosXUpDown, ((bool)(resources.GetObject("PosXUpDown.ShowHelp"))));
			this.PosXUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// positionGroup
			// 
			resources.ApplyResources(this.positionGroup, "positionGroup");
			this.positionGroup.Controls.Add(this.positionGroupLayout);
			this.helpProvider.SetHelpString(this.positionGroup, resources.GetString("positionGroup.HelpString"));
			this.positionGroup.Name = "positionGroup";
			this.helpProvider.SetShowHelp(this.positionGroup, ((bool)(resources.GetObject("positionGroup.ShowHelp"))));
			this.positionGroup.TabStop = false;
			// 
			// positionGroupLayout
			// 
			resources.ApplyResources(this.positionGroupLayout, "positionGroupLayout");
			this.positionGroupLayout.Controls.Add(this.PosZUpDown, 0, 2);
			this.positionGroupLayout.Controls.Add(this.PosYUpDown, 0, 1);
			this.positionGroupLayout.Controls.Add(this.PosXUpDown, 0, 0);
			this.positionGroupLayout.Name = "positionGroupLayout";
			this.helpProvider.SetShowHelp(this.positionGroupLayout, ((bool)(resources.GetObject("positionGroupLayout.ShowHelp"))));
			// 
			// sizeGroup
			// 
			resources.ApplyResources(this.sizeGroup, "sizeGroup");
			this.sizeGroup.Controls.Add(this.sizeGroupLayout);
			this.helpProvider.SetHelpString(this.sizeGroup, resources.GetString("sizeGroup.HelpString"));
			this.sizeGroup.Name = "sizeGroup";
			this.helpProvider.SetShowHelp(this.sizeGroup, ((bool)(resources.GetObject("sizeGroup.ShowHelp"))));
			this.sizeGroup.TabStop = false;
			// 
			// sizeGroupLayout
			// 
			resources.ApplyResources(this.sizeGroupLayout, "sizeGroupLayout");
			this.sizeGroupLayout.Controls.Add(this.SizeXUpDown, 0, 0);
			this.sizeGroupLayout.Controls.Add(this.SizeYUpDown, 0, 1);
			this.sizeGroupLayout.Controls.Add(this.SizeZUpDown, 0, 2);
			this.sizeGroupLayout.Name = "sizeGroupLayout";
			this.helpProvider.SetShowHelp(this.sizeGroupLayout, ((bool)(resources.GetObject("sizeGroupLayout.ShowHelp"))));
			// 
			// uvGroup
			// 
			resources.ApplyResources(this.uvGroup, "uvGroup");
			this.uvGroup.Controls.Add(this.uvGroupLayout);
			this.helpProvider.SetHelpString(this.uvGroup, resources.GetString("uvGroup.HelpString"));
			this.uvGroup.Name = "uvGroup";
			this.helpProvider.SetShowHelp(this.uvGroup, ((bool)(resources.GetObject("uvGroup.ShowHelp"))));
			this.uvGroup.TabStop = false;
			// 
			// uvGroupLayout
			// 
			resources.ApplyResources(this.uvGroupLayout, "uvGroupLayout");
			this.uvGroupLayout.Controls.Add(this.UVXUpDown, 0, 0);
			this.uvGroupLayout.Controls.Add(this.UVYUpDown, 1, 0);
			this.uvGroupLayout.Name = "uvGroupLayout";
			this.helpProvider.SetShowHelp(this.uvGroupLayout, ((bool)(resources.GetObject("uvGroupLayout.ShowHelp"))));
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
			this.helpProvider.SetShowHelp(this.UVXUpDown, ((bool)(resources.GetObject("UVXUpDown.ShowHelp"))));
			this.UVXUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// toggleAnimationCheckBox
			// 
			resources.ApplyResources(this.toggleAnimationCheckBox, "toggleAnimationCheckBox");
			this.toggleAnimationCheckBox.Checked = true;
			this.toggleAnimationCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
			this.helpProvider.SetHelpString(this.toggleAnimationCheckBox, resources.GetString("toggleAnimationCheckBox.HelpString"));
			this.toggleAnimationCheckBox.Name = "toggleAnimationCheckBox";
			this.helpProvider.SetShowHelp(this.toggleAnimationCheckBox, ((bool)(resources.GetObject("toggleAnimationCheckBox.ShowHelp"))));
			this.toggleAnimationCheckBox.UseVisualStyleBackColor = true;
			this.toggleAnimationCheckBox.CheckedChanged += new System.EventHandler(this.toggleAnimationChanged);
			// 
			// rightLayout
			// 
			resources.ApplyResources(this.rightLayout, "rightLayout");
			this.rightLayout.Controls.Add(this.texturePreviewGroup, 0, 0);
			this.rightLayout.Controls.Add(this.buttonDone, 0, 5);
			this.rightLayout.Controls.Add(this.offsetGroup, 0, 4);
			this.rightLayout.Controls.Add(this.uvGroup, 0, 1);
			this.rightLayout.Controls.Add(this.positionGroup, 0, 3);
			this.rightLayout.Controls.Add(this.sizeGroup, 0, 2);
			this.rightLayout.Name = "rightLayout";
			this.helpProvider.SetShowHelp(this.rightLayout, ((bool)(resources.GetObject("rightLayout.ShowHelp"))));
			// 
			// texturePreviewGroup
			// 
			this.texturePreviewGroup.Controls.Add(this.texturePreviewLayout);
			resources.ApplyResources(this.texturePreviewGroup, "texturePreviewGroup");
			this.texturePreviewGroup.Name = "texturePreviewGroup";
			this.helpProvider.SetShowHelp(this.texturePreviewGroup, ((bool)(resources.GetObject("texturePreviewGroup.ShowHelp"))));
			this.texturePreviewGroup.TabStop = false;
			// 
			// texturePreviewLayout
			// 
			resources.ApplyResources(this.texturePreviewLayout, "texturePreviewLayout");
			this.texturePreviewLayout.Controls.Add(this.importButton, 0, 1);
			this.texturePreviewLayout.Controls.Add(this.exportButton, 1, 1);
			this.texturePreviewLayout.Controls.Add(this.uvPictureBox, 0, 0);
			this.texturePreviewLayout.Name = "texturePreviewLayout";
			this.helpProvider.SetShowHelp(this.texturePreviewLayout, ((bool)(resources.GetObject("texturePreviewLayout.ShowHelp"))));
			// 
			// uvPictureBox
			// 
			this.uvPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.texturePreviewLayout.SetColumnSpan(this.uvPictureBox, 2);
			resources.ApplyResources(this.uvPictureBox, "uvPictureBox");
			this.uvPictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			this.uvPictureBox.Name = "uvPictureBox";
			this.helpProvider.SetShowHelp(this.uvPictureBox, ((bool)(resources.GetObject("uvPictureBox.ShowHelp"))));
			this.uvPictureBox.TabStop = false;
			// 
			// mainView
			// 
			this.mainView.BackColor = System.Drawing.Color.Black;
			this.mainView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.mainView, "mainView");
			this.helpProvider.SetHelpString(this.mainView, resources.GetString("mainView.HelpString"));
			this.mainView.Name = "mainView";
			this.helpProvider.SetShowHelp(this.mainView, ((bool)(resources.GetObject("mainView.ShowHelp"))));
			this.mainView.TabStop = false;
			this.mainView.VSync = false;
			this.mainView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GLStartPanning);
			this.mainView.MouseEnter += new System.EventHandler(this.GLEnableZoom);
			this.mainView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GLPan);
			this.mainView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GLStopPanning);
			this.mainView.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.GLZoom);
			// 
			// partGroup
			// 
			resources.ApplyResources(this.partGroup, "partGroup");
			this.partGroup.Controls.Add(this.partLayout);
			this.partGroup.Name = "partGroup";
			this.helpProvider.SetShowHelp(this.partGroup, ((bool)(resources.GetObject("partGroup.ShowHelp"))));
			this.partGroup.TabStop = false;
			// 
			// partLayout
			// 
			resources.ApplyResources(this.partLayout, "partLayout");
			this.partLayout.Controls.Add(this.comboParent, 0, 0);
			this.partLayout.Controls.Add(this.mirrorCheckBox, 0, 1);
			this.partLayout.Controls.Add(this.armorCheckBox, 0, 2);
			this.partLayout.Controls.Add(this.InflateUpDown, 0, 3);
			this.partLayout.Name = "partLayout";
			this.helpProvider.SetShowHelp(this.partLayout, ((bool)(resources.GetObject("partLayout.ShowHelp"))));
			// 
			// mirrorCheckBox
			// 
			resources.ApplyResources(this.mirrorCheckBox, "mirrorCheckBox");
			this.helpProvider.SetHelpString(this.mirrorCheckBox, resources.GetString("mirrorCheckBox.HelpString"));
			this.mirrorCheckBox.Name = "mirrorCheckBox";
			this.helpProvider.SetShowHelp(this.mirrorCheckBox, ((bool)(resources.GetObject("mirrorCheckBox.ShowHelp"))));
			this.mirrorCheckBox.UseVisualStyleBackColor = true;
			this.mirrorCheckBox.CheckedChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// armorCheckBox
			// 
			resources.ApplyResources(this.armorCheckBox, "armorCheckBox");
			this.helpProvider.SetHelpString(this.armorCheckBox, resources.GetString("armorCheckBox.HelpString"));
			this.armorCheckBox.Name = "armorCheckBox";
			this.helpProvider.SetShowHelp(this.armorCheckBox, ((bool)(resources.GetObject("armorCheckBox.ShowHelp"))));
			this.armorCheckBox.UseVisualStyleBackColor = true;
			this.armorCheckBox.CheckedChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// InflateUpDown
			// 
			resources.ApplyResources(this.InflateUpDown, "InflateUpDown");
			this.InflateUpDown.DecimalPlaces = 2;
			this.helpProvider.SetHelpString(this.InflateUpDown, resources.GetString("InflateUpDown.HelpString"));
			this.InflateUpDown.Name = "InflateUpDown";
			this.helpProvider.SetShowHelp(this.InflateUpDown, ((bool)(resources.GetObject("InflateUpDown.ShowHelp"))));
			this.InflateUpDown.ValueChanged += new System.EventHandler(this.formChangeSkinBox);
			// 
			// optionsGroup
			// 
			resources.ApplyResources(this.optionsGroup, "optionsGroup");
			this.optionsGroup.Controls.Add(this.optionsLayout);
			this.optionsGroup.Name = "optionsGroup";
			this.helpProvider.SetShowHelp(this.optionsGroup, ((bool)(resources.GetObject("optionsGroup.ShowHelp"))));
			this.optionsGroup.TabStop = false;
			// 
			// optionsLayout
			// 
			resources.ApplyResources(this.optionsLayout, "optionsLayout");
			this.optionsLayout.Controls.Add(this.generateTextureCheckBox, 0, 0);
			this.optionsLayout.Controls.Add(this.toggleAnimationCheckBox, 0, 3);
			this.optionsLayout.Controls.Add(this.showGuidelinesCheckBox, 0, 1);
			this.optionsLayout.Controls.Add(this.showArmorCheckBox, 0, 2);
			this.optionsLayout.Name = "optionsLayout";
			this.helpProvider.SetShowHelp(this.optionsLayout, ((bool)(resources.GetObject("optionsLayout.ShowHelp"))));
			// 
			// skinBoxList
			// 
			this.skinBoxList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.skinBoxList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			resources.ApplyResources(this.skinBoxList, "skinBoxList");
			this.helpProvider.SetHelpString(this.skinBoxList, resources.GetString("skinBoxList.HelpString"));
			this.skinBoxList.Name = "skinBoxList";
			this.helpProvider.SetShowHelp(this.skinBoxList, ((bool)(resources.GetObject("skinBoxList.ShowHelp"))));
			this.skinBoxList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.summonContextMenu);
			// 
			// layout
			// 
			this.layout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.layout, "layout");
			this.layout.Name = "layout";
			// 
			// layout.Panel1
			// 
			this.layout.Panel1.Controls.Add(this.leftLayout);
			this.helpProvider.SetShowHelp(this.layout.Panel1, ((bool)(resources.GetObject("layout.Panel1.ShowHelp"))));
			// 
			// layout.Panel2
			// 
			this.layout.Panel2.Controls.Add(this.layout2);
			this.helpProvider.SetShowHelp(this.layout.Panel2, ((bool)(resources.GetObject("layout.Panel2.ShowHelp"))));
			this.helpProvider.SetShowHelp(this.layout, ((bool)(resources.GetObject("layout.ShowHelp"))));
			// 
			// leftLayout
			// 
			resources.ApplyResources(this.leftLayout, "leftLayout");
			this.leftLayout.Controls.Add(this.skinBoxList, 0, 0);
			this.leftLayout.Controls.Add(this.buttonTemplate, 0, 3);
			this.leftLayout.Controls.Add(this.partGroup, 0, 1);
			this.leftLayout.Controls.Add(this.optionsGroup, 0, 2);
			this.leftLayout.Name = "leftLayout";
			this.helpProvider.SetShowHelp(this.leftLayout, ((bool)(resources.GetObject("leftLayout.ShowHelp"))));
			// 
			// layout2
			// 
			this.layout2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.layout2, "layout2");
			this.layout2.Name = "layout2";
			// 
			// layout2.Panel1
			// 
			this.layout2.Panel1.Controls.Add(this.mainView);
			this.helpProvider.SetShowHelp(this.layout2.Panel1, ((bool)(resources.GetObject("layout2.Panel1.ShowHelp"))));
			// 
			// layout2.Panel2
			// 
			this.layout2.Panel2.Controls.Add(this.rightLayout);
			this.helpProvider.SetShowHelp(this.layout2.Panel2, ((bool)(resources.GetObject("layout2.Panel2.ShowHelp"))));
			this.helpProvider.SetShowHelp(this.layout2, ((bool)(resources.GetObject("layout2.ShowHelp"))));
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Name = "menuStrip";
			this.helpProvider.SetShowHelp(this.menuStrip, ((bool)(resources.GetObject("menuStrip.ShowHelp"))));
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTemplateToolStripMenuItem,
            this.finishToolStripMenuItem,
            this.cancelToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// loadTemplateToolStripMenuItem
			// 
			this.loadTemplateToolStripMenuItem.Name = "loadTemplateToolStripMenuItem";
			resources.ApplyResources(this.loadTemplateToolStripMenuItem, "loadTemplateToolStripMenuItem");
			this.loadTemplateToolStripMenuItem.Click += new System.EventHandler(this.generateTemplate);
			// 
			// finishToolStripMenuItem
			// 
			this.finishToolStripMenuItem.Name = "finishToolStripMenuItem";
			resources.ApplyResources(this.finishToolStripMenuItem, "finishToolStripMenuItem");
			this.finishToolStripMenuItem.Click += new System.EventHandler(this.finished);
			// 
			// cancelToolStripMenuItem
			// 
			this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
			resources.ApplyResources(this.cancelToolStripMenuItem, "cancelToolStripMenuItem");
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.cloneToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.changeColorToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.doHelp);
			// 
			// ModelGeneratorForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.Name = "ModelGeneratorForm";
			this.helpProvider.SetShowHelp(this, ((bool)(resources.GetObject("$this.ShowHelp"))));
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formClosing);
			this.Load += new System.EventHandler(this.formLoaded);
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
			this.positionGroupLayout.ResumeLayout(false);
			this.sizeGroup.ResumeLayout(false);
			this.sizeGroup.PerformLayout();
			this.sizeGroupLayout.ResumeLayout(false);
			this.uvGroup.ResumeLayout(false);
			this.uvGroup.PerformLayout();
			this.uvGroupLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.UVXUpDown)).EndInit();
			this.rightLayout.ResumeLayout(false);
			this.rightLayout.PerformLayout();
			this.texturePreviewGroup.ResumeLayout(false);
			this.texturePreviewLayout.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uvPictureBox)).EndInit();
			this.partGroup.ResumeLayout(false);
			this.partGroup.PerformLayout();
			this.partLayout.ResumeLayout(false);
			this.partLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.InflateUpDown)).EndInit();
			this.optionsGroup.ResumeLayout(false);
			this.optionsGroup.PerformLayout();
			this.optionsLayout.ResumeLayout(false);
			this.optionsLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.skinBoxList)).EndInit();
			this.layout.Panel1.ResumeLayout(false);
			this.layout.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
			this.layout.ResumeLayout(false);
			this.leftLayout.ResumeLayout(false);
			this.leftLayout.PerformLayout();
			this.layout2.Panel1.ResumeLayout(false);
			this.layout2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layout2)).EndInit();
			this.layout2.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private TableLayoutPanel rightLayout;
		private GroupBox texturePreviewGroup;
		private GroupBox partGroup;
		private GroupBox optionsGroup;
		private OpenTK.GLControl mainView;
		private CheckBox toggleAnimationCheckBox;
		private DataGridView skinBoxList;
		private TableLayoutPanel sizeGroupLayout;
		private TableLayoutPanel uvGroupLayout;
		private TableLayoutPanel positionGroupLayout;
		private NumericUpDown UVXUpDown;
		private TableLayoutPanel optionsLayout;
		private TableLayoutPanel partLayout;
		private CheckBox mirrorCheckBox;
		private CheckBox armorCheckBox;
		private NumericUpDown InflateUpDown;
		private SplitContainer layout;
		private TableLayoutPanel leftLayout;
		private SplitContainer layout2;
		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private HelpProvider helpProvider;
		private ToolStripMenuItem loadTemplateToolStripMenuItem;
		private ToolStripMenuItem finishToolStripMenuItem;
		private ToolStripMenuItem cancelToolStripMenuItem;
	}
}