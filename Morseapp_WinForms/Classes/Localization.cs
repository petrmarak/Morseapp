using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morseapp_WinForms
{
    public partial class Form_Main
    {
        public enum Language
        {
            English,
            Czech
        }

        private Dictionary<string, string> LocalizedStrings { get; set; }

        /// <summary>
        /// Localizes texts used in the application depending on the selected language.
        /// </summary>
        /// <param name="langID">Index of language to set. Corresponds to Form_Main.Config_App_comboBox_Lang.SelectedIndex.</param>
        /// <returns>Returns index of currently set language.</returns>
        private int SetLanguage(int langID)
        {
            if (langID == (int)Language.Czech)
            {
                LocalizedStrings = new()
                {
                    { "SYSMENU_Restart", "&Restartovat" },
                    { "SYSMENU_EnableVisualStyles", "&Povolit Vizuální styly" },
                    { "SYSMENU_About", "&O aplikaci..." },
                    { "STATUS_Default", "Najeďte myší nad položky pro více informací" },
                    { "STATUS_Button_Copy", "Zkopírovat výsledek" },
                    { "STATUS_Click_Button_Copy", "Výsledek byl zkopírován do schránky"},
                    { "TIP_Button_Config", "Změňte nastavení, jako rychlost přehrávání, výběr vtipů či zda se má text převádět ihned během psaní." },
                    { "TIP_Title", "Tip:" },
                    { "ERROR_ConfigSaving", $"Nastala chyba během ukládání uživatelského nastavení do souboru {configFile}: {Environment.NewLine}{{ex.Message}}" },

                    { "Coder", "Kodér" },
                    { "Coder_Input", "Vstupní text:" },
                    { "Coder_Joke", "Vložit vtip"},
                    { "Coder_Convert", "Převést"},
                    { "Coder_Output", "Výsledek:"},
                    { "STATUS_Coder_Input", "Napište text sestávající ze standardních alfanumerických symbolů"},
                    { "STATUS_Coder_Joke_Hover", "Stáhnout vtip z internetu"},
                    { "STATUS_Coder_Joke_Invoked", "Vtip se stahuje..."},
                    { "STATUS_Coder_Convert", "Převést na Morseův kód"},
                    { "STATUS_Coder_Output", "Vygenerovaný Morseův kód ze vstupního textu"},
                    { "TIP_Coder_Caption", "Napsaný text → vygenerovaný Morseův kód"},

                    { "Decoder", "Dekodér" },
                    { "Decoder_Input", "Vstupní Morseův kód:" },
                    { "Decoder_Convert", "Převést" },
                    { "Decoder_Output", "Výsledek:" },
                    { "STATUS_Decoder_Input", "Napište Morseův kód"},
                    { "STATUS_Decoder_Convert", "Přeložit Morseův kód"},
                    { "STATUS_Decoder_Output", "Přeložený text ze vstupního Morseova kódu"},
                    { "TIP_Decoder_Caption", "Napsaný Morseův kód → přeložený text"},

                    { "Player", "Přehrávač"},
                    { "Player_Input", "Vstupní Morseův kód:"},
                    { "STATUS_Player_Input", "Napište Morseův kód" },
                    { "STATUS_Player_PlaySound_Hover", "Přehrát Morseův kód" },
                    { "STATUS_Player_PlaySound_Invoked", "Morseův kód je přehráván - stiskněte Esc pro zastavení" },
                    { "STATUS_Player_StopSound", "Zastavit přehrávání" },
                    { "TIP_Player_Caption", "Napsaný Morseův kód → přehrávané dlouhé a krátké tóny" },

                    { "Dictionary", "Slovník" },
                    { "STATUS_Dictionary_RichTextBox", "Stisknutí Ctrl+A označí a následně Ctrl+C zkopíruje tabulku" },
                    { "STATUS_Dictionary_Refresh", "Obnovit výpis" },

                    { "Config", "Nastavení" },
                    { "Config_App", "Nastavení aplikace" },
                    { "Config_App_Lang", "Jazyk: (Language:)" },
                    { "Config_App_LangChanged_Note", "Pro uplatnění změny jazyka musí být tato aplikace restartována." },
                    { "Config_App_LangChanged_NoteRestart", "Restartovat nyní." },
                    { "Config_App_Dynamic", "Dynamický překlad" },
                    { "Config_App_Jokes", "Poskytovatel vtipů:" },
                    { "Config_App_ExplicitJokes", "Povolit explicitní vtipy" },
                    { "Config_App_ProgrammingJokes", "Pouze programátorské vtipy" },
                    { "Config_App_Updates", "Zkontrolovat aktualizace" },
                    { "Config_App_About", "     O aplikaci" },
                    { "Config_Player", "Nastavení přehrávače" },
                    { "Config_Player_Speed", "Rychlost přehrávání:" },
                    { "Config_Player_Freq", "Frekvence zvuku:" },
                    { "Config_Player_StrictTiming", "Striktní časování" },
                    { "STATUS_Config_App_Lang", "Vyberte preferovaný jazyk z rozbalovací nabídky" },
                    { "STATUS_Config_App_Dynamic", "Povolí okamžitou konverzi textu již během psaní" },
                    { "STATUS_Config_App_Jokes", "Vyberte zdroj, odkud se budou stahovat vtipy" },
                    { "STATUS_Config_App_ExplicitJokes", "Povolí nebo zakáže zobrazování nevhodných vtipů" },
                    { "STATUS_Config_App_ProgrammingJokes", "Povolit pouze vtipy o programování" },
                    { "STATUS_Config_App_Updates", "Zjistí, zda existuje nová verze a umožní její stažení" },
                    { "STATUS_Config_App_About", "Verze aplikace, použité technologie a zdroje" },
                    { "STATUS_Config_Player_Speed", "Nastavitelná délka jednoho tónu v milisekundách, nižší hodnota = rychlejší přehrávání" },
                    { "STATUS_Config_Player_StrictTiming", "Přidá standardní prodlevu mezi jednotlivé Morseovy symboly, zpomalí přehrávání" },
                    { "STATUS_Config_Player_Freq", "Nastavitelná frekvence zvukových tónů" }
                };

                Coder.Text = GetLocStr("Coder");
                Coder_label_Input.Text = GetLocStr("Coder_Input");
                Coder_button_Joke.Text = GetLocStr("Coder_Joke");
                Coder_button_Convert.Text = GetLocStr("Coder_Convert");
                Coder_label_Output.Text = GetLocStr("Coder_Output");
                Decoder.Text = GetLocStr("Decoder");
                Decoder_label_Input.Text = GetLocStr("Decoder_Input");
                Decoder_button_Convert.Text = GetLocStr("Decoder_Convert");
                Decoder_label_Output.Text = GetLocStr("Decoder_Output");
                Player.Text = GetLocStr("Player");
                Player_label_Input.Text = GetLocStr("Player_Input");
                Dictionary.Text = GetLocStr("Dictionary");

                Configuration.Text = GetLocStr("Config");
                Config_groupBox_App.Text = GetLocStr("Config_App");
                Config_App_label_Lang.Text = GetLocStr("Config_App_Lang");
                Config_App_label_LangChanged.Text = GetLocStr("Config_App_LangChanged_Note");
                Config_App_linkLabel_LangChanged.Text = GetLocStr("Config_App_LangChanged_NoteRestart");
                Config_App_checkBox_Dynamic.Text = GetLocStr("Config_App_Dynamic");
                Config_App_label_Jokes.Text = GetLocStr("Config_App_Jokes");
                Config_App_button_Updates.Text = GetLocStr("Config_App_Updates");
                Config_App_button_About.Text = GetLocStr("Config_App_About");
                Config_groupBox_Player.Text = GetLocStr("Config_Player");
                Config_Player_label_Speed.Text = GetLocStr("Config_Player_Speed");
                Config_Player_checkBox_StrictTiming.Text = GetLocStr("Config_Player_StrictTiming");
                Config_Player_label_Freq.Text = GetLocStr("Config_Player_Freq");

                return (int)Language.Czech;
            }

            else
            {
                LocalizedStrings = new()
                {
                    { "SYSMENU_Restart", "&Restart" },
                    { "SYSMENU_EnableVisualStyles", "&Enable Visual styles" },
                    { "SYSMENU_About", "&About…" },
                    { "STATUS_Default", "Hover over items for more details" },
                    { "STATUS_Button_Copy", "Copy the result" },
                    { "STATUS_Click_Button_Copy", "The result has been copied to your clipboard" },
                    { "TIP_Button_Config", "Change settings such as language, playback speed, type of jokes or dynamic text conversion." },
                    { "TIP_Title", "Hint:" },
                    { "ERROR_ConfigSaving", $"An error occured during saving user configuration to {configFile} file: {Environment.NewLine}{{ex.Message}}" },

                    { "STATUS_Coder_Input", "Write text consisting of standard alphanumeric symbols" },
                    { "STATUS_Coder_Joke_Hover", "Downloads joke from the internet" },
                    { "STATUS_Coder_Joke_Invoked", "Joke is being downloaded..." },
                    { "STATUS_Coder_Convert", "Convert to Morse code" },
                    { "STATUS_Coder_Output", "Converted Morse code from standard text" },
                    { "TIP_Coder_Caption", "Written text → Converted Morse code" },
                    { "STATUS_Decoder_Input", "Write Morse code" },
                    { "STATUS_Decoder_Convert", "Get standard text from Morse code" },
                    { "STATUS_Decoder_Output", "Translated text from inputted Morse code" },
                    { "TIP_Decoder_Caption", "Written Morse code → Decoded text" },
                    { "STATUS_Player_Input", "Write Morse code for playback" },
                    { "STATUS_Player_PlaySound_Hover", "Play Morse code with sound" },
                    { "STATUS_Player_PlaySound_Invoked", "Morse code is being played - press Esc to STOP" },
                    { "STATUS_Player_StopSound", "Stop playback" },
                    { "TIP_Player_Caption", "Written Morse code → long and short tones played" },
                    { "STATUS_Dictionary_RichTextBox", "Use copy all button or press Ctrl+A and Ctrl+C to copy the contents" },
                    { "STATUS_Dictionary_Refresh", "Refresh the table" },

                    { "Config_App_ExplicitJokes", "Allow explicit jokes" },
                    { "Config_App_ProgrammingJokes", "Only programming jokes" },
                    { "STATUS_Config_App_Lang", "Choose preferred language from the drop-down menu" },
                    { "STATUS_Config_App_Dynamic", "Enable on-the-fly conversion of the inputted text" },
                    { "STATUS_Config_App_Jokes", "Choose source for downloading jokes" },
                    { "STATUS_Config_App_ExplicitJokes", "Allow or disallow showing of inappropriate jokes" },
                    { "STATUS_Config_App_ProgrammingJokes", "Allow only jokes about programming" },
                    { "STATUS_Config_App_Updates", "Checks for new version and allows its download" },
                    { "STATUS_Config_App_About", "App version, used technologies and sources" },
                    { "STATUS_Config_Player_Speed", "Adjustable length of one sound tone in milliseconds, lower value = faster playback" },
                    { "STATUS_Config_Player_StrictTiming", "Adds standard delay between each Morse symbols, slows down playback" },
                    { "STATUS_Config_Player_Freq", "Adjustable frequency of sound tones" },
                };

                return (int)Language.English;
            }
        }

        /// <summary>
        /// Returns localized string based on currently set language.
        /// </summary>
        /// <param name="key">Key to search for in internal dictionary.</param>
        /// <returns>Correctly localized string.</returns>
        public string GetLocStr(string key)
        {
            // Safety mechanism, so this method always returns valid values.
            if (LocalizedStrings == null)
                SetLanguage(Form_Main.langID);
            // Throw exception only under DEBUG mode, when we try to access localized string that isn't defined inside LocalizedStrings dictionary.
#if DEBUG
            if (LocalizedStrings.GetValueOrDefault(key) == default)
                throw new ArgumentException("Requested value was not found in LocalizedStrings dictionary: " + key);
#endif
            return LocalizedStrings.GetValueOrDefault(key);
        }
    }

    public partial class Form_Updates
    {
        private Dictionary<string, string> LocalizedStrings { get; set; }

        /// <summary>
        /// Localizes texts used in the form depending on the selected language.
        /// </summary>
        /// <param name="langID">Index of language to set. Corresponds to Form_Main.Config_App_comboBox_Lang.SelectedIndex.</param>
        private void SetLanguage(int langID)
        {
            if (langID == (int)Form_Main.Language.Czech)
            {
                LocalizedStrings = new()
                {
                    { "MAIN_Title", $"{Application.ProductName} aktualizační nástroj v{Application.ProductVersion}" },
                    { "MAIN_Header", $"Je dostupná nová aktualizace: verze {upToDateVersion}" },
                    { "MAIN_Choose", $"Kterou variantu si přejete stáhnout? Najeďte nad tlačítka pro více informací." },
                    { "MAIN_Button_Dependent", "Vyžadující .NET" },
                    { "MAIN_Button_Standalone", "Samostatná" },
                    { "MAIN_Button_Cancel", "Zrušit" },
                    { "MAIN_TIP_Button_Dependent", $"Vyžaduje nainstalovaný Microsoft .NET runtime - aplikace na to v případě potřeby upozorní.{Environment.NewLine}Velikost: {dependentSize} MB." },
                    { "MAIN_TIP_Button_Standalone", $"Samostatný .exe soubor s vestavěným .NET runtime.{Environment.NewLine}Velikost: {standaloneSize} MB." },
                    { "MAIN_TIP_Button_Cancel", "Zrušit aktualizaci." },
                    { "MAIN_FolderBrowser_Description", "Zvolte, kam se má aktualizace uložit" },

                    { "ISCURRENT_Title", $"Aktualizační nástroj v{Application.ProductVersion}" },
                    { "ISCURRENT_Message", "V tuto chvíli není k dispozici žádná aktualizace. Používáte nejnovější verzi." },

                    { "DEV_Title", $"Aktualizační nástroj v{Application.ProductVersion}" },
                    { "DEV_Message", $"Tato aplikace je nevydaná verze ve vývoji.{Environment.NewLine}Oficiální vydání má verzi {upToDateVersion}.{Environment.NewLine}Přejete si i tak stáhnout vydanou verzi?" },

                    { "ChkERROR_Title", "Kontrola aktualizací se nezdařila" },
                    { "ChkERROR_Message", $"Zkontrolujte své internetové připojení a zkuste to znovu později.{Environment.NewLine}Pokud problém přetrvává, stáhněte aplikaci přímo z GitHubu skrze tlačítko v dialogu O aplikaci." },

                    { "DlERROR_Title", "Chyba během stahování aktualizace" },
                    { "DlERROR_Message", $"Zkontrolujte své internetové připojení a zkuste to znovu později.{Environment.NewLine}Pokud problém přetrvává, stáhněte aplikaci přímo z GitHubu skrze tlačítko v dialogu O aplikaci." },
                };
            }

            else
            {
                LocalizedStrings = new()
                {
                    { "MAIN_Title", $"{Application.ProductName} update tool v{Application.ProductVersion}" },
                    { "MAIN_Header", $"A new update is available: version {upToDateVersion}" },
                    { "MAIN_Choose", $"Which variant would you like to download? Hover over buttons for more details." },
                    { "MAIN_Button_Dependent", ".NET Dependent" },
                    { "MAIN_Button_Standalone", "Standalone" },
                    { "MAIN_Button_Cancel", "Cancel" },
                    { "MAIN_TIP_Button_Dependent", $"Requires Microsoft .NET runtime to be installed - application will tell you if it's necessary.{Environment.NewLine}Size: {dependentSize} MB." },
                    { "MAIN_TIP_Button_Standalone", $"Single .exe file with .NET runtime built-in.{Environment.NewLine}Size: {standaloneSize} MB." },
                    { "MAIN_TIP_Button_Cancel", "Abort the update." },
                    { "MAIN_FolderBrowser_Description", "Choose where do you want to save the update" },

                    { "ISCURRENT_Title", $"Update tool v{Application.ProductVersion}" },
                    { "ISCURRENT_Message", $"There is no new version available at this time.{Environment.NewLine}Application is up to date." },

                    { "DEV_Title", $"Update tool v{Application.ProductVersion}" },
                    { "DEV_Message", $"This is an unreleased in-development version.{Environment.NewLine}Official release is {upToDateVersion}.{Environment.NewLine}Would you like to download the released one anyway?" },

                    { "ChkERROR_Title", "Unable to check for updates" },
                    { "ChkERROR_Message", $"Check you internet connection and please try again later.{Environment.NewLine}If this problem persists, download the application directly from GitHub through button in the About dialog." },

                    { "DlERROR_Title", "An error occured during downloading the update" },
                    { "DlERROR_Message", $"Check you internet connection and please try again later.{Environment.NewLine}If this problem persists, download the application directly from GitHub through button in the About dialog." },
                };
            }

            this.Text = GetLocStr("MAIN_Title");
            label_Title.Text = GetLocStr("MAIN_Header").Replace("{upToDateVersion}", upToDateVersion);
            label_Choose.Text = GetLocStr("MAIN_Choose");
            button_Dependent.Text = GetLocStr("MAIN_Button_Dependent");
            button_Standalone.Text = GetLocStr("MAIN_Button_Standalone");
            button_Cancel.Text = GetLocStr("MAIN_Button_Cancel");

            toolTip.SetToolTip(button_Dependent, GetLocStr("MAIN_TIP_Button_Dependent"));
            toolTip.SetToolTip(button_Standalone, GetLocStr("MAIN_TIP_Button_Standalone"));
            toolTip.SetToolTip(button_Cancel, GetLocStr("MAIN_TIP_Button_Cancel"));
        }

        /// <summary>
        /// Returns localized string based on currently set language.
        /// </summary>
        /// <param name="key">Key to search for in internal dictionary.</param>
        /// <returns>Correctly localized string.</returns>
        public string GetLocStr(string key)
        {
            if (LocalizedStrings == null)
                SetLanguage(Form_Main.langID);
#if DEBUG
            if (LocalizedStrings.GetValueOrDefault(key) == default)
                throw new ArgumentException("Requested value was not found in LocalizedStrings dictionary: " + key);
#endif
            return LocalizedStrings.GetValueOrDefault(key);
        }
    }

    public partial class Form_About
    {
        private Dictionary<string, string> LocalizedStrings { get; set; }
        public string[] MESSAGEBOX_About_Text { get; private set; }

        /// <summary>
        /// Localizes texts used in the form depending on the selected language.
        /// </summary>
        /// <param name="langID">Index of language to set. Corresponds to Form_Main.Config_App_comboBox_Lang.SelectedIndex.</param>
        private void SetLanguage(int langID)
        {
            if (langID == (int)Form_Main.Language.Czech)
            {
                MESSAGEBOX_About_Text = new string[]
                {
                    $"Grafické uživatelské rozhraní pro {Application.ProductName}.",
                    $"\t\tVerze {Application.ProductVersion}",
                    $"Vytvořeno pomocí Windows Forms v .NET {Environment.Version}",
                    string.Empty,
                    $"Aplikace\t\t©2021 Petr Mařák",
                    $"Morseův kód\t©1838 Samuel Morse",
                    $"Hlavní ikona\thttps://flaticon.com",
                    $"Další ikony\t©2021 Microsoft Corporation",
                    $"Vtipy\t\thttps://v2.jokeapi.dev",
                    "\t\thttps://api.chucknorris.io",
                    "\t\thttps://official-joke-api.appspot.com"
                };

                LocalizedStrings = new()
                {
                    { "Form_Title", "O aplikaci" },
                    { "TIP_Button_GitHub", "Otevře GitHub repozitář se zdrojovými kódy aplikace, dokumentací a možností kontaktovat autora." },
                    { "Button_Close", "Zavřít" },
                };

                this.Text = GetLocStr("Form_Title");
                button_Close.Text = GetLocStr("Button_Close");
            }

            else
            {
                MESSAGEBOX_About_Text = new string[]
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

                LocalizedStrings = new()
                {
                    { "Form_Title", "About..." },
                    { "TIP_Button_GitHub", "Opens home GitHub repository with application source code, documentation or contact the author." },
                    { "Button_Close", "Close" },
                };
            }
        }

        /// <summary>
        /// Returns localized string based on currently set language.
        /// </summary>
        /// <param name="key">Key to search for in internal dictionary.</param>
        /// <returns>Correctly localized string.</returns>
        public string GetLocStr(string key)
        {
            if (LocalizedStrings == null)
                SetLanguage(Form_Main.langID);
#if DEBUG
            if (LocalizedStrings.GetValueOrDefault(key) == default)
                throw new ArgumentException("Requested value was not found in LocalizedStrings dictionary: " + key);
#endif
            return LocalizedStrings.GetValueOrDefault(key);
        }
    }
}
