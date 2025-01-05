using System.Windows.Forms;

namespace PckStudio.Forms.Editor {
	partial class LOCEditor {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOCEditor));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.entryContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addDisplayIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteDisplayIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.languageContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.addLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rightLayout = new System.Windows.Forms.TableLayoutPanel();
			this.buttonReplaceAll = new System.Windows.Forms.Button();
			this.dataGridViewLocEntryData = new System.Windows.Forms.DataGridView();
			this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBoxReplaceAll = new System.Windows.Forms.TextBox();
			this.treeViewLocKeys = new System.Windows.Forms.TreeView();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.layout = new System.Windows.Forms.SplitContainer();
			this.helpProvider = new System.Windows.Forms.HelpProvider();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entryContextMenu.SuspendLayout();
			this.languageContextMenu.SuspendLayout();
			this.rightLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocEntryData)).BeginInit();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.layout)).BeginInit();
			this.layout.Panel1.SuspendLayout();
			this.layout.Panel2.SuspendLayout();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// entryContextMenu
			// 
			this.entryContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDisplayIDToolStripMenuItem,
            this.deleteDisplayIDToolStripMenuItem});
			this.entryContextMenu.Name = "contextMenuStrip1";
			resources.ApplyResources(this.entryContextMenu, "entryContextMenu");
			// 
			// addDisplayIDToolStripMenuItem
			// 
			this.addDisplayIDToolStripMenuItem.Name = "addDisplayIDToolStripMenuItem";
			resources.ApplyResources(this.addDisplayIDToolStripMenuItem, "addDisplayIDToolStripMenuItem");
			this.addDisplayIDToolStripMenuItem.Click += new System.EventHandler(this.KeyAdded);
			// 
			// deleteDisplayIDToolStripMenuItem
			// 
			this.deleteDisplayIDToolStripMenuItem.Name = "deleteDisplayIDToolStripMenuItem";
			resources.ApplyResources(this.deleteDisplayIDToolStripMenuItem, "deleteDisplayIDToolStripMenuItem");
			this.deleteDisplayIDToolStripMenuItem.Click += new System.EventHandler(this.KeyDeleted);
			// 
			// languageContextMenu
			// 
			this.languageContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLanguageToolStripMenuItem,
            this.removeLanguageToolStripMenuItem});
			this.languageContextMenu.Name = "GridContextMenu";
			resources.ApplyResources(this.languageContextMenu, "languageContextMenu");
			// 
			// addLanguageToolStripMenuItem
			// 
			this.addLanguageToolStripMenuItem.Name = "addLanguageToolStripMenuItem";
			resources.ApplyResources(this.addLanguageToolStripMenuItem, "addLanguageToolStripMenuItem");
			this.addLanguageToolStripMenuItem.Click += new System.EventHandler(this.LanguageAdded);
			// 
			// removeLanguageToolStripMenuItem
			// 
			this.removeLanguageToolStripMenuItem.Name = "removeLanguageToolStripMenuItem";
			resources.ApplyResources(this.removeLanguageToolStripMenuItem, "removeLanguageToolStripMenuItem");
			this.removeLanguageToolStripMenuItem.Click += new System.EventHandler(this.LanguageRemoved);
			// 
			// rightLayout
			// 
			this.rightLayout.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
			resources.ApplyResources(this.rightLayout, "rightLayout");
			this.rightLayout.Controls.Add(this.buttonReplaceAll, 1, 0);
			this.rightLayout.Controls.Add(this.dataGridViewLocEntryData, 0, 1);
			this.rightLayout.Controls.Add(this.textBoxReplaceAll, 0, 0);
			this.rightLayout.Name = "rightLayout";
			// 
			// buttonReplaceAll
			// 
			resources.ApplyResources(this.buttonReplaceAll, "buttonReplaceAll");
			this.helpProvider.SetHelpString(this.buttonReplaceAll, resources.GetString("buttonReplaceAll.HelpString"));
			this.buttonReplaceAll.Name = "buttonReplaceAll";
			this.helpProvider.SetShowHelp(this.buttonReplaceAll, ((bool)(resources.GetObject("buttonReplaceAll.ShowHelp"))));
			this.buttonReplaceAll.Click += new System.EventHandler(this.ReplaceAll);
			// 
			// dataGridViewLocEntryData
			// 
			this.dataGridViewLocEntryData.AllowUserToAddRows = false;
			this.dataGridViewLocEntryData.AllowUserToDeleteRows = false;
			this.dataGridViewLocEntryData.AllowUserToResizeColumns = false;
			resources.ApplyResources(this.dataGridViewLocEntryData, "dataGridViewLocEntryData");
			this.dataGridViewLocEntryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewLocEntryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewLocEntryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewLocEntryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Language,
            this.DisplayName});
			this.rightLayout.SetColumnSpan(this.dataGridViewLocEntryData, 2);
			this.dataGridViewLocEntryData.ContextMenuStrip = this.languageContextMenu;
			this.helpProvider.SetHelpString(this.dataGridViewLocEntryData, resources.GetString("dataGridViewLocEntryData.HelpString"));
			this.dataGridViewLocEntryData.Name = "dataGridViewLocEntryData";
			this.dataGridViewLocEntryData.RowHeadersVisible = false;
			this.helpProvider.SetShowHelp(this.dataGridViewLocEntryData, ((bool)(resources.GetObject("dataGridViewLocEntryData.ShowHelp"))));
			this.dataGridViewLocEntryData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.ValueEdited);
			this.dataGridViewLocEntryData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseTouchedAtLanguage);
			// 
			// Language
			// 
			this.Language.FillWeight = 15F;
			resources.ApplyResources(this.Language, "Language");
			this.Language.Name = "Language";
			this.Language.ReadOnly = true;
			// 
			// DisplayName
			// 
			resources.ApplyResources(this.DisplayName, "DisplayName");
			this.DisplayName.Name = "DisplayName";
			// 
			// textBoxReplaceAll
			// 
			resources.ApplyResources(this.textBoxReplaceAll, "textBoxReplaceAll");
			this.helpProvider.SetHelpString(this.textBoxReplaceAll, resources.GetString("textBoxReplaceAll.HelpString"));
			this.textBoxReplaceAll.Name = "textBoxReplaceAll";
			this.helpProvider.SetShowHelp(this.textBoxReplaceAll, ((bool)(resources.GetObject("textBoxReplaceAll.ShowHelp"))));
			// 
			// treeViewLocKeys
			// 
			this.treeViewLocKeys.ContextMenuStrip = this.entryContextMenu;
			resources.ApplyResources(this.treeViewLocKeys, "treeViewLocKeys");
			this.helpProvider.SetHelpString(this.treeViewLocKeys, resources.GetString("treeViewLocKeys.HelpString"));
			this.treeViewLocKeys.LabelEdit = true;
			this.treeViewLocKeys.Name = "treeViewLocKeys";
			this.helpProvider.SetShowHelp(this.treeViewLocKeys, ((bool)(resources.GetObject("treeViewLocKeys.ShowHelp"))));
			this.treeViewLocKeys.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.AfterEdit);
			this.treeViewLocKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyboardTouched);
			this.treeViewLocKeys.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseTouchedAtKey);
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
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Name = "menuStrip";
			// 
			// layout
			// 
			this.layout.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			resources.ApplyResources(this.layout, "layout");
			this.layout.Name = "layout";
			// 
			// layout.Panel1
			// 
			this.layout.Panel1.Controls.Add(this.treeViewLocKeys);
			// 
			// layout.Panel2
			// 
			this.layout.Panel2.Controls.Add(this.rightLayout);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.DoContextHelp);
			// 
			// LOCEditor
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.Controls.Add(this.menuStrip);
			this.Name = "LOCEditor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exiting);
			this.Load += new System.EventHandler(this.Loaded);
			this.entryContextMenu.ResumeLayout(false);
			this.languageContextMenu.ResumeLayout(false);
			this.rightLayout.ResumeLayout(false);
			this.rightLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocEntryData)).EndInit();
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.layout.Panel1.ResumeLayout(false);
			this.layout.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.layout)).EndInit();
			this.layout.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TreeView treeViewLocKeys;
		private DataGridView dataGridViewLocEntryData;
		private ContextMenuStrip entryContextMenu;
		private ToolStripMenuItem addDisplayIDToolStripMenuItem;
		private ToolStripMenuItem deleteDisplayIDToolStripMenuItem;
		private TextBox textBoxReplaceAll;
		private TableLayoutPanel rightLayout;
		private ContextMenuStrip languageContextMenu;
		private ToolStripMenuItem addLanguageToolStripMenuItem;
		private ToolStripMenuItem removeLanguageToolStripMenuItem;
		private DataGridViewTextBoxColumn Language;
		private DataGridViewTextBoxColumn DisplayName;
		private Button buttonReplaceAll;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem;
		private MenuStrip menuStrip;
		private SplitContainer layout;
		private HelpProvider helpProvider;
		private ToolStripMenuItem helpToolStripMenuItem;
	}
}