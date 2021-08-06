// Author: Petr Marak, 2021
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Text;
using static Morseapp_Console.Morse;

namespace Morseapp_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.ASCII;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Morse code application, 2021 Petr Marak";

            Console.WriteLine("F1 = Code text to Morse, F2 = Decode Morse to text, F3 = Just play some Morse, F4 = Show Morse dictionary");
            ConsoleKeyInfo option = Console.ReadKey();
            string input = "";
            string result;
            Console.ForegroundColor = ConsoleColor.White;

            switch (option.Key)
            {
                case ConsoleKey.F1:
                    goto case ConsoleKey.F3;
                case ConsoleKey.F2:
                    Console.WriteLine("Tip: write \" / \" or three spaces to separate words.");
                    goto case ConsoleKey.F3;
                case ConsoleKey.F3:
                    Console.Write($"{option.Key} input: ");
                    input = Console.ReadLine().ToLower();
                    break;
                case ConsoleKey.F4:
                    break;
                default:
                    Console.WriteLine("Error: Incorrect option choice.");
                    return;
            }

            // F1) Encoder path: 
            if (option.Key == ConsoleKey.F1)
            {
                result = MorseCoder(input);
                Console.WriteLine($"Result: {result}");

                if (result != "Error: The input text contains symbols that cannot be encoded.")
                {
                    Console.WriteLine("Do you want to play the Morse with sound? Press Y, Enter or Spacebar for yes, otherwise not.");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Y:
                        case ConsoleKey.Enter:
                        case ConsoleKey.Spacebar:
                            MorsePlayer(result);
                            break;
                        default:
                            break;
                    }
                }
            }

            // F2) Decoder path: 
            else if (option.Key == ConsoleKey.F2)
            {
                result = MorseDecoder(input);
                Console.WriteLine($"Result: {result.ToUpper()}");

                if (result != "Error: Input text contains unknown Morse code words that could not be decoded.")
                {
                    Console.WriteLine("Do you want to play the Morse with sound? Press Y, Enter or Spacebar for yes, otherwise not.");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Y:
                        case ConsoleKey.Enter:
                        case ConsoleKey.Spacebar:
                            MorsePlayer(input);
                            break;
                        default:
                            break;
                    }
                }
            }

            // F3) Player path: 
            else if (option.Key == ConsoleKey.F3)
            {
                MorsePlayer(input);
            }

            // F4) Print Morse dictionary path:
            else if (option.Key == ConsoleKey.F4)
            {
                PrintSortedList();
            }

            Console.ResetColor();
        }
    }
}
