using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Morseapp_WinForms
{
    public partial class Form_Main
    {
        /// <summary>
        /// Method used to fetch a joke from the one of APIs.
        /// </summary>
        /// <param name="source">Int32 starting from 0, determining which API jokes provider will be used.</param>
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

                    // API data are downloaded as a string...
                    try
                    {
                        downloadData = webClient.DownloadString(URL);
                    }
                    catch (WebException ex)
                    {
                        return "Error:" + ex.Message;
                    }

                    // ...and then parsed into proper Json format
                    stringToJson = JObject.Parse(downloadData);

                    // extract the joke
                    if (stringToJson.GetValue("type").ToString() == "single")
                    {
                        joke = stringToJson.GetValue("joke").ToString();
                    }

                    // some jokes have two parts - these are concatenated into one line
                    else if (stringToJson.GetValue("type").ToString() == "twopart")
                    {
                        joke = stringToJson.GetValue("setup").ToString();
                        jokePart2 = stringToJson.GetValue("delivery").ToString();
                        joke = string.Concat(joke, ' ', jokePart2);
                    }
                    break;

                case 1:
                    URL = "https://api.chucknorris.io/jokes/random";
                    try
                    {
                        do
                        {
                            downloadData = webClient.DownloadString(URL);
                        } while (!option && downloadData.Contains("[\"explicit\"]"));    // try download another joke if explicit ones are disallowed
                    }
                    catch (WebException ex)
                    {
                        return "Error:" + ex.Message;
                    }

                    stringToJson = JObject.Parse(downloadData);
                    joke = stringToJson.GetValue("value").ToString();
                    break;

                case 2:
                    if (option) URL = "https://official-joke-api.appspot.com/jokes/programming/random";    // any category
                    else URL = "https://official-joke-api.appspot.com/random_joke";                        // programming only

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
                    joke = joke.Replace("#", "Sharp");    // some C# related jokes are being returned, but Morse code doesn't have value for '#' symbol
                    break;
            }

            // some occuring symbols that can be replaced with another, close and valid symbol - very few jokes now throw an error when converted into Morse code
            joke = joke.Replace('[', '(').Replace(']', ')').Replace('’', '\'').Replace('`', '\'').Replace("\r", string.Empty).Replace("\n", string.Empty);
            return joke;
        }

        /// <summary>
        /// Loads application settings and applies them if valid, including localization.
        /// </summary>
        /// <param name="configFile">File holding configuration data.</param>
        private void LoadConfig(string configFile)
        {
            string configContent = File.ReadAllText(configFile);
            int index;
            string tempValue = "";

            // Language:
            // find index with language settings
            index = configContent.LastIndexOf("language=");
            // if file contains desired setting
            if (index != -1)
            {
                // move to position where language settings data is stored
                index += "language=".Length;
                // the setting is stored as a number value, in case it would be a number with more than one digit we read until there is not a char representing a number
                for (; char.IsNumber(configContent[index]); ++index)
                {
                    tempValue += configContent[index];
                }
            }
            // try parsing string-formatted number into Int32 variable langID, information if it worked is not needed here, so it's discarded
            _ = int.TryParse(tempValue, out langID);
            // use the found data to correctly set app's language at startup
            Config_App_comboBox_Lang.SelectedIndex = SetLanguage(langID);
            // clear tempValue to use for reading another settings value
            tempValue = "";

            // Jokes provider:
            index = configContent.LastIndexOf("jokesProvider=");
            if (index != -1)
            {
                index += "jokesProvider=".Length;
                for (; char.IsNumber(configContent[index]); ++index)
                {
                    tempValue += configContent[index];
                }
            }
            _ = int.TryParse(tempValue, out jokesID);
            Config_App_comboBox_Jokes.SelectedIndex = jokesID;
            tempValue = "";

            // Checkboxes:
            if (configContent.Contains("dynamicConversion=") && configContent.Contains("strictTiming=") && configContent.Contains("jokesOption="))
            {
                Config_App_checkBox_Dynamic.Checked = configContent.Contains("dynamicConversion=True");
                Config_App_checkBox_JokesOption.Checked = configContent.Contains("jokesOption=True");
                Config_Player_checkBox_StrictTiming.Checked = configContent.Contains("strictTiming=True");
            }

            // Speed:
            index = configContent.LastIndexOf("speed=");
            if (index != -1)
            {
                index += "speed=".Length;
                while (char.IsNumber(configContent[index]))
                {
                    tempValue += configContent[index];
                    ++index;
                }
                Config_Player_trackBar_Speed.Value = Convert.ToInt32(tempValue);
            }
            tempValue = "";

            // Frequency:
            index = configContent.LastIndexOf("frequency=");
            if (index != -1)
            {
                index += "frequency=".Length;
                while (char.IsNumber(configContent[index]))
                {
                    tempValue += configContent[index];
                    ++index;
                }
                Config_Player_trackBar_Freq.Value = Convert.ToInt32(tempValue);
            }
        }

        /// <summary>
        /// Generates file storing the current application settings with up-to-date values.
        /// </summary>
        /// <param name="configFile">File holding configuration data.</param>
        private void SaveConfig(string configFile)
        {
            try
            {
                using (StreamWriter writer = new(configFile))
                {
                    writer.WriteLine("# This file contains user-configurable settings for the Morse Application found on the \"Configuration\" tab.");
                    writer.WriteLine("# If this file or its contents are deleted, it will be regenerated at next startup with default settings applied.");
                    writer.WriteLine("[Application]");
                    writer.WriteLine($"language={Config_App_comboBox_Lang.SelectedIndex}");
                    writer.WriteLine($"dynamicConversion={Config_App_checkBox_Dynamic.Checked}");
                    writer.WriteLine($"jokesProvider={Config_App_comboBox_Jokes.SelectedIndex}");
                    writer.WriteLine($"jokesOption={Config_App_checkBox_JokesOption.Checked}");
                    writer.WriteLine("[Player]");
                    writer.WriteLine($"speed={player_Speed}");
                    writer.WriteLine($"frequency={player_Frequency}");
                    writer.WriteLine($"strictTiming={Config_Player_checkBox_StrictTiming.Checked}");
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(GetLocStr("ERROR_ConfigSaving").Replace("{ex.Message}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

    public partial class Form_Updates
    {
        /// <summary>
        /// Property to store where user chose to download the update.
        /// </summary>
        public string UpdateSavePath { get; set; }

        private Form_Main fm;

        /// <summary>
        /// Application Updater mechanism.
        /// </summary>
        /// <param name="fmInstance">Currently running instance of Form_Main, so its public objects can be managed inside Form_Updates class. Used for reporting downloading progress.</param>
        public void CheckForUpdates(in Form_Main fmInstance)
        {
            fm = fmInstance;
            const string GitHubAPI = "https://api.github.com/repos/petrmarak/Morseapp/releases/latest";
            string downloadData = "";
            bool retry = default;
            using WebClient webClient = new();
            // GitHub API doesn't allow connections without user-agent set
            webClient.Headers.Add("user-agent", $"petrmarak; {Application.ProductName} v{Application.ProductVersion}");
            
            do
            {
                try
                {
                    // download all Json-formatted information related to latest app release as a string
                    downloadData = webClient.DownloadString(GitHubAPI);
                }
                catch (WebException ex)
                {
                    // if error occured, show information to the user
                    DialogResult errorChoice = MessageBox.Show($"{ex.Message}{Environment.NewLine}{GetLocStr("ChkERROR_Message")}", GetLocStr("ChkERROR_Title"), MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (errorChoice == DialogResult.Retry)
                        retry = true;
                    else if (errorChoice == DialogResult.Cancel)
                        return;
                }
            } while (retry);

            // correctly parse downloaded string into Json
            JObject jo = JObject.Parse(downloadData);
            // get app version with first 'v' letter removed
            upToDateVersion = jo.GetValue("tag_name").ToString().TrimStart('v');
            // get changelog
            changeLog = jo.GetValue("body").ToString();

            byte sectionIndex = 0;
            string dependentURL = "";
            byte dependentIndex = 0;
            string standaloneURL = "";
            byte standaloneIndex = 0;

            // find section inside Json file for each app variant with relevant information
            while (jo.SelectToken($"assets[{sectionIndex}].browser_download_url") != null)
            {
                string temp = jo.SelectToken($"assets[{sectionIndex}].browser_download_url").ToString();
                if (temp.Contains("depend", StringComparison.OrdinalIgnoreCase))
                {
                    dependentURL = temp;              // .NET dependent download URL
                    dependentIndex = sectionIndex;    // index of section with .NET dependent variant information
                }

                else if (temp.Contains("standalone", StringComparison.OrdinalIgnoreCase))
                {
                    standaloneURL = temp;              // Standalone download URL
                    standaloneIndex = sectionIndex;    // index of section with Standalone variant information
                }
                ++sectionIndex;
            }

            // get download size in MB of each variant so it can be shown to the user
            dependentSize = MathF.Round(((float)jo.SelectToken($"assets[{dependentIndex}].size")) / 1048576, 2);
            standaloneSize = MathF.Round(((float)jo.SelectToken($"assets[{standaloneIndex}].size")) / 1048576, 2);

            byte dlChoice;
            DialogResult dlAnywayChoice;
            bool forceUpdate = default;
            int runVerNum = Convert.ToInt32(Application.ProductVersion.Replace(".", string.Empty));
            int newVerNum = Convert.ToInt32(upToDateVersion.Replace(".", string.Empty));

            if (runVerNum == newVerNum)
            {
                MessageBox.Show(GetLocStr("ISCURRENT_Message"), GetLocStr("ISCURRENT_Title"), MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            else if (runVerNum > newVerNum)
            {
                dlAnywayChoice = MessageBox.Show(GetLocStr("DEV_Message"), GetLocStr("DEV_Title"), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dlAnywayChoice == DialogResult.Yes)
                    forceUpdate = true;
                else
                    return;
            }

            if (runVerNum < newVerNum || forceUpdate)
            {
                this.ShowDialog();
                dlChoice = buttonClicked;
                
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(Updates_DownloadProgressChanged);
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Updater_DownloadFileCompleted);

                folderBrowserDialog_Updater.AutoUpgradeEnabled = true;
                folderBrowserDialog_Updater.Description = GetLocStr("MAIN_FolderBrowser_Description");
                folderBrowserDialog_Updater.UseDescriptionForTitle = true;

                if (dlChoice == (byte)UpdateButton.Dependent)
                {
                    // user can select where the downloaded file will be saved
                    DialogResult result = folderBrowserDialog_Updater.ShowDialog();
                    if (result == DialogResult.Cancel)
                        return;

                    // file will be saved into folder selected by user under its name
                    UpdateSavePath = $"{folderBrowserDialog_Updater.SelectedPath}\\{jo.SelectToken($"assets[{dependentIndex}].name")}";
                    try
                    {
                        webClient.DownloadFileAsync(new Uri(dependentURL), UpdateSavePath);
                    }
                    catch (WebException ex)
                    {
                        // if error occured, show information to the user
                        MessageBox.Show($"{ex.Message}{Environment.NewLine}{GetLocStr("DlERROR_Message")}", GetLocStr("DlERROR_Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                else if (dlChoice == (byte)UpdateButton.Standalone)
                {
                    DialogResult result = folderBrowserDialog_Updater.ShowDialog();
                    if (result == DialogResult.Cancel)
                        return;

                    UpdateSavePath = $"{folderBrowserDialog_Updater.SelectedPath}\\{jo.SelectToken($"assets[{standaloneIndex}].name")}";
                    try
                    {
                        webClient.DownloadFileAsync(new Uri(standaloneURL), UpdateSavePath);
                    }
                    catch (WebException ex)
                    {
                        MessageBox.Show($"{ex.Message}{Environment.NewLine}{GetLocStr("DlERROR_Message")}", GetLocStr("DlERROR_Title"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                else
                {
                    return;
                }
            }
        }

        private void Updates_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            fm.toolStripProgressBar.Value = e.ProgressPercentage;
            fm.toolStripStatusLabel.Text = $"Downloading update: {e.BytesReceived / 1000} KB / {e.TotalBytesToReceive / 1000} KB";
        }

        private void Updater_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            fm.toolStripStatusLabel.Text = "Download completed.";
            fm.toolStripProgressBar.Value = fm.toolStripProgressBar.Minimum;
            // when finished, open File Explorer with downloaded file selected
            System.Diagnostics.Process.Start("explorer.exe", $"/select,{UpdateSavePath}");
            this.Dispose();
        }
    }
}
