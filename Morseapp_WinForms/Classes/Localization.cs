using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morseapp_WinForms
{
    public partial class Form_Main
    {
        enum Language
        {
            English,
            Czech
        }

        // Localization strings declaration:
        string SYSMENU_Restart;
        string SYSMENU_EnableVisualStyles;
        string SYSMENU_About;

        string[] MESSAGEBOX_About_Text;
        string MESSAGEBOX_About_Title;

        string STATUS_Default;
        string STATUS_Button_Copy;

        // Coder
        string NAME_Coder;
        string NAME_Coder_Input;
        string NAME_Coder_Joke;
        string NAME_Coder_Convert;
        string NAME_Coder_Output;
        string NAME_Coder_PlaySound;

        string STATUS_Coder_Input;
        string STATUS_Coder_Joke_Hover;
        string STATUS_Coder_Joke_Invoked;
        string STATUS_Coder_Convert;
        string STATUS_Coder_Output;
        string STATUS_Coder_Tip_Title;
        string STATUS_Coder_Tip_Caption;

        // Decoder
        string NAME_Decoder;
        string NAME_Decoder_Input;
        string NAME_Decoder_Convert;
        string NAME_Decoder_Output;

        string STATUS_Decoder_Input;
        string STATUS_Decoder_Convert;
        string STATUS_Decoder_Output;
        string STATUS_Decoder_Tip_Title;
        string STATUS_Decoder_Tip_Caption;

        // Player
        string NAME_Player;
        string NAME_Player_Input;
        string NAME_Player_PlaySound;

        string STATUS_Player_Input;
        string STATUS_Player_PlaySound_Hover;
        string STATUS_Player_PlaySound_Invoked;
        string STATUS_Player_StopSound;

        // Dictionary
        string NAME_Dictionary;
        string STATUS_Dictionary_RichTextBox;
        string STATUS_Dictionary_Refresh;

        // Configuration
        string NAME_Config;
        string NAME_Config_App;
        string NAME_Config_App_Lang;
        string NAME_Config_App_LangChanged_Note;
        string NAME_Config_App_LangChanged_NoteRestart;
        string NAME_Config_App_Dynamic;
        string NAME_Config_App_Explicit;
        string NAME_Config_App_About;
        string NAME_Config_Player;
        string NAME_Config_Player_Speed;
        string NAME_Config_Player_StrictTiming;
        string NAME_Config_Player_Freq;

        string STATUS_Config_App_Lang;
        string STATUS_Config_App_Dynamic;
        string STATUS_Config_App_Explicit;
        string STATUS_Config_App_GitHub_Link;
        string STATUS_Config_Player_Speed;
        string STATUS_Config_Player_StrictTiming;
        string STATUS_Config_Player_Freq;

        /// <summary>
        /// Localizes texts used in the application depending on the selected language.
        /// </summary>
        /// <param name="langID">Index of language to set. Corresponds to indices in Config_App_comboBox_Lang</param>
        /// <returns>Returns index of currently set language.</returns>
        private Language SetLanguage(int langID)
        {
            if (langID == (int)Language.Czech)
            {
                SYSMENU_Restart = "&Restartovat";
                SYSMENU_EnableVisualStyles = "&Povolit Vizuální styly";
                SYSMENU_About = "&O aplikaci...";

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
                MESSAGEBOX_About_Title = "O aplikaci";

                STATUS_Default = "Najeďte myší nad položky pro více informací";
                STATUS_Button_Copy = "Kliknutím se zkopíruje veškerý text";
                
                // Coder
                NAME_Coder = "Kodér";
                NAME_Coder_Input = "Vstupní text:";
                NAME_Coder_Joke = "Vložit vtip";
                NAME_Coder_Convert = "Převést";
                NAME_Coder_Output = "Výsledek:";
                NAME_Coder_PlaySound = "Přehrát zvuk";

                STATUS_Coder_Input = "Napište text sestávající ze standardních alfanumerických symbolů";
                STATUS_Coder_Joke_Hover = "Stáhnout vtip z internetu";
                STATUS_Coder_Joke_Invoked = "Vtip se stahuje...";
                STATUS_Coder_Convert = "Převést na Morseův kód";
                STATUS_Coder_Output = "Vygenerovaný Morseův kód ze vstupního textu";
                STATUS_Coder_Tip_Title = "Nápověda:";
                STATUS_Coder_Tip_Caption = "Napsaný text → vygenerovaný Morseův kód";
                
                // localization
                Coder.Text = NAME_Coder;
                Coder_label_Input.Text = NAME_Coder_Input;
                Coder_button_Joke.Text = NAME_Coder_Joke;
                Coder_button_Convert.Text = NAME_Coder_Convert;
                Coder_label_Output.Text = NAME_Coder_Output;
                Coder_button_PlaySound.Text = NAME_Coder_PlaySound;

                // Decoder
                NAME_Decoder = "Dekodér";
                NAME_Decoder_Input = "Vstupní Morseův kód:";
                NAME_Decoder_Convert = "Převést";
                NAME_Decoder_Output = "Výsledek:";

                STATUS_Decoder_Input = "Napište Morseův kód";
                STATUS_Decoder_Convert = "Přeložit Morseův kód";
                STATUS_Decoder_Output = "Přeložený text ze vstupního Morseova kódu";
                STATUS_Decoder_Tip_Title = "Nápověda:";
                STATUS_Decoder_Tip_Caption = "Napsaný Morseův kód → přeložený text";

                // localization
                Decoder.Text = NAME_Decoder;
                Decoder_label_Input.Text = NAME_Decoder_Input;
                Decoder_button_Convert.Text = NAME_Decoder_Convert;
                Decoder_label_Output.Text = NAME_Decoder_Output;

                // Player
                NAME_Player = "Přehrávač";
                NAME_Player_Input = "Vstupní Morseův kód:";
                NAME_Player_PlaySound = "Přehrát zvuk";

                STATUS_Player_Input = "Napište Morseův kód";
                STATUS_Player_PlaySound_Hover = "Přehrát Morseův kód";
                STATUS_Player_PlaySound_Invoked = "Morseův kód je přehráván - stiskněte Esc pro zastavení";
                STATUS_Player_StopSound = "Zastavit přehrávání";

                // localization
                Player.Text = NAME_Player;
                Player_label_Input.Text = NAME_Player_Input;
                Player_button_Play.Text = NAME_Player_PlaySound;

                // Dictionary
                NAME_Dictionary = "Slovník";
                STATUS_Dictionary_RichTextBox = "Stisknutí Ctrl+A označí a následně Ctrl+C zkopíruje tabulku";
                STATUS_Dictionary_Refresh = "Obnovit tabulku";

                // localization
                Dictionary.Text = NAME_Dictionary;

                // Configuration
                NAME_Config = "Nastavení";
                NAME_Config_App = "Nastavení aplikace";
                NAME_Config_App_Lang = "Jazyk: / Language:";
                NAME_Config_App_LangChanged_Note = "Pro uplatnění změny jazyka musí být tato aplikace restartována.";
                NAME_Config_App_LangChanged_NoteRestart = "Restartovat nyní.";
                NAME_Config_App_Dynamic = "Dynamický překlad";
                NAME_Config_App_Explicit = "Povolit explicitní vtipy";
                NAME_Config_App_About = "     O aplikaci";
                NAME_Config_Player = "Nastavení přehrávače";
                NAME_Config_Player_Speed = "Rychlost přehrávání:";
                NAME_Config_Player_Freq = "Frekvence zvuku:";
                NAME_Config_Player_StrictTiming = "Striktní časování";

                STATUS_Config_App_Lang = "Vyberte preferovaný jazyk z rozbalovací nabídky";
                STATUS_Config_App_Dynamic = "Povolí okamžitou konverzi textu již během psaní";
                STATUS_Config_App_Explicit = "Povolí nebo zakáže zobrazování nevhodných vtipů";
                STATUS_Config_App_GitHub_Link = "Otevře repozitář se zdrojovým kódem a dokumentací k této aplikaci";
                STATUS_Config_Player_Speed = "Nastavitelná délka jednoho tónu v milisekundách, nižší hodnota = rychlejší přehrávání";
                STATUS_Config_Player_StrictTiming = "Přidá standardní prodlevu mezi jednotlivé Morseovy symboly, zpomalí přehrávání";
                STATUS_Config_Player_Freq = "Nastavitelná frekvence zvukových tónů";

                // localization
                Configuration.Text = NAME_Config;
                Config_groupBox_App.Text = NAME_Config_App;
                Config_App_label_Lang.Text = NAME_Config_App_Lang;
                Config_App_label_LangChanged.Text = NAME_Config_App_LangChanged_Note;
                Config_App_linkLabel_LangChanged.Text = NAME_Config_App_LangChanged_NoteRestart;
                Config_App_checkBox_Dynamic.Text = NAME_Config_App_Dynamic;
                Config_App_checkBox_JokeOption.Text = NAME_Config_App_Explicit;
                Config_App_button_About.Text = NAME_Config_App_About;
                Config_groupBox_Player.Text = NAME_Config_Player;
                Config_Player_label_Speed.Text = NAME_Config_Player_Speed;
                Config_Player_checkBox_StrictTiming.Text = NAME_Config_Player_StrictTiming;
                Config_Player_label_Freq.Text = NAME_Config_Player_Freq;

                return Language.Czech;
            }

            else
            {
                // Localization
                SYSMENU_Restart = "&Restart";
                SYSMENU_EnableVisualStyles = "&Enable Visual styles";
                SYSMENU_About = "&About…";
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
                MESSAGEBOX_About_Title = "About";
                STATUS_Default = "Hover over items for more details";
                STATUS_Button_Copy = "Click to copy all text";

                STATUS_Coder_Input = "Write text consisting of standard alphanumeric symbols";
                STATUS_Coder_Joke_Hover = "Downloads joke from the internet";
                STATUS_Coder_Joke_Invoked = "Joke is being downloaded...";
                STATUS_Coder_Convert = "Convert to Morse code";
                STATUS_Coder_Output = "Converted Morse code from standard text";
                STATUS_Coder_Tip_Title = "Hint:";
                STATUS_Coder_Tip_Caption = "Written text → Converted Morse code";
                STATUS_Decoder_Input = "Write Morse code";
                STATUS_Decoder_Convert = "Get standard text from Morse code";
                STATUS_Decoder_Output = "Translated text from inputted Morse code";
                STATUS_Decoder_Tip_Title = "Hint:";
                STATUS_Decoder_Tip_Caption = "Written Morse code → Decoded text";
                STATUS_Player_Input = "Write Morse code for playback";
                STATUS_Player_PlaySound_Hover = "Play result Morse code with sound";
                STATUS_Player_PlaySound_Invoked = "Morse code is being played - press Esc to STOP";
                STATUS_Player_StopSound = "Stop playback";
                STATUS_Dictionary_RichTextBox = "Press Ctrl+A to select all text and Ctrl+C to copy the contents";
                STATUS_Dictionary_Refresh = "Refresh the table";
                STATUS_Config_App_Lang = "Choose preferred language from the drop-down menu";
                STATUS_Config_App_Dynamic = "Enable on-the-fly conversion of the inputted text";
                STATUS_Config_App_Explicit = "Allow or disallow showing of inappropriate jokes";
                STATUS_Config_App_GitHub_Link = "Opens repository with source code and documentation for this application";
                STATUS_Config_Player_Speed = "Adjustable length of one sound tone in milliseconds, lower value = faster playback";
                STATUS_Config_Player_StrictTiming = "Adds standard delay between each Morse symbols, slows down playback";
                STATUS_Config_Player_Freq = "Adjustable frequency of sound tones";

                return Language.English;
            }
        }
    }
}
