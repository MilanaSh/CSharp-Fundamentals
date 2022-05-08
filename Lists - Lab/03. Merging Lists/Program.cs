using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>(list1.Count + list2.Count);
           

            int longerListCont = Math.Max(list1.Count, list2.Count);

            for (int i = 0; i < longerListCont; i++)
            {
                if (list1.Count > i)
                {
                    result.Add(list1[i]);
                }
                if (list2.Count > i)
                {
                    result.Add(list2[i]);
                }
            }
            Console.WriteLine(String.Join(" ", result));
 
        }
    }
}
