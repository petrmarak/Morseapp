using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace Morseapp_Console
{
    public static class Morse
    {
        /// <summary>
        /// Sorted list used for encoding and decoding between ASCII and Morse.
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
            // Source: https://en.wikipedia.org/wiki/Morse_code
        };

        /// <summary>
        /// Method for encoding ASCII symbols into Morse code words.
        /// </summary>
        /// <param name="input">String entered by user consisting of ASCII symbols.</param>
        /// <returns>Returns encoded string of Morse code words.</returns>
        public static string MorseCoder(string input)
        {
            string encoded = "";

            foreach (var symbol in input)
            {
                if (!morseList.TryGetValue(symbol, out string value))
                    return "Error: The input text contains symbols that cannot be encoded.";
                encoded += value;
                encoded += ' ';
            }

            return encoded;
        }

        /// <summary>
        /// Method for decoding Morse code words into ASCII symbols.
        /// </summary>
        /// <param name="input">String entered by user consisting of valid Morse code words, each separated by space.</param>
        /// <returns>Returns decoded Morse code as string of ASCII symbols.</returns>
        public static string MorseDecoder(string input)
        {
            string decoded = "";
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
                    return "Error: Input text contains unknown Morse code words that could not be decoded.";

                List<char> keys = morseList.Keys.ToList();
                decoded += Convert.ToChar(keys[codeWordIndex]);

                codeWord = "";
            }

            return decoded;
        }

        /// <summary>
        /// Method for playing Morse code with sound.
        /// </summary>
        /// <param name="input">String entered by user or passed on as method result consisting of valid Morse code symbols.</param>
        public static void MorsePlayer(string input, ushort timeUnit = 200)
        {
            if (!OperatingSystem.IsWindows())
            {
                Console.WriteLine("Error: Playing Morse code with sound is supported only on Windows.");
                return;
            }

            string validSymbols = ".-/ ";
            foreach (var symbol in input)
            {
                if (!validSymbols.Contains(symbol))
                {
                    Console.WriteLine($"Error: Input for playback contains invalid symbols. Valid symbols are: '.' '-' '/' and ' ' (space).");
                    return;
                }
            }

            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] == '.')    // short
                {
                    Console.Write('♪');
                    Console.Beep(500, timeUnit);
                }
                else if (input[i] == '-')    // long
                {
                    Console.Write('♫');
                    Console.Beep(500, 3 * timeUnit);
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
                /* currently disabled, unenjoyably slows down the playback
                if (i < input.Length && input[i] != ' ')        // sleep between individual Morse symbols
                    Thread.Sleep(timeUnit);
                */
            }

            Console.WriteLine(Environment.NewLine + "Finished.");
            return;
        }

        /// <summary>
        /// Method that prints morseList into Console.
        /// </summary>
        public static void PrintSortedList()
        {
            Console.Write($"{Environment.NewLine}ASCII\tMorse\t\tASCII\tMorse{Environment.NewLine}");
            ushort counter = 0;
            foreach (var item in morseList)
            {
                if (counter % 2 == 0)
                    Console.Write($"{item.Key}\t{item.Value}");
                else
                    Console.WriteLine($"\t\t{item.Key}\t{item.Value}\t");
                ++counter;
            }
        }
    }
}
