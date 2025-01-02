using System.Windows.Forms;

namespace PckStudio.Forms
{
    partial class ContributorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContributorsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buildLabel = new System.Windows.Forms.Label();
            this.contributorsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.layout = new System.Windows.Forms.TableLayoutPanel();
            this.layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(6, 445);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maintained by PhoenixARC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(6, 426);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Originally created and developed by jam1garner && Nobledez";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(471, 426);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Additional development by MattNL and Miku-666";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(545, 445);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Code base overhaul by Miku-666";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buildLabel
            // 
            this.buildLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layout.SetColumnSpan(this.buildLabel, 2);
            this.buildLabel.Enabled = false;
            this.buildLabel.Location = new System.Drawing.Point(6, 6);
            this.buildLabel.Margin = new System.Windows.Forms.Padding(3);
            this.buildLabel.Name = "buildLabel";
            this.buildLabel.Size = new System.Drawing.Size(702, 54);
            this.buildLabel.TabIndex = 7;
            this.buildLabel.Text = "Build Information";
            // 
            // contributorsLayoutPanel
            // 
            this.contributorsLayoutPanel.AutoScroll = true;
            this.contributorsLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.layout.SetColumnSpan(this.contributorsLayoutPanel, 2);
            this.contributorsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contributorsLayoutPanel.Location = new System.Drawing.Point(6, 66);
            this.contributorsLayoutPanel.Name = "contributorsLayoutPanel";
            this.contributorsLayoutPanel.Size = new System.Drawing.Size(702, 354);
            this.contributorsLayoutPanel.TabIndex = 8;
            // 
            // layout
            // 
            this.layout.ColumnCount = 2;
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layout.Controls.Add(this.label2, 0, 2);
            this.layout.Controls.Add(this.label6, 1, 3);
            this.layout.Controls.Add(this.buildLabel, 0, 0);
            this.layout.Controls.Add(this.label1, 0, 3);
            this.layout.Controls.Add(this.contributorsLayoutPanel, 0, 1);
            this.layout.Controls.Add(this.label5, 1, 2);
            this.layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layout.Location = new System.Drawing.Point(0, 0);
            this.layout.Name = "layout";
            this.layout.Padding = new System.Windows.Forms.Padding(3);
            this.layout.RowCount = 4;
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layout.Size = new System.Drawing.Size(714, 464);
            this.layout.TabIndex = 9;
            // 
            // ContributorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 464);
            this.Controls.Add(this.layout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(730, 500);
            this.Name = "ContributorsForm";
            this.Text = "Contributors";
            this.layout.ResumeLayout(false);
            this.layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private Label buildLabel;
        private System.Windows.Forms.FlowLayoutPanel contributorsLayoutPanel;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label6;
        private TableLayoutPanel layout;
    }
}