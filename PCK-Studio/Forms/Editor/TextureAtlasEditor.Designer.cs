using System.Windows.Forms;

namespace PckStudio.Forms.Editor
{
    partial class TextureAtlasEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextureAtlasEditor));
            this.internalTileNameLabel = new Label();
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.saveToolStripMenuItem = new ToolStripMenuItem();
            this.viewToolStripMenuItem = new ToolStripMenuItem();
            this.applyColorMaskToolStripMenuItem = new ToolStripMenuItem();
            this.playAnimationsToolStripMenuItem = new ToolStripMenuItem();
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.originalPictureBox = new PckStudio.ToolboxItems.InterpolationPictureBox();
            this.selectTilePictureBox = new PckStudio.ToolboxItems.AnimationPictureBox();
            this.replaceButton = new Button();
            this.tileNameLabel = new Label();
            this.setColorButton = new Button();
            this.animationButton = new Button();
            this.clearColorButton = new Button();
            this.extractButton = new Button();
            this.colorSlider = new TrackBar();
            this.colorSliderLabel = new Label();
            this.variantComboBox = new ComboBox();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // internalTileNameLabel
            // 
            this.internalTileNameLabel.Anchor = ((AnchorStyles)(((AnchorStyles.Top | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.internalTileNameLabel, 2);
            this.internalTileNameLabel.Location = new System.Drawing.Point(3, 281);
            this.internalTileNameLabel.Name = "internalTileNameLabel";
            this.internalTileNameLabel.Size = new System.Drawing.Size(208, 15);
            this.internalTileNameLabel.TabIndex = 18;
            this.internalTileNameLabel.Text = "InternalTileName";
            this.internalTileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.applyColorMaskToolStripMenuItem,
            this.playAnimationsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // applyColorMaskToolStripMenuItem
            // 
            this.applyColorMaskToolStripMenuItem.Checked = true;
            this.applyColorMaskToolStripMenuItem.CheckOnClick = true;
            this.applyColorMaskToolStripMenuItem.CheckState = CheckState.Checked;
            this.applyColorMaskToolStripMenuItem.Name = "applyColorMaskToolStripMenuItem";
            this.applyColorMaskToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.applyColorMaskToolStripMenuItem.Text = "Apply Color Mask";
            this.applyColorMaskToolStripMenuItem.CheckedChanged += new System.EventHandler(this.applyColorMaskToolStripMenuItem_CheckedChanged);
            // 
            // playAnimationsToolStripMenuItem
            // 
            this.playAnimationsToolStripMenuItem.Checked = true;
            this.playAnimationsToolStripMenuItem.CheckOnClick = true;
            this.playAnimationsToolStripMenuItem.CheckState = CheckState.Checked;
            this.playAnimationsToolStripMenuItem.Name = "playAnimationsToolStripMenuItem";
            this.playAnimationsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.playAnimationsToolStripMenuItem.Text = "Play Animations";
            this.playAnimationsToolStripMenuItem.CheckedChanged += new System.EventHandler(this.playAnimationsToolStripMenuItem_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.43842F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.09603F));
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.46555F));
            this.tableLayoutPanel1.Controls.Add(this.originalPictureBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.selectTilePictureBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.replaceButton, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tileNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.setColorButton, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.animationButton, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.clearColorButton, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.extractButton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.colorSlider, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.colorSliderLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.variantComboBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.internalTileNameLabel, 0, 2);
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 42.82212F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.938088F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.943623F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.943623F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.943623F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.352765F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.350623F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.352765F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.352765F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(590, 565);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // originalPictureBox
            // 
            this.originalPictureBox.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.originalPictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.originalPictureBox.Location = new System.Drawing.Point(217, 3);
            this.originalPictureBox.Name = "originalPictureBox";
            this.tableLayoutPanel1.SetRowSpan(this.originalPictureBox, 9);
            this.originalPictureBox.Size = new System.Drawing.Size(370, 535);
            this.originalPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.originalPictureBox.TabIndex = 4;
            this.originalPictureBox.TabStop = false;
            this.originalPictureBox.MouseClick += new MouseEventHandler(this.originalPictureBox_MouseClick);
            // 
            // selectTilePictureBox
            // 
            this.selectTilePictureBox.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.selectTilePictureBox.BlendColor = System.Drawing.Color.White;
            this.selectTilePictureBox.BlendMode = PckStudio.Extensions.BlendMode.Multiply;
            this.tableLayoutPanel1.SetColumnSpan(this.selectTilePictureBox, 2);
            this.selectTilePictureBox.Image = null;
            this.selectTilePictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.selectTilePictureBox.Location = new System.Drawing.Point(3, 3);
            this.selectTilePictureBox.Name = "selectTilePictureBox";
            this.selectTilePictureBox.Size = new System.Drawing.Size(208, 227);
            this.selectTilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.selectTilePictureBox.TabIndex = 0;
            this.selectTilePictureBox.TabStop = false;
            this.selectTilePictureBox.UseBlendColor = true;
            // 
            // replaceButton
            // 
            this.replaceButton.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.replaceButton.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.replaceButton, 2);
            this.replaceButton.Location = new System.Drawing.Point(3, 515);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(208, 23);
            this.replaceButton.TabIndex = 14;
            this.replaceButton.Text = "Replace Tile on Atlas";
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // tileNameLabel
            // 
            this.tileNameLabel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.tileNameLabel, 2);
            this.tileNameLabel.Location = new System.Drawing.Point(3, 233);
            this.tileNameLabel.Name = "tileNameLabel";
            this.tileNameLabel.Size = new System.Drawing.Size(208, 48);
            this.tileNameLabel.TabIndex = 19;
            this.tileNameLabel.Text = "TileName";
            this.tileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setColorButton
            // 
            this.setColorButton.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.setColorButton, 2);
            this.setColorButton.Location = new System.Drawing.Point(3, 434);
            this.setColorButton.Name = "setColorButton";
            this.setColorButton.Size = new System.Drawing.Size(208, 17);
            this.setColorButton.TabIndex = 25;
            this.setColorButton.Text = "Set Custom Colour";
            this.setColorButton.Click += new System.EventHandler(this.setColorButton_Click);
            // 
            // animationButton
            // 
            this.animationButton.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.animationButton.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.animationButton, 2);
            this.animationButton.Location = new System.Drawing.Point(3, 544);
            this.animationButton.Name = "animationButton";
            this.animationButton.Size = new System.Drawing.Size(208, 18);
            this.animationButton.TabIndex = 16;
            this.animationButton.Text = "Animation";
            this.animationButton.Click += new System.EventHandler(this.animationButton_Click);
            // 
            // clearColorButton
            // 
            this.clearColorButton.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.clearColorButton.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.clearColorButton, 2);
            this.clearColorButton.Location = new System.Drawing.Point(3, 457);
            this.clearColorButton.Name = "clearColorButton";
            this.clearColorButton.Size = new System.Drawing.Size(208, 23);
            this.clearColorButton.TabIndex = 24;
            this.clearColorButton.Text = "Clear Custom Colour";
            this.clearColorButton.Click += new System.EventHandler(this.clearColorButton_Click);
            // 
            // extractButton
            // 
            this.extractButton.Anchor = ((AnchorStyles)(((AnchorStyles.Bottom | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.extractButton.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.extractButton, 2);
            this.extractButton.Location = new System.Drawing.Point(3, 486);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(208, 23);
            this.extractButton.TabIndex = 27;
            this.extractButton.Text = "Extract Tile from Atlas";
            this.extractButton.Click += new System.EventHandler(this.extractTileToolStripMenuItem_Click);
            // 
            // colorSlider
            // 
            this.colorSlider.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            this.colorSlider.Location = new System.Drawing.Point(64, 380);
            this.colorSlider.Maximum = 255;
            this.colorSlider.Name = "colorSlider";
            this.colorSlider.Size = new System.Drawing.Size(147, 42);
            this.colorSlider.TabIndex = 26;
            this.colorSlider.Text = "metroTrackBar1";
            this.colorSlider.Value = 255;
            this.colorSlider.Visible = false;
            this.colorSlider.ValueChanged += new System.EventHandler(this.colorSlider_ValueChanged);
            // 
            // colorSliderLabel
            // 
            this.colorSliderLabel.Anchor = ((AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.colorSliderLabel.Location = new System.Drawing.Point(3, 377);
            this.colorSliderLabel.Name = "colorSliderLabel";
            this.colorSliderLabel.Size = new System.Drawing.Size(55, 48);
            this.colorSliderLabel.TabIndex = 19;
            this.colorSliderLabel.Text = "Color Value:";
            this.colorSliderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorSliderLabel.Visible = false;
            // 
            // variantComboBox
            // 
            this.variantComboBox.Anchor = ((AnchorStyles)((AnchorStyles.Left | AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.variantComboBox, 2);
            this.variantComboBox.Enabled = false;
            this.variantComboBox.FormattingEnabled = true;
            this.variantComboBox.ItemHeight = 23;
            this.variantComboBox.Location = new System.Drawing.Point(3, 338);
            this.variantComboBox.Name = "variantComboBox";
            this.variantComboBox.Size = new System.Drawing.Size(208, 29);
            this.variantComboBox.TabIndex = 17;
            this.variantComboBox.SelectedIndexChanged += new System.EventHandler(this.variantComboBox_SelectedIndexChanged);
            // 
            // TextureAtlasEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 669);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(630, 669);
            this.Name = "TextureAtlasEditor";
            this.Text = "Texture Atlas Editor";
            this.FormClosing += new FormClosingEventHandler(this.TextureAtlasEditor_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.originalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectTilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PckStudio.ToolboxItems.AnimationPictureBox selectTilePictureBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Button replaceButton;
        private PckStudio.ToolboxItems.InterpolationPictureBox originalPictureBox;
        private ToolStripMenuItem saveToolStripMenuItem;
        private Button animationButton;
        private ComboBox variantComboBox;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem applyColorMaskToolStripMenuItem;
        private ToolStripMenuItem playAnimationsToolStripMenuItem;
        private Label tileNameLabel;
        private Label internalTileNameLabel;
        private Button clearColorButton;
        private Button setColorButton;
        private TrackBar colorSlider;
        private Label colorSliderLabel;
        private Button extractButton;
    }
}