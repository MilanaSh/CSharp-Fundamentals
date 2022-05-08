﻿using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Regex regex = new Regex(@"\b(?<day>[0-9]{2})(?<separator>[\. \-\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})");


            MatchCollection correctDates = regex.Matches(input);

            foreach (Match date in correctDates)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }

        }
    }
}
