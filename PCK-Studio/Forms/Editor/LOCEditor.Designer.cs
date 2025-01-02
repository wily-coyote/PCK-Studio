namespace PckStudio.Forms.Editor
{
    partial class LOCEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOCEditor));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addDisplayIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDisplayIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GridContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewLocEntryData = new System.Windows.Forms.DataGridView();
            this.Language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxReplaceAll = new System.Windows.Forms.TextBox();
            this.treeViewLocKeys = new System.Windows.Forms.TreeView();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.buttonReplaceAll = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.GridContextMenu.SuspendLayout();
            this.layout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocEntryData)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDisplayIDToolStripMenuItem,
            this.deleteDisplayIDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // addDisplayIDToolStripMenuItem
            // 
            this.addDisplayIDToolStripMenuItem.Name = "addDisplayIDToolStripMenuItem";
            resources.ApplyResources(this.addDisplayIDToolStripMenuItem, "addDisplayIDToolStripMenuItem");
            this.addDisplayIDToolStripMenuItem.Click += new System.EventHandler(this.addDisplayIDToolStripMenuItem_Click);
            // 
            // deleteDisplayIDToolStripMenuItem
            // 
            this.deleteDisplayIDToolStripMenuItem.Name = "deleteDisplayIDToolStripMenuItem";
            resources.ApplyResources(this.deleteDisplayIDToolStripMenuItem, "deleteDisplayIDToolStripMenuItem");
            this.deleteDisplayIDToolStripMenuItem.Click += new System.EventHandler(this.deleteDisplayIDToolStripMenuItem_Click);
            // 
            // GridContextMenu
            // 
            this.GridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addLanguageToolStripMenuItem,
            this.removeLanguageToolStripMenuItem});
            this.GridContextMenu.Name = "GridContextMenu";
            resources.ApplyResources(this.GridContextMenu, "GridContextMenu");
            // 
            // addLanguageToolStripMenuItem
            // 
            this.addLanguageToolStripMenuItem.Name = "addLanguageToolStripMenuItem";
            resources.ApplyResources(this.addLanguageToolStripMenuItem, "addLanguageToolStripMenuItem");
            this.addLanguageToolStripMenuItem.Click += new System.EventHandler(this.addLanguageToolStripMenuItem_Click);
            // 
            // removeLanguageToolStripMenuItem
            // 
            this.removeLanguageToolStripMenuItem.Name = "removeLanguageToolStripMenuItem";
            resources.ApplyResources(this.removeLanguageToolStripMenuItem, "removeLanguageToolStripMenuItem");
            // 
            // layout
            // 
            this.layout.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
            resources.ApplyResources(this.layout, "layout");
            this.layout.Controls.Add(this.buttonReplaceAll, 2, 0);
            this.layout.Controls.Add(this.dataGridViewLocEntryData, 1, 1);
            this.layout.Controls.Add(this.textBoxReplaceAll, 1, 0);
            this.layout.Controls.Add(this.treeViewLocKeys, 0, 0);
            this.layout.Name = "layout";
            // 
            // dataGridViewLocEntryData
            // 
            this.dataGridViewLocEntryData.AllowUserToAddRows = false;
            this.dataGridViewLocEntryData.AllowUserToDeleteRows = false;
            this.dataGridViewLocEntryData.AllowUserToResizeColumns = false;
            resources.ApplyResources(this.dataGridViewLocEntryData, "dataGridViewLocEntryData");
            this.dataGridViewLocEntryData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewLocEntryData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewLocEntryData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLocEntryData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Language,
            this.DisplayName});
            this.layout.SetColumnSpan(this.dataGridViewLocEntryData, 2);
            this.dataGridViewLocEntryData.ContextMenuStrip = this.GridContextMenu;
            this.dataGridViewLocEntryData.Name = "dataGridViewLocEntryData";
            this.dataGridViewLocEntryData.RowHeadersVisible = false;
            this.dataGridViewLocEntryData.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
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
            this.textBoxReplaceAll.Name = "textBoxReplaceAll";
            // 
            // treeViewLocKeys
            // 
            resources.ApplyResources(this.treeViewLocKeys, "treeViewLocKeys");
            this.treeViewLocKeys.ContextMenuStrip = this.contextMenuStrip1;
            this.treeViewLocKeys.LabelEdit = true;
            this.treeViewLocKeys.Name = "treeViewLocKeys";
            this.layout.SetRowSpan(this.treeViewLocKeys, 2);
            this.treeViewLocKeys.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewLocKeys_AfterSelect);
            this.treeViewLocKeys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.treeView1_KeyDown);
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
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // buttonReplaceAll
            // 
            resources.ApplyResources(this.buttonReplaceAll, "buttonReplaceAll");
            this.buttonReplaceAll.Name = "buttonReplaceAll";
            this.buttonReplaceAll.Click += new System.EventHandler(this.buttonReplaceAll_Click);
            // 
            // LOCEditor
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layout);
            this.Controls.Add(this.menuStrip);
            this.Name = "LOCEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LOCEditor_FormClosing);
            this.Load += new System.EventHandler(this.LOCEditor_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.GridContextMenu.ResumeLayout(false);
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocEntryData)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewLocKeys;
        private System.Windows.Forms.DataGridView dataGridViewLocEntryData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addDisplayIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDisplayIDToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxReplaceAll;
        private System.Windows.Forms.TableLayoutPanel layout;
        private MetroFramework.Controls.MetroContextMenu GridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addLanguageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeLanguageToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Language;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.Button buttonReplaceAll;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}