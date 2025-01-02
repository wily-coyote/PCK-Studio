
namespace PckStudio.Forms.Additional_Popups.Animation {
	partial class FrameEditor {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrameEditor));
			this.SaveBtn = new System.Windows.Forms.Button();
			this.frameTimeLabel = new System.Windows.Forms.Label();
			this.selectFrameLabel = new System.Windows.Forms.Label();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.FrameTimeUpDown = new System.Windows.Forms.NumericUpDown();
			this.FrameList = new System.Windows.Forms.TreeView();
			this.TextureIcons = new System.Windows.Forms.ImageList(this.components);
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.FrameTimeUpDown)).BeginInit();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// SaveBtn
			// 
			this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.SaveBtn.Location = new System.Drawing.Point(3, 260);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(106, 23);
			this.SaveBtn.TabIndex = 7;
			this.SaveBtn.Text = "Save";
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// frameTimeLabel
			// 
			this.frameTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.frameTimeLabel.AutoSize = true;
			this.frameTimeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.frameTimeLabel.Location = new System.Drawing.Point(3, 237);
			this.frameTimeLabel.Name = "frameTimeLabel";
			this.frameTimeLabel.Size = new System.Drawing.Size(106, 13);
			this.frameTimeLabel.TabIndex = 10;
			this.frameTimeLabel.Text = "Frame time (ticks)";
			this.frameTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// selectFrameLabel
			// 
			this.selectFrameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.selectFrameLabel.AutoSize = true;
			this.layout.SetColumnSpan(this.selectFrameLabel, 2);
			this.selectFrameLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.selectFrameLabel.Location = new System.Drawing.Point(3, 0);
			this.selectFrameLabel.Name = "selectFrameLabel";
			this.selectFrameLabel.Size = new System.Drawing.Size(218, 40);
			this.selectFrameLabel.TabIndex = 12;
			this.selectFrameLabel.Text = "Select a frame and frame time:";
			this.selectFrameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CancelBtn
			// 
			this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.CancelBtn.Location = new System.Drawing.Point(115, 260);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(106, 23);
			this.CancelBtn.TabIndex = 13;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// FrameTimeUpDown
			// 
			this.FrameTimeUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.FrameTimeUpDown.Location = new System.Drawing.Point(115, 234);
			this.FrameTimeUpDown.Maximum = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.FrameTimeUpDown.Minimum = new decimal(new int[] {
			1,
			0,
			0,
			0});
			this.FrameTimeUpDown.Name = "FrameTimeUpDown";
			this.FrameTimeUpDown.Size = new System.Drawing.Size(106, 20);
			this.FrameTimeUpDown.TabIndex = 15;
			this.FrameTimeUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.FrameTimeUpDown.Value = new decimal(new int[] {
			1,
			0,
			0,
			0});
			// 
			// FrameList
			// 
			this.FrameList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.layout.SetColumnSpan(this.FrameList, 2);
			this.FrameList.HideSelection = false;
			this.FrameList.ImageIndex = 0;
			this.FrameList.ImageList = this.TextureIcons;
			this.FrameList.Location = new System.Drawing.Point(3, 43);
			this.FrameList.Name = "FrameList";
			this.FrameList.SelectedImageIndex = 0;
			this.FrameList.ShowLines = false;
			this.FrameList.ShowRootLines = false;
			this.FrameList.Size = new System.Drawing.Size(218, 185);
			this.FrameList.TabIndex = 1;
			// 
			// TextureIcons
			// 
			this.TextureIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
			this.TextureIcons.ImageSize = new System.Drawing.Size(32, 32);
			this.TextureIcons.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// layout
			// 
			this.layout.ColumnCount = 2;
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.layout.Controls.Add(this.selectFrameLabel, 0, 0);
			this.layout.Controls.Add(this.FrameList, 0, 1);
			this.layout.Controls.Add(this.frameTimeLabel, 0, 2);
			this.layout.Controls.Add(this.CancelBtn, 1, 3);
			this.layout.Controls.Add(this.FrameTimeUpDown, 1, 2);
			this.layout.Controls.Add(this.SaveBtn, 0, 3);
			this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layout.Location = new System.Drawing.Point(0, 0);
			this.layout.Name = "layout";
			this.layout.RowCount = 4;
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.Size = new System.Drawing.Size(224, 286);
			this.layout.TabIndex = 16;
			// 
			// FrameEditor
			// 
			this.AcceptButton = this.SaveBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.CancelBtn;
			this.ClientSize = new System.Drawing.Size(224, 286);
			this.Controls.Add(this.layout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FrameEditor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Frame editor";
			((System.ComponentModel.ISupportInitialize)(this.FrameTimeUpDown)).EndInit();
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label frameTimeLabel;
		private System.Windows.Forms.Label selectFrameLabel;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.NumericUpDown FrameTimeUpDown;
		private System.Windows.Forms.TreeView FrameList;
		public System.Windows.Forms.ImageList TextureIcons;
		public System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.TableLayoutPanel layout;
	}
}