using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
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

                if (command[0] == "Delete")
                {
                    int numberToRemove = int.Parse(command[1]);

                    //list.RemoveAll(x => x == numberToRemove);

                    // SAME AS.........

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == numberToRemove)
                        {
                            list.Remove(numberToRemove);
                            i--;
                        }
                    }
                }
                if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int position = int.Parse(command[2]);
                    list.Insert(position, element);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", list));
        }
    }
}
