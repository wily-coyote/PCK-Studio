using System.Windows.Forms;

namespace PckStudio.Forms.Additional_Popups.Grf {
	partial class AddParameter {
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
			Label nameLabel;
			Label valueLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddParameter));
			this.NameTextBox = new TextBox();
			this.ValueTextBox = new TextBox();
			this.CancelBtn = new Button();
			this.ConfirmBtn = new Button();
			this.tableLayoutPanel1 = new TableLayoutPanel();
			nameLabel = new Label();
			valueLabel = new Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(3, 9);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(50, 13);
			nameLabel.TabIndex = 4;
			nameLabel.Text = "Name";
			nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// valueLabel
			// 
			valueLabel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			valueLabel.AutoSize = true;
			valueLabel.Location = new System.Drawing.Point(3, 41);
			valueLabel.Name = "valueLabel";
			valueLabel.Size = new System.Drawing.Size(50, 13);
			valueLabel.TabIndex = 5;
			valueLabel.Text = "Value";
			valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.NameTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			this.NameTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
			this.tableLayoutPanel1.SetColumnSpan(this.NameTextBox, 3);
			this.NameTextBox.Location = new System.Drawing.Point(59, 6);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(162, 20);
			this.NameTextBox.TabIndex = 0;
			// 
			// ValueTextBox
			// 
			this.ValueTextBox.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.SetColumnSpan(this.ValueTextBox, 3);
			this.ValueTextBox.Location = new System.Drawing.Point(59, 38);
			this.ValueTextBox.Name = "ValueTextBox";
			this.ValueTextBox.Size = new System.Drawing.Size(162, 20);
			this.ValueTextBox.TabIndex = 1;
			// 
			// CancelBtn
			// 
			this.CancelBtn.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBtn.DialogResult = DialogResult.Cancel;
			this.CancelBtn.Location = new System.Drawing.Point(59, 67);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(50, 23);
			this.CancelBtn.TabIndex = 2;
			this.CancelBtn.Text = "Cancel";
			// 
			// ConfirmBtn
			// 
			this.ConfirmBtn.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ConfirmBtn.Location = new System.Drawing.Point(115, 67);
			this.ConfirmBtn.Name = "ConfirmBtn";
			this.ConfirmBtn.Size = new System.Drawing.Size(50, 23);
			this.ConfirmBtn.TabIndex = 3;
			this.ConfirmBtn.Text = "Confirm";
			this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmButton_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(nameLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.NameTextBox, 1, 0);
			this.tableLayoutPanel1.Controls.Add(valueLabel, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.ConfirmBtn, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.ValueTextBox, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.CancelBtn, 1, 2);
			this.tableLayoutPanel1.Dock = DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(224, 94);
			this.tableLayoutPanel1.TabIndex = 6;
			// 
			// AddParameter
			// 
			this.AcceptButton = this.ConfirmBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 94);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(240, 128);
			this.Name = "AddParameter";
			this.Text = "Add parameter";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private TextBox ValueTextBox;
		private Button CancelBtn;
		private Button ConfirmBtn;
		private TextBox NameTextBox;
		private TableLayoutPanel tableLayoutPanel1;
	}
}