using System.Windows.Forms;

namespace PckStudio.Forms.Features {
	partial class CemuPanel {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TableLayoutPanel layoutPanel;
			this.gameDirectoryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.radioButtonEur = new System.Windows.Forms.RadioButton();
			this.radioButtonUs = new System.Windows.Forms.RadioButton();
			this.radioButtonJap = new System.Windows.Forms.RadioButton();
			this.GameDirectoryTextBox = new System.Windows.Forms.TextBox();
			this.BrowseDirectoryBtn = new System.Windows.Forms.Button();
			this.DLCTreeView = new System.Windows.Forms.TreeView();
			this.DLCContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.openSkinPackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openTexturePackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addCustomPckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removePckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			layoutPanel = new System.Windows.Forms.TableLayoutPanel();
			layoutPanel.SuspendLayout();
			this.gameDirectoryContextMenu.SuspendLayout();
			this.DLCContextMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// layoutPanel
			// 
			layoutPanel.ColumnCount = 3;
			layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
			layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			layoutPanel.ContextMenuStrip = this.gameDirectoryContextMenu;
			layoutPanel.Controls.Add(this.radioButtonEur, 0, 1);
			layoutPanel.Controls.Add(this.radioButtonUs, 1, 1);
			layoutPanel.Controls.Add(this.radioButtonJap, 2, 1);
			layoutPanel.Controls.Add(this.GameDirectoryTextBox, 0, 0);
			layoutPanel.Controls.Add(this.BrowseDirectoryBtn, 2, 0);
			layoutPanel.Controls.Add(this.DLCTreeView, 0, 2);
			layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			layoutPanel.Location = new System.Drawing.Point(0, 0);
			layoutPanel.Margin = new System.Windows.Forms.Padding(0);
			layoutPanel.Name = "layoutPanel";
			layoutPanel.RowCount = 3;
			layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			layoutPanel.Size = new System.Drawing.Size(430, 550);
			layoutPanel.TabIndex = 4;
			// 
			// gameDirectoryContextMenu
			// 
			this.gameDirectoryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openToolStripMenuItem,
			this.copyToolStripMenuItem});
			this.gameDirectoryContextMenu.Name = "gameDirectoryContextMenu";
			this.gameDirectoryContextMenu.Size = new System.Drawing.Size(155, 48);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.openToolStripMenuItem.Text = "Open Directory";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.copyToolStripMenuItem.Text = "Copy Path";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// radioButtonEur
			// 
			this.radioButtonEur.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonEur.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButtonEur.AutoSize = true;
			this.radioButtonEur.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.radioButtonEur.Checked = true;
			this.radioButtonEur.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.radioButtonEur.Location = new System.Drawing.Point(3, 32);
			this.radioButtonEur.Name = "radioButtonEur";
			this.radioButtonEur.Size = new System.Drawing.Size(137, 23);
			this.radioButtonEur.TabIndex = 1;
			this.radioButtonEur.TabStop = true;
			this.radioButtonEur.Text = "EU";
			this.radioButtonEur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonEur.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonUs
			// 
			this.radioButtonUs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonUs.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButtonUs.AutoSize = true;
			this.radioButtonUs.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.radioButtonUs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.radioButtonUs.Location = new System.Drawing.Point(146, 32);
			this.radioButtonUs.Name = "radioButtonUs";
			this.radioButtonUs.Size = new System.Drawing.Size(137, 23);
			this.radioButtonUs.TabIndex = 0;
			this.radioButtonUs.Text = "US";
			this.radioButtonUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonUs.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// radioButtonJap
			// 
			this.radioButtonJap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.radioButtonJap.Appearance = System.Windows.Forms.Appearance.Button;
			this.radioButtonJap.AutoSize = true;
			this.radioButtonJap.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.radioButtonJap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.radioButtonJap.Location = new System.Drawing.Point(289, 32);
			this.radioButtonJap.Name = "radioButtonJap";
			this.radioButtonJap.Size = new System.Drawing.Size(138, 23);
			this.radioButtonJap.TabIndex = 2;
			this.radioButtonJap.Text = "JP";
			this.radioButtonJap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.radioButtonJap.Click += new System.EventHandler(this.radioButton_Click);
			// 
			// GameDirectoryTextBox
			// 
			this.GameDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			layoutPanel.SetColumnSpan(this.GameDirectoryTextBox, 2);
			this.GameDirectoryTextBox.Location = new System.Drawing.Point(3, 4);
			this.GameDirectoryTextBox.Name = "GameDirectoryTextBox";
			this.GameDirectoryTextBox.Size = new System.Drawing.Size(280, 20);
			this.GameDirectoryTextBox.TabIndex = 11;
			this.GameDirectoryTextBox.TextChanged += new System.EventHandler(this.GameDirectoryTextBox_TextChanged);
			// 
			// BrowseDirectoryBtn
			// 
			this.BrowseDirectoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.BrowseDirectoryBtn.AutoSize = true;
			this.BrowseDirectoryBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BrowseDirectoryBtn.FlatAppearance.BorderSize = 0;
			this.BrowseDirectoryBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.BrowseDirectoryBtn.Location = new System.Drawing.Point(289, 3);
			this.BrowseDirectoryBtn.Name = "BrowseDirectoryBtn";
			this.BrowseDirectoryBtn.Size = new System.Drawing.Size(138, 23);
			this.BrowseDirectoryBtn.TabIndex = 12;
			this.BrowseDirectoryBtn.Text = "Browse";
			this.BrowseDirectoryBtn.Click += new System.EventHandler(this.BrowseDirectoryBtn_Click);
			// 
			// DLCTreeView
			// 
			this.DLCTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			layoutPanel.SetColumnSpan(this.DLCTreeView, 3);
			this.DLCTreeView.ContextMenuStrip = this.DLCContextMenu;
			this.DLCTreeView.Location = new System.Drawing.Point(3, 61);
			this.DLCTreeView.Name = "DLCTreeView";
			this.DLCTreeView.Size = new System.Drawing.Size(424, 486);
			this.DLCTreeView.TabIndex = 13;
			this.DLCTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DLCTreeView_AfterSelect);
			this.DLCTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.DLCTreeView_NodeMouseDoubleClick);
			this.DLCTreeView.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DLCTreeView_KeyPress);
			this.DLCTreeView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.DLCTreeView_PreviewKeyDown);
			// 
			// DLCContextMenu
			// 
			this.DLCContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openSkinPackToolStripMenuItem,
			this.openTexturePackToolStripMenuItem,
			this.addCustomPckToolStripMenuItem,
			this.removePckToolStripMenuItem});
			this.DLCContextMenu.Name = "DLCContextMenu";
			this.DLCContextMenu.Size = new System.Drawing.Size(174, 92);
			// 
			// openSkinPackToolStripMenuItem
			// 
			this.openSkinPackToolStripMenuItem.Name = "openSkinPackToolStripMenuItem";
			this.openSkinPackToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.openSkinPackToolStripMenuItem.Text = "Open Pack";
			this.openSkinPackToolStripMenuItem.Click += new System.EventHandler(this.openSkinPackToolStripMenuItem_Click);
			// 
			// openTexturePackToolStripMenuItem
			// 
			this.openTexturePackToolStripMenuItem.Name = "openTexturePackToolStripMenuItem";
			this.openTexturePackToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.openTexturePackToolStripMenuItem.Text = "Open Texture Pack";
			this.openTexturePackToolStripMenuItem.Click += new System.EventHandler(this.openTexturePackToolStripMenuItem_Click);
			// 
			// addCustomPckToolStripMenuItem
			// 
			this.addCustomPckToolStripMenuItem.Name = "addCustomPckToolStripMenuItem";
			this.addCustomPckToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.addCustomPckToolStripMenuItem.Text = "Add pck";
			this.addCustomPckToolStripMenuItem.Click += new System.EventHandler(this.addCustomPckToolStripMenuItem_Click);
			// 
			// removePckToolStripMenuItem
			// 
			this.removePckToolStripMenuItem.Name = "removePckToolStripMenuItem";
			this.removePckToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
			this.removePckToolStripMenuItem.Text = "Remove pck";
			this.removePckToolStripMenuItem.Click += new System.EventHandler(this.removePckToolStripMenuItem_Click);
			// 
			// CemuPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(layoutPanel);
			this.Name = "CemuPanel";
			this.Size = new System.Drawing.Size(430, 550);
			layoutPanel.ResumeLayout(false);
			layoutPanel.PerformLayout();
			this.gameDirectoryContextMenu.ResumeLayout(false);
			this.DLCContextMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Button BrowseDirectoryBtn;
		private TextBox GameDirectoryTextBox;
		private RadioButton radioButtonEur;
		private RadioButton radioButtonUs;
		private RadioButton radioButtonJap;
		private TreeView DLCTreeView;
		private ContextMenuStrip DLCContextMenu;
		private ToolStripMenuItem openSkinPackToolStripMenuItem;
		private ToolStripMenuItem openTexturePackToolStripMenuItem;
		private ToolStripMenuItem addCustomPckToolStripMenuItem;
		private ToolStripMenuItem removePckToolStripMenuItem;
		private ContextMenuStrip gameDirectoryContextMenu;
		private ToolStripMenuItem openToolStripMenuItem;
		private ToolStripMenuItem copyToolStripMenuItem;
	}
}
