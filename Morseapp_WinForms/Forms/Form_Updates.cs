using System;
using System.Media;
using System.Windows.Forms;

namespace Morseapp_WinForms
{
    public partial class Form_Updates : Form
    {
        public Form_Updates()
        {
            InitializeComponent();
            this.Text = $"{Application.ProductName}, v{Application.ProductVersion} Update Tool";
        }

        private void Form_Updates_Load(object sender, EventArgs e)
        {
            label_Title.Text = $"Newer version is available: {upToDateVersion}";
            label_Changelog.Text = changeLog;
            using SoundPlayer soundPlayer = new(Properties.Resources.Windows_Balloon);
            soundPlayer.Play();
        }

        public enum Button : ushort
        {
            Cancel, 
            Dependent, 
            Standalone
        }

        public static ushort buttonClicked;
        public static string upToDateVersion;
        public static string changeLog;

        private void button_Dependent_Click(object sender, EventArgs e)
        {
            buttonClicked = (ushort)Button.Dependent;
            this.Close();
        }

        private void button_Standalone_Click(object sender, EventArgs e)
        {
            buttonClicked = (ushort)Button.Standalone;
            this.Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            buttonClicked = (ushort)Button.Cancel;
            this.Close();
        }

    }
}
