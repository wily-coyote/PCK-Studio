using System.Windows.Forms;

namespace PckStudio
{
    partial class TextPrompt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextPrompt));
			this.TextLabel = new System.Windows.Forms.Label();
			this.OKButton = new System.Windows.Forms.Button();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.contextLabel = new System.Windows.Forms.Label();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// TextLabel
			// 
			resources.ApplyResources(this.TextLabel, "TextLabel");
			this.TextLabel.Name = "TextLabel";
			// 
			// OKButton
			// 
			resources.ApplyResources(this.OKButton, "OKButton");
			this.OKButton.Name = "OKButton";
			this.OKButton.Click += new System.EventHandler(this.OKBtn_Click);
			// 
			// InputTextBox
			// 
			resources.ApplyResources(this.InputTextBox, "InputTextBox");
			this.layout.SetColumnSpan(this.InputTextBox, 2);
			this.InputTextBox.Name = "InputTextBox";
			// 
			// contextLabel
			// 
			this.layout.SetColumnSpan(this.contextLabel, 3);
			resources.ApplyResources(this.contextLabel, "contextLabel");
			this.contextLabel.Name = "contextLabel";
			// 
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(this.OKButton, 1, 2);
			this.layout.Controls.Add(this.contextLabel, 0, 0);
			this.layout.Controls.Add(this.TextLabel, 0, 1);
			this.layout.Controls.Add(this.InputTextBox, 1, 1);
			this.layout.Name = "layout";
			// 
			// TextPrompt
			// 
			this.AcceptButton = this.OKButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TextPrompt";
			this.Load += new System.EventHandler(this.RenamePrompt_Load);
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private TextBox InputTextBox;
		public Label contextLabel;
        private Button OKButton;
        private Label TextLabel;
		private TableLayoutPanel layout;
	}
}