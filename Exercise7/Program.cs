using System;

namespace Exercise7
{
    class Program
    {
        // Be användaren mata in en mening.
        // Översätt den enligt Leet Speak (när det finns flera alternativ i tabellen, välj själv så det bara är 1-1)
        // Skriv ut den översatta meningen.
        // Exempel: Elit > 1337
   
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in en mening:");

            string[,] leetArray = {
                {"a", "4"}, 
                {"b", "|3"}, 
                {"c", "("}, 
                {"d", "|)"}, 
                {"e", "3"}, 
                {"f", "|="}, 
                {"g", "6"}, 
                {"h", "|-|"}, 
                {"i", "l"},
                {"j", "_|"}, 
                {"k", "|<"}, 
                {"l", "1"}, 
                {"m", "|V|"}, 
                {"n", "/|/"}, 
                {"o", "0"}, 
                {"p", "|D"}, 
                {"q", "(,)"}, 
                {"r", "|2"}, 
                {"s", "$"}, 
                {"t", "7"}, 
                {"u", "|_|"}, 
                {"v", "|/"}, 
                {"w", "|/|/"}, 
                {"x", "><"},
                {"y", "'/"}, 
                {"z", "2"} 
                };

            foreach (var item in leetArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
