using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;

            string pattern = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*?<(?<product>\w+)>[^|$%.]*?\|(?<count>[0-9]+)\|[^|$%.]*?(?<price>[0-9]+[.]?[0-9]+?)\$";

            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);
                bool isValid = regex.IsMatch(input);

                if (isValid)
                {

                    string customer = regex.Match(input).Groups["name"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int count = int.Parse(regex.Match(input).Groups["count"].Value);
                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    double sum = count * price;
                    totalSum += sum;

                    Console.WriteLine($"{customer}: {product} - {sum:f2}");
                }
                    input = Console.ReadLine();              
            }
            Console.WriteLine($"Total income: {totalSum:f2}");
        }
    }
}
