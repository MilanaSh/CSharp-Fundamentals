using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string legendaryItem = String.Empty;

            Dictionary<string, int> materials = new Dictionary<string, int>()
            {
            ["motes"] = 0,
            ["shards"] = 0,
            ["fragments"] = 0
            };

            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (materials["motes"] < 250 && materials["fragments"] < 250 && materials["shards"] < 250)
            {
                string input = Console.ReadLine().ToLower();
                string[] commmand = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < commmand.Length; i+=2)
                {
                    int quantity = int.Parse(commmand[i]);
                    string material = commmand[i + 1];

                    switch (material)
                    {
                        case "motes":
                        case "shards":
                        case "fragments":
                            materials[material] += quantity;
                            break;

                        default:
                            if (!junk.ContainsKey(material))
                            {
                                junk.Add(material, 0);
                            }
                            junk[material]+=quantity;
                            break;
                    }

                    if (materials["motes"] >= 250 || materials["fragments"] >= 250 || materials["shards"] >= 250)
                    {
                        break;
                    }
                }
               
            }
            if (materials["shards"] >= 250)
            {
                legendaryItem = "Shadowmourne";
                materials["shards"] -= 250;
            }
            else if (materials["fragments"] >= 250)
            {
                legendaryItem = "Valanyr";
                materials["fragments"] -= 250;
            }
            else
            {
                legendaryItem = "Dragonwrath";
                materials["motes"] -= 250;
            }

            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (var pair in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

            foreach (var pair in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}
