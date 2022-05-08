using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
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
            bool isListChanged = false;
            while (input != "end")
            {
                string[] command = input.Split();

                switch (command[0])
                {
                    case "Add":
                        int number = int.Parse(command[1]);
                        list.Add(number);
                        isListChanged = true;
                        break;

                    case "Remove":
                        int numToDelete = int.Parse(command[1]);
                        list.Remove(numToDelete);
                        isListChanged = true;
                        break;

                    case "RemoveAt":
                        int indexToRemove = int.Parse(command[1]);
                        list.RemoveAt(indexToRemove);
                        isListChanged = true;
                        break;

                    case "Insert":
                        int num = int.Parse(command[1]);
                        int index = int.Parse(command[2]);
                        list.Insert(index, num);
                        isListChanged = true;
                        break;

                    case "Contains":
                        int numbe = int.Parse(command[1]);
                        if (list.Contains(numbe))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;

                    case "PrintEven":
                        for (int i = 0; i < list.Count; i++)
                        {                           
                            if (list[i] % 2 == 0)
                            {
                                Console.Write(list[i] + " ");
                            }                            
                        }
                        Console.WriteLine();
                        break;

                    case "PrintOdd":
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] % 2 != 0)
                            {
                                Console.Write(list[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;

                    case "GetSum":
                        int sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        Console.WriteLine(sum);
                        break;

                    case "Filter":
                        string condition = (command[1]);
                        int num1 = int.Parse(command[2]);
                        List<int> filteredList = new List<int>();

                        if (condition == "<")
                        {
                            filteredList = list.Where(x => x < num1).ToList();
                            Console.WriteLine(String.Join(" ", filteredList));                            
                        }
                        else if (condition == ">")
                        {
                            filteredList = list.Where(x => x > num1).ToList();
                            Console.WriteLine(String.Join(" ", filteredList));
                        }
                        else if (condition == ">=")
                        {
                            filteredList = list.Where(x => x >= num1).ToList();
                            Console.WriteLine(String.Join(" ", filteredList));
                        }
                        else if (condition == "<=")
                        {
                            filteredList = list.Where(x => x <= num1).ToList();
                            Console.WriteLine(String.Join(" ", filteredList));
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            if (isListChanged)
            {
                Console.WriteLine(String.Join(" ", list));
            }

        }
    }
}
