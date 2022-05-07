using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arrOne = new int[n];
            int[] arrTwo = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] temp = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    arrOne[i] = temp[0];
                    arrTwo[i] = temp[1];
                }
                else
                {
                    arrTwo[i] = temp[0];
                    arrOne[i] = temp[1];
                }

            }
            Console.WriteLine(String.Join(" ", arrOne));
            Console.WriteLine(String.Join(" ", arrTwo));
        }
    }
}
