
using System.Windows.Forms;

namespace PckStudio.Forms.Editor {
	partial class COLEditor {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COLEditor));
			this.menuStrip = new MenuStrip();
			this.fileToolStripMenuItem = new ToolStripMenuItem();
			this.saveToolStripMenuItem1 = new ToolStripMenuItem();
			this.toolsToolStripMenuItem = new ToolStripMenuItem();
			this.stripPS4BiomesToolStripMenuItem = new ToolStripMenuItem();
			this.targetUpdateToolStripMenuItem = new ToolStripMenuItem();
			this.TU12ToolStripMenuItem = new ToolStripMenuItem();
			this.TU13ToolStripMenuItem = new ToolStripMenuItem();
			this.TU14ToolStripMenuItem = new ToolStripMenuItem();
			this.TU19ToolStripMenuItem = new ToolStripMenuItem();
			this.TU31ToolStripMenuItem = new ToolStripMenuItem();
			this.TU32ToolStripMenuItem = new ToolStripMenuItem();
			this.TU43ToolStripMenuItem = new ToolStripMenuItem();
			this.TU46ToolStripMenuItem = new ToolStripMenuItem();
			this.TU51ToolStripMenuItem = new ToolStripMenuItem();
			this.TU53ToolStripMenuItem = new ToolStripMenuItem();
			this.TU54ToolStripMenuItem = new ToolStripMenuItem();
			this.TU69ToolStripMenuItem = new ToolStripMenuItem();
			this._1_9_1ToolStripMenuItem = new ToolStripMenuItem();
			this.ColorContextMenu = new ContextMenuStrip(this.components);
			this.copyColorToolStripMenuItem = new ToolStripMenuItem();
			this.pasteColorToolStripMenuItem = new ToolStripMenuItem();
			this.restoreOriginalColorToolStripMenuItem = new ToolStripMenuItem();
			this.addColorToolStripMenuItem = new ToolStripMenuItem();
			this.removeColorToolStripMenuItem = new ToolStripMenuItem();
			this.pictureBox1 = new PictureBox();
			this.hexLabel = new Label();
			this.colorTextbox = new TextBox();
			this.redLabel = new Label();
			this.greenLabel = new Label();
			this.blueLabel = new Label();
			this.alphaLabel = new Label();
			this.alphaUpDown = new NumericUpDown();
			this.redUpDown = new NumericUpDown();
			this.greenUpDown = new NumericUpDown();
			this.blueUpDown = new NumericUpDown();
			this.setColorBtn = new Button();
			this.tabControl = new TabControl();
			this.colorsTab = new TabPage();
			this.colorTreeView = new TreeView();
			this.waterTab = new TabPage();
			this.waterTreeView = new TreeView();
			this.underwaterTab = new TabPage();
			this.underwaterTreeView = new TreeView();
			this.fogTab = new TabPage();
			this.fogTreeView = new TreeView();
			this.filterLabel = new Label();
			this.filterTextBox = new TextBox();
			this.layout = new TableLayoutPanel();
			this.menuStrip.SuspendLayout();
			this.ColorContextMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.alphaUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.redUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).BeginInit();
			this.tabControl.SuspendLayout();
			this.colorsTab.SuspendLayout();
			this.waterTab.SuspendLayout();
			this.underwaterTab.SuspendLayout();
			this.fogTab.SuspendLayout();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Items.AddRange(new ToolStripItem[] {
			this.fileToolStripMenuItem,
			this.toolsToolStripMenuItem});
			this.menuStrip.Name = "menuStrip";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
			this.saveToolStripMenuItem1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// saveToolStripMenuItem1
			// 
			resources.ApplyResources(this.saveToolStripMenuItem1, "saveToolStripMenuItem1");
			this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
			this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
			this.stripPS4BiomesToolStripMenuItem,
			this.targetUpdateToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
			// 
			// stripPS4BiomesToolStripMenuItem
			// 
			this.stripPS4BiomesToolStripMenuItem.Name = "stripPS4BiomesToolStripMenuItem";
			resources.ApplyResources(this.stripPS4BiomesToolStripMenuItem, "stripPS4BiomesToolStripMenuItem");
			this.stripPS4BiomesToolStripMenuItem.Click += new System.EventHandler(this.stripPS4BiomesToolStripMenuItem_Click);
			// 
			// targetUpdateToolStripMenuItem
			// 
			this.targetUpdateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
			this.TU12ToolStripMenuItem,
			this.TU13ToolStripMenuItem,
			this.TU14ToolStripMenuItem,
			this.TU19ToolStripMenuItem,
			this.TU31ToolStripMenuItem,
			this.TU32ToolStripMenuItem,
			this.TU43ToolStripMenuItem,
			this.TU46ToolStripMenuItem,
			this.TU51ToolStripMenuItem,
			this.TU53ToolStripMenuItem,
			this.TU54ToolStripMenuItem,
			this.TU69ToolStripMenuItem,
			this._1_9_1ToolStripMenuItem});
			this.targetUpdateToolStripMenuItem.Name = "targetUpdateToolStripMenuItem";
			resources.ApplyResources(this.targetUpdateToolStripMenuItem, "targetUpdateToolStripMenuItem");
			// 
			// TU12ToolStripMenuItem
			// 
			this.TU12ToolStripMenuItem.Name = "TU12ToolStripMenuItem";
			resources.ApplyResources(this.TU12ToolStripMenuItem, "TU12ToolStripMenuItem");
			// 
			// TU13ToolStripMenuItem
			// 
			this.TU13ToolStripMenuItem.Name = "TU13ToolStripMenuItem";
			resources.ApplyResources(this.TU13ToolStripMenuItem, "TU13ToolStripMenuItem");
			// 
			// TU14ToolStripMenuItem
			// 
			this.TU14ToolStripMenuItem.Name = "TU14ToolStripMenuItem";
			resources.ApplyResources(this.TU14ToolStripMenuItem, "TU14ToolStripMenuItem");
			// 
			// TU19ToolStripMenuItem
			// 
			this.TU19ToolStripMenuItem.Name = "TU19ToolStripMenuItem";
			resources.ApplyResources(this.TU19ToolStripMenuItem, "TU19ToolStripMenuItem");
			// 
			// TU31ToolStripMenuItem
			// 
			this.TU31ToolStripMenuItem.Name = "TU31ToolStripMenuItem";
			resources.ApplyResources(this.TU31ToolStripMenuItem, "TU31ToolStripMenuItem");
			// 
			// TU32ToolStripMenuItem
			// 
			this.TU32ToolStripMenuItem.Name = "TU32ToolStripMenuItem";
			resources.ApplyResources(this.TU32ToolStripMenuItem, "TU32ToolStripMenuItem");
			// 
			// TU43ToolStripMenuItem
			// 
			this.TU43ToolStripMenuItem.Name = "TU43ToolStripMenuItem";
			resources.ApplyResources(this.TU43ToolStripMenuItem, "TU43ToolStripMenuItem");
			// 
			// TU46ToolStripMenuItem
			// 
			this.TU46ToolStripMenuItem.Name = "TU46ToolStripMenuItem";
			resources.ApplyResources(this.TU46ToolStripMenuItem, "TU46ToolStripMenuItem");
			// 
			// TU51ToolStripMenuItem
			// 
			this.TU51ToolStripMenuItem.Name = "TU51ToolStripMenuItem";
			resources.ApplyResources(this.TU51ToolStripMenuItem, "TU51ToolStripMenuItem");
			// 
			// TU53ToolStripMenuItem
			// 
			this.TU53ToolStripMenuItem.Name = "TU53ToolStripMenuItem";
			resources.ApplyResources(this.TU53ToolStripMenuItem, "TU53ToolStripMenuItem");
			// 
			// TU54ToolStripMenuItem
			// 
			this.TU54ToolStripMenuItem.Name = "TU54ToolStripMenuItem";
			resources.ApplyResources(this.TU54ToolStripMenuItem, "TU54ToolStripMenuItem");
			// 
			// TU69ToolStripMenuItem
			// 
			this.TU69ToolStripMenuItem.Name = "TU69ToolStripMenuItem";
			resources.ApplyResources(this.TU69ToolStripMenuItem, "TU69ToolStripMenuItem");
			// 
			// _1_9_1ToolStripMenuItem
			// 
			this._1_9_1ToolStripMenuItem.Name = "_1_9_1ToolStripMenuItem";
			resources.ApplyResources(this._1_9_1ToolStripMenuItem, "_1_9_1ToolStripMenuItem");
			// 
			// ColorContextMenu
			// 
			this.ColorContextMenu.Items.AddRange(new ToolStripItem[] {
			this.copyColorToolStripMenuItem,
			this.pasteColorToolStripMenuItem,
			this.restoreOriginalColorToolStripMenuItem,
			this.addColorToolStripMenuItem,
			this.removeColorToolStripMenuItem});
			this.ColorContextMenu.Name = "ColorContextMenu";
			resources.ApplyResources(this.ColorContextMenu, "ColorContextMenu");
			// 
			// copyColorToolStripMenuItem
			// 
			this.copyColorToolStripMenuItem.Image = global::PckStudio.Properties.Resources.file_copy;
			this.copyColorToolStripMenuItem.Name = "copyColorToolStripMenuItem";
			resources.ApplyResources(this.copyColorToolStripMenuItem, "copyColorToolStripMenuItem");
			this.copyColorToolStripMenuItem.Click += new System.EventHandler(this.copyColorToolStripMenuItem_Click);
			// 
			// pasteColorToolStripMenuItem
			// 
			this.pasteColorToolStripMenuItem.Image = global::PckStudio.Properties.Resources.file_paste;
			this.pasteColorToolStripMenuItem.Name = "pasteColorToolStripMenuItem";
			resources.ApplyResources(this.pasteColorToolStripMenuItem, "pasteColorToolStripMenuItem");
			this.pasteColorToolStripMenuItem.Click += new System.EventHandler(this.pasteColorToolStripMenuItem_Click);
			// 
			// restoreOriginalColorToolStripMenuItem
			// 
			this.restoreOriginalColorToolStripMenuItem.Image = global::PckStudio.Properties.Resources.file_restore;
			this.restoreOriginalColorToolStripMenuItem.Name = "restoreOriginalColorToolStripMenuItem";
			resources.ApplyResources(this.restoreOriginalColorToolStripMenuItem, "restoreOriginalColorToolStripMenuItem");
			this.restoreOriginalColorToolStripMenuItem.Click += new System.EventHandler(this.restoreOriginalColorToolStripMenuItem_Click);
			// 
			// addColorToolStripMenuItem
			// 
			this.addColorToolStripMenuItem.Image = global::PckStudio.Properties.Resources.file_new;
			this.addColorToolStripMenuItem.Name = "addColorToolStripMenuItem";
			resources.ApplyResources(this.addColorToolStripMenuItem, "addColorToolStripMenuItem");
			this.addColorToolStripMenuItem.Click += new System.EventHandler(this.addColorToolStripMenuItem_Click);
			// 
			// removeColorToolStripMenuItem
			// 
			this.removeColorToolStripMenuItem.Image = global::PckStudio.Properties.Resources.file_delete;
			this.removeColorToolStripMenuItem.Name = "removeColorToolStripMenuItem";
			resources.ApplyResources(this.removeColorToolStripMenuItem, "removeColorToolStripMenuItem");
			this.removeColorToolStripMenuItem.Click += new System.EventHandler(this.removeColorToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			resources.ApplyResources(this.pictureBox1, "pictureBox1");
			this.layout.SetColumnSpan(this.pictureBox1, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.TabStop = false;
			// 
			// hexLabel
			// 
			resources.ApplyResources(this.hexLabel, "hexLabel");
			this.hexLabel.Name = "hexLabel";
			// 
			// colorTextbox
			// 
			resources.ApplyResources(this.colorTextbox, "colorTextbox");
			this.colorTextbox.CharacterCasing = CharacterCasing.Upper;
			this.colorTextbox.Name = "colorTextbox";
			this.colorTextbox.TextChanged += new System.EventHandler(this.colorBox_TextChanged);
			this.colorTextbox.KeyPress += new KeyPressEventHandler(this.colorTextbox_KeyPress);
			// 
			// redLabel
			// 
			resources.ApplyResources(this.redLabel, "redLabel");
			this.redLabel.Name = "redLabel";
			// 
			// greenLabel
			// 
			resources.ApplyResources(this.greenLabel, "greenLabel");
			this.greenLabel.Name = "greenLabel";
			// 
			// blueLabel
			// 
			resources.ApplyResources(this.blueLabel, "blueLabel");
			this.blueLabel.Name = "blueLabel";
			// 
			// alphaLabel
			// 
			resources.ApplyResources(this.alphaLabel, "alphaLabel");
			this.alphaLabel.Name = "alphaLabel";
			// 
			// alphaUpDown
			// 
			resources.ApplyResources(this.alphaUpDown, "alphaUpDown");
			this.alphaUpDown.Maximum = new decimal(new int[] {
			255,
			0,
			0,
			0});
			this.alphaUpDown.Name = "alphaUpDown";
			this.alphaUpDown.ValueChanged += new System.EventHandler(this.alpha_ValueChanged);
			// 
			// redUpDown
			// 
			resources.ApplyResources(this.redUpDown, "redUpDown");
			this.redUpDown.Maximum = new decimal(new int[] {
			255,
			0,
			0,
			0});
			this.redUpDown.Name = "redUpDown";
			// 
			// greenUpDown
			// 
			resources.ApplyResources(this.greenUpDown, "greenUpDown");
			this.greenUpDown.Maximum = new decimal(new int[] {
			255,
			0,
			0,
			0});
			this.greenUpDown.Name = "greenUpDown";
			// 
			// blueUpDown
			// 
			resources.ApplyResources(this.blueUpDown, "blueUpDown");
			this.blueUpDown.Maximum = new decimal(new int[] {
			255,
			0,
			0,
			0});
			this.blueUpDown.Name = "blueUpDown";
			// 
			// setColorBtn
			// 
			resources.ApplyResources(this.setColorBtn, "setColorBtn");
			this.layout.SetColumnSpan(this.setColorBtn, 2);
			this.setColorBtn.Name = "setColorBtn";
			this.setColorBtn.Click += new System.EventHandler(this.setColorBtn_Click);
			// 
			// tabControl
			// 
			this.layout.SetColumnSpan(this.tabControl, 2);
			this.tabControl.Controls.Add(this.colorsTab);
			this.tabControl.Controls.Add(this.waterTab);
			this.tabControl.Controls.Add(this.underwaterTab);
			this.tabControl.Controls.Add(this.fogTab);
			resources.ApplyResources(this.tabControl, "tabControl");
			this.tabControl.Name = "tabControl";
			this.layout.SetRowSpan(this.tabControl, 8);
			this.tabControl.SelectedIndex = 0;
			// 
			// colorsTab
			// 
			this.colorsTab.Controls.Add(this.colorTreeView);
			resources.ApplyResources(this.colorsTab, "colorsTab");
			this.colorsTab.Name = "colorsTab";
			// 
			// colorTreeView
			// 
			this.colorTreeView.ContextMenuStrip = this.ColorContextMenu;
			resources.ApplyResources(this.colorTreeView, "colorTreeView");
			this.colorTreeView.Name = "colorTreeView";
			this.colorTreeView.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
			this.colorTreeView.KeyDown += new KeyEventHandler(this.treeView1_KeyDown);
			// 
			// waterTab
			// 
			this.waterTab.Controls.Add(this.waterTreeView);
			resources.ApplyResources(this.waterTab, "waterTab");
			this.waterTab.Name = "waterTab";
			// 
			// waterTreeView
			// 
			this.waterTreeView.ContextMenuStrip = this.ColorContextMenu;
			resources.ApplyResources(this.waterTreeView, "waterTreeView");
			this.waterTreeView.Name = "waterTreeView";
			this.waterTreeView.AfterSelect += new TreeViewEventHandler(this.treeView2_AfterSelect);
			this.waterTreeView.KeyDown += new KeyEventHandler(this.treeView2_KeyDown);
			// 
			// underwaterTab
			// 
			this.underwaterTab.Controls.Add(this.underwaterTreeView);
			resources.ApplyResources(this.underwaterTab, "underwaterTab");
			this.underwaterTab.Name = "underwaterTab";
			// 
			// underwaterTreeView
			// 
			this.underwaterTreeView.ContextMenuStrip = this.ColorContextMenu;
			resources.ApplyResources(this.underwaterTreeView, "underwaterTreeView");
			this.underwaterTreeView.Name = "underwaterTreeView";
			this.underwaterTreeView.AfterSelect += new TreeViewEventHandler(this.treeView3_AfterSelect);
			this.underwaterTreeView.KeyDown += new KeyEventHandler(this.treeView3_KeyDown);
			// 
			// fogTab
			// 
			this.fogTab.Controls.Add(this.fogTreeView);
			resources.ApplyResources(this.fogTab, "fogTab");
			this.fogTab.Name = "fogTab";
			// 
			// fogTreeView
			// 
			this.fogTreeView.ContextMenuStrip = this.ColorContextMenu;
			resources.ApplyResources(this.fogTreeView, "fogTreeView");
			this.fogTreeView.Name = "fogTreeView";
			this.fogTreeView.AfterSelect += new TreeViewEventHandler(this.treeView4_AfterSelect);
			this.fogTreeView.KeyDown += new KeyEventHandler(this.treeView4_KeyDown);
			// 
			// filterLabel
			// 
			resources.ApplyResources(this.filterLabel, "filterLabel");
			this.filterLabel.Name = "filterLabel";
			// 
			// filterTextBox
			// 
			resources.ApplyResources(this.filterTextBox, "filterTextBox");
			this.filterTextBox.Name = "filterTextBox";
			this.filterTextBox.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
			// 
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(this.blueUpDown, 3, 6);
			this.layout.Controls.Add(this.redUpDown, 3, 4);
			this.layout.Controls.Add(this.greenUpDown, 3, 5);
			this.layout.Controls.Add(this.alphaUpDown, 3, 3);
			this.layout.Controls.Add(this.blueLabel, 2, 6);
			this.layout.Controls.Add(this.filterLabel, 0, 0);
			this.layout.Controls.Add(this.filterTextBox, 1, 0);
			this.layout.Controls.Add(this.redLabel, 2, 4);
			this.layout.Controls.Add(this.tabControl, 0, 1);
			this.layout.Controls.Add(this.pictureBox1, 2, 1);
			this.layout.Controls.Add(this.setColorBtn, 2, 2);
			this.layout.Controls.Add(this.colorTextbox, 3, 7);
			this.layout.Controls.Add(this.hexLabel, 2, 7);
			this.layout.Controls.Add(this.alphaLabel, 2, 3);
			this.layout.Controls.Add(this.greenLabel, 2, 5);
			this.layout.Name = "layout";
			// 
			// COLEditor
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.Controls.Add(this.menuStrip);
			this.Name = "COLEditor";
			this.FormClosing += new FormClosingEventHandler(this.COLEditor_FormClosing);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ColorContextMenu.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.alphaUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.redUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.greenUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.blueUpDown)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.colorsTab.ResumeLayout(false);
			this.waterTab.ResumeLayout(false);
			this.underwaterTab.ResumeLayout(false);
			this.fogTab.ResumeLayout(false);
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem1;
		private ContextMenuStrip ColorContextMenu;
		private ToolStripMenuItem restoreOriginalColorToolStripMenuItem;
		private ToolStripMenuItem copyColorToolStripMenuItem;
		private ToolStripMenuItem pasteColorToolStripMenuItem;
		private ToolStripMenuItem toolsToolStripMenuItem;
		private ToolStripMenuItem targetUpdateToolStripMenuItem;
		private ToolStripMenuItem TU12ToolStripMenuItem;
		private ToolStripMenuItem TU13ToolStripMenuItem;
		private ToolStripMenuItem TU14ToolStripMenuItem;
		private ToolStripMenuItem TU19ToolStripMenuItem;
		private ToolStripMenuItem TU31ToolStripMenuItem;
		private ToolStripMenuItem TU32ToolStripMenuItem;
		private ToolStripMenuItem TU43ToolStripMenuItem;
		private ToolStripMenuItem TU46ToolStripMenuItem;
		private ToolStripMenuItem TU51ToolStripMenuItem;
		private ToolStripMenuItem TU53ToolStripMenuItem;
		private ToolStripMenuItem TU54ToolStripMenuItem;
		private ToolStripMenuItem TU69ToolStripMenuItem;
		private ToolStripMenuItem _1_9_1ToolStripMenuItem;
		private ToolStripMenuItem stripPS4BiomesToolStripMenuItem;
		private ToolStripMenuItem addColorToolStripMenuItem;
		private ToolStripMenuItem removeColorToolStripMenuItem;
		private PictureBox pictureBox1;
		private Label hexLabel;
		private TextBox colorTextbox;
		private Label redLabel;
		private Label greenLabel;
		private Label blueLabel;
		private Label alphaLabel;
		private NumericUpDown alphaUpDown;
		private NumericUpDown redUpDown;
		private NumericUpDown greenUpDown;
		private NumericUpDown blueUpDown;
		private Button setColorBtn;
		private TabControl tabControl;
		private TabPage colorsTab;
		private TreeView colorTreeView;
		private TabPage waterTab;
		private TreeView waterTreeView;
		private TabPage underwaterTab;
		private TreeView underwaterTreeView;
		private TabPage fogTab;
		private TreeView fogTreeView;
		private Label filterLabel;
		private TextBox filterTextBox;
		private TableLayoutPanel layout;
	}
}