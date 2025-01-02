using System.Windows.Forms;

namespace PckStudio.Forms.Editor {
	partial class GameRuleFileEditor {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameRuleFileEditor));
			this.GrfTreeView = new TreeView();
			this.MessageContextMenu = new ContextMenuStrip(this.components);
			this.addGameRuleToolStripMenuItem = new ToolStripMenuItem();
			this.removeGameRuleToolStripMenuItem = new ToolStripMenuItem();
			this.GrfParametersTreeView = new TreeView();
			this.DetailContextMenu = new ContextMenuStrip(this.components);
			this.addToolStripMenuItem1 = new ToolStripMenuItem();
			this.removeToolStripMenuItem = new ToolStripMenuItem();
			this.gameRuleLabel = new Label();
			this.parameterLabel = new Label();
			this.menuStrip = new MenuStrip();
			this.fileToolStripMenuItem = new ToolStripMenuItem();
			this.openToolStripMenuItem = new ToolStripMenuItem();
			this.saveToolStripMenuItem = new ToolStripMenuItem();
			this.compressionLvlToolStripMenuItem = new ToolStripMenuItem();
			this.levelToolStripMenuItem = new ToolStripMenuItem();
			this.noneToolStripMenuItem = new PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem();
			this.compressedToolStripMenuItem = new PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem();
			this.compressedRLEToolStripMenuItem = new PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem();
			this.compressedRLECRCToolStripMenuItem = new PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem();
			this.typeToolStripMenuItem = new ToolStripMenuItem();
			this.wiiUPSVitaToolStripMenuItem = new PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem();
			this.pS3ToolStripMenuItem = new PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem();
			this.xbox360ToolStripMenuItem = new PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem();
			this.layout = new TableLayoutPanel();
			this.MessageContextMenu.SuspendLayout();
			this.DetailContextMenu.SuspendLayout();
			this.menuStrip.SuspendLayout();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// GrfTreeView
			// 
			this.GrfTreeView.BorderStyle = BorderStyle.FixedSingle;
			this.GrfTreeView.ContextMenuStrip = this.MessageContextMenu;
			this.GrfTreeView.Dock = DockStyle.Fill;
			this.GrfTreeView.Location = new System.Drawing.Point(3, 23);
			this.GrfTreeView.Name = "GrfTreeView";
			this.GrfTreeView.Size = new System.Drawing.Size(244, 400);
			this.GrfTreeView.TabIndex = 0;
			this.GrfTreeView.AfterSelect += new TreeViewEventHandler(this.GrfTreeView_AfterSelect);
			this.GrfTreeView.KeyDown += new KeyEventHandler(this.GrfTreeView_KeyDown);
			// 
			// MessageContextMenu
			// 
			this.MessageContextMenu.Items.AddRange(new ToolStripItem[] {
            this.addGameRuleToolStripMenuItem,
            this.removeGameRuleToolStripMenuItem});
			this.MessageContextMenu.Name = "MessageContextMenu";
			this.MessageContextMenu.Size = new System.Drawing.Size(178, 48);
			// 
			// addGameRuleToolStripMenuItem
			// 
			this.addGameRuleToolStripMenuItem.Name = "addGameRuleToolStripMenuItem";
			this.addGameRuleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.addGameRuleToolStripMenuItem.Text = "Add Game Rule";
			this.addGameRuleToolStripMenuItem.Click += new System.EventHandler(this.addGameRuleToolStripMenuItem_Click);
			// 
			// removeGameRuleToolStripMenuItem
			// 
			this.removeGameRuleToolStripMenuItem.Name = "removeGameRuleToolStripMenuItem";
			this.removeGameRuleToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
			this.removeGameRuleToolStripMenuItem.Text = "Remove Game Rule";
			this.removeGameRuleToolStripMenuItem.Click += new System.EventHandler(this.removeGameRuleToolStripMenuItem_Click);
			// 
			// GrfParametersTreeView
			// 
			this.GrfParametersTreeView.BorderStyle = BorderStyle.FixedSingle;
			this.GrfParametersTreeView.ContextMenuStrip = this.DetailContextMenu;
			this.GrfParametersTreeView.Dock = DockStyle.Fill;
			this.GrfParametersTreeView.Location = new System.Drawing.Point(253, 23);
			this.GrfParametersTreeView.Name = "GrfParametersTreeView";
			this.GrfParametersTreeView.Size = new System.Drawing.Size(244, 400);
			this.GrfParametersTreeView.TabIndex = 1;
			this.GrfParametersTreeView.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(this.GrfDetailsTreeView_NodeMouseDoubleClick);
			this.GrfParametersTreeView.KeyDown += new KeyEventHandler(this.GrfDetailsTreeView_KeyDown);
			// 
			// DetailContextMenu
			// 
			this.DetailContextMenu.Items.AddRange(new ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.removeToolStripMenuItem});
			this.DetailContextMenu.Name = "DetailContextMenu";
			this.DetailContextMenu.Size = new System.Drawing.Size(118, 48);
			// 
			// addToolStripMenuItem1
			// 
			this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
			this.addToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
			this.addToolStripMenuItem1.Text = "Add";
			this.addToolStripMenuItem1.Click += new System.EventHandler(this.addDetailContextMenuItem_Click);
			// 
			// removeToolStripMenuItem
			// 
			this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
			this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.removeToolStripMenuItem.Text = "Remove";
			this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
			// 
			// gameRuleLabel
			// 
			this.gameRuleLabel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.gameRuleLabel.AutoSize = true;
			this.gameRuleLabel.Location = new System.Drawing.Point(3, 3);
			this.gameRuleLabel.Name = "gameRuleLabel";
			this.gameRuleLabel.Size = new System.Drawing.Size(244, 13);
			this.gameRuleLabel.TabIndex = 2;
			this.gameRuleLabel.Text = "Game Rule";
			this.gameRuleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// parameterLabel
			// 
			this.parameterLabel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.parameterLabel.AutoSize = true;
			this.parameterLabel.Location = new System.Drawing.Point(253, 3);
			this.parameterLabel.Name = "parameterLabel";
			this.parameterLabel.Size = new System.Drawing.Size(244, 13);
			this.parameterLabel.TabIndex = 0;
			this.parameterLabel.Text = "Parameters";
			this.parameterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.compressionLvlToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(500, 24);
			this.menuStrip.TabIndex = 3;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// compressionLvlToolStripMenuItem
			// 
			this.compressionLvlToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.levelToolStripMenuItem,
            this.typeToolStripMenuItem});
			this.compressionLvlToolStripMenuItem.Name = "compressionLvlToolStripMenuItem";
			this.compressionLvlToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
			this.compressionLvlToolStripMenuItem.Text = "Compression";
			// 
			// levelToolStripMenuItem
			// 
			this.levelToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.levelToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.compressedToolStripMenuItem,
            this.compressedRLEToolStripMenuItem,
            this.compressedRLECRCToolStripMenuItem});
			this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
			this.levelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.levelToolStripMenuItem.Text = "Level";
			// 
			// noneToolStripMenuItem
			// 
			this.noneToolStripMenuItem.Checked = true;
			this.noneToolStripMenuItem.CheckOnClick = true;
			this.noneToolStripMenuItem.CheckState = CheckState.Checked;
			this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
			this.noneToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.noneToolStripMenuItem.Text = "None";
			this.noneToolStripMenuItem.CheckedChanged += new System.EventHandler(this.noneToolStripMenuItem_CheckedChanged);
			// 
			// compressedToolStripMenuItem
			// 
			this.compressedToolStripMenuItem.CheckOnClick = true;
			this.compressedToolStripMenuItem.Name = "compressedToolStripMenuItem";
			this.compressedToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.compressedToolStripMenuItem.Text = "Compressed";
			this.compressedToolStripMenuItem.CheckedChanged += new System.EventHandler(this.compressedToolStripMenuItem_CheckedChanged);
			// 
			// compressedRLEToolStripMenuItem
			// 
			this.compressedRLEToolStripMenuItem.CheckOnClick = true;
			this.compressedRLEToolStripMenuItem.Name = "compressedRLEToolStripMenuItem";
			this.compressedRLEToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.compressedRLEToolStripMenuItem.Text = "Compressed + RLE";
			this.compressedRLEToolStripMenuItem.CheckedChanged += new System.EventHandler(this.compressedRLEToolStripMenuItem_CheckedChanged);
			// 
			// compressedRLECRCToolStripMenuItem
			// 
			this.compressedRLECRCToolStripMenuItem.CheckOnClick = true;
			this.compressedRLECRCToolStripMenuItem.Name = "compressedRLECRCToolStripMenuItem";
			this.compressedRLECRCToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.compressedRLECRCToolStripMenuItem.Text = "Compressed + RLE + CRC";
			this.compressedRLECRCToolStripMenuItem.CheckedChanged += new System.EventHandler(this.compressedRLECRCToolStripMenuItem_CheckedChanged);
			// 
			// typeToolStripMenuItem
			// 
			this.typeToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.typeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.wiiUPSVitaToolStripMenuItem,
            this.pS3ToolStripMenuItem,
            this.xbox360ToolStripMenuItem});
			this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
			this.typeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.typeToolStripMenuItem.Text = "Type";
			// 
			// wiiUPSVitaToolStripMenuItem
			// 
			this.wiiUPSVitaToolStripMenuItem.CheckOnClick = true;
			this.wiiUPSVitaToolStripMenuItem.Name = "wiiUPSVitaToolStripMenuItem";
			this.wiiUPSVitaToolStripMenuItem.ShowShortcutKeys = false;
			this.wiiUPSVitaToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.wiiUPSVitaToolStripMenuItem.Text = "Wii U, PS Vita";
			this.wiiUPSVitaToolStripMenuItem.CheckedChanged += new System.EventHandler(this.wiiUPSVitaToolStripMenuItem_CheckedChanged);
			// 
			// pS3ToolStripMenuItem
			// 
			this.pS3ToolStripMenuItem.CheckOnClick = true;
			this.pS3ToolStripMenuItem.Name = "pS3ToolStripMenuItem";
			this.pS3ToolStripMenuItem.ShowShortcutKeys = false;
			this.pS3ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.pS3ToolStripMenuItem.Text = "PS3";
			this.pS3ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.pS3ToolStripMenuItem_CheckedChanged);
			// 
			// xbox360ToolStripMenuItem
			// 
			this.xbox360ToolStripMenuItem.Checked = true;
			this.xbox360ToolStripMenuItem.CheckOnClick = true;
			this.xbox360ToolStripMenuItem.CheckState = CheckState.Checked;
			this.xbox360ToolStripMenuItem.Name = "xbox360ToolStripMenuItem";
			this.xbox360ToolStripMenuItem.ShowShortcutKeys = false;
			this.xbox360ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.xbox360ToolStripMenuItem.Text = "Xbox 360";
			this.xbox360ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.xbox360ToolStripMenuItem_CheckedChanged);
			// 
			// layout
			// 
			this.layout.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layout.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layout.Controls.Add(this.gameRuleLabel, 0, 0);
			this.layout.Controls.Add(this.GrfParametersTreeView, 1, 1);
			this.layout.Controls.Add(this.GrfTreeView, 0, 1);
			this.layout.Controls.Add(this.parameterLabel, 1, 0);
			this.layout.Dock = DockStyle.Fill;
			this.layout.Location = new System.Drawing.Point(0, 24);
			this.layout.Name = "layout";
			this.layout.RowCount = 2;
			this.layout.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layout.RowStyles.Add(new RowStyle());
			this.layout.Size = new System.Drawing.Size(500, 426);
			this.layout.TabIndex = 4;
			// 
			// GameRuleFileEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 450);
			this.Controls.Add(this.layout);
			this.Controls.Add(this.menuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(500, 450);
			this.Name = "GameRuleFileEditor";
			this.Text = "GRF Editor";
			this.FormClosing += new FormClosingEventHandler(this.GameRuleFileEditor_FormClosing);
			this.Load += new System.EventHandler(this.OnLoad);
			this.MessageContextMenu.ResumeLayout(false);
			this.DetailContextMenu.ResumeLayout(false);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TreeView GrfTreeView;
		private TreeView GrfParametersTreeView;
		private Label gameRuleLabel;
		private Label parameterLabel;
		private ContextMenuStrip MessageContextMenu;
		private ContextMenuStrip DetailContextMenu;
		private ToolStripMenuItem addGameRuleToolStripMenuItem;
		private ToolStripMenuItem addToolStripMenuItem1;
		private ToolStripMenuItem removeToolStripMenuItem;
		private ToolStripMenuItem removeGameRuleToolStripMenuItem;
		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private ToolStripMenuItem openToolStripMenuItem;
		private TableLayoutPanel layout;
		private ToolStripMenuItem compressionLvlToolStripMenuItem;
		private ToolStripMenuItem levelToolStripMenuItem;

		private PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem noneToolStripMenuItem;
		private PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem compressedToolStripMenuItem;
		private PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem compressedRLEToolStripMenuItem;
		private PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem compressedRLECRCToolStripMenuItem;

		private ToolStripMenuItem typeToolStripMenuItem;

		private PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem wiiUPSVitaToolStripMenuItem;
		private PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem pS3ToolStripMenuItem;
		private PckStudio.ToolboxItems.ToolStripRadioButtonMenuItem xbox360ToolStripMenuItem;
	}
}