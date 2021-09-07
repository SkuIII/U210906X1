using System;

namespace Exercise5
{
    class Program
    {
        //Låt användaren mata in ett ord i taget
        //Avsluta programmet om användaren matar in AVSLUTA
        //Skriv ut din mening just nu är: skriv ut alla inmatade ord

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Här kan du bygga en mening med ett ord i taget, skriv avsluta för att avsluta!");
            string sentence = "";

            while (true)
            {
                Console.WriteLine("Mata in ett ord:");
                string input = Console.ReadLine();

                if (input.ToLower() == "avsluta")
                {
                    break;
                }

                sentence += $"{input} ";
            }

            Console.WriteLine($"Din mening just nu är: {sentence}");
        }
    }
}
