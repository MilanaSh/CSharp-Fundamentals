using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
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

            while (input != "End")
            {
                string[] commands = input.Split();
                string operations = commands[0];

                switch (operations)
                {
                    case "Add":
                        int numberToAdd = int.Parse(commands[1]);
                        list.Add(numberToAdd);
                        break;

                    case "Insert":
                        int index = int.Parse(commands[2]);
                        int numToInsert = int.Parse(commands[1]);

                        if (index >= 0 && index < list.Count)
                        {
                            list.Insert(index, numToInsert);
                        }
                        else
                        {                            
                            Console.WriteLine($"Invalid index");
                        }
                        
                        break;

                    case "Remove":
                        int indexToRemove = int.Parse(commands[1]);

                        if (indexToRemove >= 0 && indexToRemove < list.Count)
                        {
                            list.RemoveAt(indexToRemove);
                        }
                        else
                        {                            
                            Console.WriteLine($"Invalid index");
                        }
                        
                        break;

                    case "Shift":
                        int countToMove = int.Parse(commands[2]);
                        if (commands[1] == "left")
                        {
                          
                            for (int i = 0; i < countToMove; i++)
                            {
                                int firstNum = list[0];
                                list.Add(firstNum);
                                list.RemoveAt(0);

                            }
                        }

                        else if (commands[1] == "right")
                        {
                            for (int i = 0; i < countToMove; i++)
                            {
                                int lastNum = list[list.Count - 1];
                                list.Insert(0, lastNum);
                                
                                list.RemoveAt(list.Count - 1);

                            }
                        }
                        
                        break;   
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
