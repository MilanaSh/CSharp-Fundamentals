using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < number; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();

                string command = input[0];
                string username = input[1];
                

                switch (command)
                {
                    case "register":
                        string carNum = input[2];     

                        if (!cars.ContainsKey(username))
                        {                            
                            cars.Add(username, carNum);
                            Console.WriteLine($"{username} registered {carNum} successfully");
                            
                        }
                        else
                        {
                            string oldNum = cars[username];
                            Console.WriteLine($"ERROR: already registered with plate number {oldNum}");
                        }
                        
                        break;

                    case "unregister":
                        if (!cars.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            cars.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var pair in cars)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}
