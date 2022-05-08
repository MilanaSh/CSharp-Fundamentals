using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            PrintFirsPart(num);
            PrintSecondPart(num);

        }

        static void PrintFirsPart (int a)
        {
            for (int i = 1; i <= a; i++)
            {
                for (int j = 1 ; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }            
        }

        static void PrintSecondPart (int a)
        {
            for (int i = a - 1; i >= 1; i--)
            {
                for (int j = 1; j<= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
