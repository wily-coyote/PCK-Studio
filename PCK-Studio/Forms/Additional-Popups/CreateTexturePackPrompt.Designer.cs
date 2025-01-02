using System.Windows.Forms;

namespace PckStudio {
	partial class CreateTexturePackPrompt {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTexturePackPrompt));
			this.nameLabel = new System.Windows.Forms.Label();
			this.OKButton = new System.Windows.Forms.Button();
			this.InputTextBox = new System.Windows.Forms.TextBox();
			this.resolutionComboBox = new System.Windows.Forms.ComboBox();
			this.resolutionLabel = new System.Windows.Forms.Label();
			this.createSkinsPckCheckBox = new System.Windows.Forms.CheckBox();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			resources.ApplyResources(this.nameLabel, "nameLabel");
			this.nameLabel.Name = "nameLabel";
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
			// resolutionComboBox
			// 
			resources.ApplyResources(this.resolutionComboBox, "resolutionComboBox");
			this.layout.SetColumnSpan(this.resolutionComboBox, 2);
			this.resolutionComboBox.FormattingEnabled = true;
			this.resolutionComboBox.Items.AddRange(new object[] {
			resources.GetString("resolutionComboBox.Items"),
			resources.GetString("resolutionComboBox.Items1"),
			resources.GetString("resolutionComboBox.Items2"),
			resources.GetString("resolutionComboBox.Items3"),
			resources.GetString("resolutionComboBox.Items4"),
			resources.GetString("resolutionComboBox.Items5"),
			resources.GetString("resolutionComboBox.Items6"),
			resources.GetString("resolutionComboBox.Items7"),
			resources.GetString("resolutionComboBox.Items8")});
			this.resolutionComboBox.Name = "resolutionComboBox";
			// 
			// resolutionLabel
			// 
			resources.ApplyResources(this.resolutionLabel, "resolutionLabel");
			this.resolutionLabel.Name = "resolutionLabel";
			// 
			// createSkinsPckCheckBox
			// 
			resources.ApplyResources(this.createSkinsPckCheckBox, "createSkinsPckCheckBox");
			this.layout.SetColumnSpan(this.createSkinsPckCheckBox, 2);
			this.createSkinsPckCheckBox.Name = "createSkinsPckCheckBox";
			// 
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(this.nameLabel, 0, 0);
			this.layout.Controls.Add(this.OKButton, 2, 2);
			this.layout.Controls.Add(this.createSkinsPckCheckBox, 0, 2);
			this.layout.Controls.Add(this.InputTextBox, 1, 0);
			this.layout.Controls.Add(this.resolutionLabel, 0, 1);
			this.layout.Controls.Add(this.resolutionComboBox, 1, 1);
			this.layout.Name = "layout";
			// 
			// CreateTexturePackPrompt
			// 
			this.AcceptButton = this.OKButton;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "CreateTexturePackPrompt";
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		public Button OKButton;
		public Label nameLabel;
		private TextBox InputTextBox;
		private ComboBox resolutionComboBox;
		public Label resolutionLabel;
		private CheckBox createSkinsPckCheckBox;
		private TableLayoutPanel layout;
	}
}