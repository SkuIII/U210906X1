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

            Array.Sort(splitString, (x, y) => x.Length.CompareTo(y.Length));

            foreach (string word in splitString)
            {
                Console.WriteLine(word);
            }

            Array.Sort(splitString, (y, x) => x.Length.CompareTo(y.Length));

            foreach (var word in splitString)
            {
                Console.WriteLine(word);
            }
        }
    }
}
