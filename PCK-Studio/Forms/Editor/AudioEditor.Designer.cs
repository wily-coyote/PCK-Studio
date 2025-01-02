using System.Windows.Forms;

namespace PckStudio.Forms.Editor
{
	partial class AudioEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioEditor));
			this.treeView1 = new TreeView();
			this.categoryContextMenu = new ContextMenuStrip(this.components);
			this.addCategoryStripMenuItem = new ToolStripMenuItem();
			this.removeCategoryStripMenuItem = new ToolStripMenuItem();
			this.changeCategoryToolStripMenuItem = new ToolStripMenuItem();
			this.catImages = new ImageList(this.components);
			this.menuStrip = new MenuStrip();
			this.fileToolStripMenuItem = new ToolStripMenuItem();
			this.saveToolStripMenuItem = new ToolStripMenuItem();
			this.toolsToolStripMenuItem = new ToolStripMenuItem();
			this.deleteUnusedBINKAsToolStripMenuItem = new ToolStripMenuItem();
			this.openDataFolderToolStripMenuItem = new ToolStripMenuItem();
			this.bulkReplaceExistingTracksToolStripMenuItem = new ToolStripMenuItem();
			this.organizeTracksToolStripMenuItem = new ToolStripMenuItem();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
			this.howToAddSongsToolStripMenuItem = new ToolStripMenuItem();
			this.whatAreTheCategoriesToolStripMenuItem = new ToolStripMenuItem();
			this.howToEditCreditsToolStripMenuItem = new ToolStripMenuItem();
			this.optimizeDataFolderToolStripMenuItem = new ToolStripMenuItem();
			this.bINKACompressionToolStripMenuItem = new ToolStripMenuItem();
			this.treeView2 = new TreeView();
			this.entryContextMenu = new ContextMenuStrip(this.components);
			this.addEntryMenuItem = new ToolStripMenuItem();
			this.removeEntryMenuItem = new ToolStripMenuItem();
			this.verifyFileLocationToolStripMenuItem = new ToolStripMenuItem();
			this.convertToWAVToolStripMenuItem = new ToolStripMenuItem();
			this.playOverworldInCreative = new CheckBox();
			this.compressionUpDown = new NumericUpDown();
			this.BinkCompressionLabel = new Label();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			this.categoryContextMenu.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.entryContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.compressionUpDown)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// treeView1
			// 
			this.treeView1.ContextMenuStrip = this.categoryContextMenu;
			resources.ApplyResources(this.treeView1, "treeView1");
			this.treeView1.ImageList = this.catImages;
			this.treeView1.LabelEdit = true;
			this.treeView1.Name = "treeView1";
			this.treeView1.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.KeyDown += new KeyEventHandler(this.treeView1_KeyDown);
			// 
			// categoryContextMenu
			// 
			this.categoryContextMenu.Items.AddRange(new ToolStripItem[] {
            this.addCategoryStripMenuItem,
            this.removeCategoryStripMenuItem,
            this.changeCategoryToolStripMenuItem});
			this.categoryContextMenu.Name = "contextMenuStrip1";
			resources.ApplyResources(this.categoryContextMenu, "categoryContextMenu");
			// 
			// addCategoryStripMenuItem
			// 
			resources.ApplyResources(this.addCategoryStripMenuItem, "addCategoryStripMenuItem");
			this.addCategoryStripMenuItem.Name = "addCategoryStripMenuItem";
			this.addCategoryStripMenuItem.Click += new System.EventHandler(this.addCategoryStripMenuItem_Click);
			// 
			// removeCategoryStripMenuItem
			// 
			this.removeCategoryStripMenuItem.Name = "removeCategoryStripMenuItem";
			resources.ApplyResources(this.removeCategoryStripMenuItem, "removeCategoryStripMenuItem");
			this.removeCategoryStripMenuItem.Click += new System.EventHandler(this.removeCategoryStripMenuItem_Click);
			// 
			// changeCategoryToolStripMenuItem
			// 
			this.changeCategoryToolStripMenuItem.Name = "changeCategoryToolStripMenuItem";
			resources.ApplyResources(this.changeCategoryToolStripMenuItem, "changeCategoryToolStripMenuItem");
			this.changeCategoryToolStripMenuItem.Click += new System.EventHandler(this.setCategoryToolStripMenuItem_Click);
			// 
			// catImages
			// 
			this.catImages.ImageStream = ((ImageListStreamer)(resources.GetObject("catImages.ImageStream")));
			this.catImages.TransparentColor = System.Drawing.Color.Transparent;
			this.catImages.Images.SetKeyName(0, "0_overworld.png");
			this.catImages.Images.SetKeyName(1, "1_nether.png");
			this.catImages.Images.SetKeyName(2, "2_end.png");
			this.catImages.Images.SetKeyName(3, "3_creative.png");
			this.catImages.Images.SetKeyName(4, "4_menu.png");
			this.catImages.Images.SetKeyName(5, "5_mg01.png");
			this.catImages.Images.SetKeyName(6, "6_mg02.png");
			this.catImages.Images.SetKeyName(7, "7_mg03.png");
			this.catImages.Images.SetKeyName(8, "8_mg04.png");
			// 
			// menuStrip
			// 
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Items.AddRange(new ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Name = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// saveToolStripMenuItem
			// 
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.deleteUnusedBINKAsToolStripMenuItem,
            this.openDataFolderToolStripMenuItem,
            this.bulkReplaceExistingTracksToolStripMenuItem,
            this.organizeTracksToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
			// 
			// deleteUnusedBINKAsToolStripMenuItem
			// 
			this.deleteUnusedBINKAsToolStripMenuItem.Name = "deleteUnusedBINKAsToolStripMenuItem";
			resources.ApplyResources(this.deleteUnusedBINKAsToolStripMenuItem, "deleteUnusedBINKAsToolStripMenuItem");
			this.deleteUnusedBINKAsToolStripMenuItem.Click += new System.EventHandler(this.deleteUnusedBINKAsToolStripMenuItem_Click);
			// 
			// openDataFolderToolStripMenuItem
			// 
			this.openDataFolderToolStripMenuItem.Name = "openDataFolderToolStripMenuItem";
			resources.ApplyResources(this.openDataFolderToolStripMenuItem, "openDataFolderToolStripMenuItem");
			this.openDataFolderToolStripMenuItem.Click += new System.EventHandler(this.openDataFolderToolStripMenuItem_Click);
			// 
			// bulkReplaceExistingTracksToolStripMenuItem
			// 
			this.bulkReplaceExistingTracksToolStripMenuItem.Name = "bulkReplaceExistingTracksToolStripMenuItem";
			resources.ApplyResources(this.bulkReplaceExistingTracksToolStripMenuItem, "bulkReplaceExistingTracksToolStripMenuItem");
			this.bulkReplaceExistingTracksToolStripMenuItem.Click += new System.EventHandler(this.bulkReplaceExistingFilesToolStripMenuItem_Click);
			// 
			// organizeTracksToolStripMenuItem
			// 
			this.organizeTracksToolStripMenuItem.Name = "organizeTracksToolStripMenuItem";
			resources.ApplyResources(this.organizeTracksToolStripMenuItem, "organizeTracksToolStripMenuItem");
			this.organizeTracksToolStripMenuItem.Click += new System.EventHandler(this.organizeTracksToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.howToAddSongsToolStripMenuItem,
            this.whatAreTheCategoriesToolStripMenuItem,
            this.howToEditCreditsToolStripMenuItem,
            this.optimizeDataFolderToolStripMenuItem,
            this.bINKACompressionToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			// 
			// howToAddSongsToolStripMenuItem
			// 
			this.howToAddSongsToolStripMenuItem.Name = "howToAddSongsToolStripMenuItem";
			resources.ApplyResources(this.howToAddSongsToolStripMenuItem, "howToAddSongsToolStripMenuItem");
			this.howToAddSongsToolStripMenuItem.Click += new System.EventHandler(this.howToAddSongsToolStripMenuItem_Click);
			// 
			// whatAreTheCategoriesToolStripMenuItem
			// 
			this.whatAreTheCategoriesToolStripMenuItem.Name = "whatAreTheCategoriesToolStripMenuItem";
			resources.ApplyResources(this.whatAreTheCategoriesToolStripMenuItem, "whatAreTheCategoriesToolStripMenuItem");
			this.whatAreTheCategoriesToolStripMenuItem.Click += new System.EventHandler(this.whatAreTheCategoriesToolStripMenuItem_Click);
			// 
			// howToEditCreditsToolStripMenuItem
			// 
			this.howToEditCreditsToolStripMenuItem.Name = "howToEditCreditsToolStripMenuItem";
			resources.ApplyResources(this.howToEditCreditsToolStripMenuItem, "howToEditCreditsToolStripMenuItem");
			this.howToEditCreditsToolStripMenuItem.Click += new System.EventHandler(this.howToEditCreditsToolStripMenuItem_Click);
			// 
			// optimizeDataFolderToolStripMenuItem
			// 
			this.optimizeDataFolderToolStripMenuItem.Name = "optimizeDataFolderToolStripMenuItem";
			resources.ApplyResources(this.optimizeDataFolderToolStripMenuItem, "optimizeDataFolderToolStripMenuItem");
			this.optimizeDataFolderToolStripMenuItem.Click += new System.EventHandler(this.optimizeDataFolderToolStripMenuItem_Click);
			// 
			// bINKACompressionToolStripMenuItem
			// 
			this.bINKACompressionToolStripMenuItem.Name = "bINKACompressionToolStripMenuItem";
			resources.ApplyResources(this.bINKACompressionToolStripMenuItem, "bINKACompressionToolStripMenuItem");
			this.bINKACompressionToolStripMenuItem.Click += new System.EventHandler(this.BINKACompressionToolStripMenuItem_Click);
			// 
			// treeView2
			// 
			this.treeView2.AllowDrop = true;
			this.tableLayoutPanel1.SetColumnSpan(this.treeView2, 2);
			this.treeView2.ContextMenuStrip = this.entryContextMenu;
			resources.ApplyResources(this.treeView2, "treeView2");
			this.treeView2.Name = "treeView2";
			this.treeView2.DragDrop += new DragEventHandler(this.Binka_DragDrop);
			this.treeView2.DragEnter += new DragEventHandler(this.treeView2_DragEnter);
			this.treeView2.KeyDown += new KeyEventHandler(this.treeView2_KeyDown);
			// 
			// entryContextMenu
			// 
			this.entryContextMenu.Items.AddRange(new ToolStripItem[] {
            this.addEntryMenuItem,
            this.removeEntryMenuItem,
            this.verifyFileLocationToolStripMenuItem,
            this.convertToWAVToolStripMenuItem});
			this.entryContextMenu.Name = "contextMenuStrip1";
			resources.ApplyResources(this.entryContextMenu, "entryContextMenu");
			// 
			// addEntryMenuItem
			// 
			resources.ApplyResources(this.addEntryMenuItem, "addEntryMenuItem");
			this.addEntryMenuItem.Name = "addEntryMenuItem";
			this.addEntryMenuItem.Click += new System.EventHandler(this.addEntryMenuItem_Click);
			// 
			// removeEntryMenuItem
			// 
			this.removeEntryMenuItem.Name = "removeEntryMenuItem";
			resources.ApplyResources(this.removeEntryMenuItem, "removeEntryMenuItem");
			this.removeEntryMenuItem.Click += new System.EventHandler(this.removeEntryMenuItem_Click);
			// 
			// verifyFileLocationToolStripMenuItem
			// 
			this.verifyFileLocationToolStripMenuItem.Name = "verifyFileLocationToolStripMenuItem";
			resources.ApplyResources(this.verifyFileLocationToolStripMenuItem, "verifyFileLocationToolStripMenuItem");
			this.verifyFileLocationToolStripMenuItem.Click += new System.EventHandler(this.verifyFileLocationToolStripMenuItem_Click);
			// 
			// convertToWAVToolStripMenuItem
			// 
			this.convertToWAVToolStripMenuItem.Name = "convertToWAVToolStripMenuItem";
			resources.ApplyResources(this.convertToWAVToolStripMenuItem, "convertToWAVToolStripMenuItem");
			this.convertToWAVToolStripMenuItem.Click += new System.EventHandler(this.convertToWAVToolStripMenuItem_Click);
			// 
			// playOverworldInCreative
			// 
			resources.ApplyResources(this.playOverworldInCreative, "playOverworldInCreative");
			this.tableLayoutPanel1.SetColumnSpan(this.playOverworldInCreative, 3);
			this.playOverworldInCreative.Name = "playOverworldInCreative";
			// 
			// compressionUpDown
			// 
			resources.ApplyResources(this.compressionUpDown, "compressionUpDown");
			this.compressionUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
			this.compressionUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.compressionUpDown.Name = "compressionUpDown";
			this.compressionUpDown.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// BinkCompressionLabel
			// 
			resources.ApplyResources(this.BinkCompressionLabel, "BinkCompressionLabel");
			this.BinkCompressionLabel.Name = "BinkCompressionLabel";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.treeView2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.BinkCompressionLabel, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.compressionUpDown, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.playOverworldInCreative, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// AudioEditor
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AudioEditor";
			this.FormClosing += new FormClosingEventHandler(this.AudioEditor_FormClosing);
			this.Shown += new System.EventHandler(this.AudioEditor_Shown);
			this.categoryContextMenu.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.entryContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.compressionUpDown)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TreeView treeView1;
		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private TreeView treeView2;
		private ContextMenuStrip categoryContextMenu;
		private ToolStripMenuItem removeCategoryStripMenuItem;
		private ToolStripMenuItem addCategoryStripMenuItem;
		private ContextMenuStrip entryContextMenu;
		private ToolStripMenuItem addEntryMenuItem;
		private ToolStripMenuItem removeEntryMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
        private ImageList catImages;
		private ToolStripMenuItem toolsToolStripMenuItem;
		private ToolStripMenuItem verifyFileLocationToolStripMenuItem;
		private CheckBox playOverworldInCreative;
		private ToolStripMenuItem deleteUnusedBINKAsToolStripMenuItem;
		private ToolStripMenuItem howToAddSongsToolStripMenuItem;
		private ToolStripMenuItem whatAreTheCategoriesToolStripMenuItem;
		private ToolStripMenuItem howToEditCreditsToolStripMenuItem;
		private ToolStripMenuItem optimizeDataFolderToolStripMenuItem;
		private NumericUpDown compressionUpDown;
		private ToolStripMenuItem bINKACompressionToolStripMenuItem;
		private Label BinkCompressionLabel;
		private ToolStripMenuItem openDataFolderToolStripMenuItem;
		private ToolStripMenuItem bulkReplaceExistingTracksToolStripMenuItem;
		private ToolStripMenuItem changeCategoryToolStripMenuItem;
		private ToolStripMenuItem organizeTracksToolStripMenuItem;
        private ToolStripMenuItem convertToWAVToolStripMenuItem;
		private TableLayoutPanel tableLayoutPanel1;
	}
}