﻿
namespace Morseapp_WinForms
{
    partial class Form_Updates
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
            this.label_Changelog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_Dependent = new System.Windows.Forms.Button();
            this.button_Standalone = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label_Title = new System.Windows.Forms.Label();
            this.label_Choose = new System.Windows.Forms.Label();
            this.folderBrowserDialog_Updater = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Changelog
            // 
            this.label_Changelog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Changelog.Location = new System.Drawing.Point(65, 35);
            this.label_Changelog.Name = "label_Changelog";
            this.label_Changelog.Size = new System.Drawing.Size(361, 122);
            this.label_Changelog.TabIndex = 0;
            this.label_Changelog.Text = "A new release.\r\nBug fixes.\r\nAnd something else...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Morseapp_WinForms.Properties.Resources.updater_48;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_Dependent
            // 
            this.button_Dependent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Dependent.Location = new System.Drawing.Point(9, 175);
            this.button_Dependent.Name = "button_Dependent";
            this.button_Dependent.Size = new System.Drawing.Size(120, 30);
            this.button_Dependent.TabIndex = 2;
            this.button_Dependent.Text = ".NET Dependent";
            this.toolTip.SetToolTip(this.button_Dependent, "Recommended. Requires Microsoft .NET runtime to be installed - application will t" +
        "ell you if it\'s necessary. Very small size.");
            this.button_Dependent.UseVisualStyleBackColor = true;
            this.button_Dependent.Click += new System.EventHandler(this.Button_Dependent_Click);
            // 
            // button_Standalone
            // 
            this.button_Standalone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Standalone.Location = new System.Drawing.Point(134, 175);
            this.button_Standalone.Name = "button_Standalone";
            this.button_Standalone.Size = new System.Drawing.Size(120, 30);
            this.button_Standalone.TabIndex = 3;
            this.button_Standalone.Text = "Standalone";
            this.toolTip.SetToolTip(this.button_Standalone, "Single .exe file with .NET runtime built-in. Significantly larger size.");
            this.button_Standalone.UseVisualStyleBackColor = true;
            this.button_Standalone.Click += new System.EventHandler(this.Button_Standalone_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(356, 175);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(70, 30);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Cancel";
            this.toolTip.SetToolTip(this.button_Cancel, "Abort the update.");
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 50;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // label_Title
            // 
            this.label_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(90, 10);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(209, 21);
            this.label_Title.TabIndex = 5;
            this.label_Title.Text = "A new update is available.";
            // 
            // label_Choose
            // 
            this.label_Choose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Choose.AutoSize = true;
            this.label_Choose.Location = new System.Drawing.Point(6, 157);
            this.label_Choose.Name = "label_Choose";
            this.label_Choose.Size = new System.Drawing.Size(429, 15);
            this.label_Choose.TabIndex = 6;
            this.label_Choose.Text = "Which variant would you like to download? Hover over buttons for more details.";
            // 
            // Form_Updates
            // 
            this.AcceptButton = this.button_Dependent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(434, 211);
            this.Controls.Add(this.label_Choose);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Standalone);
            this.Controls.Add(this.button_Dependent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Changelog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "Form_Updates";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update tool";
            this.Load += new System.EventHandler(this.Form_Updates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Changelog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_Dependent;
        private System.Windows.Forms.Button button_Standalone;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_Choose;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Updater;
    }
}