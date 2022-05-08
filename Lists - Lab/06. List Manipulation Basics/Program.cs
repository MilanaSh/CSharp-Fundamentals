using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        int number = int.Parse(command[1]);
                        list.Add(number);
                        break;

                    case "Remove":
                        int numToDelete = int.Parse(command[1]);
                        list.Remove(numToDelete);
                        break;

                    case "RemoveAt":
                        int indexToRemove = int.Parse(command[1]);
                        list.RemoveAt(indexToRemove);
                        break;

                    case "Insert":
                        int num = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        list.Insert(index, num);
                        break;

                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
