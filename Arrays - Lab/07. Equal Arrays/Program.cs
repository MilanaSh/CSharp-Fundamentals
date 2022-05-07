using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrey1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arrey2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < arrey1.Length; i++)
            {
                if (arrey1[i] != arrey2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
            }
            for (int i = 0; i < arrey2.Length; i++)
            {
                if (arrey1[i] == arrey2[i])
                {
                    int currentNum = arrey1[i];
                    sum += currentNum;
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }

    }
}
