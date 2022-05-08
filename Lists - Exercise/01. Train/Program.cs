using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] command  = input.Split();

                if (command[0] == "Add")
                {
                    int passangers = int.Parse(command[1]);
                    wagons.Add(passangers);
                }

                else
                {
                    int passangers = int.Parse(command[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passangers <= capacity)
                        {
                            wagons[i] += passangers;
                            break;
                        }
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}
