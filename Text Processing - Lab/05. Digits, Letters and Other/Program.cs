using System;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> others = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (char.IsDigit(symbol))
                {                   
                    digits.Add(input[i]);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Add(symbol);
                }
                else
                {
                    others.Add(symbol);
                }            
            }

            Console.WriteLine(String.Join("", digits));
            Console.WriteLine(String.Join("", letters));
            Console.WriteLine(String.Join("", others));
        }
    }
}
