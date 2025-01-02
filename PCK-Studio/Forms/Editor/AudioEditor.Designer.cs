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
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.categoryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addCategoryStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeCategoryStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.changeCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catImages = new System.Windows.Forms.ImageList(this.components);
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteUnusedBINKAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openDataFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bulkReplaceExistingTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.organizeTracksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.howToAddSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.whatAreTheCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.howToEditCreditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optimizeDataFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bINKACompressionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.treeView2 = new System.Windows.Forms.TreeView();
			this.entryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addEntryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeEntryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.verifyFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.convertToWAVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.playOverworldInCreative = new System.Windows.Forms.CheckBox();
			this.compressionUpDown = new System.Windows.Forms.NumericUpDown();
			this.BinkCompressionLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
			// 
			// categoryContextMenu
			// 
			this.categoryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.catImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("catImages.ImageStream")));
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
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Name = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.treeView2.DragDrop += new System.Windows.Forms.DragEventHandler(this.Binka_DragDrop);
			this.treeView2.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView2_DragEnter);
			this.treeView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView2_KeyDown);
			// 
			// entryContextMenu
			// 
			this.entryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AudioEditor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AudioEditor_FormClosing);
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

		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.TreeView treeView2;
		private System.Windows.Forms.ContextMenuStrip categoryContextMenu;
		private System.Windows.Forms.ToolStripMenuItem removeCategoryStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addCategoryStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip entryContextMenu;
		private System.Windows.Forms.ToolStripMenuItem addEntryMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeEntryMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ImageList catImages;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verifyFileLocationToolStripMenuItem;
		private CheckBox playOverworldInCreative;
		private System.Windows.Forms.ToolStripMenuItem deleteUnusedBINKAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem howToAddSongsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem whatAreTheCategoriesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem howToEditCreditsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optimizeDataFolderToolStripMenuItem;
		private System.Windows.Forms.NumericUpDown compressionUpDown;
		private System.Windows.Forms.ToolStripMenuItem bINKACompressionToolStripMenuItem;
		private Label BinkCompressionLabel;
		private System.Windows.Forms.ToolStripMenuItem openDataFolderToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bulkReplaceExistingTracksToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem changeCategoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem organizeTracksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertToWAVToolStripMenuItem;
		private TableLayoutPanel tableLayoutPanel1;
	}
}