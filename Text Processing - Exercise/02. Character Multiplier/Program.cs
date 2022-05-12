using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int sum = 0;

            string longest = "";
            string shortest = "";

            if ((input[0]).Length > (input[1]).Length)
            {
                longest = input[0];
                shortest = input[1];
            }
            else
            {
                longest = input[1];
                shortest = input[0];
            }

            for (int i = 0; i < shortest.Length; i++)
            {
                sum += shortest[i] * longest[i];
            }

            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }

            Console.WriteLine(sum);

        }
    }
}
