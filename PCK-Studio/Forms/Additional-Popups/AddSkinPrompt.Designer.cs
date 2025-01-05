using System.Windows.Forms;

namespace PckStudio.Forms.Additional_Popups {
	partial class AddSkinPrompt {
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
			System.Windows.Forms.Label themeNameLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSkinPrompt));
			System.Windows.Forms.Label skinNameLabel;
			System.Windows.Forms.Label skinIdLabel;
			this.textTheme = new System.Windows.Forms.TextBox();
			this.contextMenuSkin = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuCape = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.replaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonDone = new System.Windows.Forms.Button();
			this.buttonModelGen = new System.Windows.Forms.Button();
			this.buttonCape = new System.Windows.Forms.Button();
			this.buttonSkin = new System.Windows.Forms.Button();
			this.displayBox = new System.Windows.Forms.PictureBox();
			this.radioButtonAuto = new System.Windows.Forms.RadioButton();
			this.radioButtonManual = new System.Windows.Forms.RadioButton();
			this.textSkinID = new System.Windows.Forms.TextBox();
			this.textSkinName = new System.Windows.Forms.TextBox();
			this.textThemeName = new System.Windows.Forms.TextBox();
			this.skinLabel = new System.Windows.Forms.Label();
			this.capeLabel = new System.Windows.Forms.Label();
			this.buttonAnimGen = new System.Windows.Forms.Button();
			this.capePictureBox = new PckStudio.ToolboxItems.InterpolationPictureBox();
			this.skinPictureBox = new PckStudio.ToolboxItems.InterpolationPictureBox();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			this.skinPanel = new System.Windows.Forms.Panel();
			this.capePanel = new System.Windows.Forms.Panel();
			themeNameLabel = new System.Windows.Forms.Label();
			skinNameLabel = new System.Windows.Forms.Label();
			skinIdLabel = new System.Windows.Forms.Label();
			this.contextMenuSkin.SuspendLayout();
			this.contextMenuCape.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.capePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.skinPictureBox)).BeginInit();
			this.layout.SuspendLayout();
			this.skinPanel.SuspendLayout();
			this.capePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// themeNameLabel
			// 
			resources.ApplyResources(themeNameLabel, "themeNameLabel");
			themeNameLabel.Name = "themeNameLabel";
			// 
			// skinNameLabel
			// 
			resources.ApplyResources(skinNameLabel, "skinNameLabel");
			skinNameLabel.Name = "skinNameLabel";
			// 
			// skinIdLabel
			// 
			resources.ApplyResources(skinIdLabel, "skinIdLabel");
			skinIdLabel.Name = "skinIdLabel";
			// 
			// textTheme
			// 
			resources.ApplyResources(this.textTheme, "textTheme");
			this.textTheme.Name = "textTheme";
			// 
			// contextMenuSkin
			// 
			this.contextMenuSkin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceToolStripMenuItem});
			this.contextMenuSkin.Name = "contextMenuSkin";
			resources.ApplyResources(this.contextMenuSkin, "contextMenuSkin");
			// 
			// replaceToolStripMenuItem
			// 
			resources.ApplyResources(this.replaceToolStripMenuItem, "replaceToolStripMenuItem");
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
			// 
			// contextMenuCape
			// 
			this.contextMenuCape.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.replaceToolStripMenuItem1});
			this.contextMenuCape.Name = "contextMenuCape";
			resources.ApplyResources(this.contextMenuCape, "contextMenuCape");
			// 
			// replaceToolStripMenuItem1
			// 
			resources.ApplyResources(this.replaceToolStripMenuItem1, "replaceToolStripMenuItem1");
			this.replaceToolStripMenuItem1.Name = "replaceToolStripMenuItem1";
			// 
			// buttonDone
			// 
			resources.ApplyResources(this.buttonDone, "buttonDone");
			this.buttonDone.Name = "buttonDone";
			this.buttonDone.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// buttonModelGen
			// 
			resources.ApplyResources(this.buttonModelGen, "buttonModelGen");
			this.buttonModelGen.Name = "buttonModelGen";
			this.buttonModelGen.Click += new System.EventHandler(this.CreateCustomModel_Click);
			// 
			// buttonCape
			// 
			resources.ApplyResources(this.buttonCape, "buttonCape");
			this.buttonCape.BackgroundImage = global::PckStudio.Properties.Resources.HamburgerMenuIcon;
			this.buttonCape.Name = "buttonCape";
			this.buttonCape.Click += new System.EventHandler(this.buttonCape_Click);
			// 
			// buttonSkin
			// 
			resources.ApplyResources(this.buttonSkin, "buttonSkin");
			this.buttonSkin.BackgroundImage = global::PckStudio.Properties.Resources.HamburgerMenuIcon;
			this.buttonSkin.Name = "buttonSkin";
			this.buttonSkin.Click += new System.EventHandler(this.buttonSkin_Click);
			// 
			// displayBox
			// 
			this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.layout.SetColumnSpan(this.displayBox, 2);
			resources.ApplyResources(this.displayBox, "displayBox");
			this.displayBox.Name = "displayBox";
			this.layout.SetRowSpan(this.displayBox, 5);
			this.displayBox.TabStop = false;
			// 
			// radioButtonAuto
			// 
			resources.ApplyResources(this.radioButtonAuto, "radioButtonAuto");
			this.radioButtonAuto.Name = "radioButtonAuto";
			this.radioButtonAuto.CheckedChanged += new System.EventHandler(this.radioButtonAuto_CheckedChanged);
			// 
			// radioButtonManual
			// 
			resources.ApplyResources(this.radioButtonManual, "radioButtonManual");
			this.radioButtonManual.Checked = true;
			this.radioButtonManual.Name = "radioButtonManual";
			this.radioButtonManual.TabStop = true;
			this.radioButtonManual.CheckedChanged += new System.EventHandler(this.radioButtonManual_CheckedChanged);
			// 
			// textSkinID
			// 
			resources.ApplyResources(this.textSkinID, "textSkinID");
			this.textSkinID.Name = "textSkinID";
			this.textSkinID.TextChanged += new System.EventHandler(this.textSkinID_TextChanged);
			// 
			// textSkinName
			// 
			resources.ApplyResources(this.textSkinName, "textSkinName");
			this.layout.SetColumnSpan(this.textSkinName, 2);
			this.textSkinName.Name = "textSkinName";
			// 
			// textThemeName
			// 
			resources.ApplyResources(this.textThemeName, "textThemeName");
			this.layout.SetColumnSpan(this.textThemeName, 2);
			this.textThemeName.Name = "textThemeName";
			// 
			// skinLabel
			// 
			resources.ApplyResources(this.skinLabel, "skinLabel");
			this.skinLabel.BackColor = System.Drawing.Color.Transparent;
			this.skinLabel.Name = "skinLabel";
			// 
			// capeLabel
			// 
			resources.ApplyResources(this.capeLabel, "capeLabel");
			this.capeLabel.BackColor = System.Drawing.Color.Transparent;
			this.capeLabel.Name = "capeLabel";
			// 
			// buttonAnimGen
			// 
			resources.ApplyResources(this.buttonAnimGen, "buttonAnimGen");
			this.buttonAnimGen.Name = "buttonAnimGen";
			this.buttonAnimGen.Click += new System.EventHandler(this.buttonAnimGen_Click);
			// 
			// capePictureBox
			// 
			this.capePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.capePictureBox, "capePictureBox");
			this.capePictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			this.capePictureBox.Name = "capePictureBox";
			this.capePictureBox.TabStop = false;
			this.capePictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.capePictureBox_MouseClick);
			// 
			// skinPictureBox
			// 
			this.skinPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			resources.ApplyResources(this.skinPictureBox, "skinPictureBox");
			this.skinPictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			this.skinPictureBox.Name = "skinPictureBox";
			this.skinPictureBox.TabStop = false;
			this.skinPictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.skinPictureBox_MouseClick);
			// 
			// layout
			// 
			resources.ApplyResources(this.layout, "layout");
			this.layout.Controls.Add(this.buttonModelGen, 0, 5);
			this.layout.Controls.Add(this.buttonAnimGen, 1, 5);
			this.layout.Controls.Add(this.buttonDone, 4, 5);
			this.layout.Controls.Add(this.textSkinID, 3, 0);
			this.layout.Controls.Add(skinIdLabel, 2, 0);
			this.layout.Controls.Add(themeNameLabel, 2, 3);
			this.layout.Controls.Add(this.radioButtonManual, 4, 1);
			this.layout.Controls.Add(this.textThemeName, 3, 3);
			this.layout.Controls.Add(skinNameLabel, 2, 2);
			this.layout.Controls.Add(this.displayBox, 0, 0);
			this.layout.Controls.Add(this.textSkinName, 3, 2);
			this.layout.Controls.Add(this.radioButtonAuto, 4, 0);
			this.layout.Controls.Add(this.skinPanel, 3, 4);
			this.layout.Controls.Add(this.capePanel, 4, 4);
			this.layout.Name = "layout";
			// 
			// skinPanel
			// 
			this.skinPanel.Controls.Add(this.skinLabel);
			this.skinPanel.Controls.Add(this.buttonSkin);
			this.skinPanel.Controls.Add(this.skinPictureBox);
			resources.ApplyResources(this.skinPanel, "skinPanel");
			this.skinPanel.Name = "skinPanel";
			// 
			// capePanel
			// 
			this.capePanel.Controls.Add(this.capeLabel);
			this.capePanel.Controls.Add(this.buttonCape);
			this.capePanel.Controls.Add(this.capePictureBox);
			resources.ApplyResources(this.capePanel, "capePanel");
			this.capePanel.Name = "capePanel";
			// 
			// AddSkinPrompt
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.layout);
			this.MaximizeBox = false;
			this.Name = "AddSkinPrompt";
			this.Load += new System.EventHandler(this.AddNewSkin_Load);
			this.contextMenuSkin.ResumeLayout(false);
			this.contextMenuCape.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.capePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.skinPictureBox)).EndInit();
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.skinPanel.ResumeLayout(false);
			this.skinPanel.PerformLayout();
			this.capePanel.ResumeLayout(false);
			this.capePanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private TextBox textTheme;
		private ContextMenuStrip contextMenuSkin;
		private ToolStripMenuItem replaceToolStripMenuItem;
		private ContextMenuStrip contextMenuCape;
		private ToolStripMenuItem replaceToolStripMenuItem1;
		private Button buttonDone;
		private Button buttonModelGen;
		private Button buttonCape;
		private Button buttonSkin;
		private PictureBox displayBox;
		private RadioButton radioButtonAuto;
		private RadioButton radioButtonManual;
		private TextBox textSkinID;
		private TextBox textSkinName;
		private TextBox textThemeName;
		private PckStudio.ToolboxItems.InterpolationPictureBox skinPictureBox;
		private PckStudio.ToolboxItems.InterpolationPictureBox capePictureBox;
		private Button buttonAnimGen;
		private Label skinLabel;
		private Label capeLabel;
		private TableLayoutPanel layout;
		private Panel skinPanel;
		private Panel capePanel;
	}
}