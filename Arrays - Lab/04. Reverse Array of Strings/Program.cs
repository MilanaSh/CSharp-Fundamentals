using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse() //ако това го няма
                .ToArray();

            Console.WriteLine(string.Join(" ", input));

            //Console.WriteLine(string.Join("", Console.ReadLine().ToArray().Reverse()));
            //Console.WriteLine(string.Join(" ", input.Reverse));

        }
    }
}
