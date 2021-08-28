
namespace Morseapp_WinForms
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.Coder = new System.Windows.Forms.TabPage();
            this.Coder_button_Copy = new System.Windows.Forms.Button();
            this.Coder_button_StopSound = new System.Windows.Forms.Button();
            this.Coder_button_Joke = new System.Windows.Forms.Button();
            this.Coder_button_Settings = new System.Windows.Forms.Button();
            this.Coder_button_PlaySound = new System.Windows.Forms.Button();
            this.Coder_textBox_Output = new System.Windows.Forms.TextBox();
            this.Coder_label_Output = new System.Windows.Forms.Label();
            this.Coder_label_Input = new System.Windows.Forms.Label();
            this.Coder_textBox_Input = new System.Windows.Forms.TextBox();
            this.Coder_button_Convert = new System.Windows.Forms.Button();
            this.Coder_label_Tip = new System.Windows.Forms.Label();
            this.Decoder = new System.Windows.Forms.TabPage();
            this.Decoder_button_Copy = new System.Windows.Forms.Button();
            this.Decoder_button_Settings = new System.Windows.Forms.Button();
            this.Decoder_label_Tip = new System.Windows.Forms.Label();
            this.Decoder_textBox_Output = new System.Windows.Forms.TextBox();
            this.Decoder_label_Output = new System.Windows.Forms.Label();
            this.Decoder_label_Input = new System.Windows.Forms.Label();
            this.Decoder_textBox_Input = new System.Windows.Forms.TextBox();
            this.Decoder_button_Convert = new System.Windows.Forms.Button();
            this.Player = new System.Windows.Forms.TabPage();
            this.Player_button_StopSound = new System.Windows.Forms.Button();
            this.Player_button_Settings = new System.Windows.Forms.Button();
            this.Player_label_Tip = new System.Windows.Forms.Label();
            this.Player_button_Play = new System.Windows.Forms.Button();
            this.Player_label_Input = new System.Windows.Forms.Label();
            this.Player_textBox_Input = new System.Windows.Forms.TextBox();
            this.Dictionary = new System.Windows.Forms.TabPage();
            this.ShowDict_button_Copy = new System.Windows.Forms.Button();
            this.ShowDict_button_Refresh = new System.Windows.Forms.Button();
            this.ShowDict_richtextBox_Output = new System.Windows.Forms.RichTextBox();
            this.Configuration = new System.Windows.Forms.TabPage();
            this.Config_groupBox_App = new System.Windows.Forms.GroupBox();
            this.Config_App_button_Updates = new System.Windows.Forms.Button();
            this.Config_App_label_Jokes = new System.Windows.Forms.Label();
            this.Config_App_comboBox_Jokes = new System.Windows.Forms.ComboBox();
            this.Config_App_button_About = new System.Windows.Forms.Button();
            this.Config_App_pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.Config_App_checkBox_JokesOption = new System.Windows.Forms.CheckBox();
            this.Config_App_label_LangChanged = new System.Windows.Forms.Label();
            this.Config_App_linkLabel_LangChanged = new System.Windows.Forms.LinkLabel();
            this.Config_App_checkBox_Dynamic = new System.Windows.Forms.CheckBox();
            this.Config_App_label_Lang = new System.Windows.Forms.Label();
            this.Config_App_comboBox_Lang = new System.Windows.Forms.ComboBox();
            this.Config_groupBox_Player = new System.Windows.Forms.GroupBox();
            this.Config_Player_pictureBox_Icon = new System.Windows.Forms.PictureBox();
            this.Config_Player_label_CurrentFreq = new System.Windows.Forms.Label();
            this.Config_Player_label_CurrentSpeed = new System.Windows.Forms.Label();
            this.Config_Player_label_Freq = new System.Windows.Forms.Label();
            this.Config_Player_trackBar_Freq = new System.Windows.Forms.TrackBar();
            this.Config_Player_label_Speed = new System.Windows.Forms.Label();
            this.Config_Player_checkBox_StrictTiming = new System.Windows.Forms.CheckBox();
            this.Config_Player_trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog_Updater = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl_Main.SuspendLayout();
            this.Coder.SuspendLayout();
            this.Decoder.SuspendLayout();
            this.Player.SuspendLayout();
            this.Dictionary.SuspendLayout();
            this.Configuration.SuspendLayout();
            this.Config_groupBox_App.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Config_App_pictureBox_Icon)).BeginInit();
            this.Config_groupBox_Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Config_Player_pictureBox_Icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config_Player_trackBar_Freq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config_Player_trackBar_Speed)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.Coder);
            this.tabControl_Main.Controls.Add(this.Decoder);
            this.tabControl_Main.Controls.Add(this.Player);
            this.tabControl_Main.Controls.Add(this.Dictionary);
            this.tabControl_Main.Controls.Add(this.Configuration);
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Main.Multiline = true;
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.Padding = new System.Drawing.Point(9, 3);
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.ShowToolTips = true;
            this.tabControl_Main.Size = new System.Drawing.Size(584, 361);
            this.tabControl_Main.TabIndex = 0;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.TabControl_Main_SelectedIndexChanged);
            // 
            // Coder
            // 
            this.Coder.AllowDrop = true;
            this.Coder.Controls.Add(this.Coder_button_Copy);
            this.Coder.Controls.Add(this.Coder_button_StopSound);
            this.Coder.Controls.Add(this.Coder_button_Joke);
            this.Coder.Controls.Add(this.Coder_button_Settings);
            this.Coder.Controls.Add(this.Coder_button_PlaySound);
            this.Coder.Controls.Add(this.Coder_textBox_Output);
            this.Coder.Controls.Add(this.Coder_label_Output);
            this.Coder.Controls.Add(this.Coder_label_Input);
            this.Coder.Controls.Add(this.Coder_textBox_Input);
            this.Coder.Controls.Add(this.Coder_button_Convert);
            this.Coder.Controls.Add(this.Coder_label_Tip);
            this.Coder.Location = new System.Drawing.Point(4, 24);
            this.Coder.Name = "Coder";
            this.Coder.Padding = new System.Windows.Forms.Padding(3);
            this.Coder.Size = new System.Drawing.Size(576, 333);
            this.Coder.TabIndex = 0;
            this.Coder.Text = "Coder";
            this.Coder.UseVisualStyleBackColor = true;
            // 
            // Coder_button_Copy
            // 
            this.Coder_button_Copy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Coder_button_Copy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Coder_button_Copy.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Coder_button_Copy.Location = new System.Drawing.Point(24, 197);
            this.Coder_button_Copy.Name = "Coder_button_Copy";
            this.Coder_button_Copy.Size = new System.Drawing.Size(25, 25);
            this.Coder_button_Copy.TabIndex = 10;
            this.Coder_button_Copy.Text = "⎘";
            this.Coder_button_Copy.UseVisualStyleBackColor = true;
            this.Coder_button_Copy.Visible = false;
            this.Coder_button_Copy.Click += new System.EventHandler(this.Coder_button_Copy_Click);
            this.Coder_button_Copy.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_Copy.MouseHover += new System.EventHandler(this.Coder_button_Copy_MouseHover);
            // 
            // Coder_button_StopSound
            // 
            this.Coder_button_StopSound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Coder_button_StopSound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Coder_button_StopSound.Location = new System.Drawing.Point(138, 244);
            this.Coder_button_StopSound.Name = "Coder_button_StopSound";
            this.Coder_button_StopSound.Size = new System.Drawing.Size(25, 25);
            this.Coder_button_StopSound.TabIndex = 9;
            this.Coder_button_StopSound.Text = "■";
            this.Coder_button_StopSound.UseVisualStyleBackColor = true;
            this.Coder_button_StopSound.Visible = false;
            this.Coder_button_StopSound.Click += new System.EventHandler(this.Coder_button_StopSound_Click);
            this.Coder_button_StopSound.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_StopSound.MouseHover += new System.EventHandler(this.Button_StopSound_MouseHover);
            // 
            // Coder_button_Joke
            // 
            this.Coder_button_Joke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Coder_button_Joke.Location = new System.Drawing.Point(24, 86);
            this.Coder_button_Joke.Name = "Coder_button_Joke";
            this.Coder_button_Joke.Size = new System.Drawing.Size(75, 25);
            this.Coder_button_Joke.TabIndex = 8;
            this.Coder_button_Joke.Text = "Insert joke";
            this.Coder_button_Joke.UseVisualStyleBackColor = true;
            this.Coder_button_Joke.Click += new System.EventHandler(this.Coder_button_Joke_Click);
            this.Coder_button_Joke.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_Joke.MouseHover += new System.EventHandler(this.Coder_button_Joke_MouseHover);
            // 
            // Coder_button_Settings
            // 
            this.Coder_button_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Coder_button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Coder_button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Coder_button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Coder_button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Coder_button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Coder_button_Settings.Image = global::Morseapp_WinForms.Properties.Resources.settings_24;
            this.Coder_button_Settings.Location = new System.Drawing.Point(548, 286);
            this.Coder_button_Settings.Name = "Coder_button_Settings";
            this.Coder_button_Settings.Size = new System.Drawing.Size(27, 27);
            this.Coder_button_Settings.TabIndex = 7;
            this.Coder_button_Settings.UseVisualStyleBackColor = true;
            this.Coder_button_Settings.Click += new System.EventHandler(this.Coder_button_Settings_Click);
            // 
            // Coder_button_PlaySound
            // 
            this.Coder_button_PlaySound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Coder_button_PlaySound.Location = new System.Drawing.Point(113, 208);
            this.Coder_button_PlaySound.Name = "Coder_button_PlaySound";
            this.Coder_button_PlaySound.Size = new System.Drawing.Size(75, 30);
            this.Coder_button_PlaySound.TabIndex = 6;
            this.Coder_button_PlaySound.Text = "▶️";
            this.Coder_button_PlaySound.UseVisualStyleBackColor = true;
            this.Coder_button_PlaySound.Visible = false;
            this.Coder_button_PlaySound.Click += new System.EventHandler(this.Button_PlaySound_Click);
            this.Coder_button_PlaySound.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_PlaySound.MouseHover += new System.EventHandler(this.Coder_button_PlaySound_MouseHover);
            // 
            // Coder_textBox_Output
            // 
            this.Coder_textBox_Output.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Coder_textBox_Output.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Coder_textBox_Output.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Coder_textBox_Output.Location = new System.Drawing.Point(25, 173);
            this.Coder_textBox_Output.Name = "Coder_textBox_Output";
            this.Coder_textBox_Output.ReadOnly = true;
            this.Coder_textBox_Output.Size = new System.Drawing.Size(250, 23);
            this.Coder_textBox_Output.TabIndex = 4;
            this.Coder_textBox_Output.TextChanged += new System.EventHandler(this.Coder_textBox_Output_TextChanged);
            this.Coder_textBox_Output.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coder_textBox_Output_KeyDown);
            this.Coder_textBox_Output.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_textBox_Output.MouseHover += new System.EventHandler(this.Coder_textBox_Output_MouseHover);
            // 
            // Coder_label_Output
            // 
            this.Coder_label_Output.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Coder_label_Output.AutoSize = true;
            this.Coder_label_Output.Location = new System.Drawing.Point(25, 155);
            this.Coder_label_Output.Name = "Coder_label_Output";
            this.Coder_label_Output.Size = new System.Drawing.Size(42, 15);
            this.Coder_label_Output.TabIndex = 3;
            this.Coder_label_Output.Text = "Result:";
            // 
            // Coder_label_Input
            // 
            this.Coder_label_Input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Coder_label_Input.AutoSize = true;
            this.Coder_label_Input.Location = new System.Drawing.Point(25, 42);
            this.Coder_label_Input.Name = "Coder_label_Input";
            this.Coder_label_Input.Size = new System.Drawing.Size(61, 15);
            this.Coder_label_Input.TabIndex = 2;
            this.Coder_label_Input.Text = "Input text:";
            // 
            // Coder_textBox_Input
            // 
            this.Coder_textBox_Input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Coder_textBox_Input.Location = new System.Drawing.Point(25, 60);
            this.Coder_textBox_Input.Name = "Coder_textBox_Input";
            this.Coder_textBox_Input.Size = new System.Drawing.Size(250, 23);
            this.Coder_textBox_Input.TabIndex = 1;
            this.Coder_textBox_Input.TextChanged += new System.EventHandler(this.Coder_textBox_Input_TextChanged);
            this.Coder_textBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coder_textBox_Input_KeyDown);
            this.Coder_textBox_Input.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_textBox_Input.MouseHover += new System.EventHandler(this.Coder_textBox_Input_MouseHover);
            // 
            // Coder_button_Convert
            // 
            this.Coder_button_Convert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Coder_button_Convert.Location = new System.Drawing.Point(113, 113);
            this.Coder_button_Convert.Name = "Coder_button_Convert";
            this.Coder_button_Convert.Size = new System.Drawing.Size(75, 30);
            this.Coder_button_Convert.TabIndex = 0;
            this.Coder_button_Convert.Text = "Convert";
            this.Coder_button_Convert.UseVisualStyleBackColor = true;
            this.Coder_button_Convert.Click += new System.EventHandler(this.Coder_button_Convert_Click);
            this.Coder_button_Convert.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_Convert.MouseHover += new System.EventHandler(this.Coder_button_Convert_MouseHover);
            // 
            // Coder_label_Tip
            // 
            this.Coder_label_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Coder_label_Tip.AutoSize = true;
            this.Coder_label_Tip.BackColor = System.Drawing.Color.Transparent;
            this.Coder_label_Tip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Coder_label_Tip.Cursor = System.Windows.Forms.Cursors.Help;
            this.Coder_label_Tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Coder_label_Tip.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Coder_label_Tip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Coder_label_Tip.Location = new System.Drawing.Point(420, 10);
            this.Coder_label_Tip.Name = "Coder_label_Tip";
            this.Coder_label_Tip.Size = new System.Drawing.Size(144, 36);
            this.Coder_label_Tip.TabIndex = 5;
            this.Coder_label_Tip.Text = "SOS → ... --- ...";
            this.Coder_label_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Decoder
            // 
            this.Decoder.Controls.Add(this.Decoder_button_Copy);
            this.Decoder.Controls.Add(this.Decoder_button_Settings);
            this.Decoder.Controls.Add(this.Decoder_label_Tip);
            this.Decoder.Controls.Add(this.Decoder_textBox_Output);
            this.Decoder.Controls.Add(this.Decoder_label_Output);
            this.Decoder.Controls.Add(this.Decoder_label_Input);
            this.Decoder.Controls.Add(this.Decoder_textBox_Input);
            this.Decoder.Controls.Add(this.Decoder_button_Convert);
            this.Decoder.Location = new System.Drawing.Point(4, 24);
            this.Decoder.Name = "Decoder";
            this.Decoder.Padding = new System.Windows.Forms.Padding(3);
            this.Decoder.Size = new System.Drawing.Size(576, 333);
            this.Decoder.TabIndex = 1;
            this.Decoder.Text = "Decoder";
            this.Decoder.UseVisualStyleBackColor = true;
            // 
            // Decoder_button_Copy
            // 
            this.Decoder_button_Copy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Decoder_button_Copy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Decoder_button_Copy.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Decoder_button_Copy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Decoder_button_Copy.Location = new System.Drawing.Point(24, 197);
            this.Decoder_button_Copy.Name = "Decoder_button_Copy";
            this.Decoder_button_Copy.Size = new System.Drawing.Size(25, 25);
            this.Decoder_button_Copy.TabIndex = 12;
            this.Decoder_button_Copy.Text = "⎘";
            this.Decoder_button_Copy.UseVisualStyleBackColor = true;
            this.Decoder_button_Copy.Visible = false;
            this.Decoder_button_Copy.Click += new System.EventHandler(this.Decoder_button_Copy_Click);
            this.Decoder_button_Copy.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Decoder_button_Copy.MouseHover += new System.EventHandler(this.Decoder_button_Copy_MouseHover);
            // 
            // Decoder_button_Settings
            // 
            this.Decoder_button_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Decoder_button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Decoder_button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Decoder_button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Decoder_button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Decoder_button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decoder_button_Settings.Image = global::Morseapp_WinForms.Properties.Resources.settings_24;
            this.Decoder_button_Settings.Location = new System.Drawing.Point(548, 286);
            this.Decoder_button_Settings.Name = "Decoder_button_Settings";
            this.Decoder_button_Settings.Size = new System.Drawing.Size(27, 27);
            this.Decoder_button_Settings.TabIndex = 11;
            this.Decoder_button_Settings.UseVisualStyleBackColor = true;
            this.Decoder_button_Settings.Click += new System.EventHandler(this.Decoder_button_Settings_Click);
            // 
            // Decoder_label_Tip
            // 
            this.Decoder_label_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Decoder_label_Tip.AutoSize = true;
            this.Decoder_label_Tip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Decoder_label_Tip.Cursor = System.Windows.Forms.Cursors.Help;
            this.Decoder_label_Tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decoder_label_Tip.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Decoder_label_Tip.Location = new System.Drawing.Point(420, 10);
            this.Decoder_label_Tip.Name = "Decoder_label_Tip";
            this.Decoder_label_Tip.Size = new System.Drawing.Size(144, 36);
            this.Decoder_label_Tip.TabIndex = 10;
            this.Decoder_label_Tip.Text = "... --- ... → SOS";
            this.Decoder_label_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Decoder_textBox_Output
            // 
            this.Decoder_textBox_Output.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Decoder_textBox_Output.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Decoder_textBox_Output.Location = new System.Drawing.Point(25, 173);
            this.Decoder_textBox_Output.Name = "Decoder_textBox_Output";
            this.Decoder_textBox_Output.ReadOnly = true;
            this.Decoder_textBox_Output.Size = new System.Drawing.Size(250, 23);
            this.Decoder_textBox_Output.TabIndex = 9;
            this.Decoder_textBox_Output.TextChanged += new System.EventHandler(this.Decoder_textBox_Output_TextChanged);
            this.Decoder_textBox_Output.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Decoder_textBox_Output_KeyDown);
            this.Decoder_textBox_Output.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Decoder_textBox_Output.MouseHover += new System.EventHandler(this.Decoder_textBox_Output_MouseHover);
            // 
            // Decoder_label_Output
            // 
            this.Decoder_label_Output.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Decoder_label_Output.AutoSize = true;
            this.Decoder_label_Output.Location = new System.Drawing.Point(25, 155);
            this.Decoder_label_Output.Name = "Decoder_label_Output";
            this.Decoder_label_Output.Size = new System.Drawing.Size(42, 15);
            this.Decoder_label_Output.TabIndex = 8;
            this.Decoder_label_Output.Text = "Result:";
            // 
            // Decoder_label_Input
            // 
            this.Decoder_label_Input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Decoder_label_Input.AutoSize = true;
            this.Decoder_label_Input.Location = new System.Drawing.Point(25, 42);
            this.Decoder_label_Input.Name = "Decoder_label_Input";
            this.Decoder_label_Input.Size = new System.Drawing.Size(103, 15);
            this.Decoder_label_Input.TabIndex = 7;
            this.Decoder_label_Input.Text = "Input Morse code:";
            // 
            // Decoder_textBox_Input
            // 
            this.Decoder_textBox_Input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Decoder_textBox_Input.Location = new System.Drawing.Point(25, 60);
            this.Decoder_textBox_Input.Name = "Decoder_textBox_Input";
            this.Decoder_textBox_Input.Size = new System.Drawing.Size(250, 23);
            this.Decoder_textBox_Input.TabIndex = 6;
            this.Decoder_textBox_Input.TextChanged += new System.EventHandler(this.Decoder_textBox_Input_TextChanged);
            this.Decoder_textBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Decoder_textBox_Input_KeyDown);
            this.Decoder_textBox_Input.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Decoder_textBox_Input.MouseHover += new System.EventHandler(this.Decoder_textBox_Input_MouseHover);
            // 
            // Decoder_button_Convert
            // 
            this.Decoder_button_Convert.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Decoder_button_Convert.Location = new System.Drawing.Point(113, 113);
            this.Decoder_button_Convert.Name = "Decoder_button_Convert";
            this.Decoder_button_Convert.Size = new System.Drawing.Size(75, 30);
            this.Decoder_button_Convert.TabIndex = 5;
            this.Decoder_button_Convert.Text = "Convert";
            this.Decoder_button_Convert.UseVisualStyleBackColor = true;
            this.Decoder_button_Convert.Click += new System.EventHandler(this.Decoder_button_Convert_Click);
            this.Decoder_button_Convert.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Decoder_button_Convert.MouseHover += new System.EventHandler(this.Decoder_button_Convert_MouseHover);
            // 
            // Player
            // 
            this.Player.Controls.Add(this.Player_button_StopSound);
            this.Player.Controls.Add(this.Player_button_Settings);
            this.Player.Controls.Add(this.Player_label_Tip);
            this.Player.Controls.Add(this.Player_button_Play);
            this.Player.Controls.Add(this.Player_label_Input);
            this.Player.Controls.Add(this.Player_textBox_Input);
            this.Player.Location = new System.Drawing.Point(4, 24);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(576, 333);
            this.Player.TabIndex = 2;
            this.Player.Text = "Player";
            this.Player.UseVisualStyleBackColor = true;
            // 
            // Player_button_StopSound
            // 
            this.Player_button_StopSound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player_button_StopSound.Location = new System.Drawing.Point(138, 149);
            this.Player_button_StopSound.Name = "Player_button_StopSound";
            this.Player_button_StopSound.Size = new System.Drawing.Size(25, 25);
            this.Player_button_StopSound.TabIndex = 13;
            this.Player_button_StopSound.Text = "■";
            this.Player_button_StopSound.UseVisualStyleBackColor = true;
            this.Player_button_StopSound.Visible = false;
            this.Player_button_StopSound.Click += new System.EventHandler(this.Player_button_StopSound_Click);
            this.Player_button_StopSound.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Player_button_StopSound.MouseHover += new System.EventHandler(this.Button_StopSound_MouseHover);
            // 
            // Player_button_Settings
            // 
            this.Player_button_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Player_button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Player_button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Player_button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Player_button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_button_Settings.Image = global::Morseapp_WinForms.Properties.Resources.settings_24;
            this.Player_button_Settings.Location = new System.Drawing.Point(548, 286);
            this.Player_button_Settings.Name = "Player_button_Settings";
            this.Player_button_Settings.Size = new System.Drawing.Size(27, 27);
            this.Player_button_Settings.TabIndex = 12;
            this.Player_button_Settings.UseVisualStyleBackColor = true;
            this.Player_button_Settings.Click += new System.EventHandler(this.Player_button_Settings_Click);
            // 
            // Player_label_Tip
            // 
            this.Player_label_Tip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Player_label_Tip.AutoSize = true;
            this.Player_label_Tip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player_label_Tip.Cursor = System.Windows.Forms.Cursors.Help;
            this.Player_label_Tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_label_Tip.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Player_label_Tip.Location = new System.Drawing.Point(329, 10);
            this.Player_label_Tip.Name = "Player_label_Tip";
            this.Player_label_Tip.Size = new System.Drawing.Size(235, 36);
            this.Player_label_Tip.TabIndex = 11;
            this.Player_label_Tip.Text = "... --- ... → ♪♪♪ ♫♫♫ ♪♪♪";
            this.Player_label_Tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Player_button_Play
            // 
            this.Player_button_Play.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player_button_Play.Location = new System.Drawing.Point(113, 113);
            this.Player_button_Play.Name = "Player_button_Play";
            this.Player_button_Play.Size = new System.Drawing.Size(75, 30);
            this.Player_button_Play.TabIndex = 10;
            this.Player_button_Play.Text = "▶️";
            this.Player_button_Play.UseVisualStyleBackColor = true;
            this.Player_button_Play.Click += new System.EventHandler(this.Button_PlaySound_Click);
            this.Player_button_Play.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Player_button_Play.MouseHover += new System.EventHandler(this.Player_button_Play_MouseHover);
            // 
            // Player_label_Input
            // 
            this.Player_label_Input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player_label_Input.AutoSize = true;
            this.Player_label_Input.Location = new System.Drawing.Point(25, 42);
            this.Player_label_Input.Name = "Player_label_Input";
            this.Player_label_Input.Size = new System.Drawing.Size(103, 15);
            this.Player_label_Input.TabIndex = 9;
            this.Player_label_Input.Text = "Input Morse code:";
            // 
            // Player_textBox_Input
            // 
            this.Player_textBox_Input.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Player_textBox_Input.Location = new System.Drawing.Point(25, 60);
            this.Player_textBox_Input.Name = "Player_textBox_Input";
            this.Player_textBox_Input.Size = new System.Drawing.Size(250, 23);
            this.Player_textBox_Input.TabIndex = 8;
            this.Player_textBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Player_textBox_Input_KeyDown);
            this.Player_textBox_Input.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Player_textBox_Input.MouseHover += new System.EventHandler(this.Player_textBox_Input_MouseHover);
            // 
            // Dictionary
            // 
            this.Dictionary.Controls.Add(this.ShowDict_button_Copy);
            this.Dictionary.Controls.Add(this.ShowDict_button_Refresh);
            this.Dictionary.Controls.Add(this.ShowDict_richtextBox_Output);
            this.Dictionary.Location = new System.Drawing.Point(4, 24);
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.Size = new System.Drawing.Size(576, 333);
            this.Dictionary.TabIndex = 3;
            this.Dictionary.Text = "Dictionary";
            this.Dictionary.UseVisualStyleBackColor = true;
            this.Dictionary.HandleCreated += new System.EventHandler(this.Dictionary_HandleCreated);
            // 
            // ShowDict_button_Copy
            // 
            this.ShowDict_button_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowDict_button_Copy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ShowDict_button_Copy.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowDict_button_Copy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ShowDict_button_Copy.Location = new System.Drawing.Point(523, 288);
            this.ShowDict_button_Copy.Name = "ShowDict_button_Copy";
            this.ShowDict_button_Copy.Size = new System.Drawing.Size(25, 25);
            this.ShowDict_button_Copy.TabIndex = 13;
            this.ShowDict_button_Copy.Text = "⎘";
            this.ShowDict_button_Copy.UseVisualStyleBackColor = true;
            this.ShowDict_button_Copy.Click += new System.EventHandler(this.ShowDict_button_Copy_Click);
            this.ShowDict_button_Copy.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.ShowDict_button_Copy.MouseHover += new System.EventHandler(this.ShowDict_button_Copy_MouseHover);
            // 
            // ShowDict_button_Refresh
            // 
            this.ShowDict_button_Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowDict_button_Refresh.Location = new System.Drawing.Point(547, 288);
            this.ShowDict_button_Refresh.Name = "ShowDict_button_Refresh";
            this.ShowDict_button_Refresh.Size = new System.Drawing.Size(25, 25);
            this.ShowDict_button_Refresh.TabIndex = 1;
            this.ShowDict_button_Refresh.Text = "↻";
            this.ShowDict_button_Refresh.UseVisualStyleBackColor = true;
            this.ShowDict_button_Refresh.Click += new System.EventHandler(this.ShowDict_button_Refresh_Click);
            this.ShowDict_button_Refresh.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.ShowDict_button_Refresh.MouseHover += new System.EventHandler(this.ShowDict_button_Refresh_MouseHover);
            // 
            // ShowDict_richtextBox_Output
            // 
            this.ShowDict_richtextBox_Output.BackColor = System.Drawing.Color.Beige;
            this.ShowDict_richtextBox_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowDict_richtextBox_Output.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShowDict_richtextBox_Output.Location = new System.Drawing.Point(0, 0);
            this.ShowDict_richtextBox_Output.Name = "ShowDict_richtextBox_Output";
            this.ShowDict_richtextBox_Output.ReadOnly = true;
            this.ShowDict_richtextBox_Output.Size = new System.Drawing.Size(576, 333);
            this.ShowDict_richtextBox_Output.TabIndex = 0;
            this.ShowDict_richtextBox_Output.Text = "";
            this.ShowDict_richtextBox_Output.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.ShowDict_richtextBox_Output.MouseHover += new System.EventHandler(this.ShowDict_richtextBox_Output_MouseHover);
            // 
            // Configuration
            // 
            this.Configuration.BackColor = System.Drawing.SystemColors.Control;
            this.Configuration.Controls.Add(this.Config_groupBox_App);
            this.Configuration.Controls.Add(this.Config_groupBox_Player);
            this.Configuration.Location = new System.Drawing.Point(4, 24);
            this.Configuration.Name = "Configuration";
            this.Configuration.Size = new System.Drawing.Size(576, 333);
            this.Configuration.TabIndex = 4;
            this.Configuration.Text = "Configuration";
            // 
            // Config_groupBox_App
            // 
            this.Config_groupBox_App.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Config_groupBox_App.Controls.Add(this.Config_App_button_Updates);
            this.Config_groupBox_App.Controls.Add(this.Config_App_label_Jokes);
            this.Config_groupBox_App.Controls.Add(this.Config_App_comboBox_Jokes);
            this.Config_groupBox_App.Controls.Add(this.Config_App_button_About);
            this.Config_groupBox_App.Controls.Add(this.Config_App_pictureBox_Icon);
            this.Config_groupBox_App.Controls.Add(this.Config_App_checkBox_JokesOption);
            this.Config_groupBox_App.Controls.Add(this.Config_App_label_LangChanged);
            this.Config_groupBox_App.Controls.Add(this.Config_App_linkLabel_LangChanged);
            this.Config_groupBox_App.Controls.Add(this.Config_App_checkBox_Dynamic);
            this.Config_groupBox_App.Controls.Add(this.Config_App_label_Lang);
            this.Config_groupBox_App.Controls.Add(this.Config_App_comboBox_Lang);
            this.Config_groupBox_App.Location = new System.Drawing.Point(11, 3);
            this.Config_groupBox_App.Name = "Config_groupBox_App";
            this.Config_groupBox_App.Size = new System.Drawing.Size(555, 198);
            this.Config_groupBox_App.TabIndex = 1;
            this.Config_groupBox_App.TabStop = false;
            this.Config_groupBox_App.Text = " Application settings";
            // 
            // Config_App_button_Updates
            // 
            this.Config_App_button_Updates.AutoSize = true;
            this.Config_App_button_Updates.Location = new System.Drawing.Point(6, 162);
            this.Config_App_button_Updates.Name = "Config_App_button_Updates";
            this.Config_App_button_Updates.Size = new System.Drawing.Size(114, 30);
            this.Config_App_button_Updates.TabIndex = 13;
            this.Config_App_button_Updates.Text = "Check for updates";
            this.Config_App_button_Updates.UseVisualStyleBackColor = true;
            this.Config_App_button_Updates.Click += new System.EventHandler(this.Config_App_button_Updates_Click);
            this.Config_App_button_Updates.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_button_Updates.MouseHover += new System.EventHandler(this.Config_App_button_Updates_MouseHover);
            // 
            // Config_App_label_Jokes
            // 
            this.Config_App_label_Jokes.AutoSize = true;
            this.Config_App_label_Jokes.Location = new System.Drawing.Point(58, 97);
            this.Config_App_label_Jokes.Name = "Config_App_label_Jokes";
            this.Config_App_label_Jokes.Size = new System.Drawing.Size(85, 15);
            this.Config_App_label_Jokes.TabIndex = 12;
            this.Config_App_label_Jokes.Text = "Jokes provider:";
            // 
            // Config_App_comboBox_Jokes
            // 
            this.Config_App_comboBox_Jokes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Config_App_comboBox_Jokes.FormattingEnabled = true;
            this.Config_App_comboBox_Jokes.Items.AddRange(new object[] {
            "JokeAPI",
            "Chuck Norris",
            "Official Joke API"});
            this.Config_App_comboBox_Jokes.Location = new System.Drawing.Point(58, 115);
            this.Config_App_comboBox_Jokes.Name = "Config_App_comboBox_Jokes";
            this.Config_App_comboBox_Jokes.Size = new System.Drawing.Size(121, 23);
            this.Config_App_comboBox_Jokes.TabIndex = 0;
            this.Config_App_comboBox_Jokes.SelectedValueChanged += new System.EventHandler(this.Config_App_comboBox_Jokes_SelectedValueChanged);
            this.Config_App_comboBox_Jokes.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_comboBox_Jokes.MouseHover += new System.EventHandler(this.Config_App_comboBox_Jokes_MouseHover);
            // 
            // Config_App_button_About
            // 
            this.Config_App_button_About.AutoSize = true;
            this.Config_App_button_About.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Config_App_button_About.Image = global::Morseapp_WinForms.Properties.Resources.info_16;
            this.Config_App_button_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Config_App_button_About.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Config_App_button_About.Location = new System.Drawing.Point(469, 162);
            this.Config_App_button_About.Name = "Config_App_button_About";
            this.Config_App_button_About.Size = new System.Drawing.Size(75, 30);
            this.Config_App_button_About.TabIndex = 9;
            this.Config_App_button_About.Text = "About...";
            this.Config_App_button_About.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Config_App_button_About.UseVisualStyleBackColor = true;
            this.Config_App_button_About.Click += new System.EventHandler(this.Config_App_button_About_Click);
            this.Config_App_button_About.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_button_About.MouseHover += new System.EventHandler(this.Config_App_button_About_MouseHover);
            // 
            // Config_App_pictureBox_Icon
            // 
            this.Config_App_pictureBox_Icon.Image = global::Morseapp_WinForms.Properties.Resources.app_settings_40;
            this.Config_App_pictureBox_Icon.Location = new System.Drawing.Point(6, 26);
            this.Config_App_pictureBox_Icon.Name = "Config_App_pictureBox_Icon";
            this.Config_App_pictureBox_Icon.Size = new System.Drawing.Size(40, 40);
            this.Config_App_pictureBox_Icon.TabIndex = 14;
            this.Config_App_pictureBox_Icon.TabStop = false;
            // 
            // Config_App_checkBox_JokesOption
            // 
            this.Config_App_checkBox_JokesOption.AutoSize = true;
            this.Config_App_checkBox_JokesOption.Checked = true;
            this.Config_App_checkBox_JokesOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Config_App_checkBox_JokesOption.Location = new System.Drawing.Point(208, 115);
            this.Config_App_checkBox_JokesOption.Name = "Config_App_checkBox_JokesOption";
            this.Config_App_checkBox_JokesOption.Size = new System.Drawing.Size(127, 19);
            this.Config_App_checkBox_JokesOption.TabIndex = 14;
            this.Config_App_checkBox_JokesOption.Text = "Allow explicit jokes";
            this.Config_App_checkBox_JokesOption.UseVisualStyleBackColor = true;
            this.Config_App_checkBox_JokesOption.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_checkBox_JokesOption.MouseHover += new System.EventHandler(this.Config_App_checkBox_JokesOption_MouseHover);
            // 
            // Config_App_label_LangChanged
            // 
            this.Config_App_label_LangChanged.AutoSize = true;
            this.Config_App_label_LangChanged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Config_App_label_LangChanged.Location = new System.Drawing.Point(58, 71);
            this.Config_App_label_LangChanged.Name = "Config_App_label_LangChanged";
            this.Config_App_label_LangChanged.Size = new System.Drawing.Size(374, 15);
            this.Config_App_label_LangChanged.TabIndex = 5;
            this.Config_App_label_LangChanged.Text = "For language changes to take effect, you need to restart this program.";
            this.Config_App_label_LangChanged.Visible = false;
            // 
            // Config_App_linkLabel_LangChanged
            // 
            this.Config_App_linkLabel_LangChanged.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            this.Config_App_linkLabel_LangChanged.AutoSize = true;
            this.Config_App_linkLabel_LangChanged.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Config_App_linkLabel_LangChanged.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Config_App_linkLabel_LangChanged.LinkColor = System.Drawing.SystemColors.Highlight;
            this.Config_App_linkLabel_LangChanged.Location = new System.Drawing.Point(433, 71);
            this.Config_App_linkLabel_LangChanged.Name = "Config_App_linkLabel_LangChanged";
            this.Config_App_linkLabel_LangChanged.Size = new System.Drawing.Size(78, 15);
            this.Config_App_linkLabel_LangChanged.TabIndex = 4;
            this.Config_App_linkLabel_LangChanged.TabStop = true;
            this.Config_App_linkLabel_LangChanged.Text = "Restart now.";
            this.Config_App_linkLabel_LangChanged.Visible = false;
            this.Config_App_linkLabel_LangChanged.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Config_App_linkLabel_LangChanged_LinkClicked);
            // 
            // Config_App_checkBox_Dynamic
            // 
            this.Config_App_checkBox_Dynamic.AutoSize = true;
            this.Config_App_checkBox_Dynamic.Checked = true;
            this.Config_App_checkBox_Dynamic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Config_App_checkBox_Dynamic.Location = new System.Drawing.Point(208, 44);
            this.Config_App_checkBox_Dynamic.Name = "Config_App_checkBox_Dynamic";
            this.Config_App_checkBox_Dynamic.Size = new System.Drawing.Size(134, 19);
            this.Config_App_checkBox_Dynamic.TabIndex = 1;
            this.Config_App_checkBox_Dynamic.Text = "Dynamic conversion";
            this.Config_App_checkBox_Dynamic.UseVisualStyleBackColor = true;
            this.Config_App_checkBox_Dynamic.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_checkBox_Dynamic.MouseHover += new System.EventHandler(this.Config_App_checkBox_Dynamic_MouseHover);
            // 
            // Config_App_label_Lang
            // 
            this.Config_App_label_Lang.AutoSize = true;
            this.Config_App_label_Lang.Location = new System.Drawing.Point(58, 26);
            this.Config_App_label_Lang.Name = "Config_App_label_Lang";
            this.Config_App_label_Lang.Size = new System.Drawing.Size(62, 15);
            this.Config_App_label_Lang.TabIndex = 0;
            this.Config_App_label_Lang.Text = "Language:";
            // 
            // Config_App_comboBox_Lang
            // 
            this.Config_App_comboBox_Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Config_App_comboBox_Lang.FormattingEnabled = true;
            this.Config_App_comboBox_Lang.Items.AddRange(new object[] {
            "English (default)",
            "Czech"});
            this.Config_App_comboBox_Lang.Location = new System.Drawing.Point(59, 44);
            this.Config_App_comboBox_Lang.Name = "Config_App_comboBox_Lang";
            this.Config_App_comboBox_Lang.Size = new System.Drawing.Size(120, 23);
            this.Config_App_comboBox_Lang.TabIndex = 0;
            this.Config_App_comboBox_Lang.SelectionChangeCommitted += new System.EventHandler(this.Config_App_comboBox_Lang_SelectionChangeCommitted);
            this.Config_App_comboBox_Lang.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_comboBox_Lang.MouseHover += new System.EventHandler(this.Config_App_comboBox_Lang_MouseHover);
            // 
            // Config_groupBox_Player
            // 
            this.Config_groupBox_Player.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_pictureBox_Icon);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_label_CurrentFreq);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_label_CurrentSpeed);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_label_Freq);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_trackBar_Freq);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_label_Speed);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_checkBox_StrictTiming);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_trackBar_Speed);
            this.Config_groupBox_Player.Location = new System.Drawing.Point(11, 207);
            this.Config_groupBox_Player.Name = "Config_groupBox_Player";
            this.Config_groupBox_Player.Size = new System.Drawing.Size(555, 105);
            this.Config_groupBox_Player.TabIndex = 0;
            this.Config_groupBox_Player.TabStop = false;
            this.Config_groupBox_Player.Text = "Player settings";
            // 
            // Config_Player_pictureBox_Icon
            // 
            this.Config_Player_pictureBox_Icon.Image = global::Morseapp_WinForms.Properties.Resources.player_40;
            this.Config_Player_pictureBox_Icon.Location = new System.Drawing.Point(6, 22);
            this.Config_Player_pictureBox_Icon.Name = "Config_Player_pictureBox_Icon";
            this.Config_Player_pictureBox_Icon.Size = new System.Drawing.Size(40, 40);
            this.Config_Player_pictureBox_Icon.TabIndex = 0;
            this.Config_Player_pictureBox_Icon.TabStop = false;
            // 
            // Config_Player_label_CurrentFreq
            // 
            this.Config_Player_label_CurrentFreq.AutoSize = true;
            this.Config_Player_label_CurrentFreq.Location = new System.Drawing.Point(357, 84);
            this.Config_Player_label_CurrentFreq.Name = "Config_Player_label_CurrentFreq";
            this.Config_Player_label_CurrentFreq.Size = new System.Drawing.Size(70, 15);
            this.Config_Player_label_CurrentFreq.TabIndex = 6;
            this.Config_Player_label_CurrentFreq.Text = "CurrentFreq";
            // 
            // Config_Player_label_CurrentSpeed
            // 
            this.Config_Player_label_CurrentSpeed.AutoSize = true;
            this.Config_Player_label_CurrentSpeed.Location = new System.Drawing.Point(59, 84);
            this.Config_Player_label_CurrentSpeed.Name = "Config_Player_label_CurrentSpeed";
            this.Config_Player_label_CurrentSpeed.Size = new System.Drawing.Size(79, 15);
            this.Config_Player_label_CurrentSpeed.TabIndex = 5;
            this.Config_Player_label_CurrentSpeed.Text = "CurrentSpeed";
            // 
            // Config_Player_label_Freq
            // 
            this.Config_Player_label_Freq.AutoSize = true;
            this.Config_Player_label_Freq.Location = new System.Drawing.Point(357, 23);
            this.Config_Player_label_Freq.Name = "Config_Player_label_Freq";
            this.Config_Player_label_Freq.Size = new System.Drawing.Size(100, 15);
            this.Config_Player_label_Freq.TabIndex = 4;
            this.Config_Player_label_Freq.Text = "Sound frequency:";
            // 
            // Config_Player_trackBar_Freq
            // 
            this.Config_Player_trackBar_Freq.LargeChange = 250;
            this.Config_Player_trackBar_Freq.Location = new System.Drawing.Point(356, 43);
            this.Config_Player_trackBar_Freq.Maximum = 1000;
            this.Config_Player_trackBar_Freq.Minimum = 100;
            this.Config_Player_trackBar_Freq.Name = "Config_Player_trackBar_Freq";
            this.Config_Player_trackBar_Freq.Size = new System.Drawing.Size(110, 45);
            this.Config_Player_trackBar_Freq.SmallChange = 100;
            this.Config_Player_trackBar_Freq.TabIndex = 3;
            this.Config_Player_trackBar_Freq.TickFrequency = 100;
            this.Config_Player_trackBar_Freq.Value = 500;
            this.Config_Player_trackBar_Freq.ValueChanged += new System.EventHandler(this.Config_Player_trackBar_Freq_ValueChanged);
            this.Config_Player_trackBar_Freq.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_Player_trackBar_Freq.MouseHover += new System.EventHandler(this.Config_Player_trackBar_Freq_MouseHover);
            // 
            // Config_Player_label_Speed
            // 
            this.Config_Player_label_Speed.AutoSize = true;
            this.Config_Player_label_Speed.Location = new System.Drawing.Point(59, 25);
            this.Config_Player_label_Speed.Name = "Config_Player_label_Speed";
            this.Config_Player_label_Speed.Size = new System.Drawing.Size(91, 15);
            this.Config_Player_label_Speed.TabIndex = 2;
            this.Config_Player_label_Speed.Text = "Playback speed:";
            // 
            // Config_Player_checkBox_StrictTiming
            // 
            this.Config_Player_checkBox_StrictTiming.AutoSize = true;
            this.Config_Player_checkBox_StrictTiming.Location = new System.Drawing.Point(208, 43);
            this.Config_Player_checkBox_StrictTiming.Name = "Config_Player_checkBox_StrictTiming";
            this.Config_Player_checkBox_StrictTiming.Size = new System.Drawing.Size(91, 19);
            this.Config_Player_checkBox_StrictTiming.TabIndex = 1;
            this.Config_Player_checkBox_StrictTiming.Text = "Strict timing";
            this.Config_Player_checkBox_StrictTiming.UseVisualStyleBackColor = true;
            this.Config_Player_checkBox_StrictTiming.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_Player_checkBox_StrictTiming.MouseHover += new System.EventHandler(this.Config_Player_StrictTiming_MouseHover);
            // 
            // Config_Player_trackBar_Speed
            // 
            this.Config_Player_trackBar_Speed.LargeChange = 150;
            this.Config_Player_trackBar_Speed.Location = new System.Drawing.Point(59, 43);
            this.Config_Player_trackBar_Speed.Maximum = 500;
            this.Config_Player_trackBar_Speed.Minimum = 50;
            this.Config_Player_trackBar_Speed.Name = "Config_Player_trackBar_Speed";
            this.Config_Player_trackBar_Speed.Size = new System.Drawing.Size(110, 45);
            this.Config_Player_trackBar_Speed.SmallChange = 50;
            this.Config_Player_trackBar_Speed.TabIndex = 0;
            this.Config_Player_trackBar_Speed.TickFrequency = 50;
            this.Config_Player_trackBar_Speed.Value = 250;
            this.Config_Player_trackBar_Speed.ValueChanged += new System.EventHandler(this.Config_Player_trackBar_Speed_ValueChanged);
            this.Config_Player_trackBar_Speed.Leave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_Player_trackBar_Speed.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_Player_trackBar_Speed.MouseHover += new System.EventHandler(this.Config_Player_trackBar_Speed_MouseHover);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.statusStrip.Location = new System.Drawing.Point(0, 339);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(584, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.AutoSize = false;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(480, 17);
            this.toolStripStatusLabel.Text = "Hover over items for more details";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 250;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 250;
            this.toolTip.IsBalloon = true;
            this.toolTip.ReshowDelay = 50;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl_Main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Morse Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.tabControl_Main.ResumeLayout(false);
            this.Coder.ResumeLayout(false);
            this.Coder.PerformLayout();
            this.Decoder.ResumeLayout(false);
            this.Decoder.PerformLayout();
            this.Player.ResumeLayout(false);
            this.Player.PerformLayout();
            this.Dictionary.ResumeLayout(false);
            this.Configuration.ResumeLayout(false);
            this.Config_groupBox_App.ResumeLayout(false);
            this.Config_groupBox_App.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Config_App_pictureBox_Icon)).EndInit();
            this.Config_groupBox_Player.ResumeLayout(false);
            this.Config_groupBox_Player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Config_Player_pictureBox_Icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config_Player_trackBar_Freq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Config_Player_trackBar_Speed)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage Coder;
        private System.Windows.Forms.TabPage Decoder;
        private System.Windows.Forms.TabPage Player;
        private System.Windows.Forms.TabPage Dictionary;
        private System.Windows.Forms.Button Coder_button_Convert;
        private System.Windows.Forms.TextBox Coder_textBox_Input;
        private System.Windows.Forms.Label Coder_label_Input;
        private System.Windows.Forms.TextBox Coder_textBox_Output;
        private System.Windows.Forms.Label Coder_label_Output;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.TextBox Decoder_textBox_Output;
        private System.Windows.Forms.Label Decoder_label_Output;
        private System.Windows.Forms.Label Decoder_label_Input;
        private System.Windows.Forms.TextBox Decoder_textBox_Input;
        private System.Windows.Forms.Button Decoder_button_Convert;
        private System.Windows.Forms.Label Coder_label_Tip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label Decoder_label_Tip;
        private System.Windows.Forms.GroupBox Config_groupBox_Player;
        private System.Windows.Forms.GroupBox Config_groupBox_App;
        private System.Windows.Forms.TrackBar Config_Player_trackBar_Speed;
        private System.Windows.Forms.Button Coder_button_PlaySound;
        private System.Windows.Forms.CheckBox Config_Player_checkBox_StrictTiming;
        private System.Windows.Forms.Button Player_button_Play;
        private System.Windows.Forms.Label Player_label_Input;
        private System.Windows.Forms.TextBox Player_textBox_Input;
        private System.Windows.Forms.RichTextBox ShowDict_richtextBox_Output;
        private System.Windows.Forms.Label Config_App_label_Lang;
        private System.Windows.Forms.Label Config_Player_label_Speed;
        private System.Windows.Forms.CheckBox Config_App_checkBox_Dynamic;
        private System.Windows.Forms.Label Player_label_Tip;
        private System.Windows.Forms.Label Config_Player_label_Freq;
        private System.Windows.Forms.TrackBar Config_Player_trackBar_Freq;
        private System.Windows.Forms.Label Config_Player_label_CurrentSpeed;
        private System.Windows.Forms.Label Config_Player_label_CurrentFreq;
        private System.Windows.Forms.Button ShowDict_button_Refresh;
        private System.Windows.Forms.LinkLabel Config_App_linkLabel_LangChanged;
        private System.Windows.Forms.Label Config_App_label_LangChanged;
        private System.Windows.Forms.Button Coder_button_Settings;
        private System.Windows.Forms.Button Coder_button_Joke;
        private System.Windows.Forms.CheckBox Config_App_checkBox_JokesOption;
        private System.Windows.Forms.Button Coder_button_StopSound;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.PictureBox Config_App_pictureBox_Icon;
        private System.Windows.Forms.PictureBox Config_Player_pictureBox_Icon;
        private System.Windows.Forms.Button Decoder_button_Settings;
        private System.Windows.Forms.Button Player_button_Settings;
        private System.Windows.Forms.Button Player_button_StopSound;
        private System.Windows.Forms.Button Config_App_button_About;
        private System.Windows.Forms.Button Coder_button_Copy;
        private System.Windows.Forms.Button Decoder_button_Copy;
        private System.Windows.Forms.Button ShowDict_button_Copy;
        private System.Windows.Forms.ComboBox Config_App_comboBox_Jokes;
        private System.Windows.Forms.Label Config_App_label_Jokes;
        private System.Windows.Forms.Button Config_App_button_Updates;
        public System.Windows.Forms.ComboBox Config_App_comboBox_Lang;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        public System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Updater;
    }
}

