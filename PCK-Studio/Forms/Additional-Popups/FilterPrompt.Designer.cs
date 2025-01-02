using System.Windows.Forms;

namespace PckStudio.Forms.Additional_Popups.Animation {
	partial class FilterPrompt {
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
			System.Windows.Forms.Label filterLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterPrompt));
			this.acceptButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.filterTextBox = new System.Windows.Forms.TextBox();
			this.tabController = new System.Windows.Forms.TabControl();
			filterLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// filterLabel
			// 
			filterLabel.AutoSize = true;
			filterLabel.Location = new System.Drawing.Point(133, 19);
			filterLabel.Name = "filterLabel";
			filterLabel.Size = new System.Drawing.Size(35, 13);
			filterLabel.TabIndex = 16;
			filterLabel.Text = "Filter: ";
			// 
			// acceptButton
			// 
			this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.acceptButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.acceptButton.Location = new System.Drawing.Point(92, 196);
			this.acceptButton.Name = "acceptButton";
			this.acceptButton.Size = new System.Drawing.Size(75, 23);
			this.acceptButton.TabIndex = 7;
			this.acceptButton.Text = "Save";
			this.acceptButton.Click += new System.EventHandler(this.AcceptBtn_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cancelButton.Location = new System.Drawing.Point(172, 196);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 13;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// filterTextBox
			// 
			this.filterTextBox.Location = new System.Drawing.Point(173, 18);
			this.filterTextBox.Name = "filterTextBox";
			this.filterTextBox.Size = new System.Drawing.Size(156, 20);
			this.filterTextBox.TabIndex = 17;
			this.filterTextBox.TextChanged += new System.EventHandler(this.filter_TextChanged);
			// 
			// tabController
			// 
			this.tabController.Location = new System.Drawing.Point(6, 8);
			this.tabController.Name = "tabController";
			this.tabController.SelectedIndex = 0;
			this.tabController.Size = new System.Drawing.Size(326, 184);
			this.tabController.TabIndex = 18;
			// 
			// FilterPrompt
			// 
			this.AcceptButton = this.acceptButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(338, 228);
			this.ControlBox = false;
			this.Controls.Add(this.filterTextBox);
			this.Controls.Add(filterLabel);
			this.Controls.Add(this.tabController);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.acceptButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FilterPrompt";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void MetroTextBox1_TextChanged(object sender, System.EventArgs e) {
			throw new System.NotImplementedException();
		}

		#endregion
		private System.Windows.Forms.Button acceptButton;
		private System.Windows.Forms.Button cancelButton;
		private TextBox filterTextBox;
		private TabControl tabController;
	}
}