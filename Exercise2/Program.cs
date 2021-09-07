using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening:");
            string sentence = Console.ReadLine();

            // Dela upp strängen vid varje mellanslag, lagra alla ord som olika element av array
            string[] splitString = sentence.Split(' '); 

            // Sorterar alla element efter antalet karaktärer de har
            Array.Sort(splitString, (x, y) => x.Length.CompareTo(y.Length));

            Console.WriteLine("Din mening sorterad i stigande ordning:");

            // Loopar genom arrayen och printar varje element
            foreach (string word in splitString)
            {
                Console.WriteLine(word);
            }

            // Sorterar alla element efter antalet karaktärer de har men omvänd ordning
            Array.Sort(splitString, (y, x) => x.Length.CompareTo(y.Length));

            Console.WriteLine("Din mening sorterad i fallande ordning:");

            foreach (var word in splitString)
            {
                Console.WriteLine(word);
            }
        }
    }
}
