using System.Windows.Forms;

namespace PckStudio.Forms.Editor
{
	partial class AnimationEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimationEditor));
            this.frameTreeView = new TreeView();
            this.contextMenuStrip1 = new ContextMenuStrip(this.components);
            this.addFrameToolStripMenuItem = new ToolStripMenuItem();
            this.removeFrameToolStripMenuItem = new ToolStripMenuItem();
            this.TextureIcons = new ImageList(this.components);
            this.menuStrip = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new ToolStripMenuItem();
            this.toolStripSeparator1 = new ToolStripSeparator();
            this.importToolStripMenuItem = new ToolStripMenuItem();
            this.importAnimationTextureToolStripMenuItem = new ToolStripMenuItem();
            this.importJavaAnimationToolStripMenuItem = new ToolStripMenuItem();
            this.importGifToolStripMenuItem = new ToolStripMenuItem();
            this.exportAsToolStripMenuItem = new ToolStripMenuItem();
            this.exportJavaAnimationToolStripMenuItem = new ToolStripMenuItem();
            this.gifToolStripMenuItem = new ToolStripMenuItem();
            this.editToolStripMenuItem = new ToolStripMenuItem();
            this.bulkAnimationSpeedToolStripMenuItem = new ToolStripMenuItem();
            this.helpToolStripMenuItem = new ToolStripMenuItem();
            this.frameTimeandTicksToolStripMenuItem = new ToolStripMenuItem();
            this.howToInterpolation = new ToolStripMenuItem();
            this.editorControlsToolStripMenuItem = new ToolStripMenuItem();
            this.setBulkSpedToolStripMenuItem = new ToolStripMenuItem();
            this.javaAnimationSupportToolStripMenuItem = new ToolStripMenuItem();
            this.InterpolationCheckbox = new CheckBox();
            this.AnimationStartStopBtn = new Button();
            this.tileLabel = new Label();
            this.animationPictureBox = new PckStudio.ToolboxItems.AnimationPictureBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // frameTreeView
            // 
            this.frameTreeView.AllowDrop = true;
            this.frameTreeView.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | AnchorStyles.Left)));
            this.frameTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.frameTreeView.ContextMenuStrip = this.contextMenuStrip1;
            this.frameTreeView.ForeColor = System.Drawing.Color.White;
            this.frameTreeView.ImageIndex = 0;
            this.frameTreeView.ImageList = this.TextureIcons;
            this.frameTreeView.Location = new System.Drawing.Point(20, 88);
            this.frameTreeView.Margin = new Padding(0);
            this.frameTreeView.Name = "frameTreeView";
            this.frameTreeView.SelectedImageIndex = 0;
            this.frameTreeView.ShowLines = false;
            this.frameTreeView.ShowRootLines = false;
            this.frameTreeView.Size = new System.Drawing.Size(134, 253);
            this.frameTreeView.TabIndex = 15;
            this.frameTreeView.ItemDrag += new ItemDragEventHandler(this.frameTreeView_ItemDrag);
            this.frameTreeView.AfterSelect += new TreeViewEventHandler(this.frameTreeView_AfterSelect);
            this.frameTreeView.NodeMouseDoubleClick += new TreeNodeMouseClickEventHandler(this.treeView1_doubleClick);
            this.frameTreeView.DragDrop += new DragEventHandler(this.frameTreeView_DragDrop);
            this.frameTreeView.DragEnter += new DragEventHandler(this.frameTreeView_DragEnter);
            this.frameTreeView.DragOver += new DragEventHandler(this.frameTreeView_DragOver);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] {
            this.addFrameToolStripMenuItem,
            this.removeFrameToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            // 
            // addFrameToolStripMenuItem
            // 
            this.addFrameToolStripMenuItem.Name = "addFrameToolStripMenuItem";
            this.addFrameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.addFrameToolStripMenuItem.Text = "Add Frame";
            this.addFrameToolStripMenuItem.Click += new System.EventHandler(this.addFrameToolStripMenuItem_Click);
            // 
            // removeFrameToolStripMenuItem
            // 
            this.removeFrameToolStripMenuItem.Name = "removeFrameToolStripMenuItem";
            this.removeFrameToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.removeFrameToolStripMenuItem.Text = "Remove Frame";
            this.removeFrameToolStripMenuItem.Click += new System.EventHandler(this.removeFrameToolStripMenuItem_Click);
            // 
            // TextureIcons
            // 
            this.TextureIcons.ColorDepth = ColorDepth.Depth32Bit;
            this.TextureIcons.ImageSize = new System.Drawing.Size(32, 32);
            this.TextureIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.Dock = DockStyle.None;
            this.menuStrip.Items.AddRange(new ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(20, 60);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(134, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.saveToolStripMenuItem1,
            this.toolStripSeparator1,
            this.importToolStripMenuItem,
            this.exportAsToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem1.Image")));
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.importAnimationTextureToolStripMenuItem,
            this.importJavaAnimationToolStripMenuItem,
            this.importGifToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // importAnimationTextureToolStripMenuItem
            // 
            this.importAnimationTextureToolStripMenuItem.Name = "importAnimationTextureToolStripMenuItem";
            this.importAnimationTextureToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.importAnimationTextureToolStripMenuItem.Text = "Animation Texture";
            this.importAnimationTextureToolStripMenuItem.Click += new System.EventHandler(this.importAnimationTextureToolStripMenuItem_Click);
            // 
            // importJavaAnimationToolStripMenuItem
            // 
            this.importJavaAnimationToolStripMenuItem.Name = "importJavaAnimationToolStripMenuItem";
            this.importJavaAnimationToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.importJavaAnimationToolStripMenuItem.Text = "Java Animation";
            this.importJavaAnimationToolStripMenuItem.Click += new System.EventHandler(this.importJavaAnimationToolStripMenuItem_Click);
            // 
            // importGifToolStripMenuItem
            // 
            this.importGifToolStripMenuItem.Name = "importGifToolStripMenuItem";
            this.importGifToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.importGifToolStripMenuItem.Text = "Gif";
            this.importGifToolStripMenuItem.Click += new System.EventHandler(this.importGifToolStripMenuItem_Click);
            // 
            // exportAsToolStripMenuItem
            // 
            this.exportAsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.exportJavaAnimationToolStripMenuItem,
            this.gifToolStripMenuItem});
            this.exportAsToolStripMenuItem.Name = "exportAsToolStripMenuItem";
            this.exportAsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exportAsToolStripMenuItem.Text = "Export as";
            // 
            // exportJavaAnimationToolStripMenuItem
            // 
            this.exportJavaAnimationToolStripMenuItem.Name = "exportJavaAnimationToolStripMenuItem";
            this.exportJavaAnimationToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exportJavaAnimationToolStripMenuItem.Text = "Java Animation";
            this.exportJavaAnimationToolStripMenuItem.Click += new System.EventHandler(this.exportJavaAnimationToolStripMenuItem_Click);
            // 
            // gifToolStripMenuItem
            // 
            this.gifToolStripMenuItem.Name = "gifToolStripMenuItem";
            this.gifToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.gifToolStripMenuItem.Text = "Gif";
            this.gifToolStripMenuItem.Click += new System.EventHandler(this.gifToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.bulkAnimationSpeedToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.editToolStripMenuItem.Text = "Tools";
            // 
            // bulkAnimationSpeedToolStripMenuItem
            // 
            this.bulkAnimationSpeedToolStripMenuItem.Name = "bulkAnimationSpeedToolStripMenuItem";
            this.bulkAnimationSpeedToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.bulkAnimationSpeedToolStripMenuItem.Text = "Set Bulk Animation Speed";
            this.bulkAnimationSpeedToolStripMenuItem.Click += new System.EventHandler(this.bulkAnimationSpeedToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.frameTimeandTicksToolStripMenuItem,
            this.howToInterpolation,
            this.editorControlsToolStripMenuItem,
            this.setBulkSpedToolStripMenuItem,
            this.javaAnimationSupportToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // frameTimeandTicksToolStripMenuItem
            // 
            this.frameTimeandTicksToolStripMenuItem.Name = "frameTimeandTicksToolStripMenuItem";
            this.frameTimeandTicksToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.frameTimeandTicksToolStripMenuItem.Text = "Frame Time (and Ticks)";
            this.frameTimeandTicksToolStripMenuItem.Click += new System.EventHandler(this.frameTimeandTicksToolStripMenuItem_Click);
            // 
            // howToInterpolation
            // 
            this.howToInterpolation.Name = "howToInterpolation";
            this.howToInterpolation.Size = new System.Drawing.Size(200, 22);
            this.howToInterpolation.Text = "Interpolation";
            this.howToInterpolation.Click += new System.EventHandler(this.howToInterpolation_Click);
            // 
            // editorControlsToolStripMenuItem
            // 
            this.editorControlsToolStripMenuItem.Name = "editorControlsToolStripMenuItem";
            this.editorControlsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.editorControlsToolStripMenuItem.Text = "Editor Controls";
            this.editorControlsToolStripMenuItem.Click += new System.EventHandler(this.editorControlsToolStripMenuItem_Click);
            // 
            // setBulkSpedToolStripMenuItem
            // 
            this.setBulkSpedToolStripMenuItem.Name = "setBulkSpedToolStripMenuItem";
            this.setBulkSpedToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.setBulkSpedToolStripMenuItem.Text = "Set Bulk Speed";
            this.setBulkSpedToolStripMenuItem.Click += new System.EventHandler(this.setBulkSpeedToolStripMenuItem_Click);
            // 
            // javaAnimationSupportToolStripMenuItem
            // 
            this.javaAnimationSupportToolStripMenuItem.Name = "javaAnimationSupportToolStripMenuItem";
            this.javaAnimationSupportToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.javaAnimationSupportToolStripMenuItem.Text = "Java Animation Support";
            this.javaAnimationSupportToolStripMenuItem.Click += new System.EventHandler(this.javaAnimationSupportToolStripMenuItem_Click);
            // 
            // InterpolationCheckbox
            // 
            this.InterpolationCheckbox.AutoSize = true;
            this.InterpolationCheckbox.Location = new System.Drawing.Point(161, 63);
            this.InterpolationCheckbox.Name = "InterpolationCheckbox";
            this.InterpolationCheckbox.Size = new System.Drawing.Size(129, 15);
            this.InterpolationCheckbox.TabIndex = 17;
            this.InterpolationCheckbox.Text = "Enable Interpolation";
            this.InterpolationCheckbox.CheckedChanged += new System.EventHandler(this.InterpolationCheckbox_CheckedChanged);
            // 
            // AnimationStartStopBtn
            // 
            this.AnimationStartStopBtn.Anchor = ((AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.AnimationStartStopBtn.Location = new System.Drawing.Point(157, 317);
            this.AnimationStartStopBtn.Name = "AnimationStartStopBtn";
            this.AnimationStartStopBtn.Size = new System.Drawing.Size(232, 24);
            this.AnimationStartStopBtn.TabIndex = 18;
            this.AnimationStartStopBtn.Text = "Play Animation";
            this.AnimationStartStopBtn.Click += new System.EventHandler(this.AnimationStartStopBtn_Click);
            // 
            // tileLabel
            // 
            this.tileLabel.Anchor = ((AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tileLabel.AutoSize = true;
            this.tileLabel.Location = new System.Drawing.Point(20, 341);
            this.tileLabel.MinimumSize = new System.Drawing.Size(170, 19);
            this.tileLabel.Name = "tileLabel";
            this.tileLabel.Size = new System.Drawing.Size(57, 19);
            this.tileLabel.TabIndex = 20;
            this.tileLabel.Text = "tileLabel";
            // 
            // animationPictureBox
            // 
            this.animationPictureBox.Anchor = ((AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | AnchorStyles.Left) 
            | AnchorStyles.Right)));
            this.animationPictureBox.BlendColor = System.Drawing.Color.White;
            this.animationPictureBox.BlendMode = PckStudio.Extensions.BlendMode.Multiply;
            this.animationPictureBox.Image = null;
            this.animationPictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
            this.animationPictureBox.Location = new System.Drawing.Point(157, 88);
            this.animationPictureBox.Name = "animationPictureBox";
            this.animationPictureBox.Size = new System.Drawing.Size(235, 223);
            this.animationPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            this.animationPictureBox.TabIndex = 16;
            this.animationPictureBox.TabStop = false;
            // 
            // AnimationEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 362);
            this.Controls.Add(this.InterpolationCheckbox);
            this.Controls.Add(this.AnimationStartStopBtn);
            this.Controls.Add(this.tileLabel);
            this.Controls.Add(this.animationPictureBox);
            this.Controls.Add(this.frameTreeView);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(412, 362);
            this.Name = "AnimationEditor";
            this.Text = "Animation Editor";
            this.FormClosing += new FormClosingEventHandler(this.AnimationEditor_FormClosing);
            this.Load += new System.EventHandler(this.AnimationEditor_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private TreeView frameTreeView;
		private MenuStrip menuStrip;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem saveToolStripMenuItem1;
		private PckStudio.ToolboxItems.AnimationPictureBox animationPictureBox;
		private CheckBox InterpolationCheckbox;
		private Button AnimationStartStopBtn;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem addFrameToolStripMenuItem;
		private ToolStripMenuItem removeFrameToolStripMenuItem;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem bulkAnimationSpeedToolStripMenuItem;
		private ToolStripMenuItem helpToolStripMenuItem;
		private Label tileLabel;
		private ToolStripMenuItem howToInterpolation;
		private ToolStripMenuItem editorControlsToolStripMenuItem;
		private ToolStripMenuItem setBulkSpedToolStripMenuItem;
		private ToolStripMenuItem javaAnimationSupportToolStripMenuItem;
		private ImageList TextureIcons;
        private ToolStripMenuItem importToolStripMenuItem;
        private ToolStripMenuItem importJavaAnimationToolStripMenuItem;
        private ToolStripMenuItem importGifToolStripMenuItem;
        private ToolStripMenuItem exportAsToolStripMenuItem;
        private ToolStripMenuItem exportJavaAnimationToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem importAnimationTextureToolStripMenuItem;
        private ToolStripMenuItem gifToolStripMenuItem;
		private ToolStripMenuItem frameTimeandTicksToolStripMenuItem;
	}
}