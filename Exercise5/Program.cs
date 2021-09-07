using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Här kan du bygga en mening med ett ord i taget, skriv avsluta för att avsluta!");
            string sentence = "";

            while (true)
            {
                Console.WriteLine("Mata in ett ord:");
                string input = Console.ReadLine();

                // Om input är avsluta (ToLower för att undvika case sensitive), avsluta programmet
                if (input.ToLower() == "avsluta")
                {
                    break;
                }

                // Lägg till ordet i meningen
                sentence += $"{input} ";
            }

            Console.WriteLine($"Din mening just nu är: {sentence}");
        }
    }
}
