using static System.Formats.Asn1.AsnWriter;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System;

namespace SpellCheckerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = createDictionary();
          namespace SpellCheckerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dictionary = File.ReadAllLines("WordsFile.txt");
            Console.WriteLine("Type a word:");
            string inputWord = Console.ReadLine().ToLower().Trim();

            if (IsWordCorrect(inputWord, dictionary))
            {
                Console.WriteLine("That word is spelled correctly!");
            }
            else
            {
                Console.WriteLine("That word is NOT spelled correctly.");
            }

            Console.WriteLine("Type a sentence:");
            string sentence = Console.ReadLine().ToLower();

            string[] words = sentence.Split(' ', '.', ',', '!', '?');

            int correctCount = 0;
            int totalWords = 0;

            foreach (string word in words)
            {
                if (word.Trim() == "")
                    continue;

                totalWords++;

                if (IsWordCorrect(word.Trim(), dictionary))
                {
                    correctCount++;
                }
                else
                {
                    Console.WriteLine($"Incorrect word: {word}");
                }
            }
            if (totalWords > 0)
            {
                double score = (double)correctCount / totalWords * 100;
                Console.WriteLine($"Spelling score: {score:0.##}%");
            }
            else
            {
                Console.WriteLine("No words to check.");
            }
        }

        static bool IsWordCorrect(string word, string[] dictionary)
        {
            foreach (string dictWord in dictionary)
            {
                if (dictWord.ToLower() == word)
                {
                    return true;
                }
            }
            return false;
        }
    }
}




        }
        static string[] createDictionary()
        {
            using StreamReader words = new("WordsFile.txt");
            int count = 0;
            string[] dictionaryData = new string[178636];
            while (!words.EndOfStream)
            {

                dictionaryData[count] = words.ReadLine();
                count++;
            }
            words.Close();
            return dictionaryData;
        }
    }
}
