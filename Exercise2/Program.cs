using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening:");
            string sentence = Console.ReadLine();

            string[] splitString = sentence.Split(' ');

            Array.Sort(splitString, (word, word2) => word.Length.CompareTo(word2.Length));

            foreach (string word in splitString)
            {
                Console.WriteLine(word);
            }
        }
    }
}
