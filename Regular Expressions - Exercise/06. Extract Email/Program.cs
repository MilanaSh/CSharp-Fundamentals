using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|\s)(?<name>[A-Za-z0-9][\w\.\-_]*[A-Za-z0-9]*)@(?<host>[A-Za-z]+\-?[A-Za-z]*)\.[A-Za-z]*\.?[A-Za-z]*\b";

            Regex regex = new Regex(pattern);

            MatchCollection validEmails = regex.Matches(input);

            foreach (Match email in validEmails)
            {
                Console.WriteLine(email.Value);
            }

        }
    }
}
