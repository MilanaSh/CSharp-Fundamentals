using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@"\+([359]{3})( ?-?)2(\2)([0-9]{3})(\2)([0-9]{4})\b");

            MatchCollection phoneMatches = regex.Matches(input);
            List<string> phoneList = new List<string>();

            foreach (Match phone in phoneMatches)
            {
                phoneList.Add(phone.ToString());
            }
            Console.WriteLine(String.Join(", ",phoneList));
        }
    }
}
