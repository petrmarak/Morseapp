using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Morseapp_WinForms
{
    public partial class Form1
    {
        /// <summary>
        /// Method used to fetch a cringe Chuck Norris joke from the internet.
        /// </summary>
        /// <returns>A string that is modified to contain only a joke in usable format.</returns>
        private static string GetJoke(bool allowExplicitContent)
        {
            const string chuckURL = "https://api.chucknorris.io/jokes/random";
            string download;
            

            using (WebClient webClient = new())
            {
                try
                {
                    do
                    {
                        download = webClient.DownloadString(chuckURL);
                    } while (!allowExplicitContent && download.Contains("[\"explicit\"]"));
                }
                catch (WebException ex)
                {
                    webClient.Dispose();
                    return "Error:" + ex.Message;
                }
            }

            int index = download.LastIndexOf("\"value\":");
            string joke;
            StringBuilder sb = new(download.Length / 2);

            if (index != -1)
            {
                index += "\"value\":".Length + 1;
                while (download[index + 1] != '}')
                {
                    sb.Append(download[index]);
                    ++index;
                }
                sb.Replace("\\", string.Empty);    // Sometimes downloaded string containing \" instead of just "
                if (sb[^1] != '.') sb.Append('.');    // Sometimes downloaded string is missing dot at the end; sb[^1] == sb[sb.Length - 1]
                joke = sb.ToString();
                return joke;
            }
            else
            {
                return "Error: Downloaded data were not in a correct format.";
            }
        }
        /*
        /// <summary>
        /// Reads text aloud in English
        /// </summary>
        /// <param name="text">Text to be read</param>
        private void TextToSpeech(string text)
        {
            var synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak(text);
        }
        */
        /// <summary>
        /// Generates file storing the current application settings with up-to-date values.
        /// </summary>
        private void GenerateConfigFile(string configFile)
        {
            try
            {
                using (StreamWriter configWriter = new(configFile))
                {
                    configWriter.WriteLine("# This file contains user-configurable settings for the Morse Application found on the \"Configuration\" tab.");
                    configWriter.WriteLine("# If this file or its contents are deleted, it will be regenerated at next startup with default settings.");
                    configWriter.WriteLine("[Application]");
                    configWriter.WriteLine($"language={Config_App_comboBox_Lang.SelectedIndex} ({Config_App_comboBox_Lang.SelectedItem})");
                    configWriter.WriteLine($"dynamicConversion={Config_App_checkBox_Dynamic.Checked}");
                    configWriter.WriteLine($"allowExplicitJokes={Config_App_checkBox_AllowExplicit.Checked}");
                    configWriter.WriteLine("[Player]");
                    configWriter.WriteLine($"speed={player_TimeUnit}");
                    configWriter.WriteLine($"frequency={player_Frequency}");
                    configWriter.WriteLine($"strictTiming={Config_Player_checkBox_StrictTiming.Checked}");
                    configWriter.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured during saving user configuration to {configFile} file: {Environment.NewLine}{ex.Message}{Environment.NewLine}Configuration is not saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
