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
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			this.entryContextMenu = new ContextMenuStrip(this.components);
			this.addDisplayIDToolStripMenuItem = new ToolStripMenuItem();
			this.editDisplayIDToolStripMenuItem = new ToolStripMenuItem();
			this.deleteDisplayIDToolStripMenuItem = new ToolStripMenuItem();
			this.languageContextMenu = new ContextMenuStrip(this.components);
			this.addLanguageToolStripMenuItem = new ToolStripMenuItem();
			this.removeLanguageToolStripMenuItem = new ToolStripMenuItem();
			this.rightLayout = new TableLayoutPanel();
			this.buttonReplaceAll = new Button();
			this.dataGridViewLocEntryData = new DataGridView();
			this.Language = new DataGridViewTextBoxColumn();
			this.DisplayName = new DataGridViewTextBoxColumn();
			this.textBoxReplaceAll = new TextBox();
			this.treeViewLocKeys = new TreeView();
			this.fileToolStripMenuItem = new ToolStripMenuItem();
			this.saveToolStripMenuItem = new ToolStripMenuItem();
			this.menuStrip = new MenuStrip();
			this.layout = new SplitContainer();
			this.helpProvider = new HelpProvider();
			this.helpToolStripMenuItem = new ToolStripMenuItem();
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
			this.entryContextMenu.Items.AddRange(new ToolStripItem[] {
				this.addDisplayIDToolStripMenuItem,
				this.editDisplayIDToolStripMenuItem,
				this.deleteDisplayIDToolStripMenuItem});
			this.entryContextMenu.Name = "contextMenuStrip1";
			resources.ApplyResources(this.entryContextMenu, "entryContextMenu");
			// 
			// addDisplayIDToolStripMenuItem
			// 
			this.addDisplayIDToolStripMenuItem.Image = global::PckStudio.Icons.Add;
			this.addDisplayIDToolStripMenuItem.Name = "addDisplayIDToolStripMenuItem";
			resources.ApplyResources(this.addDisplayIDToolStripMenuItem, "addDisplayIDToolStripMenuItem");
			this.addDisplayIDToolStripMenuItem.Click += new System.EventHandler(this.KeyAdded);
			// 
			// editDisplayIDToolStripMenuItem
			// 
			this.editDisplayIDToolStripMenuItem.Image = global::PckStudio.Icons.Edit;
			this.editDisplayIDToolStripMenuItem.Name = "editDisplayIDToolStripMenuItem";
			resources.ApplyResources(this.editDisplayIDToolStripMenuItem, "editDisplayIDToolStripMenuItem");
			this.editDisplayIDToolStripMenuItem.Click += new System.EventHandler(this.KeyEdited);
			// 
			// deleteDisplayIDToolStripMenuItem
			// 
			this.deleteDisplayIDToolStripMenuItem.Image = global::PckStudio.Icons.DeleteHS;
			this.deleteDisplayIDToolStripMenuItem.Name = "deleteDisplayIDToolStripMenuItem";
			resources.ApplyResources(this.deleteDisplayIDToolStripMenuItem, "deleteDisplayIDToolStripMenuItem");
			this.deleteDisplayIDToolStripMenuItem.Click += new System.EventHandler(this.KeyDeleted);
			// 
			// languageContextMenu
			// 
			this.languageContextMenu.Items.AddRange(new ToolStripItem[] {
				this.addLanguageToolStripMenuItem,
				this.removeLanguageToolStripMenuItem});
			this.languageContextMenu.Name = "GridContextMenu";
			resources.ApplyResources(this.languageContextMenu, "languageContextMenu");
			// 
			// addLanguageToolStripMenuItem
			// 
			this.addLanguageToolStripMenuItem.Image = global::PckStudio.Icons.Add;
			this.addLanguageToolStripMenuItem.Name = "addLanguageToolStripMenuItem";
			resources.ApplyResources(this.addLanguageToolStripMenuItem, "addLanguageToolStripMenuItem");
			this.addLanguageToolStripMenuItem.Click += new System.EventHandler(this.LanguageAdded);
			// 
			// removeLanguageToolStripMenuItem
			// 
			this.removeLanguageToolStripMenuItem.Image = global::PckStudio.Icons.DeleteHS;
			this.removeLanguageToolStripMenuItem.Name = "removeLanguageToolStripMenuItem";
			resources.ApplyResources(this.removeLanguageToolStripMenuItem, "removeLanguageToolStripMenuItem");
			this.removeLanguageToolStripMenuItem.Click += new System.EventHandler(this.LanguageRemoved);
			// 
			// rightLayout
			// 
			this.rightLayout.AccessibleRole = AccessibleRole.Table;
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
			this.dataGridViewLocEntryData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			this.dataGridViewLocEntryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewLocEntryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewLocEntryData.Columns.AddRange(new DataGridViewColumn[] {
				this.Language,
				this.DisplayName});
			this.rightLayout.SetColumnSpan(this.dataGridViewLocEntryData, 2);
			this.dataGridViewLocEntryData.ContextMenuStrip = this.languageContextMenu;
			this.helpProvider.SetHelpString(this.dataGridViewLocEntryData, resources.GetString("dataGridViewLocEntryData.HelpString"));
			this.dataGridViewLocEntryData.Name = "dataGridViewLocEntryData";
			this.dataGridViewLocEntryData.RowHeadersVisible = false;
			this.helpProvider.SetShowHelp(this.dataGridViewLocEntryData, ((bool)(resources.GetObject("dataGridViewLocEntryData.ShowHelp"))));
			this.dataGridViewLocEntryData.CellEndEdit += new DataGridViewCellEventHandler(this.ValueEdited);
			this.dataGridViewLocEntryData.MouseDown += new MouseEventHandler(this.MouseTouchedAtLanguage);
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
			this.treeViewLocKeys.LabelEdit = false;
			this.treeViewLocKeys.Name = "treeViewLocKeys";
			this.helpProvider.SetShowHelp(this.treeViewLocKeys, ((bool)(resources.GetObject("treeViewLocKeys.ShowHelp"))));
			this.treeViewLocKeys.AfterSelect += new TreeViewEventHandler(this.KeySelected);
			this.treeViewLocKeys.AfterLabelEdit += new NodeLabelEditEventHandler(this.AfterEdit);
			this.treeViewLocKeys.KeyDown += new KeyEventHandler(this.KeyboardTouched);
			this.treeViewLocKeys.MouseDown += new MouseEventHandler(this.MouseTouchedAtKey);
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
			this.saveToolStripMenuItem.Image = global::PckStudio.Icons.saveHS;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.Save);
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new ToolStripItem[] {
				this.fileToolStripMenuItem,
				this.helpToolStripMenuItem});
			resources.ApplyResources(this.menuStrip, "menuStrip");
			this.menuStrip.Name = "menuStrip";
			// 
			// layout
			// 
			this.layout.BorderStyle = BorderStyle.Fixed3D;
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
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.Controls.Add(this.menuStrip);
			this.Name = "LOCEditor";
			this.FormClosing += new FormClosingEventHandler(this.Exiting);
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
		private ToolStripMenuItem editDisplayIDToolStripMenuItem;
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
