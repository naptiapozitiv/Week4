using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TextHelper
    {
        public string text;
        public TextHelper(string t)
        {
            text = t;
        }
        public int CountWordWith4orMoreWords(string text)
        {
            int counter = 0;
            string[] word = text.Split(' ');
            foreach (string words in word)
            {
                if (word.Length <= 4)
                    counter++;
            }
            return counter;
        }
        public bool IsPoli(string text)
        {
            text.Replace(" ", "").ToLower();

            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length -1 - i])
                {
                    return false;
                }

            }
            return true;
        }
        public string CountLetterC_and_V(string text)
        {
            string result;
            int VowelCounter = 0;
            var ignore = @"[?.,;:'!-()]";
            text.Replace(" ", "").Replace(ignore, "").ToLower();
            int ConsonanceCounter = 0;
            foreach (char character in text)
            {
                if (!Char.IsLetter(character))
                    continue;
                if (character == 'a' || character == 'e' || character == 'i' || character == 'y' || character == 'o' || character == 'u')
                    VowelCounter++;
                else
                    ConsonanceCounter++;
            }
            int sum = ConsonanceCounter + VowelCounter;
            result = $"Number of Vowels is {VowelCounter}, Number of Consonances is {ConsonanceCounter}, sum of characters is {sum}";
            return result;
        }
    }
}
