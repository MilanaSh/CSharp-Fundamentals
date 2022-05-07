using System;
using System.Linq;
namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numebrs = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sumOdd = 0;
            int sumEven = 0;
            

            for (int i = 0; i < numebrs.Length; i++)
            {
                int currentNumber = numebrs[i];
                
                if (currentNumber % 2 == 0 )
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
            }
            Console.WriteLine(sumEven-sumOdd);
        }
    }
}
