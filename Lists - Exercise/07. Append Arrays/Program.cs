using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = Console.ReadLine()
                .Split("|").Reverse().ToList();

            List<int> newList = new List<int>();

            foreach (var item in myList)
            {
                newList.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(String.Join(" ", newList));

      

        }
    }
}
