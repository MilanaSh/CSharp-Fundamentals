using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var forceSides = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    string[] data = input.Split(" | ");
                    string side = data[0];
                    string user = data[1];

                    if (!forceSides.ContainsKey(side))
                    {
                        forceSides.Add(side, new List<string>());
                        forceSides[side].Add(user);
                    }
                    if (forceSides[side].Contains(user) && !forceSides.Values.Any(users => users.Contains(user)))
                    {
                        forceSides[side].Add(user);
                    }                      
                }

                else if (input.Contains("->"))
                {
                    var data = input.Split(" -> ");
                    string user = data[0];
                    string side = data[1];

                    if (!forceSides.Values.Any(users => users.Contains(user)))
                    {
                        if (!forceSides.ContainsKey(side))
                        {
                            forceSides.Add(side, new List<string>());
                        }
                        
                        forceSides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var sides in forceSides.Where(sides => sides.Value.Contains(user)))
                        {
                            sides.Value.Remove(user);
                        }
                        if (!forceSides.ContainsKey(side))
                        {
                            forceSides.Add(side, new List<string>());
                        }
                        forceSides[side].Add(user);

                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }

                input = Console.ReadLine();
            }
            forceSides = forceSides.OrderByDescending(key => key.Value.Count)
                .ThenBy(x => x.Key).ToDictionary(x => x.Key, u => u.Value);

            foreach (var pair in forceSides)
            {
                pair.Value.Sort();
                if (pair.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine(string.Join("\n! ", pair.Value));
                }
            }

        }
    }
}
