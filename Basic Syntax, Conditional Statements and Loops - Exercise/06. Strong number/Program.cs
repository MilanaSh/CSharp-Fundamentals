using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int temNumber = number;
            int factSum = 0;

            while (temNumber > 0)
            {
                int currNum = temNumber % 10;
                temNumber /= 10;
                int curFactNum = 1;

                for (int i = 1; i <= currNum; i++)
                {
                    curFactNum *= i;
                }
                factSum += curFactNum;
            }
            string result = factSum == number ? "yes" : "no";
            Console.WriteLine(result);

        }
    }
}
