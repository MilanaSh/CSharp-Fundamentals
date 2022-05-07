using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int newNum = number;

            while(number != 0)
            {
                newNum = number % 10;
                sum += newNum;
                number /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
