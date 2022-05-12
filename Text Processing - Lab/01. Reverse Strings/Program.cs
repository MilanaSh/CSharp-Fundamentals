using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            while (word != "end")
            {
                string reversed = new string(word.ToCharArray().Reverse().ToArray());

                pairs.Add(word, reversed);

                word = Console.ReadLine();
            }

            foreach (var pair in pairs)
            {
                Console.WriteLine($"{pair.Key} = {pair.Value}");
            }
        }
    }
}
