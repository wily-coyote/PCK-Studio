using System.Windows.Forms;

namespace PckStudio.Forms.Features
{
    partial class PckManager
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
			System.Windows.Forms.Label consoleTypeLabel;
			System.Windows.Forms.Label platformTypeLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PckManager));
			this.supportedPlatformComboBox = new System.Windows.Forms.ComboBox();
			this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
			consoleTypeLabel = new System.Windows.Forms.Label();
			platformTypeLabel = new System.Windows.Forms.Label();
			this.mainPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// consoleTypeLabel
			// 
			consoleTypeLabel.AutoSize = true;
			consoleTypeLabel.Location = new System.Drawing.Point(264, 73);
			consoleTypeLabel.Name = "consoleTypeLabel";
			consoleTypeLabel.Size = new System.Drawing.Size(75, 13);
			consoleTypeLabel.TabIndex = 1;
			consoleTypeLabel.Text = "Console Type:";
			// 
			// platformTypeLabel
			// 
			platformTypeLabel.AutoSize = true;
			platformTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			platformTypeLabel.Location = new System.Drawing.Point(3, 0);
			platformTypeLabel.Name = "platformTypeLabel";
			platformTypeLabel.Size = new System.Drawing.Size(203, 35);
			platformTypeLabel.TabIndex = 13;
			platformTypeLabel.Text = "Platform type:";
			platformTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// supportedPlatformComboBox
			// 
			this.supportedPlatformComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.supportedPlatformComboBox.FormattingEnabled = true;
			this.supportedPlatformComboBox.ItemHeight = 13;
			this.supportedPlatformComboBox.Location = new System.Drawing.Point(212, 3);
			this.supportedPlatformComboBox.Name = "supportedPlatformComboBox";
			this.supportedPlatformComboBox.Size = new System.Drawing.Size(204, 21);
			this.supportedPlatformComboBox.TabIndex = 0;
			this.supportedPlatformComboBox.SelectionChangeCommitted += new System.EventHandler(this.supportedPlatformComboBox_SelectionChangeCommitted);
			// 
			// mainPanel
			// 
			this.mainPanel.ColumnCount = 2;
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.mainPanel.Controls.Add(this.supportedPlatformComboBox, 1, 0);
			this.mainPanel.Controls.Add(platformTypeLabel, 0, 0);
			this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel.Location = new System.Drawing.Point(0, 0);
			this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.RowCount = 2;
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.mainPanel.Size = new System.Drawing.Size(419, 640);
			this.mainPanel.TabIndex = 3;
			// 
			// PckManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 640);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(consoleTypeLabel);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(419, 640);
			this.Name = "PckManager";
			this.Text = "Pck Manager";
			this.mainPanel.ResumeLayout(false);
			this.mainPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private ComboBox supportedPlatformComboBox;
        private TableLayoutPanel mainPanel;
    }
}