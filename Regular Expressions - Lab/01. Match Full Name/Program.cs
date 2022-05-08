using System;
using System.Text.RegularExpressions;

namespace _01._Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();

            Regex regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+");

            MatchCollection correctOnce = regex.Matches(names);

            foreach (Match item in correctOnce)
            {
                Console.Write(item.Value + " ");
            }
        }
    }
}
