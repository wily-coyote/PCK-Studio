using System.Windows.Forms;

namespace PckStudio.Forms.Additional_Popups {
	partial class InProgressPrompt {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InProgressPrompt));
			this.metroLabel1 = new Label();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.BorderStyle = BorderStyle.FixedSingle;
			this.metroLabel1.Dock = DockStyle.Fill;
			this.metroLabel1.Location = new System.Drawing.Point(0, 0);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(396, 59);
			this.metroLabel1.TabIndex = 0;
			this.metroLabel1.Text = "Please wait while PCK Studio processes the request.";
			this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InProgressPrompt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(396, 59);
			this.Controls.Add(this.metroLabel1);
			this.FormBorderStyle = FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "InProgressPrompt";
			this.ResumeLayout(false);

		}

		#endregion

		private Label metroLabel1;
	}
}