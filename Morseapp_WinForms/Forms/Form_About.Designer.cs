
namespace Morseapp_WinForms
{
    partial class Form_About
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
            this.button_Close = new System.Windows.Forms.Button();
            this.richTextBox_AboutInfo = new System.Windows.Forms.RichTextBox();
            this.pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.splitter_Vertical = new System.Windows.Forms.Splitter();
            this.button_GitHub = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.Location = new System.Drawing.Point(331, 204);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(75, 28);
            this.button_Close.TabIndex = 0;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = true;
            // 
            // richTextBox_AboutInfo
            // 
            this.richTextBox_AboutInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_AboutInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox_AboutInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_AboutInfo.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox_AboutInfo.Location = new System.Drawing.Point(61, 10);
            this.richTextBox_AboutInfo.Name = "richTextBox_AboutInfo";
            this.richTextBox_AboutInfo.ReadOnly = true;
            this.richTextBox_AboutInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox_AboutInfo.Size = new System.Drawing.Size(345, 194);
            this.richTextBox_AboutInfo.TabIndex = 3;
            this.richTextBox_AboutInfo.Text = "Sample text";
            // 
            // pictureBox_Icon
            // 
            this.pictureBox_Icon.Image = global::Morseapp_WinForms.Properties.Resources.morse_code;
            this.pictureBox_Icon.Location = new System.Drawing.Point(10, 10);
            this.pictureBox_Icon.Name = "pictureBox_Icon";
            this.pictureBox_Icon.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Icon.TabIndex = 1;
            this.pictureBox_Icon.TabStop = false;
            // 
            // splitter_Vertical
            // 
            this.splitter_Vertical.BackColor = System.Drawing.SystemColors.Control;
            this.splitter_Vertical.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter_Vertical.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter_Vertical.Location = new System.Drawing.Point(0, 201);
            this.splitter_Vertical.Name = "splitter_Vertical";
            this.splitter_Vertical.Size = new System.Drawing.Size(409, 35);
            this.splitter_Vertical.TabIndex = 4;
            this.splitter_Vertical.TabStop = false;
            // 
            // button_GitHub
            // 
            this.button_GitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_GitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_GitHub.Image = global::Morseapp_WinForms.Properties.Resources.GitHub_Mark_24px;
            this.button_GitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_GitHub.Location = new System.Drawing.Point(4, 204);
            this.button_GitHub.Name = "button_GitHub";
            this.button_GitHub.Size = new System.Drawing.Size(80, 28);
            this.button_GitHub.TabIndex = 5;
            this.button_GitHub.Text = "GitHub";
            this.button_GitHub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip.SetToolTip(this.button_GitHub, "Opens home GitHub repository where you can view application source code, document" +
        "ation or contact the author.");
            this.button_GitHub.UseVisualStyleBackColor = true;
            this.button_GitHub.Click += new System.EventHandler(this.button_GitHub_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.ReshowDelay = 50;
            // 
            // Form_About
            // 
            this.AcceptButton = this.button_Close;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CancelButton = this.button_Close;
            this.ClientSize = new System.Drawing.Size(409, 236);
            this.Controls.Add(this.button_GitHub);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.splitter_Vertical);
            this.Controls.Add(this.pictureBox_Icon);
            this.Controls.Add(this.richTextBox_AboutInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_About";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About...";
            this.Load += new System.EventHandler(this.Form_About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.RichTextBox richTextBox_AboutInfo;
        private System.Windows.Forms.PictureBox pictureBox_Icon;
        private System.Windows.Forms.Splitter splitter_Vertical;
        private System.Windows.Forms.Button button_GitHub;
        private System.Windows.Forms.ToolTip toolTip;
    }
}