using System.Windows.Forms;

namespace PckStudio.Forms.Editor
{
	partial class BehaviourEditor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BehaviourEditor));
			this.treeView1 = new TreeView();
			this.contextMenu = new ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new ToolStripMenuItem();
			this.addNewEntryToolStripMenuItem = new ToolStripMenuItem();
			this.addNewPositionOverrideToolStripMenuItem = new ToolStripMenuItem();
			this.renameToolStripMenuItem = new ToolStripMenuItem();
			this.removeToolStripMenuItem = new ToolStripMenuItem();
			this.menuStrip = new MenuStrip();
			this.fileToolStripMenuItem = new ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new ToolStripMenuItem();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
			this.MobIsTamedCheckbox = new CheckBox();
			this.MobHasSaddleCheckbox = new CheckBox();
			this.zUpDown = new NumericUpDown();
			this.yUpDown = new NumericUpDown();
			this.zLabel = new Label();
			this.yLabel = new Label();
			this.xUpDown = new NumericUpDown();
			this.xLabel = new Label();
			this.layout = new TableLayoutPanel();
			this.contextMenu.SuspendLayout();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.zUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xUpDown)).BeginInit();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.ContextMenuStrip = this.contextMenu;
			this.treeView1.Dock = DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(3, 3);
			this.treeView1.Name = "treeView1";
			this.layout.SetRowSpan(this.treeView1, 6);
			this.treeView1.Size = new System.Drawing.Size(236, 250);
			this.treeView1.TabIndex = 13;
			this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			this.treeView1.KeyDown += new KeyEventHandler(this.treeView1_KeyDown);
			this.treeView1.MouseHover += new System.EventHandler(this.treeView1_MouseHover);
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new ToolStripItem[] {
            this.addToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.removeToolStripMenuItem});
			this.contextMenu.Name = "metroContextMenu1";
			this.contextMenu.Size = new System.Drawing.Size(118, 70);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.addNewEntryToolStripMenuItem,
            this.addNewPositionOverrideToolStripMenuItem});
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.addToolStripMenuItem.Text = "Add";
			// 
			// addNewEntryToolStripMenuItem
			// 
			this.addNewEntryToolStripMenuItem.Name = "addNewEntryToolStripMenuItem";
			this.addNewEntryToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
			this.addNewEntryToolStripMenuItem.Text = "Add New Entry";
			this.addNewEntryToolStripMenuItem.Click += new System.EventHandler(this.addNewEntryToolStripMenuItem_Click);
			// 
			// addNewPositionOverrideToolStripMenuItem
			// 
			this.addNewPositionOverrideToolStripMenuItem.Name = "addNewPositionOverrideToolStripMenuItem";
			this.addNewPositionOverrideToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
			this.addNewPositionOverrideToolStripMenuItem.Text = "Add New Position Override";
			this.addNewPositionOverrideToolStripMenuItem.Click += new System.EventHandler(this.addNewPositionOverrideToolStripMenuItem_Click);
			// 
			// renameToolStripMenuItem
			// 
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.renameToolStripMenuItem.Text = "Change";
			this.renameToolStripMenuItem.Click += new System.EventHandler(this.changeToolStripMenuItem_Click);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// menuStrip
			// 
			this.menuStrip.AutoSize = false;
			this.menuStrip.Items.AddRange(new ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(349, 24);
			this.menuStrip.TabIndex = 14;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.saveToolStripMenuItem1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem1
			// 
			this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
			this.saveToolStripMenuItem1.Text = "Save";
			this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// MobIsTamedCheckbox
			// 
			this.MobIsTamedCheckbox.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.MobIsTamedCheckbox.AutoSize = true;
			this.layout.SetColumnSpan(this.MobIsTamedCheckbox, 2);
			this.MobIsTamedCheckbox.Enabled = false;
			this.MobIsTamedCheckbox.Location = new System.Drawing.Point(245, 3);
			this.MobIsTamedCheckbox.Name = "MobIsTamedCheckbox";
			this.MobIsTamedCheckbox.Size = new System.Drawing.Size(101, 17);
			this.MobIsTamedCheckbox.TabIndex = 22;
			this.MobIsTamedCheckbox.Text = "Mob is tamed";
			this.MobIsTamedCheckbox.CheckedChanged += new System.EventHandler(this.MobIsTamedCheckbox_CheckedChanged);
			// 
			// MobHasSaddleCheckbox
			// 
			this.MobHasSaddleCheckbox.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.MobHasSaddleCheckbox.AutoSize = true;
			this.layout.SetColumnSpan(this.MobHasSaddleCheckbox, 2);
			this.MobHasSaddleCheckbox.Enabled = false;
			this.MobHasSaddleCheckbox.Location = new System.Drawing.Point(245, 26);
			this.MobHasSaddleCheckbox.Name = "MobHasSaddleCheckbox";
			this.MobHasSaddleCheckbox.Size = new System.Drawing.Size(101, 17);
			this.MobHasSaddleCheckbox.TabIndex = 23;
			this.MobHasSaddleCheckbox.Text = "Mob has saddle";
			this.MobHasSaddleCheckbox.CheckedChanged += new System.EventHandler(this.MobHasSaddleCheckbox_CheckedChanged);
			// 
			// zUpDown
			// 
			this.zUpDown.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.zUpDown.DecimalPlaces = 3;
			this.zUpDown.Enabled = false;
			this.zUpDown.Location = new System.Drawing.Point(265, 101);
			this.zUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.zUpDown.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
			this.zUpDown.Name = "zUpDown";
			this.zUpDown.Size = new System.Drawing.Size(81, 20);
			this.zUpDown.TabIndex = 29;
			this.zUpDown.ValueChanged += new System.EventHandler(this.zUpDown_ValueChanged);
			// 
			// yUpDown
			// 
			this.yUpDown.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.yUpDown.DecimalPlaces = 3;
			this.yUpDown.Enabled = false;
			this.yUpDown.Location = new System.Drawing.Point(265, 75);
			this.yUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.yUpDown.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
			this.yUpDown.Name = "yUpDown";
			this.yUpDown.Size = new System.Drawing.Size(81, 20);
			this.yUpDown.TabIndex = 28;
			this.yUpDown.ValueChanged += new System.EventHandler(this.yUpDown_ValueChanged);
			// 
			// zLabel
			// 
			this.zLabel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.zLabel.AutoSize = true;
			this.zLabel.Location = new System.Drawing.Point(245, 104);
			this.zLabel.Name = "zLabel";
			this.zLabel.Size = new System.Drawing.Size(14, 13);
			this.zLabel.TabIndex = 25;
			this.zLabel.Text = "Z";
			this.zLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// yLabel
			// 
			this.yLabel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.yLabel.AutoSize = true;
			this.yLabel.Location = new System.Drawing.Point(245, 78);
			this.yLabel.Name = "yLabel";
			this.yLabel.Size = new System.Drawing.Size(14, 13);
			this.yLabel.TabIndex = 24;
			this.yLabel.Text = "Y";
			this.yLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// xUpDown
			// 
			this.xUpDown.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.xUpDown.DecimalPlaces = 3;
			this.xUpDown.Enabled = false;
			this.xUpDown.Location = new System.Drawing.Point(265, 49);
			this.xUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.xUpDown.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
			this.xUpDown.Name = "xUpDown";
			this.xUpDown.Size = new System.Drawing.Size(81, 20);
			this.xUpDown.TabIndex = 31;
			this.xUpDown.ValueChanged += new System.EventHandler(this.xUpDown_ValueChanged);
			// 
			// xLabel
			// 
			this.xLabel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.xLabel.AutoSize = true;
			this.xLabel.Location = new System.Drawing.Point(245, 52);
			this.xLabel.Name = "xLabel";
			this.xLabel.Size = new System.Drawing.Size(14, 13);
			this.xLabel.TabIndex = 30;
			this.xLabel.Text = "X";
			this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// layout
			// 
			this.layout.ColumnCount = 3;
			this.layout.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layout.ColumnStyles.Add(new ColumnStyle());
			this.layout.ColumnStyles.Add(new ColumnStyle());
			this.layout.Controls.Add(this.zUpDown, 2, 4);
			this.layout.Controls.Add(this.zLabel, 1, 4);
			this.layout.Controls.Add(this.MobIsTamedCheckbox, 1, 0);
			this.layout.Controls.Add(this.treeView1, 0, 0);
			this.layout.Controls.Add(this.MobHasSaddleCheckbox, 1, 1);
			this.layout.Controls.Add(this.xLabel, 1, 2);
			this.layout.Controls.Add(this.xUpDown, 2, 2);
			this.layout.Controls.Add(this.yLabel, 1, 3);
			this.layout.Controls.Add(this.yUpDown, 2, 3);
			this.layout.Dock = DockStyle.Fill;
			this.layout.Location = new System.Drawing.Point(0, 24);
			this.layout.Name = "layout";
			this.layout.RowCount = 6;
			this.layout.RowStyles.Add(new RowStyle());
			this.layout.RowStyles.Add(new RowStyle());
			this.layout.RowStyles.Add(new RowStyle());
			this.layout.RowStyles.Add(new RowStyle());
			this.layout.RowStyles.Add(new RowStyle());
			this.layout.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layout.Size = new System.Drawing.Size(349, 256);
			this.layout.TabIndex = 32;
			// 
			// BehaviourEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 280);
			this.Controls.Add(this.layout);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BehaviourEditor";
			this.Text = "Behaviour Editor";
			this.FormClosing += new FormClosingEventHandler(this.BehaviourEditor_FormClosing);
			this.contextMenu.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.zUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xUpDown)).EndInit();
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TreeView treeView1;
		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem1;
		private ToolStripMenuItem helpToolStripMenuItem;
		private CheckBox MobIsTamedCheckbox;
		private CheckBox MobHasSaddleCheckbox;
		private NumericUpDown zUpDown;
		private NumericUpDown yUpDown;
		private Label zLabel;
		private Label yLabel;
		private NumericUpDown xUpDown;
		private Label xLabel;
		private ContextMenuStrip contextMenu;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem renameToolStripMenuItem;
		private ToolStripMenuItem removeToolStripMenuItem;
		private ToolStripMenuItem addNewPositionOverrideToolStripMenuItem;
		private ToolStripMenuItem addNewEntryToolStripMenuItem;
		private TableLayoutPanel layout;
	}
}