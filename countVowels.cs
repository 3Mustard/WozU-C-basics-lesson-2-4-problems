using System;
using static System.Console;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = GetSentence();
            int numOfVowels = CountVowels(sentence);
            WriteLine($"There are {numOfVowels} vowels in the sentence: {sentence}");
        }

        static string GetSentence()
        {
            WriteLine("enter a sentence");
            string userInput = ReadLine();
            return userInput;
        }

        static int CountVowels(string input)
        {
            char[] vowels = { 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            int total = 0;
            for (int i = 0; i < input.Length; i++)
            {
                for (int v = 0; v < vowels.Length; v++)
                {
                    if(input[i] == vowels[v])
                    {
                        total++;
                    }
                }
            }
            return total;
        }
    }
}
