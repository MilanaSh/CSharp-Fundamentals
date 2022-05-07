using System;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            Dictionary<string, double> productPrice = new Dictionary<string, double>();
            Dictionary<string, int> productQuantity = new Dictionary<string, int>();

            while (input!="buy")
            {
                string[] command = input.Split();
                string product = command[0];
                double price = double.Parse(command[1]);
                int quantity = int.Parse(command[2]);

                productPrice[product] = price;

                if (!productQuantity.ContainsKey(product))
                {
                    productQuantity.Add(product, quantity);
                }
                else
                {
                    productQuantity[product] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var pair in productQuantity)
            {
                string productName = pair.Key;
                int totalquantity = pair.Value;
                double price = productPrice[productName];
                double totalPrice = totalquantity * price;
                Console.WriteLine($"{productName} -> {totalPrice:f2}");
            }
        }
    }
}
