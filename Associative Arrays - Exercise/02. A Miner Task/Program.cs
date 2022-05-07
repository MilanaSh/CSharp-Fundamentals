using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (input != "stop")
            {
                
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(input))
                {
                    resources.Add(input, quantity);
                }

                else
                {
                    resources[input] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in resources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
