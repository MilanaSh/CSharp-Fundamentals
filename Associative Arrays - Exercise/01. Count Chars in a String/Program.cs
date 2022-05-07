using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
           // string text = Console.ReadLine();
           // Dictionary<char, int> counterChars = new Dictionary<char, int>();

            // for (int i = 0; i < text.Length; i++)
            // {
            //     char symbol = text[i];
            //
            //     if (symbol == ' ')
            //     {
            //         continue;
            //     }
            //
            //     if (counterChars.ContainsKey(symbol))
            //     {
            //         counterChars[symbol]++;
            //     }
            //     else
            //     {
            //         counterChars.Add(symbol, 1);
            //     }
            //     
            // }

            char[] text = Console.ReadLine().Where(x => x != ' ').ToArray();
            Dictionary<char, int> counterChars = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)         
            {
                char symbol = text[i];

                if (!counterChars.ContainsKey(symbol))
                {
                    counterChars.Add(symbol, 0);
                }

                counterChars[symbol]++;
            }

            foreach (var pair in counterChars)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}


