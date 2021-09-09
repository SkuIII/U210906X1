using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in hur många tal du vill ange:");

            int amountOfNumbers = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[amountOfNumbers];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Skriv in ett tal");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            Console.WriteLine("Sorterad:");
            foreach (int p in arr) 
            {
                Console.Write(p + " ");
            }
        }
    }
}
