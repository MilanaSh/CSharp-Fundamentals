using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int sum = 0;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                int amountOfPeople = int.Parse(Console.ReadLine());
                array[i] = amountOfPeople;

                sum += amountOfPeople;
                amountOfPeople = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine(sum);
        }
    }
}
