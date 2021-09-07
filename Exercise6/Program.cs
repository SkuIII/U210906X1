using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datorn genererade ett tal mellan 1-21, gissa vilket!");
            // Generera ett random tal
            Random rand = new Random();
            int number = rand.Next(1, 21);

            while (true)
            {
                int answer = Convert.ToInt32(Console.ReadLine()); // input

                if (answer == number)
                {
                    Console.WriteLine($"Grattis! Du gissade rätt, talet var {number}");
                    break;
                }

                Console.WriteLine("Du gissade fel, gissa igen!");
            }

        }
    }
}
