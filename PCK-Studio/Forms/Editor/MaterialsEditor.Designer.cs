using System.Windows.Forms;

namespace PckStudio.Forms.Editor {
	partial class MaterialsEditor {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialsEditor));
			this.treeView1 = new TreeView();
			this.metroContextMenu1 = new ContextMenuStrip(this.components);
			this.addToolStripMenuItem = new ToolStripMenuItem();
			this.removeToolStripMenuItem = new ToolStripMenuItem();
			this.menuStrip = new MenuStrip();
			this.fileToolStripMenuItem = new ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new ToolStripMenuItem();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
			this.xLabel = new Label();
			this.materialComboBox = new ComboBox();
			this.layout = new TableLayoutPanel();
			this.metroContextMenu1.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.layout.SetColumnSpan(this.treeView1, 2);
			this.treeView1.ContextMenuStrip = this.metroContextMenu1;
			this.treeView1.Dock = DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(3, 3);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(378, 307);
			this.treeView1.TabIndex = 13;
			this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.NodeMouseClick += new TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			this.treeView1.KeyDown += new KeyEventHandler(this.treeView1_KeyDown);
			// 
			// metroContextMenu1
			// 
			this.metroContextMenu1.Items.AddRange(new ToolStripItem[] {
			this.addToolStripMenuItem,
			this.removeToolStripMenuItem});
			this.metroContextMenu1.Name = "metroContextMenu1";
			this.metroContextMenu1.Size = new System.Drawing.Size(127, 48);
			// 
			// addToolStripMenuItem
			// 
			this.addToolStripMenuItem.Name = "addToolStripMenuItem";
			this.addToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.addToolStripMenuItem.Text = "Add Entry";
			this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
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
			this.menuStrip.Size = new System.Drawing.Size(384, 24);
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
			// xLabel
			// 
			this.xLabel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.xLabel.AutoSize = true;
			this.xLabel.Location = new System.Drawing.Point(3, 320);
			this.xLabel.Name = "xLabel";
			this.xLabel.Size = new System.Drawing.Size(90, 13);
			this.xLabel.TabIndex = 30;
			this.xLabel.Text = "Material Type";
			this.xLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// materialComboBox
			// 
			this.materialComboBox.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.materialComboBox.FormattingEnabled = true;
			this.materialComboBox.ItemHeight = 13;
			this.materialComboBox.Items.AddRange(new object[] {
			"entity",
			"entity_alphatest",
			"entity_emissive_alpha",
			"entity_emissive_alpha_only",
			"entity_alphatest_change_color",
			"entity_change_color"});
			this.materialComboBox.Location = new System.Drawing.Point(99, 316);
			this.materialComboBox.Name = "materialComboBox";
			this.materialComboBox.Size = new System.Drawing.Size(282, 21);
			this.materialComboBox.TabIndex = 31;
			this.materialComboBox.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_SelectedIndexChanged);
			// 
			// layout
			// 
			this.layout.ColumnCount = 2;
			this.layout.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layout.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.layout.Controls.Add(this.treeView1, 0, 0);
			this.layout.Controls.Add(this.xLabel, 0, 1);
			this.layout.Controls.Add(this.materialComboBox, 1, 1);
			this.layout.Dock = DockStyle.Fill;
			this.layout.Location = new System.Drawing.Point(0, 24);
			this.layout.Name = "layout";
			this.layout.RowCount = 3;
			this.layout.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layout.RowStyles.Add(new RowStyle());
			this.layout.RowStyles.Add(new RowStyle());
			this.layout.Size = new System.Drawing.Size(384, 340);
			this.layout.TabIndex = 32;
			// 
			// MaterialsEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 364);
			this.Controls.Add(this.layout);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MaterialsEditor";
			this.Text = "Materials Editor";
			this.metroContextMenu1.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
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
		private Label xLabel;
		private ContextMenuStrip metroContextMenu1;
		private ToolStripMenuItem addToolStripMenuItem;
		private ToolStripMenuItem removeToolStripMenuItem;
		private ComboBox materialComboBox;
		private TableLayoutPanel layout;
	}
}