using System;
using System.Collections.Generic;

namespace PenduLib.Base
{
    public class PenduBase
    {
        public char LetterInput;
        public string Word = "Bonjour";
        public List<char> MysteryWord = new List<char>();
        public int TriesRemining = 0;

        public void Create()
        {
            bool error = false;

            CreateUderscore();
            if (IsValidInput(GetLetterInput()))
            {
                error = true;
            }

            if (!error)
            {
                for (int i = 0; i < Word.Length; i++)
                {
                    if (Word[i] == LetterInput)
                    {
                        MysteryWord[i] = LetterInput;
                        error = false;
                        break;
                    }

                    error = true;
                }
            }

            if (error)
            {
                Console.WriteLine(AsciiCode());
                TriesRemining++;
            }

            Console.WriteLine(string.Join(" ", MysteryWord));
        }

        private void CreateUderscore()
        {
            for (int i = 0; i < Word.Length; i++)
            {
                MysteryWord.Add('_');
            }

            Console.WriteLine(string.Join(" ", MysteryWord));
        }

        private char GetLetterInput()
        {
            char[] inputArray = Console.ReadLine().ToCharArray();
            return inputArray[0];
        }

        private bool IsValidInput(char input)
        {
            if (isNumber(input))
            {
                return false;
            }

            return true;
        }

        private bool isNumber(char input)
        {
            if (!char.IsDigit(input))
            {
                return true;
            }

            return false;
        }

        private string AsciiCode()
        {
            switch (TriesRemining)
            {
                case 1:
                {
                    return " -----\r\n" +
                           " |/  |\r\n" +
                           " |   \r\n" +
                           " |    \r\n" +
                           " | \r\n" +
                           "-|-";
                }
                case 2:
                {
                    return " -----\r\n" +
                           " |/  |\r\n" +
                           " |   °\r\n" +
                           " |    \r\n" +
                           " | \r\n" +
                           "-|-";
                }
                case 3:
                {
                    return " -----\r\n" +
                           " |/  |\r\n" +
                           " |   °\r\n" +
                           " |   |\r\n" +
                           " | \r\n" +
                           "-|-";
                }
                case 4:
                {
                    return " -----\r\n" +
                           " |/  |\r\n" +
                           " |   °\r\n" +
                           " |  /|\r\n" +
                           " | \r\n" +
                           "-|-";
                }
                case 5:
                {
                    return " -----\r\n" +
                           " |/  |\r\n" +
                           " |   °\r\n" +
                           " |  /|\\\r\n" +
                           " | \r\n" +
                           "-|-";
                }
                case 6:
                {
                    return " -----\r\n" +
                           " |/  |\r\n" +
                           " |   °\r\n" +
                           " |  /|\\\r\n" +
                           " |  / \r\n" +
                           "-|-";
                }
                case 7:
                {
                    return " -----\r\n" +
                           " |/  |\r\n" +
                           " |   °\r\n" +
                           " |  /|\\\r\n" +
                           " |  / \\\r\n" +
                           "-|-";
                }
            }

            return " -----\r\n" +
                   " |/  \r\n" +
                   " |   \r\n" +
                   " |    \r\n" +
                   " | \r\n" +
                   "-|-";
        }
    }
}