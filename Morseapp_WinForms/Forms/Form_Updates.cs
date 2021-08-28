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
        }

        private void Form_Updates_Load(object sender, EventArgs e)
        {
            SetLanguage(Form_Main.langID);

            using (SoundPlayer soundPlayer = new(Properties.Resources.Windows_Balloon))
            {
                soundPlayer.Play();
            }

            label_Changelog.Text = changeLog;
        }

        public enum UpdateButton : byte
        {
            Cancel, 
            Dependent, 
            Standalone
        }

        private byte buttonClicked;
        private string upToDateVersion;
        private string changeLog;
        private float dependentSize;
        private float standaloneSize;

        private void Button_Dependent_Click(object sender, EventArgs e)
        {
            buttonClicked = (byte)UpdateButton.Dependent;
            this.Close();
        }

        private void Button_Standalone_Click(object sender, EventArgs e)
        {
            buttonClicked = (byte)UpdateButton.Standalone;
            this.Close();
        }

        private void Button_Cancel_Click(object sender, EventArgs e)
        {
            buttonClicked = (byte)UpdateButton.Cancel;
            this.Close();
        }        
    }
}
