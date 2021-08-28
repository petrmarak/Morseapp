using System;
using System.Drawing;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Morseapp_WinForms
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void Form_About_Load(object sender, EventArgs e)
        {
            SetLanguage(Form_Main.langID);

            using (SoundPlayer soundPlayer = new(Properties.Resources.Windows_Balloon))
            {
                soundPlayer.Play();
            }

            toolTip.SetToolTip(button_GitHub, GetLocStr("TIP_Button_GitHub"));
            richTextBox_AboutInfo.Lines = MESSAGEBOX_About_Text;
            // change font for some parts of text
            richTextBox_AboutInfo.Select(0, richTextBox_AboutInfo.Lines[0].Length);
            richTextBox_AboutInfo.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_AboutInfo.Select(richTextBox_AboutInfo.Lines[0].Length, richTextBox_AboutInfo.Lines[1].Length + 1);
            richTextBox_AboutInfo.SelectionFont = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        }

        /// <summary>
        /// Removes the blinking text cursor (caret) from the screen.
        /// </summary>
        /// <param name="HWND">A handle to the window that owns the caret.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr HWND);

        private void RichTextBox_SelectionChanged(object sender, EventArgs e)
        {
            HideCaret(richTextBox_AboutInfo.Handle);
        }

        private void RichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            if (e.LinkText == "https://flaticon.com")
                System.Diagnostics.Process.Start("explorer.exe", e.LinkText + "/free-icon/morse-code_260301");
            else
                System.Diagnostics.Process.Start("explorer.exe", e.LinkText);

            richTextBox_AboutInfo.DeselectAll();
        }

        private void Button_GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/petrmarak/Morseapp");
        }
    }
}
