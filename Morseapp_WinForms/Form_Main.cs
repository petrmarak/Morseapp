﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morseapp_WinForms
{
    public partial class Form_Main : Form
    {
        // *** System menu modifications: *** \\
        // Essentials learned from: https://stackoverflow.com/questions/4615940/how-can-i-customize-the-system-menu-of-a-windows-form
        // P/Invoke constants
        private const int WM_SYSCOMMAND = 0x112;
        private const int MF_STRING = 0x0;
        private const int MF_SEPARATOR = 0x800;
        private const int MF_CHECKED = 0x8;
        private const int MF_UNCHECKED = 0x0;
        private const int WM_HOTKEY = 0x0312;

        // P/Invoke declarations
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetSystemMenu(IntPtr HWND, bool bRevert);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool AppendMenu(IntPtr hMenu, int uFlags, int uIDNewItem, string lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InsertMenu(IntPtr hMenu, int uPosition, int uFlags, int uIDNewItem, string lpNewItem);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool RemoveMenu(IntPtr hMenu, int uPosition, int uFlags);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool DrawMenuBar(IntPtr HWND);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool DestroyMenu(IntPtr hMenu);
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool RegisterHotKey(IntPtr HWND, int id, int fsModifiers, Keys vk);

        // ID for the items on the system menu
        private const int SYSMENU_APPRESTART_ID = 0x0;
        private const int SYSMENU_FIRSTSEPARATOR_ID = 0x1;
        private const int SYSMENU_ENABLEVISUALSTYLES_ID = 0x2;
        private const int SYSMENU_ABOUT_ID = 0x3;

        // ID for the RegisterHotKey keys
        private const int HOTKEY_ESC_ID = 1;

        // Helper variables
        private bool hasCheck = true;

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            // Get a handle to a copy of this form's system (window) menu
            IntPtr hSysMenu = GetSystemMenu(this.Handle, false);

            // Add the "Restart" menu item
            AppendMenu(hSysMenu, MF_STRING, SYSMENU_APPRESTART_ID, GetLocStr("SYSMENU_Restart"));

            // Add a separator
            AppendMenu(hSysMenu, MF_SEPARATOR, SYSMENU_FIRSTSEPARATOR_ID, "");

            // Add the "Switch Visual Styles" menu item
            AppendMenu(hSysMenu, MF_CHECKED, SYSMENU_ENABLEVISUALSTYLES_ID, GetLocStr("SYSMENU_EnableVisualStyles"));

            // Add the "About" menu item
            AppendMenu(hSysMenu, MF_STRING, SYSMENU_ABOUT_ID, GetLocStr("SYSMENU_About"));

            // Register ESC key as global hotkey
            RegisterHotKey(this.Handle, HOTKEY_ESC_ID, 0x0, Keys.Escape);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            // Test if the "Restart" item was selected from the system menu
            if ((m.Msg == WM_SYSCOMMAND) && ((int)m.WParam == SYSMENU_APPRESTART_ID))
            {
                Application.Restart();
            }

            // Test if the "Switch Visual Styles" item was selected from the system menu
            if ((m.Msg == WM_SYSCOMMAND) && ((int)m.WParam == SYSMENU_ENABLEVISUALSTYLES_ID))
            {
                IntPtr hSysMenu = GetSystemMenu(this.Handle, false);
                if (hasCheck)
                {
                    RemoveMenu(hSysMenu, SYSMENU_ENABLEVISUALSTYLES_ID, MF_CHECKED);
                    InsertMenu(hSysMenu, SYSMENU_ABOUT_ID, MF_UNCHECKED, SYSMENU_ENABLEVISUALSTYLES_ID, GetLocStr("SYSMENU_EnableVisualStyles"));
                    DrawMenuBar(this.Handle);
                    hasCheck = false;

                    Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
                }
                else
                {
                    RemoveMenu(hSysMenu, SYSMENU_ENABLEVISUALSTYLES_ID, MF_UNCHECKED);
                    InsertMenu(hSysMenu, SYSMENU_ABOUT_ID, MF_CHECKED, SYSMENU_ENABLEVISUALSTYLES_ID, GetLocStr("SYSMENU_EnableVisualStyles"));
                    DrawMenuBar(this.Handle);
                    hasCheck = true;

                    Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.ClientAndNonClientAreasEnabled;
                }
            }

            // Test if the "About" item was selected from the system menu
            if ((m.Msg == WM_SYSCOMMAND) && ((int)m.WParam == SYSMENU_ABOUT_ID))
            {
                ShowAboutWindow();
            }
            
            // Test if ESC key was pressed and stop Morse playback - works anywhere in the application
            if (m.Msg == WM_HOTKEY)
            {
                stopPlaying = true;
            }
        }

        public Form_Main()
        {
            InitializeComponent();

            // Init control settings (when config file is not set yet):
            this.ActiveControl = Coder_textBox_Input;
            this.Config_App_comboBox_Lang.SelectedIndex = (int)Language.English;
            this.Config_App_comboBox_Jokes.SelectedIndex = 0;
            this.Config_Player_trackBar_Speed.Value = player_Speed;
            this.Config_Player_label_CurrentSpeed.Text = $"{player_Speed} ms";
            this.Config_Player_trackBar_Freq.Value = player_Frequency;
            this.Config_Player_label_CurrentFreq.Text = $"{player_Frequency} Hz";

            // Multiple methods for one event are removed when put in Form_Main.Designer.cs, so they are here:
            this.Coder_textBox_Input.TextChanged += new EventHandler(Common_textBox_TextChanged);
            this.Coder_textBox_Output.TextChanged += new EventHandler(Common_textBox_TextChanged);
            this.Decoder_textBox_Input.TextChanged += new EventHandler(Common_textBox_TextChanged);
            this.Decoder_textBox_Output.TextChanged += new EventHandler(Common_textBox_TextChanged);
            this.Player_textBox_Input.TextChanged += new EventHandler(Common_textBox_TextChanged);
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);

            LoadConfig(configFile);

            toolTip.ToolTipTitle = GetLocStr("TIP_Title");
            toolTip.SetToolTip(Coder_label_Tip, GetLocStr("TIP_Coder_Caption"));
            toolTip.SetToolTip(Coder_button_Settings, GetLocStr("TIP_Button_Config"));
            toolTip.SetToolTip(Decoder_label_Tip, GetLocStr("TIP_Decoder_Caption"));
            toolTip.SetToolTip(Decoder_button_Settings, GetLocStr("TIP_Button_Config"));
            toolTip.SetToolTip(Player_label_Tip, GetLocStr("TIP_Player_Caption"));
            toolTip.SetToolTip(Player_button_Settings, GetLocStr("TIP_Button_Config"));
            this.toolStripStatusLabel.Text = GetLocStr("STATUS_Default");
        }

        // *** 0) Common logic: *** \\
        private const string configFile = "config.ini";
        public static int langID;
        private int jokesID;
        private int player_Speed = 250;
        private int player_Frequency = 500;
        private static bool stopPlaying = default;

        private void ShowAboutWindow()
        {
            using (Form_About fa = new())
            {
                fa.ShowDialog();
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopPlaying = true;
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            SaveConfig(configFile);
        }

        private void Common_textBox_TextChanged(object sender, EventArgs e)    // universal dynamic resizing for text boxes
        {
            TextBox tSender = (TextBox)sender;
            Size size = TextRenderer.MeasureText(tSender.Text, tSender.Font);

            if (size.Width > 250)
            {
                if (size.Width < 525)
                    tSender.Width = size.Width;
                else
                    tSender.Width = 525;
            }
            else
            {
                tSender.Width = 250;
            }

            if (size.Height > 23)
            {
                tSender.Height = size.Height;
            }
            else
            {
                tSender.Height = 23;
            }
        }

        private void Common_MouseLeave(object sender, EventArgs e)    // resets status label after mouse leaves any control
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Default");
        }

        private void Button_PlaySound_Click(object sender, EventArgs e)
        {
            stopPlaying = false;
            toolStripStatusLabel.Text = GetLocStr("STATUS_Player_PlaySound_Invoked");
            Cursor.Current = Cursors.AppStarting;
            toolStripProgressBar.Step = 1;
            if (tabControl_Main.SelectedTab == Coder)
            {
                Coder_button_StopSound.Visible = true;
                toolStripProgressBar.Maximum = Coder_textBox_Output.TextLength;
                Coder_textBox_Output.SelectionStart = 0;
                Coder_textBox_Output.SelectionLength = 1;
                Coder_textBox_Output.Select();

                foreach (char symbol in Coder_textBox_Output.Text)
                {
                    // user can press Esc key or click the Stop button
                    if (stopPlaying)
                        break;

                    toolStripProgressBar.PerformStep();
                    toolStripStatusLabel.Text = GetLocStr("STATUS_Player_PlaySound_Invoked");
                    Morse.Player(symbol, player_Frequency, player_Speed, Config_Player_checkBox_StrictTiming.Checked);
                    // Running the Morse.Player method on another thread completely breaks functionality and the sound - any tips about this are appreciated.
                    //Task.Run(() => Morse.Player(symbol, player_Frequency, player_Speed, Config_Player_checkBox_StrictTiming.Checked));
                    Coder_textBox_Output.Select();
                    ++Coder_textBox_Output.SelectionStart;

                    Application.DoEvents();    // provisory "solution"
                }

                Coder_button_StopSound.Visible = false;
            }

            else
            {
                Player_button_StopSound.Visible = true;
                toolStripProgressBar.Maximum = Player_textBox_Input.TextLength;
                Player_textBox_Input.SelectionStart = 0;
                Player_textBox_Input.SelectionLength = 1;
                Coder_textBox_Output.Select();

                foreach (char symbol in Player_textBox_Input.Text)
                {
                    if (stopPlaying)
                        break;

                    toolStripProgressBar.PerformStep();
                    toolStripStatusLabel.Text = GetLocStr("STATUS_Player_PlaySound_Invoked");
                    Morse.Player(symbol, player_Frequency, player_Speed, Config_Player_checkBox_StrictTiming.Checked);
                    Player_textBox_Input.Select();
                    ++Player_textBox_Input.SelectionStart;

                    Application.DoEvents();
                }

                Player_button_StopSound.Visible = false;
            }

            // prevents crash (NullReferenceException) when the main form is closed during ongoing playback
            if (!toolStripProgressBar.IsDisposed) 
                toolStripProgressBar.Value = toolStripProgressBar.Minimum;

            toolStripStatusLabel.Text = GetLocStr("STATUS_Default");
            Cursor.Current = Cursors.Default;
            stopPlaying = false;
        }

        private void Button_StopSound_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Player_StopSound");
        }

        private void TabControl_Main_SelectedIndexChanged(object sender, EventArgs e)   // sets appropriate focus when switching tabs
        {
            TabControl tc = tabControl_Main;

            switch (tc.SelectedIndex)
            {
                case 0:
                    Coder_textBox_Input.Focus();
                    break;
                case 1:
                    Decoder_textBox_Input.Focus();
                    break;
                case 2:
                    Player_textBox_Input.Focus();
                    break;
                default:
                    break;
            }
        }



        // *** 1) Coder tab logic: *** \\
        private void Coder_textBox_Input_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Coder_Input");
        }

        private void Coder_textBox_Input_TextChanged(object sender, EventArgs e)
        {
            if (Config_App_checkBox_Dynamic.Checked)
                Coder_textBox_Output.Text = Morse.Coder(Coder_textBox_Input.Text);
            else
                Coder_textBox_Output.ResetText();
        }

        private void Coder_textBox_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Coder_button_Convert.PerformClick();
            }
        }

        private void Coder_button_Joke_Click(object sender, EventArgs e)
        {
            Coder_textBox_Input.ResetText();
            toolStripStatusLabel.Text = GetLocStr("STATUS_Coder_Joke_Invoked");
            Cursor.Current = Cursors.WaitCursor;

            int jokesSource = Config_App_comboBox_Jokes.SelectedIndex;
            bool option = Config_App_checkBox_JokesOption.Checked;
            Coder_textBox_Input.Text = Task.Run(() => GetJoke(jokesSource, option)).Result;

            Cursor.Current = Cursors.Default;
            toolStripStatusLabel.Text = GetLocStr("STATUS_Default");
        }

        private void Coder_button_Joke_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Coder_Joke_Hover");
        }

        private void Coder_button_Convert_Click(object sender, EventArgs e)
        {
            Coder_textBox_Output.Text = Morse.Coder(Coder_textBox_Input.Text);
        }

        private void Coder_button_Convert_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Coder_Convert");
        }

        private void Coder_textBox_Output_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Coder_Output");
        }

        private void Coder_textBox_Output_TextChanged(object sender, EventArgs e)
        {
            if (Coder_textBox_Output.TextLength > 0)
            {
                Coder_button_PlaySound.Visible = true;
                Coder_button_Copy.Visible = true;
            }
            else
            {
                Coder_button_PlaySound.Visible = false;
                Coder_button_Copy.Visible = false;
            }
        }

        private void Coder_textBox_Output_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                Coder_textBox_Output.SelectAll();
        }

        private void Coder_button_Copy_Click(object sender, EventArgs e)
        {
            Coder_textBox_Output.SelectAll();
            Coder_textBox_Output.Copy();
            toolStripStatusLabel.Text = GetLocStr("STATUS_Click_Button_Copy");
        }

        private void Coder_button_Copy_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Button_Copy");
        }

        private void Coder_button_PlaySound_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Player_PlaySound_Hover");
        }

        private void Coder_button_StopSound_Click(object sender, EventArgs e)
        {
            stopPlaying = true;
        }

        private void Coder_button_Settings_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedTab = Configuration;
            Config_App_checkBox_Dynamic.Focus();
        }



        // *** 2) Decoder tab logic: *** \\
        private void Decoder_textBox_Input_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Decoder_Input");
        }

        private void Decoder_textBox_Input_TextChanged(object sender, EventArgs e)
        {
            if (Config_App_checkBox_Dynamic.Checked)
            {
                Decoder_textBox_Output.Text = Morse.Decoder(Decoder_textBox_Input.Text);
            }
            else
            {
                Decoder_textBox_Output.ResetText();
            }
        }

        private void Decoder_textBox_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Decoder_button_Convert.PerformClick();
            }
        }

        private void Decoder_button_Convert_Click(object sender, EventArgs e)
        {
            Decoder_textBox_Output.Text = Morse.Decoder(Decoder_textBox_Input.Text);
        }

        private void Decoder_button_Convert_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Decoder_Convert");
        }

        private void Decoder_textBox_Output_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Decoder_Output");
        }

        private void Decoder_textBox_Output_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                Decoder_textBox_Output.SelectAll();
        }

        private void Decoder_textBox_Output_TextChanged(object sender, EventArgs e)
        {
            if (Decoder_textBox_Output.TextLength > 0)
                Decoder_button_Copy.Visible = true;
            else
                Decoder_button_Copy.Visible = false;
        }

        private void Decoder_button_Copy_Click(object sender, EventArgs e)
        {
            Decoder_textBox_Output.SelectAll();
            Decoder_textBox_Output.Copy();
            toolStripStatusLabel.Text = GetLocStr("STATUS_Click_Button_Copy");
        }

        private void Decoder_button_Copy_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Button_Copy");
        }

        private void Decoder_button_Settings_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedTab = Configuration;
            Config_App_checkBox_Dynamic.Focus();
        }



        // *** Player tab logic: *** \\
        private void Player_textBox_Input_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Player_Input");
        }

        private void Player_textBox_Input_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                Player_button_Play.PerformClick();
            }
        }

        private void Player_button_Play_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Player_PlaySound_Hover");
        }

        private void Player_button_StopSound_Click(object sender, EventArgs e)
        {
            stopPlaying = true;
        }

        private void Player_button_Settings_Click(object sender, EventArgs e)
        {
            tabControl_Main.SelectedTab = Configuration;
            Config_Player_trackBar_Speed.Focus();
        }



        // *** Show Dictionary logic: *** \\
        private void Dictionary_HandleCreated(object sender, EventArgs e)
        {
            ShowDict_richtextBox_Output.Text = Morse.PrintSortedList();
        }

        private void ShowDict_richtextBox_Output_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Dictionary_RichTextBox");
        }

        private void ShowDict_button_Copy_Click(object sender, EventArgs e)
        {
            ShowDict_richtextBox_Output.SelectAll();
            ShowDict_richtextBox_Output.Copy();
            ShowDict_richtextBox_Output.DeselectAll();
            toolStripStatusLabel.Text = GetLocStr("STATUS_Click_Button_Copy");
        }

        private void ShowDict_button_Copy_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Button_Copy");
        }

        private void ShowDict_button_Refresh_Click(object sender, EventArgs e)
        {
            ShowDict_richtextBox_Output.ResetText();
            ShowDict_richtextBox_Output.Text = Morse.PrintSortedList();
        }

        private void ShowDict_button_Refresh_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Dictionary_Refresh");
        }



        // *** Configuration logic: *** \\
        private void Config_App_comboBox_Lang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Config_App_label_LangChanged.Visible = true;
            Config_App_linkLabel_LangChanged.Visible = true;
        }

        private void Config_App_linkLabel_LangChanged_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Restart();
        }

        private void Config_App_comboBox_Lang_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Config_App_Lang");
        }

        private void Config_App_checkBox_Dynamic_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Config_App_Dynamic");
        }

        private void Config_App_comboBox_Jokes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Config_App_comboBox_Jokes.SelectedIndex == 2)
                Config_App_checkBox_JokesOption.Text = GetLocStr("Config_App_ProgrammingJokes");
            else
                Config_App_checkBox_JokesOption.Text = GetLocStr("Config_App_ExplicitJokes");
        }

        private void Config_App_comboBox_Jokes_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Config_App_Jokes");
        }

        private void Config_App_checkBox_JokesOption_MouseHover(object sender, EventArgs e)
        {
            if (Config_App_comboBox_Jokes.SelectedIndex == 2)
                toolStripStatusLabel.Text = GetLocStr("STATUS_Config_App_ProgrammingJokes");
            else
                toolStripStatusLabel.Text = GetLocStr("STATUS_Config_App_ExplicitJokes");
        }

        private void Config_App_button_Updates_Click(object sender, EventArgs e)
        {
            using (Form_Updates fu = new())
            {
                fu.CheckForUpdates(this);
            }
        }

        private void Config_App_button_Updates_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Config_App_Updates");
        }

        private void Config_App_button_About_Click(object sender, EventArgs e)
        {
            ShowAboutWindow();
        }

        private void Config_App_button_About_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Config_App_About");
        }

        private void Config_Player_trackBar_Speed_ValueChanged(object sender, EventArgs e)
        {
            int mod = Config_Player_trackBar_Speed.Value % 50;
            if (mod != 0)
            {
                Config_Player_trackBar_Speed.Value += 50 - mod;
            }
            player_Speed = Config_Player_trackBar_Speed.Value;
            Config_Player_label_CurrentSpeed.Text = Convert.ToString(Config_Player_trackBar_Speed.Value) + " ms";
        }

        private void Config_Player_trackBar_Speed_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Config_Player_Speed");
        }

        private void Config_Player_trackBar_Freq_ValueChanged(object sender, EventArgs e)
        {
            int mod = Config_Player_trackBar_Freq.Value % 100;
            if (mod != 0)
            {
                Config_Player_trackBar_Freq.Value += 100 - mod;
            }
            player_Frequency = Config_Player_trackBar_Freq.Value;
            Config_Player_label_CurrentFreq.Text = Convert.ToString(Config_Player_trackBar_Freq.Value) + " Hz";
        }

        private void Config_Player_trackBar_Freq_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Config_Player_Freq");
        }

        private void Config_Player_StrictTiming_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = GetLocStr("STATUS_Config_Player_StrictTiming");
        }
    }
}
