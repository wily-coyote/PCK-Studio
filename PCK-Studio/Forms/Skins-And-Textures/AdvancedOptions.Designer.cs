using System.Windows.Forms;

namespace PckStudio.Popups
{
    partial class AdvancedOptions
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
			System.Windows.Forms.Label label1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedOptions));
			System.Windows.Forms.Label label2;
			System.Windows.Forms.Label label3;
			this.propertyTreeview = new System.Windows.Forms.TreeView();
			this.fileTypeComboBox = new System.Windows.Forms.ComboBox();
			this.applyButton = new System.Windows.Forms.Button();
			this.propertyValueTextBox = new System.Windows.Forms.TextBox();
			this.propertyKeyTextBox = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			label1 = new System.Windows.Forms.Label();
			label2 = new System.Windows.Forms.Label();
			label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.Name = "label1";
			// 
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.Name = "label2";
			// 
			// label3
			// 
			resources.ApplyResources(label3, "label3");
			label3.Name = "label3";
			// 
			// propertyTreeview
			// 
			this.propertyTreeview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.tableLayoutPanel1.SetColumnSpan(this.propertyTreeview, 2);
			resources.ApplyResources(this.propertyTreeview, "propertyTreeview");
			this.propertyTreeview.Name = "propertyTreeview";
			this.propertyTreeview.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeMeta_AfterSelect);
			// 
			// fileTypeComboBox
			// 
			resources.ApplyResources(this.fileTypeComboBox, "fileTypeComboBox");
			this.fileTypeComboBox.FormattingEnabled = true;
			this.fileTypeComboBox.Items.AddRange(new object[] {
            resources.GetString("fileTypeComboBox.Items"),
            resources.GetString("fileTypeComboBox.Items1"),
            resources.GetString("fileTypeComboBox.Items2"),
            resources.GetString("fileTypeComboBox.Items3"),
            resources.GetString("fileTypeComboBox.Items4"),
            resources.GetString("fileTypeComboBox.Items5"),
            resources.GetString("fileTypeComboBox.Items6"),
            resources.GetString("fileTypeComboBox.Items7"),
            resources.GetString("fileTypeComboBox.Items8"),
            resources.GetString("fileTypeComboBox.Items9"),
            resources.GetString("fileTypeComboBox.Items10"),
            resources.GetString("fileTypeComboBox.Items11"),
            resources.GetString("fileTypeComboBox.Items12"),
            resources.GetString("fileTypeComboBox.Items13")});
			this.fileTypeComboBox.Name = "fileTypeComboBox";
			// 
			// applyButton
			// 
			resources.ApplyResources(this.applyButton, "applyButton");
			this.applyButton.Name = "applyButton";
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// propertyValueTextBox
			// 
			resources.ApplyResources(this.propertyValueTextBox, "propertyValueTextBox");
			this.propertyValueTextBox.Name = "propertyValueTextBox";
			// 
			// propertyKeyTextBox
			// 
			resources.ApplyResources(this.propertyKeyTextBox, "propertyKeyTextBox");
			this.propertyKeyTextBox.Name = "propertyKeyTextBox";
			// 
			// tableLayoutPanel1
			// 
			resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
			this.tableLayoutPanel1.Controls.Add(this.propertyTreeview, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.applyButton, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.propertyValueTextBox, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.fileTypeComboBox, 1, 3);
			this.tableLayoutPanel1.Controls.Add(label1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(label2, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.propertyKeyTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(label3, 0, 1);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			// 
			// AdvancedOptions
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AdvancedOptions";
			this.TopMost = true;
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private TreeView propertyTreeview;
        private ComboBox fileTypeComboBox;
        private Button applyButton;
        private TextBox propertyValueTextBox;
        private TextBox propertyKeyTextBox;
		private TableLayoutPanel tableLayoutPanel1;
	}
}