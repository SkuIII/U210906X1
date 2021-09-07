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
            while (true)
            {
                Console.WriteLine("Mata in ett ord:");
                string input = Console.ReadLine();

                if (input.ToLower() == "avsluta")
                {
                    break;
                }
            }
        }
    }
}
