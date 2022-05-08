using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @">>(?<type>[A-Za-z]+)<<(?<price>[0-9]+.?[0-9]*)!(?<quantity>[0-9]+)";

            double sum = 0.0;
            List<string> list = new List<string>();

            while (input != "Purchase")
            {
                Regex regex = new Regex(pattern);
                Match matchedFurnicher = regex.Match(input);

                if (matchedFurnicher.Success)
                {
                    list.Add(matchedFurnicher.Groups["type"].Value);
                    sum += double.Parse(matchedFurnicher.Groups["price"].Value) * int.Parse(matchedFurnicher.Groups["quantity"].Value);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Bought furniture:");
            if (list.Count > 0)
            {
                Console.WriteLine(String.Join(Environment.NewLine, list));
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
