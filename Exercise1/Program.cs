using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening:");
            string sentence = Console.ReadLine(); 
            int wordCount = 0;

            for (int i = 0; i < sentence.Length - 1; i++)
            {
                if (sentence[i] == ' ' && Char.IsLetter(sentence[i + 1]) && (i > 0))
                {
                    wordCount++;
                }
            }
            wordCount++;

            Console.WriteLine("Antalet ord i meningen är: " + wordCount);
        }
    }
}