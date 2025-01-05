using System.Windows.Forms;

namespace PckStudio.Forms.Additional_Popups
{
    partial class ItemSelectionPopUp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSelectionPopUp));
			this.itemsLabel = new System.Windows.Forms.Label();
			this.okBtn = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.ComboBox = new System.Windows.Forms.ComboBox();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// itemsLabel
			// 
			resources.ApplyResources(this.itemsLabel, "itemsLabel");
			this.itemsLabel.Name = "itemsLabel";
			// 
			// okBtn
			// 
			resources.ApplyResources(this.okBtn, "okBtn");
			this.okBtn.Name = "okBtn";
			this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
			// 
			// cancelButton
			// 
			resources.ApplyResources(this.cancelButton, "cancelButton");
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// ComboBox
			// 
			resources.ApplyResources(this.ComboBox, "ComboBox");
			this.layout.SetColumnSpan(this.ComboBox, 3);
			this.ComboBox.FormattingEnabled = true;
			this.ComboBox.Name = "ComboBox";
			// 
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(this.itemsLabel, 0, 0);
			this.layout.Controls.Add(this.cancelButton, 2, 1);
			this.layout.Controls.Add(this.okBtn, 1, 1);
			this.layout.Controls.Add(this.ComboBox, 1, 0);
			this.layout.Name = "layout";
			// 
			// ItemSelectionPopUp
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "ItemSelectionPopUp";
			this.Load += new System.EventHandler(this.ItemSelectionPopUp_Load);
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
		private Button cancelButton;
        private ComboBox ComboBox;
        private Label itemsLabel;
        private Button okBtn;
		private TableLayoutPanel layout;
	}
}