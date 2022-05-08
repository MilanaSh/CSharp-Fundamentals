using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Check(num);
        }
        static void Check(int number) 
        {
            string sign = null;

            if (number < 0)
            {
                sign = "negative";
            }

            else if (number > 0)
            {
                sign = "positive";
            }

            else
            {
                sign = "zero";
            }

            Console.WriteLine($"The number {number} is {sign}.");
        }

    }
}
