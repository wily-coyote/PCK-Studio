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
			Label label3;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSkinPrompt));
			Label label2;
			Label label1;
			this.textTheme = new TextBox();
			this.contextMenuSkin = new ContextMenuStrip(this.components);
			this.replaceToolStripMenuItem = new ToolStripMenuItem();
			this.contextMenuCape = new ContextMenuStrip(this.components);
			this.replaceToolStripMenuItem1 = new ToolStripMenuItem();
			this.buttonDone = new Button();
			this.buttonModelGen = new Button();
			this.buttonCape = new Button();
			this.buttonSkin = new Button();
			this.displayBox = new PictureBox();
			this.radioButtonAuto = new RadioButton();
			this.radioButtonManual = new RadioButton();
			this.textSkinID = new TextBox();
			this.textSkinName = new TextBox();
			this.textThemeName = new TextBox();
			this.labelSelectTexture = new Label();
			this.capeLabel = new Label();
			this.buttonAnimGen = new Button();
			this.capePictureBox = new PckStudio.ToolboxItems.InterpolationPictureBox();
			this.skinPictureBox = new PckStudio.ToolboxItems.InterpolationPictureBox();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			this.contextMenuSkin.SuspendLayout();
			this.contextMenuCape.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.capePictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.skinPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			resources.ApplyResources(label3, "label3");
			label3.ForeColor = System.Drawing.Color.White;
			label3.Name = "label3";
			// 
			// label2
			// 
			resources.ApplyResources(label2, "label2");
			label2.ForeColor = System.Drawing.Color.White;
			label2.Name = "label2";
			// 
			// label1
			// 
			resources.ApplyResources(label1, "label1");
			label1.ForeColor = System.Drawing.Color.White;
			label1.Name = "label1";
			// 
			// textTheme
			// 
			resources.ApplyResources(this.textTheme, "textTheme");
			this.textTheme.Name = "textTheme";
			// 
			// contextMenuSkin
			// 
			this.contextMenuSkin.Items.AddRange(new ToolStripItem[] {
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
			this.contextMenuCape.Items.AddRange(new ToolStripItem[] {
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
			this.buttonCape.BackgroundImage = global::PckStudio.Properties.Resources.HamburgerMenuIcon;
			resources.ApplyResources(this.buttonCape, "buttonCape");
			this.buttonCape.Name = "buttonCape";
			this.buttonCape.Click += new System.EventHandler(this.buttonCape_Click);
			// 
			// buttonSkin
			// 
			this.buttonSkin.BackgroundImage = global::PckStudio.Properties.Resources.HamburgerMenuIcon;
			resources.ApplyResources(this.buttonSkin, "buttonSkin");
			this.buttonSkin.Name = "buttonSkin";
			this.buttonSkin.Click += new System.EventHandler(this.buttonSkin_Click);
			// 
			// displayBox
			// 
			this.displayBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
			resources.ApplyResources(this.displayBox, "displayBox");
			this.displayBox.Name = "displayBox";
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
			// 
			// 
			// 
			this.textSkinID.ForeColor = System.Drawing.Color.White;
			this.textSkinID.Lines = new string[0];
			resources.ApplyResources(this.textSkinID, "textSkinID");
			this.textSkinID.MaxLength = 8;
			this.textSkinID.Name = "textSkinID";
			this.textSkinID.PasswordChar = '\0';
			this.textSkinID.ScrollBars = ScrollBars.None;
			this.textSkinID.SelectedText = "";
			this.textSkinID.SelectionLength = 0;
			this.textSkinID.SelectionStart = 0;
			this.textSkinID.ShortcutsEnabled = true;
			this.textSkinID.TextChanged += new System.EventHandler(this.textSkinID_TextChanged);
			// 
			// textSkinName
			// 
			// 
			// 
			// 
			this.textSkinName.ForeColor = System.Drawing.Color.White;
			this.textSkinName.Lines = new string[0];
			resources.ApplyResources(this.textSkinName, "textSkinName");
			this.textSkinName.MaxLength = 32767;
			this.textSkinName.Name = "textSkinName";
			this.textSkinName.PasswordChar = '\0';
			this.textSkinName.ScrollBars = ScrollBars.None;
			this.textSkinName.SelectedText = "";
			this.textSkinName.SelectionLength = 0;
			this.textSkinName.SelectionStart = 0;
			this.textSkinName.ShortcutsEnabled = true;
			// 
			// textThemeName
			// 
			// 
			// 
			// 
			this.textThemeName.ForeColor = System.Drawing.Color.White;
			this.textThemeName.Lines = new string[0];
			resources.ApplyResources(this.textThemeName, "textThemeName");
			this.textThemeName.MaxLength = 32767;
			this.textThemeName.Name = "textThemeName";
			this.textThemeName.PasswordChar = '\0';
			this.textThemeName.ScrollBars = ScrollBars.None;
			this.textThemeName.SelectedText = "";
			this.textThemeName.SelectionLength = 0;
			this.textThemeName.SelectionStart = 0;
			this.textThemeName.ShortcutsEnabled = true;
			// 
			// labelSelectTexture
			// 
			resources.ApplyResources(this.labelSelectTexture, "labelSelectTexture");
			this.labelSelectTexture.Name = "labelSelectTexture";
			// 
			// capeLabel
			// 
			resources.ApplyResources(this.capeLabel, "capeLabel");
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
			resources.ApplyResources(this.capePictureBox, "capePictureBox");
			this.capePictureBox.BorderStyle = BorderStyle.FixedSingle;
			this.capePictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			this.capePictureBox.Name = "capePictureBox";
			this.capePictureBox.TabStop = false;
			this.capePictureBox.MouseClick += new MouseEventHandler(this.capePictureBox_MouseClick);
			// 
			// skinPictureBox
			// 
			resources.ApplyResources(this.skinPictureBox, "skinPictureBox");
			this.skinPictureBox.BorderStyle = BorderStyle.FixedSingle;
			this.skinPictureBox.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
			this.skinPictureBox.Name = "skinPictureBox";
			this.skinPictureBox.TabStop = false;
			this.skinPictureBox.MouseClick += new MouseEventHandler(this.skinPictureBox_MouseClick);
			// 
			// AddNewSkin
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = AutoScaleMode.Font;
			this.Controls.Add(this.buttonCape);
			this.Controls.Add(this.buttonAnimGen);
			this.Controls.Add(this.capeLabel);
			this.Controls.Add(this.textThemeName);
			this.Controls.Add(this.textSkinName);
			this.Controls.Add(this.textSkinID);
			this.Controls.Add(this.labelSelectTexture);
			this.Controls.Add(this.radioButtonManual);
			this.Controls.Add(this.radioButtonAuto);
			this.Controls.Add(this.buttonDone);
			this.Controls.Add(this.buttonModelGen);
			this.Controls.Add(this.buttonSkin);
			this.Controls.Add(this.capePictureBox);
			this.Controls.Add(this.skinPictureBox);
			this.Controls.Add(this.displayBox);
			this.Controls.Add(label3);
			this.Controls.Add(label2);
			this.Controls.Add(label1);
			this.MaximizeBox = false;
			this.Name = "AddNewSkin";
			this.Load += new System.EventHandler(this.AddNewSkin_Load);
			this.contextMenuSkin.ResumeLayout(false);
			this.contextMenuCape.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.capePictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.skinPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private Label labelSelectTexture;
		private Label capeLabel;
	}
}