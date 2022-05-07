using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .ToLower()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> counts = new Dictionary<string, int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (!counts.ContainsKey(list[i]))
                {
                    counts.Add(list[i], 0);
                }

                counts[list[i]]++;
            }

            foreach (var item in counts)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write(item.Key + " ");
                }
            }

        }
    }
}
