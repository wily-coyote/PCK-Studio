using System.Windows.Forms;

namespace PckStudio.Forms {
	partial class AppSettingsForm {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingsForm));
			this.flowLayoutPanel = new FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.AutoScroll = true;
			this.flowLayoutPanel.Dock = DockStyle.Fill;
			this.flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
			this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Padding = new Padding(3);
			this.flowLayoutPanel.Size = new System.Drawing.Size(527, 270);
			this.flowLayoutPanel.TabIndex = 0;
			// 
			// AppSettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(527, 270);
			this.Controls.Add(this.flowLayoutPanel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AppSettingsForm";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Application Settings";
			this.FormClosing += new FormClosingEventHandler(this.AppBehaviorSettingsForm_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion
		private FlowLayoutPanel flowLayoutPanel;
	}
}