using System.Windows.Forms;

namespace PckStudio.Forms.Editor
{
	partial class ANIMEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ANIMEditor));
			this.saveButton = new System.Windows.Forms.Button();
			this.flagsGroup = new System.Windows.Forms.GroupBox();
			this.rightLegOCheckBox = new System.Windows.Forms.CheckBox();
			this.headOCheckBox = new System.Windows.Forms.CheckBox();
			this.leftLegOCheckBox = new System.Windows.Forms.CheckBox();
			this.leftArmOCheckBox = new System.Windows.Forms.CheckBox();
			this.bodyOCheckBox = new System.Windows.Forms.CheckBox();
			this.rightLegCheckBox = new System.Windows.Forms.CheckBox();
			this.slimCheckBox = new System.Windows.Forms.CheckBox();
			this.headCheckBox = new System.Windows.Forms.CheckBox();
			this.leftLegCheckBox = new System.Windows.Forms.CheckBox();
			this.rightArmCheckBox = new System.Windows.Forms.CheckBox();
			this.leftArmCheckBox = new System.Windows.Forms.CheckBox();
			this.bodyCheckBox = new System.Windows.Forms.CheckBox();
			this.classicCheckBox = new System.Windows.Forms.CheckBox();
			this.rightArmOCheckBox = new System.Windows.Forms.CheckBox();
			this.armorFlagsGroupBox = new System.Windows.Forms.GroupBox();
			this.rightLeggingCheckBox = new System.Windows.Forms.CheckBox();
			this.helmetCheckBox = new System.Windows.Forms.CheckBox();
			this.leftLeggingCheckBox = new System.Windows.Forms.CheckBox();
			this.rightArmorCheckBox = new System.Windows.Forms.CheckBox();
			this.leftArmorCheckBox = new System.Windows.Forms.CheckBox();
			this.chestplateCheckBox = new System.Windows.Forms.CheckBox();
			this.specialAnimGroupBox = new System.Windows.Forms.GroupBox();
			this.unknownCheckBox = new System.Windows.Forms.CheckBox();
			this.crouchCheckBox = new System.Windows.Forms.CheckBox();
			this.dinnerboneCheckBox = new System.Windows.Forms.CheckBox();
			this.noArmorCheckBox = new System.Windows.Forms.CheckBox();
			this.bobbingCheckBox = new System.Windows.Forms.CheckBox();
			this.santaCheckBox = new System.Windows.Forms.CheckBox();
			this.syncLegsCheckBox = new System.Windows.Forms.CheckBox();
			this.staticArmsCheckBox = new System.Windows.Forms.CheckBox();
			this.syncArmsCheckBox = new System.Windows.Forms.CheckBox();
			this.statueCheckBox = new System.Windows.Forms.CheckBox();
			this.zombieCheckBox = new System.Windows.Forms.CheckBox();
			this.staticLegsCheckBox = new System.Windows.Forms.CheckBox();
			this.copyButton = new System.Windows.Forms.Button();
			this.importButton = new System.Windows.Forms.Button();
			this.exportButton = new System.Windows.Forms.Button();
			this.animValue = new System.Windows.Forms.Label();
			this.uncheckAllButton = new System.Windows.Forms.Button();
			this.checkAllButton = new System.Windows.Forms.Button();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.resetButton = new System.Windows.Forms.Button();
			this.templateButton = new System.Windows.Forms.Button();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			this.armorFlagsLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.specialAnimLayout = new System.Windows.Forms.TableLayoutPanel();
			this.flagsLayout = new System.Windows.Forms.TableLayoutPanel();
			this.flagsGroup.SuspendLayout();
			this.armorFlagsGroupBox.SuspendLayout();
			this.specialAnimGroupBox.SuspendLayout();
			this.layout.SuspendLayout();
			this.armorFlagsLayout.SuspendLayout();
			this.specialAnimLayout.SuspendLayout();
			this.flagsLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.saveButton.Location = new System.Drawing.Point(197, 428);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(188, 23);
			this.saveButton.TabIndex = 1;
			this.saveButton.Text = "Save";
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// flagsGroup
			// 
			this.layout.SetColumnSpan(this.flagsGroup, 2);
			this.flagsGroup.Controls.Add(this.flagsLayout);
			this.flagsGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flagsGroup.Location = new System.Drawing.Point(3, 109);
			this.flagsGroup.Name = "flagsGroup";
			this.layout.SetRowSpan(this.flagsGroup, 2);
			this.flagsGroup.Size = new System.Drawing.Size(382, 192);
			this.flagsGroup.TabIndex = 2;
			this.flagsGroup.TabStop = false;
			this.flagsGroup.Text = "Skin Flags";
			// 
			// rightLegOCheckBox
			// 
			this.rightLegOCheckBox.AutoSize = true;
			this.rightLegOCheckBox.Location = new System.Drawing.Point(191, 141);
			this.rightLegOCheckBox.Name = "rightLegOCheckBox";
			this.rightLegOCheckBox.Size = new System.Drawing.Size(165, 17);
			this.rightLegOCheckBox.TabIndex = 13;
			this.rightLegOCheckBox.Text = "Remove Right Leg Layer Box";
			this.toolTip.SetToolTip(this.rightLegOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// headOCheckBox
			// 
			this.headOCheckBox.AutoSize = true;
			this.headOCheckBox.Location = new System.Drawing.Point(191, 26);
			this.headOCheckBox.Name = "headOCheckBox";
			this.headOCheckBox.Size = new System.Drawing.Size(145, 17);
			this.headOCheckBox.TabIndex = 12;
			this.headOCheckBox.Text = "Remove Head Layer Box";
			this.toolTip.SetToolTip(this.headOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// leftLegOCheckBox
			// 
			this.leftLegOCheckBox.AutoSize = true;
			this.leftLegOCheckBox.Location = new System.Drawing.Point(191, 118);
			this.leftLegOCheckBox.Name = "leftLegOCheckBox";
			this.leftLegOCheckBox.Size = new System.Drawing.Size(158, 17);
			this.leftLegOCheckBox.TabIndex = 11;
			this.leftLegOCheckBox.Text = "Remove Left Leg Layer Box";
			this.toolTip.SetToolTip(this.leftLegOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// leftArmOCheckBox
			// 
			this.leftArmOCheckBox.AutoSize = true;
			this.leftArmOCheckBox.Location = new System.Drawing.Point(191, 72);
			this.leftArmOCheckBox.Name = "leftArmOCheckBox";
			this.leftArmOCheckBox.Size = new System.Drawing.Size(158, 17);
			this.leftArmOCheckBox.TabIndex = 9;
			this.leftArmOCheckBox.Text = "Remove Left Arm Layer Box";
			this.toolTip.SetToolTip(this.leftArmOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// bodyOCheckBox
			// 
			this.bodyOCheckBox.AutoSize = true;
			this.bodyOCheckBox.Location = new System.Drawing.Point(191, 49);
			this.bodyOCheckBox.Name = "bodyOCheckBox";
			this.bodyOCheckBox.Size = new System.Drawing.Size(143, 17);
			this.bodyOCheckBox.TabIndex = 8;
			this.bodyOCheckBox.Text = "Remove Body Layer Box";
			this.toolTip.SetToolTip(this.bodyOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// rightLegCheckBox
			// 
			this.rightLegCheckBox.AutoSize = true;
			this.rightLegCheckBox.Location = new System.Drawing.Point(3, 141);
			this.rightLegCheckBox.Name = "rightLegCheckBox";
			this.rightLegCheckBox.Size = new System.Drawing.Size(136, 17);
			this.rightLegCheckBox.TabIndex = 7;
			this.rightLegCheckBox.Text = "Remove Right Leg Box";
			this.toolTip.SetToolTip(this.rightLegCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// slimCheckBox
			// 
			this.slimCheckBox.AutoSize = true;
			this.slimCheckBox.Location = new System.Drawing.Point(191, 3);
			this.slimCheckBox.Name = "slimCheckBox";
			this.slimCheckBox.Size = new System.Drawing.Size(126, 17);
			this.slimCheckBox.TabIndex = 6;
			this.slimCheckBox.Text = "64x64 Alex/Slim Skin";
			this.toolTip.SetToolTip(this.slimCheckBox, "          The 1.8 style skin type with slim arms, overlays for each part, and sep" +
        "arate textures for right and left limbs. Resolution is also set to 64x64.       " +
        "   ");
			// 
			// headCheckBox
			// 
			this.headCheckBox.AutoSize = true;
			this.headCheckBox.Location = new System.Drawing.Point(3, 26);
			this.headCheckBox.Name = "headCheckBox";
			this.headCheckBox.Size = new System.Drawing.Size(116, 17);
			this.headCheckBox.TabIndex = 5;
			this.headCheckBox.Text = "Remove Head Box";
			this.toolTip.SetToolTip(this.headCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// leftLegCheckBox
			// 
			this.leftLegCheckBox.AutoSize = true;
			this.leftLegCheckBox.Location = new System.Drawing.Point(3, 118);
			this.leftLegCheckBox.Name = "leftLegCheckBox";
			this.leftLegCheckBox.Size = new System.Drawing.Size(129, 17);
			this.leftLegCheckBox.TabIndex = 4;
			this.leftLegCheckBox.Text = "Remove Left Leg Box";
			this.toolTip.SetToolTip(this.leftLegCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// rightArmCheckBox
			// 
			this.rightArmCheckBox.AutoSize = true;
			this.rightArmCheckBox.Location = new System.Drawing.Point(3, 95);
			this.rightArmCheckBox.Name = "rightArmCheckBox";
			this.rightArmCheckBox.Size = new System.Drawing.Size(136, 17);
			this.rightArmCheckBox.TabIndex = 3;
			this.rightArmCheckBox.Text = "Remove Right Arm Box";
			this.toolTip.SetToolTip(this.rightArmCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// leftArmCheckBox
			// 
			this.leftArmCheckBox.AutoSize = true;
			this.leftArmCheckBox.Location = new System.Drawing.Point(3, 72);
			this.leftArmCheckBox.Name = "leftArmCheckBox";
			this.leftArmCheckBox.Size = new System.Drawing.Size(129, 17);
			this.leftArmCheckBox.TabIndex = 2;
			this.leftArmCheckBox.Text = "Remove Left Arm Box";
			this.toolTip.SetToolTip(this.leftArmCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// bodyCheckBox
			// 
			this.bodyCheckBox.AutoSize = true;
			this.bodyCheckBox.Location = new System.Drawing.Point(3, 49);
			this.bodyCheckBox.Name = "bodyCheckBox";
			this.bodyCheckBox.Size = new System.Drawing.Size(114, 17);
			this.bodyCheckBox.TabIndex = 1;
			this.bodyCheckBox.Text = "Remove Body Box";
			this.toolTip.SetToolTip(this.bodyCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// classicCheckBox
			// 
			this.classicCheckBox.AutoSize = true;
			this.classicCheckBox.Location = new System.Drawing.Point(3, 3);
			this.classicCheckBox.Name = "classicCheckBox";
			this.classicCheckBox.Size = new System.Drawing.Size(115, 17);
			this.classicCheckBox.TabIndex = 0;
			this.classicCheckBox.Text = "64x64 Classic Skin";
			this.toolTip.SetToolTip(this.classicCheckBox, "          The 1.8 style skin type with overlays for each part and separate textur" +
        "es for right and left limbs. Resolution is also set to 64x64.         ");
			// 
			// rightArmOCheckBox
			// 
			this.rightArmOCheckBox.AutoSize = true;
			this.rightArmOCheckBox.Location = new System.Drawing.Point(191, 95);
			this.rightArmOCheckBox.Name = "rightArmOCheckBox";
			this.rightArmOCheckBox.Size = new System.Drawing.Size(165, 17);
			this.rightArmOCheckBox.TabIndex = 10;
			this.rightArmOCheckBox.Text = "Remove Right Arm Layer Box";
			this.toolTip.SetToolTip(this.rightArmOCheckBox, "             Removes the parent Box for this part. You can still make new boxes f" +
        "or this part. Armor will be disabled for this part, but can be rendered again wi" +
        "th the armor flags.              ");
			// 
			// armorFlagsGroupBox
			// 
			this.armorFlagsGroupBox.Controls.Add(this.armorFlagsLayout);
			this.armorFlagsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.armorFlagsGroupBox.Location = new System.Drawing.Point(391, 138);
			this.armorFlagsGroupBox.Name = "armorFlagsGroupBox";
			this.armorFlagsGroupBox.Size = new System.Drawing.Size(190, 163);
			this.armorFlagsGroupBox.TabIndex = 14;
			this.armorFlagsGroupBox.TabStop = false;
			this.armorFlagsGroupBox.Text = "Armor Flags";
			// 
			// rightLeggingCheckBox
			// 
			this.rightLeggingCheckBox.AutoSize = true;
			this.rightLeggingCheckBox.Enabled = false;
			this.rightLeggingCheckBox.Location = new System.Drawing.Point(3, 118);
			this.rightLeggingCheckBox.Name = "rightLeggingCheckBox";
			this.rightLeggingCheckBox.Size = new System.Drawing.Size(140, 17);
			this.rightLeggingCheckBox.TabIndex = 7;
			this.rightLeggingCheckBox.Text = "Render Right Leg Armor";
			this.toolTip.SetToolTip(this.rightLeggingCheckBox, " Forcefully enables the specified armor piece.");
			// 
			// helmetCheckBox
			// 
			this.helmetCheckBox.AutoSize = true;
			this.helmetCheckBox.Enabled = false;
			this.helmetCheckBox.Location = new System.Drawing.Point(3, 3);
			this.helmetCheckBox.Name = "helmetCheckBox";
			this.helmetCheckBox.Size = new System.Drawing.Size(120, 17);
			this.helmetCheckBox.TabIndex = 5;
			this.helmetCheckBox.Text = "Render Head Armor";
			this.toolTip.SetToolTip(this.helmetCheckBox, " Forcefully enables the specified armor piece.");
			// 
			// leftLeggingCheckBox
			// 
			this.leftLeggingCheckBox.AutoSize = true;
			this.leftLeggingCheckBox.Enabled = false;
			this.leftLeggingCheckBox.Location = new System.Drawing.Point(3, 95);
			this.leftLeggingCheckBox.Name = "leftLeggingCheckBox";
			this.leftLeggingCheckBox.Size = new System.Drawing.Size(133, 17);
			this.leftLeggingCheckBox.TabIndex = 4;
			this.leftLeggingCheckBox.Text = "Render Left Leg Armor";
			this.toolTip.SetToolTip(this.leftLeggingCheckBox, " Forcefully enables the specified armor piece.");
			// 
			// rightArmorCheckBox
			// 
			this.rightArmorCheckBox.AutoSize = true;
			this.rightArmorCheckBox.Enabled = false;
			this.rightArmorCheckBox.Location = new System.Drawing.Point(3, 72);
			this.rightArmorCheckBox.Name = "rightArmorCheckBox";
			this.rightArmorCheckBox.Size = new System.Drawing.Size(140, 17);
			this.rightArmorCheckBox.TabIndex = 3;
			this.rightArmorCheckBox.Text = "Render Right Arm Armor";
			this.toolTip.SetToolTip(this.rightArmorCheckBox, " Forcefully enables the specified armor piece.");
			// 
			// leftArmorCheckBox
			// 
			this.leftArmorCheckBox.AutoSize = true;
			this.leftArmorCheckBox.Enabled = false;
			this.leftArmorCheckBox.Location = new System.Drawing.Point(3, 49);
			this.leftArmorCheckBox.Name = "leftArmorCheckBox";
			this.leftArmorCheckBox.Size = new System.Drawing.Size(133, 17);
			this.leftArmorCheckBox.TabIndex = 2;
			this.leftArmorCheckBox.Text = "Render Left Arm Armor";
			this.toolTip.SetToolTip(this.leftArmorCheckBox, " Forcefully enables the specified armor piece.");
			// 
			// chestplateCheckBox
			// 
			this.chestplateCheckBox.AutoSize = true;
			this.chestplateCheckBox.Enabled = false;
			this.chestplateCheckBox.Location = new System.Drawing.Point(3, 26);
			this.chestplateCheckBox.Name = "chestplateCheckBox";
			this.chestplateCheckBox.Size = new System.Drawing.Size(118, 17);
			this.chestplateCheckBox.TabIndex = 1;
			this.chestplateCheckBox.Text = "Render Body Armor";
			this.toolTip.SetToolTip(this.chestplateCheckBox, " Forcefully enables the specified armor piece.");
			// 
			// specialAnimGroupBox
			// 
			this.layout.SetColumnSpan(this.specialAnimGroupBox, 3);
			this.specialAnimGroupBox.Controls.Add(this.specialAnimLayout);
			this.specialAnimGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.specialAnimGroupBox.Location = new System.Drawing.Point(3, 307);
			this.specialAnimGroupBox.Name = "specialAnimGroupBox";
			this.specialAnimGroupBox.Size = new System.Drawing.Size(578, 115);
			this.specialAnimGroupBox.TabIndex = 15;
			this.specialAnimGroupBox.TabStop = false;
			this.specialAnimGroupBox.Text = "Special Animations";
			// 
			// unknownCheckBox
			// 
			this.unknownCheckBox.AutoSize = true;
			this.unknownCheckBox.Location = new System.Drawing.Point(146, 49);
			this.unknownCheckBox.Name = "unknownCheckBox";
			this.unknownCheckBox.Size = new System.Drawing.Size(72, 17);
			this.unknownCheckBox.TabIndex = 13;
			this.unknownCheckBox.Text = "Unknown";
			this.toolTip.SetToolTip(this.unknownCheckBox, "   If you figure out what this is. Please reach out to MNL#8935 on Discord. (:   " +
        "");
			// 
			// crouchCheckBox
			// 
			this.crouchCheckBox.AutoSize = true;
			this.crouchCheckBox.Location = new System.Drawing.Point(146, 26);
			this.crouchCheckBox.Name = "crouchCheckBox";
			this.crouchCheckBox.Size = new System.Drawing.Size(116, 17);
			this.crouchCheckBox.TabIndex = 12;
			this.crouchCheckBox.Text = "Backwards Crouch";
			this.toolTip.SetToolTip(this.crouchCheckBox, "      The crouch animation is reversed so that the arms and body lean back. Usefu" +
        "l for small skins.     ");
			// 
			// dinnerboneCheckBox
			// 
			this.dinnerboneCheckBox.AutoSize = true;
			this.dinnerboneCheckBox.Location = new System.Drawing.Point(146, 3);
			this.dinnerboneCheckBox.Name = "dinnerboneCheckBox";
			this.dinnerboneCheckBox.Size = new System.Drawing.Size(81, 17);
			this.dinnerboneCheckBox.TabIndex = 11;
			this.dinnerboneCheckBox.Text = "Dinnerbone";
			this.dinnerboneCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.toolTip.SetToolTip(this.dinnerboneCheckBox, "   Flips the skin upside down like Dinnerbone\'s skin, a Minecraft developer.  ");
			// 
			// noArmorCheckBox
			// 
			this.noArmorCheckBox.AutoSize = true;
			this.noArmorCheckBox.Location = new System.Drawing.Point(432, 49);
			this.noArmorCheckBox.Name = "noArmorCheckBox";
			this.noArmorCheckBox.Size = new System.Drawing.Size(105, 17);
			this.noArmorCheckBox.TabIndex = 10;
			this.noArmorCheckBox.Text = "Disable All Armor";
			this.toolTip.SetToolTip(this.noArmorCheckBox, " Disables all armor desptie the armor flags.  ");
			// 
			// bobbingCheckBox
			// 
			this.bobbingCheckBox.AutoSize = true;
			this.bobbingCheckBox.Location = new System.Drawing.Point(289, 26);
			this.bobbingCheckBox.Name = "bobbingCheckBox";
			this.bobbingCheckBox.Size = new System.Drawing.Size(103, 17);
			this.bobbingCheckBox.TabIndex = 9;
			this.bobbingCheckBox.Text = "Disable Bobbing";
			this.toolTip.SetToolTip(this.bobbingCheckBox, " Disables the bobbing effect in first person.");
			// 
			// santaCheckBox
			// 
			this.santaCheckBox.AutoSize = true;
			this.santaCheckBox.Location = new System.Drawing.Point(432, 26);
			this.santaCheckBox.Name = "santaCheckBox";
			this.santaCheckBox.Size = new System.Drawing.Size(76, 17);
			this.santaCheckBox.TabIndex = 8;
			this.santaCheckBox.Text = "Bad Santa";
			this.toolTip.SetToolTip(this.santaCheckBox, "       The skin sits down after about 10 seconds of no controller input. Made for" +
        " Bad Santa in the \"Festive\" skin pack.       ");
			// 
			// syncLegsCheckBox
			// 
			this.syncLegsCheckBox.AutoSize = true;
			this.syncLegsCheckBox.Location = new System.Drawing.Point(289, 3);
			this.syncLegsCheckBox.Name = "syncLegsCheckBox";
			this.syncLegsCheckBox.Size = new System.Drawing.Size(114, 17);
			this.syncLegsCheckBox.TabIndex = 7;
			this.syncLegsCheckBox.Text = "Synchronous Legs";
			this.toolTip.SetToolTip(this.syncLegsCheckBox, "   These parts will move at the same time and angle as each other.  ");
			// 
			// staticArmsCheckBox
			// 
			this.staticArmsCheckBox.AutoSize = true;
			this.staticArmsCheckBox.Location = new System.Drawing.Point(3, 3);
			this.staticArmsCheckBox.Name = "staticArmsCheckBox";
			this.staticArmsCheckBox.Size = new System.Drawing.Size(79, 17);
			this.staticArmsCheckBox.TabIndex = 5;
			this.staticArmsCheckBox.Text = "Static Arms";
			this.toolTip.SetToolTip(this.staticArmsCheckBox, " These parts will not move in most animations. ");
			// 
			// syncArmsCheckBox
			// 
			this.syncArmsCheckBox.AutoSize = true;
			this.syncArmsCheckBox.Location = new System.Drawing.Point(432, 3);
			this.syncArmsCheckBox.Name = "syncArmsCheckBox";
			this.syncArmsCheckBox.Size = new System.Drawing.Size(114, 17);
			this.syncArmsCheckBox.TabIndex = 4;
			this.syncArmsCheckBox.Text = "Synchronous Arms";
			this.toolTip.SetToolTip(this.syncArmsCheckBox, "   These parts will move at the same time and angle as each other.  ");
			// 
			// statueCheckBox
			// 
			this.statueCheckBox.AutoSize = true;
			this.statueCheckBox.Location = new System.Drawing.Point(289, 49);
			this.statueCheckBox.Name = "statueCheckBox";
			this.statueCheckBox.Size = new System.Drawing.Size(103, 17);
			this.statueCheckBox.TabIndex = 3;
			this.statueCheckBox.Text = "Statue of Liberty";
			this.toolTip.SetToolTip(this.statueCheckBox, "       The right arm is lifted like the Statue of Liberty. Made for Angel of Libe" +
        "rty in the \"Doctor Who Volume I\" skin pack.       ");
			// 
			// zombieCheckBox
			// 
			this.zombieCheckBox.AutoSize = true;
			this.zombieCheckBox.Location = new System.Drawing.Point(3, 49);
			this.zombieCheckBox.Name = "zombieCheckBox";
			this.zombieCheckBox.Size = new System.Drawing.Size(87, 17);
			this.zombieCheckBox.TabIndex = 2;
			this.zombieCheckBox.Text = "Zombie Arms";
			this.toolTip.SetToolTip(this.zombieCheckBox, " Both arms will stick up like a Zombie. ");
			// 
			// staticLegsCheckBox
			// 
			this.staticLegsCheckBox.AutoSize = true;
			this.staticLegsCheckBox.Location = new System.Drawing.Point(3, 26);
			this.staticLegsCheckBox.Name = "staticLegsCheckBox";
			this.staticLegsCheckBox.Size = new System.Drawing.Size(79, 17);
			this.staticLegsCheckBox.TabIndex = 1;
			this.staticLegsCheckBox.Text = "Static Legs";
			this.toolTip.SetToolTip(this.staticLegsCheckBox, " These parts will not move in most animations. ");
			// 
			// copyButton
			// 
			this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.copyButton.Location = new System.Drawing.Point(391, 80);
			this.copyButton.Name = "copyButton";
			this.copyButton.Size = new System.Drawing.Size(190, 23);
			this.copyButton.TabIndex = 22;
			this.copyButton.Text = "Copy ANIM Value";
			this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
			// 
			// importButton
			// 
			this.importButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.importButton.Location = new System.Drawing.Point(3, 80);
			this.importButton.Name = "importButton";
			this.importButton.Size = new System.Drawing.Size(188, 23);
			this.importButton.TabIndex = 23;
			this.importButton.Text = "Import ANIM";
			this.importButton.Click += new System.EventHandler(this.importButton_Click);
			// 
			// exportButton
			// 
			this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.exportButton.Location = new System.Drawing.Point(197, 80);
			this.exportButton.Name = "exportButton";
			this.exportButton.Size = new System.Drawing.Size(188, 23);
			this.exportButton.TabIndex = 24;
			this.exportButton.Text = "Export Template Texture";
			this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
			// 
			// animValue
			// 
			this.animValue.AutoSize = true;
			this.layout.SetColumnSpan(this.animValue, 3);
			this.animValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.animValue.Location = new System.Drawing.Point(3, 0);
			this.animValue.Name = "animValue";
			this.animValue.Size = new System.Drawing.Size(578, 48);
			this.animValue.TabIndex = 25;
			this.animValue.Text = "0x00000000";
			this.animValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// uncheckAllButton
			// 
			this.uncheckAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.uncheckAllButton.Location = new System.Drawing.Point(197, 51);
			this.uncheckAllButton.Name = "uncheckAllButton";
			this.uncheckAllButton.Size = new System.Drawing.Size(188, 23);
			this.uncheckAllButton.TabIndex = 26;
			this.uncheckAllButton.Text = "Uncheck All";
			this.uncheckAllButton.Click += new System.EventHandler(this.uncheckAllButton_Click);
			// 
			// checkAllButton
			// 
			this.checkAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.checkAllButton.Location = new System.Drawing.Point(3, 51);
			this.checkAllButton.Name = "checkAllButton";
			this.checkAllButton.Size = new System.Drawing.Size(188, 23);
			this.checkAllButton.TabIndex = 27;
			this.checkAllButton.Text = "Check All";
			this.checkAllButton.Click += new System.EventHandler(this.checkAllButton_Click);
			// 
			// toolTip
			// 
			this.toolTip.StripAmpersands = true;
			// 
			// resetButton
			// 
			this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.resetButton.Location = new System.Drawing.Point(391, 51);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(190, 23);
			this.resetButton.TabIndex = 28;
			this.resetButton.Text = "Restore ANIM";
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// templateButton
			// 
			this.templateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.templateButton.Location = new System.Drawing.Point(391, 109);
			this.templateButton.Name = "templateButton";
			this.templateButton.Size = new System.Drawing.Size(190, 23);
			this.templateButton.TabIndex = 29;
			this.templateButton.Text = "Skin Presets";
			this.templateButton.Click += new System.EventHandler(this.templateButton_Click);
			// 
			// layout
			// 
			this.layout.ColumnCount = 3;
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
			this.layout.Controls.Add(this.saveButton, 1, 6);
			this.layout.Controls.Add(this.specialAnimGroupBox, 0, 5);
			this.layout.Controls.Add(this.flagsGroup, 0, 3);
			this.layout.Controls.Add(this.armorFlagsGroupBox, 2, 4);
			this.layout.Controls.Add(this.templateButton, 2, 3);
			this.layout.Controls.Add(this.checkAllButton, 0, 1);
			this.layout.Controls.Add(this.uncheckAllButton, 1, 1);
			this.layout.Controls.Add(this.importButton, 0, 2);
			this.layout.Controls.Add(this.exportButton, 1, 2);
			this.layout.Controls.Add(this.resetButton, 2, 1);
			this.layout.Controls.Add(this.copyButton, 2, 2);
			this.layout.Controls.Add(this.animValue, 0, 0);
			this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layout.Location = new System.Drawing.Point(0, 0);
			this.layout.Name = "layout";
			this.layout.RowCount = 7;
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.layout.Size = new System.Drawing.Size(584, 454);
			this.layout.TabIndex = 30;
			// 
			// armorFlagsLayout
			// 
			this.armorFlagsLayout.Controls.Add(this.helmetCheckBox);
			this.armorFlagsLayout.Controls.Add(this.chestplateCheckBox);
			this.armorFlagsLayout.Controls.Add(this.leftArmorCheckBox);
			this.armorFlagsLayout.Controls.Add(this.rightArmorCheckBox);
			this.armorFlagsLayout.Controls.Add(this.leftLeggingCheckBox);
			this.armorFlagsLayout.Controls.Add(this.rightLeggingCheckBox);
			this.armorFlagsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.armorFlagsLayout.Location = new System.Drawing.Point(3, 16);
			this.armorFlagsLayout.Name = "armorFlagsLayout";
			this.armorFlagsLayout.Size = new System.Drawing.Size(184, 144);
			this.armorFlagsLayout.TabIndex = 8;
			// 
			// specialAnimLayout
			// 
			this.specialAnimLayout.ColumnCount = 4;
			this.specialAnimLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.specialAnimLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.specialAnimLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.specialAnimLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.specialAnimLayout.Controls.Add(this.staticArmsCheckBox, 0, 0);
			this.specialAnimLayout.Controls.Add(this.zombieCheckBox, 0, 2);
			this.specialAnimLayout.Controls.Add(this.unknownCheckBox, 1, 2);
			this.specialAnimLayout.Controls.Add(this.dinnerboneCheckBox, 1, 0);
			this.specialAnimLayout.Controls.Add(this.statueCheckBox, 2, 2);
			this.specialAnimLayout.Controls.Add(this.noArmorCheckBox, 3, 2);
			this.specialAnimLayout.Controls.Add(this.crouchCheckBox, 1, 1);
			this.specialAnimLayout.Controls.Add(this.santaCheckBox, 3, 1);
			this.specialAnimLayout.Controls.Add(this.bobbingCheckBox, 2, 1);
			this.specialAnimLayout.Controls.Add(this.syncLegsCheckBox, 2, 0);
			this.specialAnimLayout.Controls.Add(this.syncArmsCheckBox, 3, 0);
			this.specialAnimLayout.Controls.Add(this.staticLegsCheckBox, 0, 1);
			this.specialAnimLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.specialAnimLayout.Location = new System.Drawing.Point(3, 16);
			this.specialAnimLayout.Name = "specialAnimLayout";
			this.specialAnimLayout.RowCount = 4;
			this.specialAnimLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.specialAnimLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.specialAnimLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.specialAnimLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.specialAnimLayout.Size = new System.Drawing.Size(572, 96);
			this.specialAnimLayout.TabIndex = 14;
			// 
			// flagsLayout
			// 
			this.flagsLayout.ColumnCount = 2;
			this.flagsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.flagsLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.flagsLayout.Controls.Add(this.classicCheckBox, 0, 0);
			this.flagsLayout.Controls.Add(this.rightLegOCheckBox, 1, 6);
			this.flagsLayout.Controls.Add(this.headCheckBox, 0, 1);
			this.flagsLayout.Controls.Add(this.leftLegOCheckBox, 1, 5);
			this.flagsLayout.Controls.Add(this.headOCheckBox, 1, 1);
			this.flagsLayout.Controls.Add(this.rightArmOCheckBox, 1, 4);
			this.flagsLayout.Controls.Add(this.leftArmOCheckBox, 1, 3);
			this.flagsLayout.Controls.Add(this.bodyCheckBox, 0, 2);
			this.flagsLayout.Controls.Add(this.bodyOCheckBox, 1, 2);
			this.flagsLayout.Controls.Add(this.leftArmCheckBox, 0, 3);
			this.flagsLayout.Controls.Add(this.rightArmCheckBox, 0, 4);
			this.flagsLayout.Controls.Add(this.leftLegCheckBox, 0, 5);
			this.flagsLayout.Controls.Add(this.slimCheckBox, 1, 0);
			this.flagsLayout.Controls.Add(this.rightLegCheckBox, 0, 6);
			this.flagsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flagsLayout.Location = new System.Drawing.Point(3, 16);
			this.flagsLayout.Name = "flagsLayout";
			this.flagsLayout.RowCount = 8;
			this.flagsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.flagsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.flagsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.flagsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.flagsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.flagsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.flagsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.flagsLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.flagsLayout.Size = new System.Drawing.Size(376, 173);
			this.flagsLayout.TabIndex = 14;
			// 
			// ANIMEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 454);
			this.Controls.Add(this.layout);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ANIMEditor";
			this.Text = "ANIM Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ANIMEditor_FormClosing);
			this.flagsGroup.ResumeLayout(false);
			this.armorFlagsGroupBox.ResumeLayout(false);
			this.specialAnimGroupBox.ResumeLayout(false);
			this.layout.ResumeLayout(false);
			this.layout.PerformLayout();
			this.armorFlagsLayout.ResumeLayout(false);
			this.armorFlagsLayout.PerformLayout();
			this.specialAnimLayout.ResumeLayout(false);
			this.specialAnimLayout.PerformLayout();
			this.flagsLayout.ResumeLayout(false);
			this.flagsLayout.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private Button saveButton;
		private System.Windows.Forms.GroupBox flagsGroup;
		private CheckBox headCheckBox;
		private CheckBox leftLegCheckBox;
		private CheckBox rightArmCheckBox;
		private CheckBox leftArmCheckBox;
		private CheckBox bodyCheckBox;
		private CheckBox classicCheckBox;
		private CheckBox slimCheckBox;
		private CheckBox rightLegCheckBox;
		private CheckBox rightLegOCheckBox;
		private CheckBox headOCheckBox;
		private CheckBox leftLegOCheckBox;
		private CheckBox rightArmOCheckBox;
		private CheckBox leftArmOCheckBox;
		private CheckBox bodyOCheckBox;
		private System.Windows.Forms.GroupBox armorFlagsGroupBox;
		private CheckBox rightLeggingCheckBox;
		private CheckBox helmetCheckBox;
		private CheckBox leftLeggingCheckBox;
		private CheckBox rightArmorCheckBox;
		private CheckBox leftArmorCheckBox;
		private CheckBox chestplateCheckBox;
		private System.Windows.Forms.GroupBox specialAnimGroupBox;
		private CheckBox syncLegsCheckBox;
		private CheckBox staticArmsCheckBox;
		private CheckBox syncArmsCheckBox;
		private CheckBox statueCheckBox;
		private CheckBox zombieCheckBox;
		private CheckBox staticLegsCheckBox;
		private CheckBox bobbingCheckBox;
		private CheckBox santaCheckBox;
		private CheckBox noArmorCheckBox;
		private CheckBox dinnerboneCheckBox;
		private CheckBox crouchCheckBox;
		private CheckBox unknownCheckBox;
		private Button copyButton;
		private Button importButton;
		private Button exportButton;
		private Label animValue;
		private Button uncheckAllButton;
		private Button checkAllButton;
		private ToolTip toolTip;
		private Button resetButton;
		private Button templateButton;
		private TableLayoutPanel layout;
		private FlowLayoutPanel armorFlagsLayout;
		private TableLayoutPanel specialAnimLayout;
		private TableLayoutPanel flagsLayout;
	}
}