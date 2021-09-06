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

            foreach (string word in splitString)
            {
                Console.WriteLine(word);
            }
        }
    }
}
