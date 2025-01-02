using System.Windows.Forms;

namespace PckStudio.Forms.Editor
{
	partial class BoxEditor
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
            System.Windows.Forms.Label parentLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label uvLabel;
            System.Windows.Forms.Label inflationLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BoxEditor));
            this.closeButton = new System.Windows.Forms.Button();
            this.parentComboBox = new System.Windows.Forms.ComboBox();
            this.PosXUpDown = new System.Windows.Forms.NumericUpDown();
            this.PosYUpDown = new System.Windows.Forms.NumericUpDown();
            this.PosZUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeZUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeYUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeXUpDown = new System.Windows.Forms.NumericUpDown();
            this.uvYUpDown = new System.Windows.Forms.NumericUpDown();
            this.uvXUpDown = new System.Windows.Forms.NumericUpDown();
            this.armorCheckBox = new System.Windows.Forms.CheckBox();
            this.mirrorCheckBox = new System.Windows.Forms.CheckBox();
            this.scaleUpDown = new System.Windows.Forms.NumericUpDown();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            parentLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            uvLabel = new System.Windows.Forms.Label();
            inflationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PosXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosZUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeZUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvYUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvXUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleUpDown)).BeginInit();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentLabel
            // 
            parentLabel.AutoSize = true;
            parentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            parentLabel.Location = new System.Drawing.Point(419, 0);
            parentLabel.Name = "parentLabel";
            parentLabel.Size = new System.Drawing.Size(38, 32);
            parentLabel.TabIndex = 2;
            parentLabel.Text = "Parent";
            parentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            positionLabel.Location = new System.Drawing.Point(3, 0);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(44, 32);
            positionLabel.TabIndex = 4;
            positionLabel.Text = "Position";
            positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            sizeLabel.Location = new System.Drawing.Point(3, 32);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(44, 32);
            sizeLabel.TabIndex = 22;
            sizeLabel.Text = "Size";
            sizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uvLabel
            // 
            uvLabel.AutoSize = true;
            uvLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            uvLabel.Location = new System.Drawing.Point(3, 64);
            uvLabel.Name = "uvLabel";
            uvLabel.Size = new System.Drawing.Size(44, 32);
            uvLabel.TabIndex = 26;
            uvLabel.Text = "UV";
            uvLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inflationLabel
            // 
            inflationLabel.AutoSize = true;
            inflationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            inflationLabel.Location = new System.Drawing.Point(3, 96);
            inflationLabel.Name = "inflationLabel";
            inflationLabel.Size = new System.Drawing.Size(44, 32);
            inflationLabel.TabIndex = 31;
            inflationLabel.Text = "Scale";
            inflationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.layout.SetColumnSpan(this.closeButton, 2);
            this.closeButton.Location = new System.Drawing.Point(175, 134);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(238, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Save";
            this.closeButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // parentComboBox
            // 
            this.parentComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.parentComboBox.FormattingEnabled = true;
            this.parentComboBox.ItemHeight = 13;
            this.parentComboBox.Items.AddRange(new object[] {
            "HEAD",
            "BODY",
            "ARM0",
            "ARM1",
            "LEG0",
            "LEG1",
            "HEADWEAR",
            "JACKET",
            "SLEEVE0",
            "SLEEVE1",
            "PANTS0",
            "PANTS1",
            "WAIST",
            "LEGGING0",
            "LEGGING1",
            "SOCK0",
            "SOCK1",
            "BOOT0",
            "BOOT1",
            "ARMARMOR1",
            "ARMARMOR0",
            "BODYARMOR",
            "BELT"});
            this.parentComboBox.Location = new System.Drawing.Point(463, 5);
            this.parentComboBox.Name = "parentComboBox";
            this.parentComboBox.Size = new System.Drawing.Size(118, 21);
            this.parentComboBox.TabIndex = 3;
            // 
            // PosXUpDown
            // 
            this.PosXUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PosXUpDown.DecimalPlaces = 3;
            this.PosXUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PosXUpDown.Location = new System.Drawing.Point(53, 6);
            this.PosXUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PosXUpDown.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.PosXUpDown.Name = "PosXUpDown";
            this.PosXUpDown.Size = new System.Drawing.Size(116, 20);
            this.PosXUpDown.TabIndex = 19;
            // 
            // PosYUpDown
            // 
            this.PosYUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PosYUpDown.DecimalPlaces = 3;
            this.PosYUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PosYUpDown.Location = new System.Drawing.Point(175, 6);
            this.PosYUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PosYUpDown.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.PosYUpDown.Name = "PosYUpDown";
            this.PosYUpDown.Size = new System.Drawing.Size(116, 20);
            this.PosYUpDown.TabIndex = 20;
            // 
            // PosZUpDown
            // 
            this.PosZUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PosZUpDown.DecimalPlaces = 3;
            this.PosZUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.PosZUpDown.Location = new System.Drawing.Point(297, 6);
            this.PosZUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.PosZUpDown.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.PosZUpDown.Name = "PosZUpDown";
            this.PosZUpDown.Size = new System.Drawing.Size(116, 20);
            this.PosZUpDown.TabIndex = 21;
            // 
            // SizeZUpDown
            // 
            this.SizeZUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeZUpDown.DecimalPlaces = 3;
            this.SizeZUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SizeZUpDown.Location = new System.Drawing.Point(297, 38);
            this.SizeZUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SizeZUpDown.Name = "SizeZUpDown";
            this.SizeZUpDown.Size = new System.Drawing.Size(116, 20);
            this.SizeZUpDown.TabIndex = 25;
            // 
            // SizeYUpDown
            // 
            this.SizeYUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeYUpDown.DecimalPlaces = 3;
            this.SizeYUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SizeYUpDown.Location = new System.Drawing.Point(175, 38);
            this.SizeYUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SizeYUpDown.Name = "SizeYUpDown";
            this.SizeYUpDown.Size = new System.Drawing.Size(116, 20);
            this.SizeYUpDown.TabIndex = 24;
            // 
            // SizeXUpDown
            // 
            this.SizeXUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeXUpDown.DecimalPlaces = 3;
            this.SizeXUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.SizeXUpDown.Location = new System.Drawing.Point(53, 38);
            this.SizeXUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.SizeXUpDown.Name = "SizeXUpDown";
            this.SizeXUpDown.Size = new System.Drawing.Size(116, 20);
            this.SizeXUpDown.TabIndex = 23;
            // 
            // uvYUpDown
            // 
            this.uvYUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uvYUpDown.DecimalPlaces = 3;
            this.uvYUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uvYUpDown.Location = new System.Drawing.Point(175, 70);
            this.uvYUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.uvYUpDown.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.uvYUpDown.Name = "uvYUpDown";
            this.uvYUpDown.Size = new System.Drawing.Size(116, 20);
            this.uvYUpDown.TabIndex = 28;
            // 
            // uvXUpDown
            // 
            this.uvXUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uvXUpDown.DecimalPlaces = 3;
            this.uvXUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.uvXUpDown.Location = new System.Drawing.Point(53, 70);
            this.uvXUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.uvXUpDown.Minimum = new decimal(new int[] {
            9999,
            0,
            0,
            -2147483648});
            this.uvXUpDown.Name = "uvXUpDown";
            this.uvXUpDown.Size = new System.Drawing.Size(116, 20);
            this.uvXUpDown.TabIndex = 27;
            // 
            // armorCheckBox
            // 
            this.armorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.armorCheckBox.AutoSize = true;
            this.layout.SetColumnSpan(this.armorCheckBox, 2);
            this.armorCheckBox.Location = new System.Drawing.Point(419, 39);
            this.armorCheckBox.Name = "armorCheckBox";
            this.armorCheckBox.Size = new System.Drawing.Size(162, 17);
            this.armorCheckBox.TabIndex = 29;
            this.armorCheckBox.Text = "Hide when wearing a helmet";
            // 
            // mirrorCheckBox
            // 
            this.mirrorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mirrorCheckBox.AutoSize = true;
            this.layout.SetColumnSpan(this.mirrorCheckBox, 2);
            this.mirrorCheckBox.Location = new System.Drawing.Point(419, 71);
            this.mirrorCheckBox.Name = "mirrorCheckBox";
            this.mirrorCheckBox.Size = new System.Drawing.Size(162, 17);
            this.mirrorCheckBox.TabIndex = 30;
            this.mirrorCheckBox.Text = "Mirror Texture";
            // 
            // scaleUpDown
            // 
            this.scaleUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.scaleUpDown.DecimalPlaces = 3;
            this.scaleUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleUpDown.Location = new System.Drawing.Point(53, 102);
            this.scaleUpDown.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.scaleUpDown.Name = "scaleUpDown";
            this.scaleUpDown.Size = new System.Drawing.Size(116, 20);
            this.scaleUpDown.TabIndex = 32;
            // 
            // layout
            // 
            this.layout.ColumnCount = 6;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.layout.Controls.Add(positionLabel, 0, 0);
            this.layout.Controls.Add(this.mirrorCheckBox, 4, 2);
            this.layout.Controls.Add(this.parentComboBox, 5, 0);
            this.layout.Controls.Add(this.armorCheckBox, 4, 1);
            this.layout.Controls.Add(this.SizeZUpDown, 3, 1);
            this.layout.Controls.Add(this.uvYUpDown, 2, 2);
            this.layout.Controls.Add(this.scaleUpDown, 1, 3);
            this.layout.Controls.Add(parentLabel, 4, 0);
            this.layout.Controls.Add(sizeLabel, 0, 1);
            this.layout.Controls.Add(this.SizeYUpDown, 2, 1);
            this.layout.Controls.Add(uvLabel, 0, 2);
            this.layout.Controls.Add(this.uvXUpDown, 1, 2);
            this.layout.Controls.Add(inflationLabel, 0, 3);
            this.layout.Controls.Add(this.PosYUpDown, 2, 0);
            this.layout.Controls.Add(this.PosZUpDown, 3, 0);
            this.layout.Controls.Add(this.SizeXUpDown, 1, 1);
            this.layout.Controls.Add(this.PosXUpDown, 1, 0);
            this.layout.Controls.Add(this.closeButton, 2, 4);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.RowCount = 5;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.layout.Size = new System.Drawing.Size(584, 164);
            this.layout.TabIndex = 33;
            // 
            // BoxEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 164);
            this.Controls.Add(this.layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 554);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "BoxEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BOX Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BoxEditor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PosXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PosZUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeZUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvYUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uvXUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleUpDown)).EndInit();
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private Button closeButton;
		private ComboBox parentComboBox;
		private NumericUpDown PosXUpDown;
		private NumericUpDown PosYUpDown;
		private NumericUpDown PosZUpDown;
		private NumericUpDown SizeZUpDown;
		private NumericUpDown SizeYUpDown;
		private NumericUpDown SizeXUpDown;
		private NumericUpDown uvYUpDown;
		private NumericUpDown uvXUpDown;
		private CheckBox armorCheckBox;
		private CheckBox mirrorCheckBox;
		private NumericUpDown scaleUpDown;
        private TableLayoutPanel layout;
    }
}