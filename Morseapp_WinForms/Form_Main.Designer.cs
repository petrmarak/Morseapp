
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
            this.Coder_button_while = new System.Windows.Forms.Button();
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
            this.Config_App_linkLabel_GitHubPage = new System.Windows.Forms.LinkLabel();
            this.Config_App_label_GitHub = new System.Windows.Forms.Label();
            this.Config_App_button_About = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Config_App_checkBox_JokeOption = new System.Windows.Forms.CheckBox();
            this.Config_App_label_LangChanged = new System.Windows.Forms.Label();
            this.Config_App_linkLabel_LangChanged = new System.Windows.Forms.LinkLabel();
            this.Config_App_checkBox_Dynamic = new System.Windows.Forms.CheckBox();
            this.Config_App_label_Lang = new System.Windows.Forms.Label();
            this.Config_App_comboBox_Lang = new System.Windows.Forms.ComboBox();
            this.Config_groupBox_Player = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Config_groupBox_Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            resources.ApplyResources(this.tabControl_Main, "tabControl_Main");
            this.tabControl_Main.Multiline = true;
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.SelectedIndexChanged += new System.EventHandler(this.TabControl_Main_SelectedIndexChanged);
            // 
            // Coder
            // 
            this.Coder.AllowDrop = true;
            this.Coder.Controls.Add(this.Coder_button_while);
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
            resources.ApplyResources(this.Coder, "Coder");
            this.Coder.Name = "Coder";
            this.Coder.UseVisualStyleBackColor = true;
            // 
            // Coder_button_while
            // 
            resources.ApplyResources(this.Coder_button_while, "Coder_button_while");
            this.Coder_button_while.Name = "Coder_button_while";
            this.Coder_button_while.UseVisualStyleBackColor = true;
            this.Coder_button_while.Click += new System.EventHandler(this.Coder_button_while_Click);
            // 
            // Coder_button_Copy
            // 
            resources.ApplyResources(this.Coder_button_Copy, "Coder_button_Copy");
            this.Coder_button_Copy.Name = "Coder_button_Copy";
            this.Coder_button_Copy.UseVisualStyleBackColor = true;
            this.Coder_button_Copy.Click += new System.EventHandler(this.Coder_button_Copy_Click);
            this.Coder_button_Copy.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_Copy.MouseHover += new System.EventHandler(this.Coder_button_Copy_MouseHover);
            // 
            // Coder_button_StopSound
            // 
            resources.ApplyResources(this.Coder_button_StopSound, "Coder_button_StopSound");
            this.Coder_button_StopSound.Name = "Coder_button_StopSound";
            this.Coder_button_StopSound.UseVisualStyleBackColor = true;
            this.Coder_button_StopSound.Click += new System.EventHandler(this.Coder_button_StopSound_Click);
            this.Coder_button_StopSound.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_StopSound.MouseHover += new System.EventHandler(this.Button_StopSound_MouseHover);
            // 
            // Coder_button_Joke
            // 
            resources.ApplyResources(this.Coder_button_Joke, "Coder_button_Joke");
            this.Coder_button_Joke.Name = "Coder_button_Joke";
            this.Coder_button_Joke.UseVisualStyleBackColor = true;
            this.Coder_button_Joke.Click += new System.EventHandler(this.Coder_button_Joke_Click);
            this.Coder_button_Joke.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_Joke.MouseHover += new System.EventHandler(this.Coder_button_Joke_MouseHover);
            // 
            // Coder_button_Settings
            // 
            this.Coder_button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Coder_button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Coder_button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Coder_button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Coder_button_Settings, "Coder_button_Settings");
            this.Coder_button_Settings.Image = global::Morseapp_WinForms.Properties.Resources.settings_24;
            this.Coder_button_Settings.Name = "Coder_button_Settings";
            this.toolTip.SetToolTip(this.Coder_button_Settings, resources.GetString("Coder_button_Settings.ToolTip"));
            this.Coder_button_Settings.UseVisualStyleBackColor = true;
            this.Coder_button_Settings.Click += new System.EventHandler(this.Coder_button_Settings_Click);
            // 
            // Coder_button_PlaySound
            // 
            resources.ApplyResources(this.Coder_button_PlaySound, "Coder_button_PlaySound");
            this.Coder_button_PlaySound.Name = "Coder_button_PlaySound";
            this.Coder_button_PlaySound.UseVisualStyleBackColor = true;
            this.Coder_button_PlaySound.Click += new System.EventHandler(this.Button_PlaySound_Click);
            this.Coder_button_PlaySound.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_PlaySound.MouseHover += new System.EventHandler(this.Coder_button_PlaySound_MouseHover);
            // 
            // Coder_textBox_Output
            // 
            resources.ApplyResources(this.Coder_textBox_Output, "Coder_textBox_Output");
            this.Coder_textBox_Output.Name = "Coder_textBox_Output";
            this.Coder_textBox_Output.TextChanged += new System.EventHandler(this.Coder_textBox_Output_TextChanged);
            this.Coder_textBox_Output.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coder_textBox_Output_KeyDown);
            this.Coder_textBox_Output.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_textBox_Output.MouseHover += new System.EventHandler(this.Coder_textBox_Output_MouseHover);
            // 
            // Coder_label_Output
            // 
            resources.ApplyResources(this.Coder_label_Output, "Coder_label_Output");
            this.Coder_label_Output.Name = "Coder_label_Output";
            // 
            // Coder_label_Input
            // 
            resources.ApplyResources(this.Coder_label_Input, "Coder_label_Input");
            this.Coder_label_Input.Name = "Coder_label_Input";
            // 
            // Coder_textBox_Input
            // 
            resources.ApplyResources(this.Coder_textBox_Input, "Coder_textBox_Input");
            this.Coder_textBox_Input.Name = "Coder_textBox_Input";
            this.Coder_textBox_Input.TextChanged += new System.EventHandler(this.Coder_textBox_Input_TextChanged);
            this.Coder_textBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Coder_textBox_Input_KeyDown);
            this.Coder_textBox_Input.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_textBox_Input.MouseHover += new System.EventHandler(this.Coder_textBox_Input_MouseHover);
            // 
            // Coder_button_Convert
            // 
            resources.ApplyResources(this.Coder_button_Convert, "Coder_button_Convert");
            this.Coder_button_Convert.Name = "Coder_button_Convert";
            this.Coder_button_Convert.UseVisualStyleBackColor = true;
            this.Coder_button_Convert.Click += new System.EventHandler(this.Coder_button_Convert_Click);
            this.Coder_button_Convert.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Coder_button_Convert.MouseHover += new System.EventHandler(this.Coder_button_Convert_MouseHover);
            // 
            // Coder_label_Tip
            // 
            resources.ApplyResources(this.Coder_label_Tip, "Coder_label_Tip");
            this.Coder_label_Tip.BackColor = System.Drawing.Color.Transparent;
            this.Coder_label_Tip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Coder_label_Tip.Cursor = System.Windows.Forms.Cursors.Help;
            this.Coder_label_Tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Coder_label_Tip.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Coder_label_Tip.Name = "Coder_label_Tip";
            this.Coder_label_Tip.MouseHover += new System.EventHandler(this.Coder_label_Tip_MouseHover);
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
            resources.ApplyResources(this.Decoder, "Decoder");
            this.Decoder.Name = "Decoder";
            this.Decoder.UseVisualStyleBackColor = true;
            // 
            // Decoder_button_Copy
            // 
            resources.ApplyResources(this.Decoder_button_Copy, "Decoder_button_Copy");
            this.Decoder_button_Copy.Name = "Decoder_button_Copy";
            this.Decoder_button_Copy.UseVisualStyleBackColor = true;
            this.Decoder_button_Copy.Click += new System.EventHandler(this.Decoder_button_Copy_Click);
            this.Decoder_button_Copy.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Decoder_button_Copy.MouseHover += new System.EventHandler(this.Decoder_button_Copy_MouseHover);
            // 
            // Decoder_button_Settings
            // 
            this.Decoder_button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Decoder_button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Decoder_button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Decoder_button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Decoder_button_Settings, "Decoder_button_Settings");
            this.Decoder_button_Settings.Image = global::Morseapp_WinForms.Properties.Resources.settings_24;
            this.Decoder_button_Settings.Name = "Decoder_button_Settings";
            this.toolTip.SetToolTip(this.Decoder_button_Settings, resources.GetString("Decoder_button_Settings.ToolTip"));
            this.Decoder_button_Settings.UseVisualStyleBackColor = true;
            this.Decoder_button_Settings.Click += new System.EventHandler(this.Decoder_button_Settings_Click);
            // 
            // Decoder_label_Tip
            // 
            resources.ApplyResources(this.Decoder_label_Tip, "Decoder_label_Tip");
            this.Decoder_label_Tip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Decoder_label_Tip.Cursor = System.Windows.Forms.Cursors.Help;
            this.Decoder_label_Tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Decoder_label_Tip.Name = "Decoder_label_Tip";
            this.Decoder_label_Tip.MouseHover += new System.EventHandler(this.Decoder_label_Tip_MouseHover);
            // 
            // Decoder_textBox_Output
            // 
            resources.ApplyResources(this.Decoder_textBox_Output, "Decoder_textBox_Output");
            this.Decoder_textBox_Output.Name = "Decoder_textBox_Output";
            this.Decoder_textBox_Output.TextChanged += new System.EventHandler(this.Decoder_textBox_Output_TextChanged);
            this.Decoder_textBox_Output.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Decoder_textBox_Output_KeyDown);
            this.Decoder_textBox_Output.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Decoder_textBox_Output.MouseHover += new System.EventHandler(this.Decoder_textBox_Output_MouseHover);
            // 
            // Decoder_label_Output
            // 
            resources.ApplyResources(this.Decoder_label_Output, "Decoder_label_Output");
            this.Decoder_label_Output.Name = "Decoder_label_Output";
            // 
            // Decoder_label_Input
            // 
            resources.ApplyResources(this.Decoder_label_Input, "Decoder_label_Input");
            this.Decoder_label_Input.Name = "Decoder_label_Input";
            // 
            // Decoder_textBox_Input
            // 
            resources.ApplyResources(this.Decoder_textBox_Input, "Decoder_textBox_Input");
            this.Decoder_textBox_Input.Name = "Decoder_textBox_Input";
            this.Decoder_textBox_Input.TextChanged += new System.EventHandler(this.Decoder_textBox_Input_TextChanged);
            this.Decoder_textBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Decoder_textBox_Input_KeyDown);
            this.Decoder_textBox_Input.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Decoder_textBox_Input.MouseHover += new System.EventHandler(this.Decoder_textBox_Input_MouseHover);
            // 
            // Decoder_button_Convert
            // 
            resources.ApplyResources(this.Decoder_button_Convert, "Decoder_button_Convert");
            this.Decoder_button_Convert.Name = "Decoder_button_Convert";
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
            resources.ApplyResources(this.Player, "Player");
            this.Player.Name = "Player";
            this.Player.UseVisualStyleBackColor = true;
            // 
            // Player_button_StopSound
            // 
            resources.ApplyResources(this.Player_button_StopSound, "Player_button_StopSound");
            this.Player_button_StopSound.Name = "Player_button_StopSound";
            this.Player_button_StopSound.UseVisualStyleBackColor = true;
            this.Player_button_StopSound.Click += new System.EventHandler(this.Player_button_StopSound_Click);
            this.Player_button_StopSound.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Player_button_StopSound.MouseHover += new System.EventHandler(this.Button_StopSound_MouseHover);
            // 
            // Player_button_Settings
            // 
            this.Player_button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Player_button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Player_button_Settings.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Player_button_Settings.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.Player_button_Settings, "Player_button_Settings");
            this.Player_button_Settings.Image = global::Morseapp_WinForms.Properties.Resources.settings_24;
            this.Player_button_Settings.Name = "Player_button_Settings";
            this.toolTip.SetToolTip(this.Player_button_Settings, resources.GetString("Player_button_Settings.ToolTip"));
            this.Player_button_Settings.UseVisualStyleBackColor = true;
            this.Player_button_Settings.Click += new System.EventHandler(this.Player_button_Settings_Click);
            // 
            // Player_label_Tip
            // 
            resources.ApplyResources(this.Player_label_Tip, "Player_label_Tip");
            this.Player_label_Tip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Player_label_Tip.Cursor = System.Windows.Forms.Cursors.Help;
            this.Player_label_Tip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Player_label_Tip.Name = "Player_label_Tip";
            // 
            // Player_button_Play
            // 
            resources.ApplyResources(this.Player_button_Play, "Player_button_Play");
            this.Player_button_Play.Name = "Player_button_Play";
            this.Player_button_Play.UseVisualStyleBackColor = true;
            this.Player_button_Play.Click += new System.EventHandler(this.Button_PlaySound_Click);
            this.Player_button_Play.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Player_button_Play.MouseHover += new System.EventHandler(this.Player_button_Play_MouseHover);
            // 
            // Player_label_Input
            // 
            resources.ApplyResources(this.Player_label_Input, "Player_label_Input");
            this.Player_label_Input.Name = "Player_label_Input";
            // 
            // Player_textBox_Input
            // 
            resources.ApplyResources(this.Player_textBox_Input, "Player_textBox_Input");
            this.Player_textBox_Input.Name = "Player_textBox_Input";
            this.Player_textBox_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Player_textBox_Input_KeyDown);
            this.Player_textBox_Input.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Player_textBox_Input.MouseHover += new System.EventHandler(this.Player_textBox_Input_MouseHover);
            // 
            // Dictionary
            // 
            this.Dictionary.Controls.Add(this.ShowDict_button_Copy);
            this.Dictionary.Controls.Add(this.ShowDict_button_Refresh);
            this.Dictionary.Controls.Add(this.ShowDict_richtextBox_Output);
            resources.ApplyResources(this.Dictionary, "Dictionary");
            this.Dictionary.Name = "Dictionary";
            this.Dictionary.UseVisualStyleBackColor = true;
            this.Dictionary.HandleCreated += new System.EventHandler(this.Dictionary_HandleCreated);
            // 
            // ShowDict_button_Copy
            // 
            resources.ApplyResources(this.ShowDict_button_Copy, "ShowDict_button_Copy");
            this.ShowDict_button_Copy.Name = "ShowDict_button_Copy";
            this.ShowDict_button_Copy.UseVisualStyleBackColor = true;
            this.ShowDict_button_Copy.Click += new System.EventHandler(this.ShowDict_button_Copy_Click);
            this.ShowDict_button_Copy.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.ShowDict_button_Copy.MouseHover += new System.EventHandler(this.ShowDict_button_Copy_MouseHover);
            // 
            // ShowDict_button_Refresh
            // 
            resources.ApplyResources(this.ShowDict_button_Refresh, "ShowDict_button_Refresh");
            this.ShowDict_button_Refresh.Name = "ShowDict_button_Refresh";
            this.ShowDict_button_Refresh.UseVisualStyleBackColor = true;
            this.ShowDict_button_Refresh.Click += new System.EventHandler(this.ShowDict_button_Refresh_Click);
            this.ShowDict_button_Refresh.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.ShowDict_button_Refresh.MouseHover += new System.EventHandler(this.ShowDict_button_Refresh_MouseHover);
            // 
            // ShowDict_richtextBox_Output
            // 
            this.ShowDict_richtextBox_Output.BackColor = System.Drawing.Color.Beige;
            resources.ApplyResources(this.ShowDict_richtextBox_Output, "ShowDict_richtextBox_Output");
            this.ShowDict_richtextBox_Output.Name = "ShowDict_richtextBox_Output";
            this.ShowDict_richtextBox_Output.ReadOnly = true;
            this.ShowDict_richtextBox_Output.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.ShowDict_richtextBox_Output.MouseHover += new System.EventHandler(this.ShowDict_richtextBox_Output_MouseHover);
            // 
            // Configuration
            // 
            this.Configuration.BackColor = System.Drawing.SystemColors.Control;
            this.Configuration.Controls.Add(this.Config_groupBox_App);
            this.Configuration.Controls.Add(this.Config_groupBox_Player);
            resources.ApplyResources(this.Configuration, "Configuration");
            this.Configuration.Name = "Configuration";
            // 
            // Config_groupBox_App
            // 
            this.Config_groupBox_App.Controls.Add(this.Config_App_button_Updates);
            this.Config_groupBox_App.Controls.Add(this.Config_App_label_Jokes);
            this.Config_groupBox_App.Controls.Add(this.Config_App_comboBox_Jokes);
            this.Config_groupBox_App.Controls.Add(this.Config_App_linkLabel_GitHubPage);
            this.Config_groupBox_App.Controls.Add(this.Config_App_label_GitHub);
            this.Config_groupBox_App.Controls.Add(this.Config_App_button_About);
            this.Config_groupBox_App.Controls.Add(this.pictureBox1);
            this.Config_groupBox_App.Controls.Add(this.Config_App_checkBox_JokeOption);
            this.Config_groupBox_App.Controls.Add(this.Config_App_label_LangChanged);
            this.Config_groupBox_App.Controls.Add(this.Config_App_linkLabel_LangChanged);
            this.Config_groupBox_App.Controls.Add(this.Config_App_checkBox_Dynamic);
            this.Config_groupBox_App.Controls.Add(this.Config_App_label_Lang);
            this.Config_groupBox_App.Controls.Add(this.Config_App_comboBox_Lang);
            resources.ApplyResources(this.Config_groupBox_App, "Config_groupBox_App");
            this.Config_groupBox_App.Name = "Config_groupBox_App";
            this.Config_groupBox_App.TabStop = false;
            // 
            // Config_App_button_Updates
            // 
            resources.ApplyResources(this.Config_App_button_Updates, "Config_App_button_Updates");
            this.Config_App_button_Updates.Name = "Config_App_button_Updates";
            this.Config_App_button_Updates.UseVisualStyleBackColor = true;
            this.Config_App_button_Updates.Click += new System.EventHandler(this.Config_App_button_Updates_Click);
            // 
            // Config_App_label_Jokes
            // 
            resources.ApplyResources(this.Config_App_label_Jokes, "Config_App_label_Jokes");
            this.Config_App_label_Jokes.Name = "Config_App_label_Jokes";
            // 
            // Config_App_comboBox_Jokes
            // 
            this.Config_App_comboBox_Jokes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Config_App_comboBox_Jokes.FormattingEnabled = true;
            this.Config_App_comboBox_Jokes.Items.AddRange(new object[] {
            resources.GetString("Config_App_comboBox_Jokes.Items"),
            resources.GetString("Config_App_comboBox_Jokes.Items1"),
            resources.GetString("Config_App_comboBox_Jokes.Items2")});
            resources.ApplyResources(this.Config_App_comboBox_Jokes, "Config_App_comboBox_Jokes");
            this.Config_App_comboBox_Jokes.Name = "Config_App_comboBox_Jokes";
            this.Config_App_comboBox_Jokes.SelectedValueChanged += new System.EventHandler(this.Config_App_comboBox_Jokes_SelectedValueChanged);
            // 
            // Config_App_linkLabel_GitHubPage
            // 
            this.Config_App_linkLabel_GitHubPage.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.Config_App_linkLabel_GitHubPage, "Config_App_linkLabel_GitHubPage");
            this.Config_App_linkLabel_GitHubPage.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Config_App_linkLabel_GitHubPage.LinkColor = System.Drawing.SystemColors.Highlight;
            this.Config_App_linkLabel_GitHubPage.Name = "Config_App_linkLabel_GitHubPage";
            this.Config_App_linkLabel_GitHubPage.TabStop = true;
            this.Config_App_linkLabel_GitHubPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Config_App_linkLabel_GitHubPage_LinkClicked);
            this.Config_App_linkLabel_GitHubPage.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_linkLabel_GitHubPage.MouseHover += new System.EventHandler(this.Config_App_linkLabel_GitHubPage_MouseHover);
            // 
            // Config_App_label_GitHub
            // 
            resources.ApplyResources(this.Config_App_label_GitHub, "Config_App_label_GitHub");
            this.Config_App_label_GitHub.Name = "Config_App_label_GitHub";
            // 
            // Config_App_button_About
            // 
            resources.ApplyResources(this.Config_App_button_About, "Config_App_button_About");
            this.Config_App_button_About.Image = global::Morseapp_WinForms.Properties.Resources.info_16;
            this.Config_App_button_About.Name = "Config_App_button_About";
            this.Config_App_button_About.UseVisualStyleBackColor = true;
            this.Config_App_button_About.Click += new System.EventHandler(this.Config_App_button_About_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Image = global::Morseapp_WinForms.Properties.Resources.app_settings_40;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Config_App_checkBox_JokeOption
            // 
            resources.ApplyResources(this.Config_App_checkBox_JokeOption, "Config_App_checkBox_JokeOption");
            this.Config_App_checkBox_JokeOption.Name = "Config_App_checkBox_JokeOption";
            this.Config_App_checkBox_JokeOption.UseVisualStyleBackColor = true;
            this.Config_App_checkBox_JokeOption.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_checkBox_JokeOption.MouseHover += new System.EventHandler(this.Config_App_checkBox_AllowExplicit_MouseHover);
            // 
            // Config_App_label_LangChanged
            // 
            resources.ApplyResources(this.Config_App_label_LangChanged, "Config_App_label_LangChanged");
            this.Config_App_label_LangChanged.Name = "Config_App_label_LangChanged";
            // 
            // Config_App_linkLabel_LangChanged
            // 
            this.Config_App_linkLabel_LangChanged.ActiveLinkColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.Config_App_linkLabel_LangChanged, "Config_App_linkLabel_LangChanged");
            this.Config_App_linkLabel_LangChanged.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.Config_App_linkLabel_LangChanged.LinkColor = System.Drawing.SystemColors.Highlight;
            this.Config_App_linkLabel_LangChanged.Name = "Config_App_linkLabel_LangChanged";
            this.Config_App_linkLabel_LangChanged.TabStop = true;
            this.Config_App_linkLabel_LangChanged.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Config_App_linkLabel_LangChanged_LinkClicked);
            // 
            // Config_App_checkBox_Dynamic
            // 
            resources.ApplyResources(this.Config_App_checkBox_Dynamic, "Config_App_checkBox_Dynamic");
            this.Config_App_checkBox_Dynamic.Checked = true;
            this.Config_App_checkBox_Dynamic.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Config_App_checkBox_Dynamic.Name = "Config_App_checkBox_Dynamic";
            this.Config_App_checkBox_Dynamic.UseVisualStyleBackColor = true;
            this.Config_App_checkBox_Dynamic.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_checkBox_Dynamic.MouseHover += new System.EventHandler(this.Config_App_checkBox_Dynamic_MouseHover);
            // 
            // Config_App_label_Lang
            // 
            resources.ApplyResources(this.Config_App_label_Lang, "Config_App_label_Lang");
            this.Config_App_label_Lang.Name = "Config_App_label_Lang";
            // 
            // Config_App_comboBox_Lang
            // 
            this.Config_App_comboBox_Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Config_App_comboBox_Lang.FormattingEnabled = true;
            this.Config_App_comboBox_Lang.Items.AddRange(new object[] {
            resources.GetString("Config_App_comboBox_Lang.Items"),
            resources.GetString("Config_App_comboBox_Lang.Items1")});
            resources.ApplyResources(this.Config_App_comboBox_Lang, "Config_App_comboBox_Lang");
            this.Config_App_comboBox_Lang.Name = "Config_App_comboBox_Lang";
            this.Config_App_comboBox_Lang.SelectionChangeCommitted += new System.EventHandler(this.Config_App_comboBox_Lang_SelectionChangeCommitted);
            this.Config_App_comboBox_Lang.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_App_comboBox_Lang.MouseHover += new System.EventHandler(this.Config_App_comboBox_Lang_MouseHover);
            // 
            // Config_groupBox_Player
            // 
            this.Config_groupBox_Player.Controls.Add(this.pictureBox2);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_label_CurrentFreq);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_label_CurrentSpeed);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_label_Freq);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_trackBar_Freq);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_label_Speed);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_checkBox_StrictTiming);
            this.Config_groupBox_Player.Controls.Add(this.Config_Player_trackBar_Speed);
            resources.ApplyResources(this.Config_groupBox_Player, "Config_groupBox_Player");
            this.Config_groupBox_Player.Name = "Config_groupBox_Player";
            this.Config_groupBox_Player.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Morseapp_WinForms.Properties.Resources.player_40;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // Config_Player_label_CurrentFreq
            // 
            resources.ApplyResources(this.Config_Player_label_CurrentFreq, "Config_Player_label_CurrentFreq");
            this.Config_Player_label_CurrentFreq.Name = "Config_Player_label_CurrentFreq";
            // 
            // Config_Player_label_CurrentSpeed
            // 
            resources.ApplyResources(this.Config_Player_label_CurrentSpeed, "Config_Player_label_CurrentSpeed");
            this.Config_Player_label_CurrentSpeed.Name = "Config_Player_label_CurrentSpeed";
            // 
            // Config_Player_label_Freq
            // 
            resources.ApplyResources(this.Config_Player_label_Freq, "Config_Player_label_Freq");
            this.Config_Player_label_Freq.Name = "Config_Player_label_Freq";
            // 
            // Config_Player_trackBar_Freq
            // 
            this.Config_Player_trackBar_Freq.LargeChange = 250;
            resources.ApplyResources(this.Config_Player_trackBar_Freq, "Config_Player_trackBar_Freq");
            this.Config_Player_trackBar_Freq.Maximum = 1000;
            this.Config_Player_trackBar_Freq.Minimum = 100;
            this.Config_Player_trackBar_Freq.Name = "Config_Player_trackBar_Freq";
            this.Config_Player_trackBar_Freq.SmallChange = 100;
            this.Config_Player_trackBar_Freq.TickFrequency = 100;
            this.Config_Player_trackBar_Freq.Value = 500;
            this.Config_Player_trackBar_Freq.ValueChanged += new System.EventHandler(this.Config_Player_trackBar_Freq_ValueChanged);
            this.Config_Player_trackBar_Freq.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_Player_trackBar_Freq.MouseHover += new System.EventHandler(this.Config_Player_trackBar_Freq_MouseHover);
            // 
            // Config_Player_label_Speed
            // 
            resources.ApplyResources(this.Config_Player_label_Speed, "Config_Player_label_Speed");
            this.Config_Player_label_Speed.Name = "Config_Player_label_Speed";
            // 
            // Config_Player_checkBox_StrictTiming
            // 
            resources.ApplyResources(this.Config_Player_checkBox_StrictTiming, "Config_Player_checkBox_StrictTiming");
            this.Config_Player_checkBox_StrictTiming.Name = "Config_Player_checkBox_StrictTiming";
            this.Config_Player_checkBox_StrictTiming.UseVisualStyleBackColor = true;
            this.Config_Player_checkBox_StrictTiming.MouseLeave += new System.EventHandler(this.Common_MouseLeave);
            this.Config_Player_checkBox_StrictTiming.MouseHover += new System.EventHandler(this.Config_Player_StrictTiming_MouseHover);
            // 
            // Config_Player_trackBar_Speed
            // 
            this.Config_Player_trackBar_Speed.LargeChange = 150;
            resources.ApplyResources(this.Config_Player_trackBar_Speed, "Config_Player_trackBar_Speed");
            this.Config_Player_trackBar_Speed.Maximum = 500;
            this.Config_Player_trackBar_Speed.Minimum = 50;
            this.Config_Player_trackBar_Speed.Name = "Config_Player_trackBar_Speed";
            this.Config_Player_trackBar_Speed.SmallChange = 50;
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
            resources.ApplyResources(this.statusStrip, "statusStrip");
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.SizingGrip = false;
            // 
            // toolStripStatusLabel
            // 
            resources.ApplyResources(this.toolStripStatusLabel, "toolStripStatusLabel");
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            resources.ApplyResources(this.toolStripProgressBar, "toolStripProgressBar");
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
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.tabControl_Main);
            this.DoubleBuffered = true;
            this.Name = "Form_Main";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Config_groupBox_Player.ResumeLayout(false);
            this.Config_groupBox_Player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
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
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.TabPage Configuration;
        private System.Windows.Forms.TextBox Decoder_textBox_Output;
        private System.Windows.Forms.Label Decoder_label_Output;
        private System.Windows.Forms.Label Decoder_label_Input;
        private System.Windows.Forms.TextBox Decoder_textBox_Input;
        private System.Windows.Forms.Button Decoder_button_Convert;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
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
        private System.Windows.Forms.ComboBox Config_App_comboBox_Lang;
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
        private System.Windows.Forms.CheckBox Config_App_checkBox_JokeOption;
        private System.Windows.Forms.Button Coder_button_StopSound;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Decoder_button_Settings;
        private System.Windows.Forms.Button Player_button_Settings;
        private System.Windows.Forms.Button Player_button_StopSound;
        private System.Windows.Forms.Button Config_App_button_About;
        private System.Windows.Forms.LinkLabel Config_App_linkLabel_GitHubPage;
        private System.Windows.Forms.Label Config_App_label_GitHub;
        private System.Windows.Forms.Button Coder_button_Copy;
        private System.Windows.Forms.Button Decoder_button_Copy;
        private System.Windows.Forms.Button ShowDict_button_Copy;
        private System.Windows.Forms.ComboBox Config_App_comboBox_Jokes;
        private System.Windows.Forms.Label Config_App_label_Jokes;
        private System.Windows.Forms.Button Config_App_button_Updates;
        private System.Windows.Forms.Button Coder_button_while;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Updater;
    }
}

