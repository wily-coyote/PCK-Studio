
namespace PckStudio.Forms.Additional_Popups.Animation {
	partial class SetBulkSpeed {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetBulkSpeed));
			this.saveButton = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.cancelButton = new System.Windows.Forms.Button();
			this.TimeUpDown = new System.Windows.Forms.NumericUpDown();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.TimeUpDown)).BeginInit();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.saveButton.Location = new System.Drawing.Point(115, 36);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(50, 23);
			this.saveButton.TabIndex = 7;
			this.saveButton.Text = "Save";
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// label
			// 
			this.label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label.AutoSize = true;
			this.layout.SetColumnSpan(this.label, 2);
			this.label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label.Location = new System.Drawing.Point(3, 10);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(106, 13);
			this.label.TabIndex = 10;
			this.label.Text = "Ticks for each frame";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cancelButton
			// 
			this.cancelButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cancelButton.Location = new System.Drawing.Point(59, 36);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(50, 23);
			this.cancelButton.TabIndex = 13;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// TimeUpDown
			// 
			this.TimeUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.layout.SetColumnSpan(this.TimeUpDown, 2);
			this.TimeUpDown.Location = new System.Drawing.Point(115, 6);
			this.TimeUpDown.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.TimeUpDown.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.TimeUpDown.Name = "TimeUpDown";
			this.TimeUpDown.Size = new System.Drawing.Size(106, 20);
			this.TimeUpDown.TabIndex = 15;
			this.TimeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TimeUpDown.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// layout
			// 
			this.layout.ColumnCount = 4;
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.layout.Controls.Add(this.TimeUpDown, 2, 0);
			this.layout.Controls.Add(this.label, 0, 0);
			this.layout.Controls.Add(this.saveButton, 2, 1);
			this.layout.Controls.Add(this.cancelButton, 1, 1);
			this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layout.Location = new System.Drawing.Point(0, 0);
			this.layout.Name = "layout";
			this.layout.RowCount = 2;
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.Size = new System.Drawing.Size(224, 62);
			this.layout.TabIndex = 16;
			// 
			// SetBulkSpeed
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 62);
			this.Controls.Add(this.layout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(240, 96);
			this.Name = "SetBulkSpeed";
			this.Text = "Set speed";
			((System.ComponentModel.ISupportInitialize)(this.TimeUpDown)).EndInit();
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.NumericUpDown TimeUpDown;
		private System.Windows.Forms.TableLayoutPanel layout;
	}
}