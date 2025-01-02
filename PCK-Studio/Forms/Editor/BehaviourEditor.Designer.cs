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
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNewPositionOverrideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.renameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MobIsTamedCheckbox = new System.Windows.Forms.CheckBox();
			this.MobHasSaddleCheckbox = new System.Windows.Forms.CheckBox();
			this.zUpDown = new System.Windows.Forms.NumericUpDown();
			this.yUpDown = new System.Windows.Forms.NumericUpDown();
			this.zLabel = new System.Windows.Forms.Label();
			this.yLabel = new System.Windows.Forms.Label();
			this.xUpDown = new System.Windows.Forms.NumericUpDown();
			this.xLabel = new System.Windows.Forms.Label();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
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
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(3, 3);
			this.treeView1.Name = "treeView1";
			this.layout.SetRowSpan(this.treeView1, 6);
			this.treeView1.Size = new System.Drawing.Size(236, 250);
			this.treeView1.TabIndex = 13;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
			this.treeView1.MouseHover += new System.EventHandler(this.treeView1_MouseHover);
			// 
			// contextMenu
			// 
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.renameToolStripMenuItem,
            this.removeToolStripMenuItem});
			this.contextMenu.Name = "metroContextMenu1";
			this.contextMenu.Size = new System.Drawing.Size(118, 70);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.MobIsTamedCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
			this.MobHasSaddleCheckbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
			this.zUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
			this.yUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
			this.zLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
			this.yLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
			this.xUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
			this.xLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
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
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.layout.Controls.Add(this.zUpDown, 2, 4);
			this.layout.Controls.Add(this.zLabel, 1, 4);
			this.layout.Controls.Add(this.MobIsTamedCheckbox, 1, 0);
			this.layout.Controls.Add(this.treeView1, 0, 0);
			this.layout.Controls.Add(this.MobHasSaddleCheckbox, 1, 1);
			this.layout.Controls.Add(this.xLabel, 1, 2);
			this.layout.Controls.Add(this.xUpDown, 2, 2);
			this.layout.Controls.Add(this.yLabel, 1, 3);
			this.layout.Controls.Add(this.yUpDown, 2, 3);
			this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layout.Location = new System.Drawing.Point(0, 24);
			this.layout.Name = "layout";
			this.layout.RowCount = 6;
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layout.Size = new System.Drawing.Size(349, 256);
			this.layout.TabIndex = 32;
			// 
			// BehaviourEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(349, 280);
			this.Controls.Add(this.layout);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BehaviourEditor";
			this.Text = "Behaviour Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BehaviourEditor_FormClosing);
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

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private CheckBox MobIsTamedCheckbox;
		private CheckBox MobHasSaddleCheckbox;
		private System.Windows.Forms.NumericUpDown zUpDown;
		private System.Windows.Forms.NumericUpDown yUpDown;
		private Label zLabel;
		private Label yLabel;
		private System.Windows.Forms.NumericUpDown xUpDown;
		private Label xLabel;
		private ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewPositionOverrideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNewEntryToolStripMenuItem;
		private TableLayoutPanel layout;
	}
}