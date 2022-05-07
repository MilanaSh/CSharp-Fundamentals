using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CONSUMED_BY_WORKERS = 26;
            const int MINIMUM_SPICES_TO_GATHER = 100;
            const int DAILY_DECREES_OF_MINE = 10;
            int countOfSpices = int.Parse(Console.ReadLine());
            int totalConsumed = 0;
            int daysCount = 0;

            while (countOfSpices>=100)
            {
                totalConsumed += countOfSpices - CONSUMED_BY_WORKERS;
                countOfSpices -= DAILY_DECREES_OF_MINE;
                daysCount++;
                if (countOfSpices<100)
                {
                    totalConsumed -= CONSUMED_BY_WORKERS;
                }
            }
            Console.WriteLine(daysCount);
            Console.WriteLine(totalConsumed);
        }
    }
}
