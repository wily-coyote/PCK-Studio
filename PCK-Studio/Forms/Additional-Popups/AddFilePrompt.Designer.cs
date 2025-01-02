using System.Windows.Forms;

namespace PckStudio.Popups {
	partial class AddFilePrompt {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFilePrompt));
			this.pathlabel = new System.Windows.Forms.Label();
			this.OKButton = new System.Windows.Forms.Button();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.typeLabel = new System.Windows.Forms.Label();
			this.FileTypeComboBox = new System.Windows.Forms.ComboBox();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// pathlabel
			// 
			resources.ApplyResources(this.pathlabel, "pathlabel");
			this.pathlabel.Name = "pathlabel";
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
			// typeLabel
			// 
			resources.ApplyResources(this.typeLabel, "typeLabel");
			this.typeLabel.Name = "typeLabel";
			// 
			// FileTypeComboBox
			// 
			resources.ApplyResources(this.FileTypeComboBox, "FileTypeComboBox");
			this.layout.SetColumnSpan(this.FileTypeComboBox, 2);
			this.FileTypeComboBox.FormattingEnabled = true;
			this.FileTypeComboBox.Items.AddRange(new object[] {
			resources.GetString("FileTypeComboBox.Items"),
			resources.GetString("FileTypeComboBox.Items1"),
			resources.GetString("FileTypeComboBox.Items2"),
			resources.GetString("FileTypeComboBox.Items3"),
			resources.GetString("FileTypeComboBox.Items4"),
			resources.GetString("FileTypeComboBox.Items5"),
			resources.GetString("FileTypeComboBox.Items6"),
			resources.GetString("FileTypeComboBox.Items7"),
			resources.GetString("FileTypeComboBox.Items8"),
			resources.GetString("FileTypeComboBox.Items9"),
			resources.GetString("FileTypeComboBox.Items10"),
			resources.GetString("FileTypeComboBox.Items11"),
			resources.GetString("FileTypeComboBox.Items12"),
			resources.GetString("FileTypeComboBox.Items13")});
			this.FileTypeComboBox.Name = "FileTypeComboBox";
			// 
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(this.pathlabel, 0, 0);
			this.layout.Controls.Add(this.typeLabel, 0, 1);
			this.layout.Controls.Add(this.FileTypeComboBox, 1, 1);
			this.layout.Controls.Add(this.InputTextBox, 1, 0);
			this.layout.Controls.Add(this.OKButton, 1, 2);
			this.layout.Name = "layout";
			// 
			// AddFilePrompt
			// 
			this.AcceptButton = this.OKButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AddFilePrompt";
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		public System.Windows.Forms.Button OKButton;
		public System.Windows.Forms.Label pathlabel;
		private TextBox InputTextBox;
		public System.Windows.Forms.Label typeLabel;
		private ComboBox FileTypeComboBox;
		private TableLayoutPanel layout;
	}
}