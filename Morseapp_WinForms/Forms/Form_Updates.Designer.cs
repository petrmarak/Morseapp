
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Changelog
            // 
            this.label_Changelog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Changelog.AutoSize = true;
            this.label_Changelog.Location = new System.Drawing.Point(71, 37);
            this.label_Changelog.Name = "label_Changelog";
            this.label_Changelog.Size = new System.Drawing.Size(126, 15);
            this.label_Changelog.TabIndex = 0;
            this.label_Changelog.Text = "Dev release for testing.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Morseapp_WinForms.Properties.Resources.morse_code;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_Dependent
            // 
            this.button_Dependent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Dependent.Location = new System.Drawing.Point(11, 144);
            this.button_Dependent.Name = "button_Dependent";
            this.button_Dependent.Size = new System.Drawing.Size(125, 30);
            this.button_Dependent.TabIndex = 2;
            this.button_Dependent.Text = ".NET Dependent";
            this.toolTip.SetToolTip(this.button_Dependent, "Requires Microsoft .NET Runtime to be installed. Application asks for it if neces" +
        "sary. Very small size.");
            this.button_Dependent.UseVisualStyleBackColor = true;
            this.button_Dependent.Click += new System.EventHandler(this.button_Dependent_Click);
            // 
            // button_Standalone
            // 
            this.button_Standalone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_Standalone.Location = new System.Drawing.Point(142, 144);
            this.button_Standalone.Name = "button_Standalone";
            this.button_Standalone.Size = new System.Drawing.Size(125, 30);
            this.button_Standalone.TabIndex = 3;
            this.button_Standalone.Text = "Standalone";
            this.toolTip.SetToolTip(this.button_Standalone, "Single .exe file with no extra requirements. Takes up more disk space.");
            this.button_Standalone.UseVisualStyleBackColor = true;
            this.button_Standalone.Click += new System.EventHandler(this.button_Standalone_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Cancel.Location = new System.Drawing.Point(322, 144);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 30);
            this.button_Cancel.TabIndex = 4;
            this.button_Cancel.Text = "Cancel";
            this.toolTip.SetToolTip(this.button_Cancel, "Abort the update");
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
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
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Title.Location = new System.Drawing.Point(68, 12);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(240, 25);
            this.label_Title.TabIndex = 5;
            this.label_Title.Text = "A new update is available.";
            // 
            // label_Choose
            // 
            this.label_Choose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Choose.AutoSize = true;
            this.label_Choose.Location = new System.Drawing.Point(11, 126);
            this.label_Choose.Name = "label_Choose";
            this.label_Choose.Size = new System.Drawing.Size(236, 15);
            this.label_Choose.TabIndex = 6;
            this.label_Choose.Text = "Which edition would you like to download?";
            // 
            // Form_Updates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 186);
            this.Controls.Add(this.label_Choose);
            this.Controls.Add(this.label_Title);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Standalone);
            this.Controls.Add(this.button_Dependent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_Changelog);
            this.Name = "Form_Updates";
            this.Text = "Form_Updates";
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
    }
}