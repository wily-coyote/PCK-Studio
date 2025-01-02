using System.Windows.Forms;

namespace PckStudio.Forms.Additional_Popups.Loc
{
    partial class AddLanguage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddLanguage));
			this.LanguageComboBox = new ComboBox();
			this.AddBtn = new Button();
			this.layout = new TableLayoutPanel();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// LanguageComboBox
			// 
			this.LanguageComboBox.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.layout.SetColumnSpan(this.LanguageComboBox, 3);
			this.LanguageComboBox.FormattingEnabled = true;
			this.LanguageComboBox.ItemHeight = 13;
			this.LanguageComboBox.Location = new System.Drawing.Point(3, 6);
			this.LanguageComboBox.Name = "LanguageComboBox";
			this.LanguageComboBox.Size = new System.Drawing.Size(218, 21);
			this.LanguageComboBox.TabIndex = 0;
			// 
			// AddBtn
			// 
			this.AddBtn.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.AddBtn.Location = new System.Drawing.Point(77, 36);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(68, 23);
			this.AddBtn.TabIndex = 1;
			this.AddBtn.Text = "Add";
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			// 
			// layout
			// 
			this.layout.ColumnCount = 3;
			this.layout.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layout.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layout.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layout.Controls.Add(this.LanguageComboBox, 0, 0);
			this.layout.Controls.Add(this.AddBtn, 1, 1);
			this.layout.Dock = DockStyle.Fill;
			this.layout.Location = new System.Drawing.Point(0, 0);
			this.layout.Name = "layout";
			this.layout.RowCount = 2;
			this.layout.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layout.RowStyles.Add(new RowStyle());
			this.layout.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layout.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.layout.Size = new System.Drawing.Size(224, 62);
			this.layout.TabIndex = 2;
			// 
			// AddLanguage
			// 
			this.AcceptButton = this.AddBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 60);
			this.Controls.Add(this.layout);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(240, 96);
			this.Name = "AddLanguage";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Add Language";
			this.layout.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private ComboBox LanguageComboBox;
        private Button AddBtn;
		private TableLayoutPanel layout;
	}
}