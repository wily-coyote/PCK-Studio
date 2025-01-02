namespace PckStudio.Forms.Additional_Popups {
	partial class AddPropertyPrompt {
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
			System.Windows.Forms.Label entrylabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPropertyPrompt));
			System.Windows.Forms.Label valueLabel;
			this.keyTextBox = new System.Windows.Forms.TextBox();
			this.valueTextBox = new System.Windows.Forms.TextBox();
			this.saveButton = new System.Windows.Forms.Button();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			entrylabel = new System.Windows.Forms.Label();
			valueLabel = new System.Windows.Forms.Label();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// entrylabel
			// 
			resources.ApplyResources(entrylabel, "entrylabel");
			entrylabel.Name = "entrylabel";
			// 
			// valueLabel
			// 
			resources.ApplyResources(valueLabel, "valueLabel");
			valueLabel.Name = "valueLabel";
			// 
			// keyTextBox
			// 
			resources.ApplyResources(this.keyTextBox, "keyTextBox");
			this.layout.SetColumnSpan(this.keyTextBox, 2);
			this.keyTextBox.Name = "keyTextBox";
			// 
			// valueTextBox
			// 
			resources.ApplyResources(this.valueTextBox, "valueTextBox");
			this.layout.SetColumnSpan(this.valueTextBox, 2);
			this.valueTextBox.Name = "valueTextBox";
			// 
			// saveButton
			// 
			resources.ApplyResources(this.saveButton, "saveButton");
			this.saveButton.Name = "saveButton";
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(entrylabel, 0, 0);
			this.layout.Controls.Add(valueLabel, 0, 1);
			this.layout.Controls.Add(this.keyTextBox, 1, 0);
			this.layout.Controls.Add(this.valueTextBox, 1, 1);
			this.layout.Controls.Add(this.saveButton, 1, 2);
			this.layout.Name = "layout";
			// 
			// AddPropertyPrompt
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddPropertyPrompt";
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox keyTextBox;
		private System.Windows.Forms.TextBox valueTextBox;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.TableLayoutPanel layout;
	}
}