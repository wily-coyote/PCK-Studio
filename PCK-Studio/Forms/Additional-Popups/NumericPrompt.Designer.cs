using System.Windows.Forms;

namespace PckStudio
{
    partial class NumericPrompt
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NumericPrompt));
			this.TextLabel = new Label();
			this.OKButton = new Button();
			this.ContextLabel = new Label();
			this.ValueUpDown = new NumericUpDown();
			this.layout = new TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.ValueUpDown)).BeginInit();
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
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKBtn_Click);
			// 
			// ContextLabel
			// 
			this.layout.SetColumnSpan(this.ContextLabel, 3);
			resources.ApplyResources(this.ContextLabel, "ContextLabel");
			this.ContextLabel.Name = "ContextLabel";
			// 
			// ValueUpDown
			// 
			resources.ApplyResources(this.ValueUpDown, "ValueUpDown");
			this.layout.SetColumnSpan(this.ValueUpDown, 2);
			this.ValueUpDown.Name = "ValueUpDown";
			// 
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(this.TextLabel, 0, 1);
			this.layout.Controls.Add(this.ContextLabel, 0, 0);
			this.layout.Controls.Add(this.ValueUpDown, 1, 1);
			this.layout.Controls.Add(this.OKButton, 1, 2);
			this.layout.Name = "layout";
			// 
			// NumericPrompt
			// 
			this.AcceptButton = this.OKButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NumericPrompt";
			this.Load += new System.EventHandler(this.RenamePrompt_Load);
			((System.ComponentModel.ISupportInitialize)(this.ValueUpDown)).EndInit();
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        public Button OKButton;
        public Label TextLabel;
		public Label ContextLabel;
        private NumericUpDown ValueUpDown;
		private TableLayoutPanel layout;
	}
}