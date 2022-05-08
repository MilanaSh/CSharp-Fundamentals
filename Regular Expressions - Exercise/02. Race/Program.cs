using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> racersData = new Dictionary<string, int>();

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                string namesPattern = @"[A-Za-z]";
                string kmPattern = @"[0-9]";

                
                MatchCollection nameMatch = Regex.Matches(input, namesPattern);
                MatchCollection kmMatch = Regex.Matches(input, kmPattern);

                var name = String.Concat(nameMatch);
                var sumOfKm = kmMatch.Select(x => int.Parse(x.Value)).Sum();

                if (names.Contains(name))
                {
                    if (racersData.ContainsKey(name))
                    {
                        racersData[name] += sumOfKm;
                    }
                    else
                    {
                        racersData.Add(name, sumOfKm);
                    }
                }

                input = Console.ReadLine();
            }

            var sorted = racersData.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();

            Console.WriteLine("1st place: " + sorted[0]);
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}
