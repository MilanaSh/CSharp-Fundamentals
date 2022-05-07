using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            SortedDictionary<double, int> counter = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (counter.ContainsKey(numbers[i]))
                {
                    counter[numbers[i]]++;
                }
                else
                {
                    counter.Add(numbers[i], 1);
                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
