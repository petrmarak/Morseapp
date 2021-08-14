using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
//using System.Speech.Synthesis;

namespace Morseapp_WinForms
{
    public partial class Form_Main
    {
        /// <summary>
        /// Method used to fetch a joke from the one of APIs.
        /// </summary>
        /// <param name="source">Integer starting from 0, determining which API jokes provider will be used.</param>
        /// <param name="option">Option that can be set to affect what type of jokes will be returned from selected provider.</param>
        /// <returns>A string with joke.</returns>
        public static string GetJoke(int source, bool option = false)
        {
            string URL;
            string downloadData;
            JObject stringToJson;
            string joke = "";
            string jokePart2;
            using WebClient webClient = new();

            switch (source)
            {
                case 0:
                    if (option) URL = "https://v2.jokeapi.dev/joke/Any";
                    else URL = "https://v2.jokeapi.dev/joke/Any?blacklistFlags=explicit";    // disallow explicit jokes

                    try
                    {
                        downloadData = webClient.DownloadString(URL);
                    }
                    catch (WebException ex)
                    {
                        return "Error:" + ex.Message;
                    }
                    stringToJson = JObject.Parse(downloadData);

                    if (stringToJson.GetValue("type").ToString() == "single")
                        joke = stringToJson.GetValue("joke").ToString();
                    else if (stringToJson.GetValue("type").ToString() == "twopart")
                    {
                        joke = stringToJson.GetValue("setup").ToString();
                        jokePart2 = stringToJson.GetValue("delivery").ToString();
                        joke += ' ' + jokePart2;
                    }
                    break;

                case 1:
                    URL = "https://api.chucknorris.io/jokes/random";
                    try
                    {
                        do
                        {
                            downloadData = webClient.DownloadString(URL);
                        } while (!option && downloadData.Contains("[\"explicit\"]"));    // disallow explicit jokes
                    }
                    catch (WebException ex)
                    {
                        return "Error:" + ex.Message;
                    }
                    stringToJson = JObject.Parse(downloadData);

                    joke = stringToJson.GetValue("value").ToString();
                    break;

                case 2:
                    if (option) URL = "https://official-joke-api.appspot.com/jokes/programming/random";   // any category
                    else URL = "https://official-joke-api.appspot.com/random_joke";    // programming only

                    try
                    {
                        downloadData = webClient.DownloadString(URL);
                    }
                    catch (WebException ex)
                    {
                        return "Error:" + ex.Message;
                    }
                    downloadData = downloadData.Trim('[', ']');
                    stringToJson = JObject.Parse(downloadData);

                    joke = stringToJson.GetValue("setup").ToString();
                    jokePart2 = stringToJson.GetValue("punchline").ToString();
                    joke += ' ' + jokePart2;
                    break;
            }

            webClient.Dispose();
            joke = joke.Replace('[', '(').Replace(']', ')').Replace('’', '\'');
            return joke;
        }

