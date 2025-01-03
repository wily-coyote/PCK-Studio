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
			this.maintainerLabel = new System.Windows.Forms.Label();
			this.originalAuthorLabel = new System.Windows.Forms.Label();
			this.contribLabel = new System.Windows.Forms.Label();
			this.refactorLabel = new System.Windows.Forms.Label();
			this.buildLabel = new System.Windows.Forms.Label();
			this.contributorsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.layout = new System.Windows.Forms.TableLayoutPanel();
			this.layout.SuspendLayout();
			this.SuspendLayout();
			// 
			// maintainerLabel
			// 
			this.maintainerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.maintainerLabel.AutoSize = true;
			this.maintainerLabel.Location = new System.Drawing.Point(6, 445);
			this.maintainerLabel.Margin = new System.Windows.Forms.Padding(3);
			this.maintainerLabel.Name = "maintainerLabel";
			this.maintainerLabel.Size = new System.Drawing.Size(136, 13);
			this.maintainerLabel.TabIndex = 1;
			this.maintainerLabel.Text = "Maintained by PhoenixARC";
			this.maintainerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// originalAuthorLabel
			// 
			this.originalAuthorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.originalAuthorLabel.AutoSize = true;
			this.originalAuthorLabel.Location = new System.Drawing.Point(6, 426);
			this.originalAuthorLabel.Margin = new System.Windows.Forms.Padding(3);
			this.originalAuthorLabel.Name = "originalAuthorLabel";
			this.originalAuthorLabel.Size = new System.Drawing.Size(288, 13);
			this.originalAuthorLabel.TabIndex = 2;
			this.originalAuthorLabel.Text = "Originally created and developed by jam1garner && Nobledez";
			this.originalAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// contribLabel
			// 
			this.contribLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.contribLabel.AutoSize = true;
			this.contribLabel.Location = new System.Drawing.Point(471, 426);
			this.contribLabel.Margin = new System.Windows.Forms.Padding(3);
			this.contribLabel.Name = "contribLabel";
			this.contribLabel.Size = new System.Drawing.Size(237, 13);
			this.contribLabel.TabIndex = 5;
			this.contribLabel.Text = "Additional development by MattNL and Miku-666";
			this.contribLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// refactorLabel
			// 
			this.refactorLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.refactorLabel.AutoSize = true;
			this.refactorLabel.Location = new System.Drawing.Point(545, 445);
			this.refactorLabel.Margin = new System.Windows.Forms.Padding(3);
			this.refactorLabel.Name = "refactorLabel";
			this.refactorLabel.Size = new System.Drawing.Size(163, 13);
			this.refactorLabel.TabIndex = 6;
			this.refactorLabel.Text = "Code base overhaul by Miku-666";
			this.refactorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// buildLabel
			// 
			this.buildLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.layout.SetColumnSpan(this.buildLabel, 2);
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
			this.layout.Controls.Add(this.originalAuthorLabel, 0, 2);
			this.layout.Controls.Add(this.refactorLabel, 1, 3);
			this.layout.Controls.Add(this.buildLabel, 0, 0);
			this.layout.Controls.Add(this.maintainerLabel, 0, 3);
			this.layout.Controls.Add(this.contributorsLayoutPanel, 0, 1);
			this.layout.Controls.Add(this.contribLabel, 1, 2);
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
        private Label buildLabel;
        private FlowLayoutPanel contributorsLayoutPanel;
        private Label maintainerLabel;
        private Label originalAuthorLabel;
        private Label contribLabel;
        private Label refactorLabel;
        private TableLayoutPanel layout;
    }
}