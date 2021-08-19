using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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
            using (SoundPlayer soundPlayer = new(Properties.Resources.Windows_Balloon))
            {
                soundPlayer.Play();
            }

            string[] aboutLines = new string[]
            {
                $"Graphical User Interface for {Application.ProductName}.",
                $"\t\tVersion {Application.ProductVersion}",
                $"Created using Windows Forms in .NET {Environment.Version}",
                string.Empty,
                $"Application\t©2021 Petr Mařák",
                $"Morse code\t©1838 Samuel Morse",
                $"App icon\thttps://flaticon.com",
                $"Other icons\t©2021 Microsoft Corporation",
                $"Jokes providers\thttps://v2.jokeapi.dev",
                "\t\thttps://api.chucknorris.io",
                "\t\thttps://official-joke-api.appspot.com"
            };

            richTextBox_AboutInfo.Cursor = Cursors.Default;
            richTextBox_AboutInfo.Lines = aboutLines;
            richTextBox_AboutInfo.Select(0, richTextBox_AboutInfo.Lines[0].Length);
            richTextBox_AboutInfo.SelectionFont = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox_AboutInfo.LinkClicked += new LinkClickedEventHandler(RichTextBox_LinkClicked);
            richTextBox_AboutInfo.SelectionChanged += new EventHandler(RichTextBox_Click);
        }

        /// <summary>
        /// Removes the blinking text cursor from the screen.
        /// </summary>
        /// <param name="HWND">A handle to the window that owns the caret.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr HWND);

        private void RichTextBox_Click(object sender, EventArgs e)
        {
            HideCaret(richTextBox_AboutInfo.Handle);
        }

        private void RichTextBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", e.LinkText);

        }

        private void button_GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "https://github.com/petrmarak/Morseapp");
        }
    }
}