        /// <summary>
        /// Application Updater
        /// </summary>
        public void CheckForUpdates()
        {
            const string GitHubAPI = "https://api.github.com/repos/petrmarak/Morseapp/releases/latest";
            string downloadData = "";
            bool retry = default;
            do
            {
                try
                {
                    using (WebClient webClient = new())
                    {
                        webClient.Headers.Add("user-agent", $"petrmarak; {Application.ProductName} v{Application.ProductVersion}");
                        downloadData = webClient.DownloadString(GitHubAPI);
                    }
                }
                catch (WebException ex)
                {
                    DialogResult errorChoice = MessageBox.Show($"Error: {ex.Message}{Environment.NewLine}Check your internet connection or try again later.", "Unable to check for updates", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (errorChoice == DialogResult.Retry)
                        retry = true;
                    else if (errorChoice == DialogResult.Cancel)
                        return;
                }
            } while (retry);

            // extract app version from downloaded Json to string with first 'v' letter removed
            string upToDateVersion = JObject.Parse(downloadData).GetValue("tag_name").ToString().TrimStart('v');
            string changeLog = JObject.Parse(downloadData).GetValue("body").ToString();
            string dependentURL = "";
            short dependentIndex = 0;
            string standaloneURL = "";
            short standaloneIndex = 0;

            JObject jo = JObject.Parse(downloadData);
            short sectionIndex = 0;
            while (jo.SelectToken($"assets[{sectionIndex}].browser_download_url") != null)
            {
                string temp = jo.SelectToken($"assets[{sectionIndex}].browser_download_url").ToString();
                if (temp.Contains("depend", StringComparison.OrdinalIgnoreCase))
                {
                    dependentURL = temp;
                    dependentIndex = sectionIndex;
                }
                else if (temp.Contains("standalone", StringComparison.OrdinalIgnoreCase))
                {
                    standaloneURL = temp;
                    standaloneIndex = sectionIndex;
                }
                ++sectionIndex;
            }

            ushort dlChoice;
            Form_Updates.upToDateVersion = upToDateVersion;
            Form_Updates.changeLog = changeLog;
            if (Application.ProductVersion == upToDateVersion)
            {
                MessageBox.Show($"Application is up-to-date.", $"{Application.ProductName}, version {Application.ProductVersion} Update Tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form_Updates fu = new();
                fu.ShowDialog();
                dlChoice = Form_Updates.buttonClicked;

                using WebClient webClient = new();
                webClient.Headers.Add("user-agent", $"petrmarak; {Application.ProductName} v{Application.ProductVersion}");
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Updates_DownloadProgressChanged);
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Updater_DownloadFileCompleted);

                folderBrowserDialog_Updater.AutoUpgradeEnabled = true;
                folderBrowserDialog_Updater.Description = "Choose where do you want to save the new version";
                folderBrowserDialog_Updater.UseDescriptionForTitle = true;

                if (dlChoice == (ushort)Form_Updates.Button.Dependent)
                {
                    DialogResult result = folderBrowserDialog_Updater.ShowDialog();
                    if (result == DialogResult.Cancel)
                        return;

                    string savePath = $"{folderBrowserDialog_Updater.SelectedPath}\\{jo.SelectToken($"assets[{dependentIndex}].name")}";
                    try
                    {
                        webClient.DownloadFileAsync(new Uri(dependentURL), savePath);
                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show($"An error occured during downloading: {ex.Message}{Environment.NewLine}Please try again later.", "Error - Update Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,{savePath}");
                }

                else if (dlChoice == (ushort)Form_Updates.Button.Standalone)
                {
                    DialogResult result = folderBrowserDialog_Updater.ShowDialog();
                    if (result == DialogResult.Cancel)
                        return;

                    string savePath = $"{folderBrowserDialog_Updater.SelectedPath}\\{jo.SelectToken($"assets[{standaloneIndex}].name")}";
                    try
                    {
                        webClient.DownloadFileAsync(new Uri(standaloneURL), savePath);
                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show($"An error occured during downloading: {ex.Message}{Environment.NewLine}Please try again later.", "Error - Update Tool", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    System.Diagnostics.Process.Start("explorer.exe", $"/select,{savePath}");
                }

                else
                {
                    return;
                }
                
            }
        }

        private void Updates_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            toolStripProgressBar.Value = e.ProgressPercentage;
            toolStripStatusLabel.Text = $"Downloading update: {e.BytesReceived / 1000} KB / {e.TotalBytesToReceive / 1000} KB";
        }

        private void Updater_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            toolStripStatusLabel.Text = "Download completed.";
            toolStripProgressBar.Value = toolStripProgressBar.Minimum;
        }

        /*
        /// <summary>
        /// Reads text aloud
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
                    configWriter.WriteLine($"allowExplicitJokes={Config_App_checkBox_JokeOption.Checked}");
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
