using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Morseapp_WinForms
{
    public static class Morse
    {
        /// <summary>
        /// Sorted list used for encoding and decoding between ASCII and Morse code.
        /// Key<char> = ASCII symbol
        /// Value<string> = Corresponding Morse code word
        /// </summary>
        private static readonly SortedList<char, string> morseList = new()
        {
            { 'a', ".-" },
            { 'b', "-..." },
            { 'c', "-.-." },
            { 'd', "-.." },
            { 'e', "." },
            { 'f', "..-." },
            { 'g', "--." },
            { 'h', "...." },
            { 'i', ".." },
            { 'j', ".---" },
            { 'k', "-.-" },
            { 'l', ".-.." },
            { 'm', "--" },
            { 'n', "-." },
            { 'o', "---" },
            { 'p', ".--." },
            { 'q', "--.-" },
            { 'r', ".-." },
            { 's', "..." },
            { 't', "-" },
            { 'u', "..-" },
            { 'v', "...-" },
            { 'w', ".--" },
            { 'x', "-..-" },
            { 'y', "-.--" },
            { 'z', "--.." },
            { '0', "-----" },
            { '1', ".----" },
            { '2', "..---" },
            { '3', "...--" },
            { '4', "....-" },
            { '5', "....." },
            { '6', "-...." },
            { '7', "--..." },
            { '8', "---.." },
            { '9', "----." },
            { '.', ".-.-.-" },
            { ',', "--..--" },
            { '?', "..--.." },
            { '\'', ".----." },
            { '!', "-.-.--" },
            { '/', "-..-." },
            { '(', "-.--." },
            { ')', "-.--.-" },
            { '&', ".-..." },
            { ':', "---..." },
            { ';', "-.-.-." },
            { '=', "-...-" },
            { '+', ".-.-." },
            { '-', "-....-" },
            { '_', "..--.-" },
            { '"', ".-..-." },
            { '$', "...-..-" },
            { '@', ".--.-." },
            { ' ', "/" }
        };

        /// <summary>
        /// Method for encoding ASCII symbols into Morse code words.
        /// </summary>
        /// <param name="input">String entered by user consisting of ASCII symbols.</param>
        /// <returns>Returns encoded string of Morse code words.</returns>
        public static string Coder(string input)
        {
            input = input.ToLower();
            StringBuilder encoded = new();

            foreach (var symbol in input)
            {
                if (!morseList.TryGetValue(symbol, out string value))
                    return "Error: The input text contains symbols that can't be encoded.";
                encoded.Append(value);
                encoded.Append(' ');
            }

            return encoded.ToString().TrimEnd();
        }

        /// <summary>
        /// Method for decoding Morse code words into ASCII symbols.
        /// </summary>
        /// <param name="input">String entered by user consisting of valid Morse code words, each separated by space.</param>
        /// <returns>Returns decoded Morse code as string of ASCII symbols.</returns>
        public static string Decoder(string input)
        {
            StringBuilder decoded = new();
            string codeWord = "";
            int codeWordIndex;
            input = input.Replace("   ", " / ");

            for (int i = 0; i < input.Length; ++i)
            {
                while (i < input.Length && input[i] != ' ')
                {
                    codeWord += input[i];
                    ++i;
                }

                codeWordIndex = morseList.IndexOfValue(codeWord);
                if (codeWordIndex == -1)
                    return "Error: Input text contains unknown Morse code words that can't be decoded.";

                List<char> keys = morseList.Keys.ToList();
                decoded.Append(Convert.ToChar(keys[codeWordIndex]));

                codeWord = "";
            }

            return decoded.ToString().ToUpper();
        }

        /// <summary>
        /// Method for playing Morse code with sound per character.
        /// </summary>
        /// <param name="input">Char passed on consisting of single valid Morse code symbol.</param>
        /// <param name="frequency">Adjustable frequency of sound.</param>
        /// <param name="timeUnit">Adjustable length of one time unit in milliseconds.</param>
        /// <param name="strict">Enable or disable strict waiting between Morse symbols.</param>
        /// <returns>Status message.</returns>
        public static string Player(char input, int frequency, int timeUnit, bool strict = false)
        {
            if (!OperatingSystem.IsWindows())
            {
                return "Error: Playing Morse code with sound is Windows-only feature.";
            }

            string validSymbols = ".-/ ";
            if (!validSymbols.Contains(input))
            {
                return "Error: Input for playback contains invalid symbols. Valid symbols are: '.' '-' '/' and ' ' (space).";
            }
            else if (frequency < 1 || timeUnit < 1)
            {
                return "Error: Frequency or timeUnit variable passed to this method has invalid value (<1).";
            }

                if (input == '.')    // short
                {
                    Console.Write('♪');
                    Console.Beep(frequency, timeUnit);
                }
                else if (input == '-')    // long
                {
                    Console.Write('♫');
                    Console.Beep(frequency, 3 * timeUnit);
                }
                else if (input == ' ')    // sleep between letters
                {
                    Console.Write(' ');
                    Thread.Sleep(3 * timeUnit);
                }
                else if (input == ' ')    // sleep between words
                {
                    Console.Write(" / ");
                    Thread.Sleep(7 * timeUnit);
                }
                
                if (strict && input != ' ')        // sleep between individual Morse symbols
                    Thread.Sleep(timeUnit);
                
            return "Success.";
        }

        /// <summary>
        /// Method for playing Morse code with sound as a whole string.
        /// </summary>
        /// <param name="input">String passed on consisting of valid Morse code symbols.</param>
        /// <param name="frequency">Adjustable frequency of sound.</param>
        /// <param name="timeUnit">Adjustable length of one time unit in milliseconds.</param>
        /// <param name="strict">Enable or disable strict waiting between Morse symbols.</param>
        public static string Player(string input, int frequency, int timeUnit, bool strict = false)
        {
            if (!OperatingSystem.IsWindows())
            {
                return "Error: Playing Morse code with sound is supported only on Windows.";
            }

            string validSymbols = ".-/ ";
            foreach (var symbol in input)
            {
                if (!validSymbols.Contains(symbol))
                {
                    return $"Error: Input for playback contains invalid symbols. Valid symbols are: '.' '-' '/' and ' ' (space).";
                }
            }

            if (frequency < 1 || timeUnit < 1)
            {
                return "Error: Frequency or timeUnit variable passed to this method has invalid value (<1).";
            }

            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] == '.')    // short
                {
                    Console.Write('♪');
                    Console.Beep(frequency, timeUnit);
                }
                else if (input[i] == '-')    // long
                {
                    Console.Write('♫');
                    Console.Beep(frequency, 3 * timeUnit);
                }
                else if (i + 1 < input.Length && input[i] == ' ' && input[i + 1] != ' ' && input[i + 1] != '/')    // sleep between letters
                {
                    Console.Write(' ');
                    Thread.Sleep(3 * timeUnit);
                }
                else if (i + 1 < input.Length)    // sleep between words
                {
                    Console.Write(" / ");
                    Thread.Sleep(7 * timeUnit);
                    i += 2;
                }

                if (strict && i < input.Length && input[i] != ' ')        // sleep between individual Morse symbols
                    Thread.Sleep(timeUnit);
                
            }

            Console.WriteLine(Environment.NewLine + "Finished.");
            return "Success.";
        }


        /// <summary>
        /// Method that returns morseList as table-formatted string.
        /// </summary>
        public static string PrintSortedList()
        {
            string table = "";
            table += $"ASCII\tMorse\t\tASCII\tMorse\t\tASCII\tMorse\t\tASCII\tMorse{Environment.NewLine}";
            ushort counter = 0;

            foreach (var item in morseList)
            {
                if (counter % 4 == 0)
                    table += $"{item.Key}\t{item.Value}";
                else if (counter % 4 == 1 || counter % 4 == 2)
                    table += $"\t\t{item.Key}\t{item.Value}";
                else if (counter % 4 == 3)
                    table += $"\t\t{item.Key}\t{item.Value}{Environment.NewLine}";
                ++counter;
            }
            return table;
        }
    }
}
