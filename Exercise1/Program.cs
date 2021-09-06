using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening:");
            string sentence = Console.ReadLine(); // input
            int wordCount = 0;

            // Loopa genom strängen
            for (int i = 0; i < sentence.Length - 1; i++)
            {
                // Räknar alla mellanslag i strängen
                if (sentence[i] == ' ' && Char.IsLetter(sentence[i + 1]) && (i > 0))
                {
                    wordCount++;
                }
            }
            // Lägg till 1 för att räkna sista ordet
            wordCount++;

            Console.WriteLine($"Antalet ord i meningen är: {wordCount}");

            // Dela upp strängen vid varje mellanslag
            string[] splitString = sentence.Split(' ');

            // Loopa genom den splittade strängen och mata ut varje ord med antal tecken i () bredvid
            foreach (string word in splitString)
            {
                Console.WriteLine($"{word} ({word.Length})");
            }
        }
    }
}