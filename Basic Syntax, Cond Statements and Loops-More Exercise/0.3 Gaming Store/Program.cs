using System;

namespace _0._3_Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            double currentBalans = double.Parse(Console.ReadLine());

            string gameName = Console.ReadLine();
            double gamePrice = 0.0;
            double totalSpentMoney = 0.0;

            while (gameName != "Game Time")
            {
                if (gameName == "OutFall 4" || gameName == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;

                    if (currentBalans >= gamePrice)
                    {
                        currentBalans -= gamePrice;
                        totalSpentMoney += gamePrice;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "CS: OG")
                {
                    gamePrice = 15.99;

                    if (currentBalans >= gamePrice)
                    {
                        currentBalans -= gamePrice;
                        totalSpentMoney += gamePrice;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }
                }
                else if (gameName == "Zplinter Zell")
                {
                    gamePrice = 19.99;

                    if (currentBalans >= gamePrice)
                    {
                        currentBalans -= gamePrice;
                        totalSpentMoney += gamePrice;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (gameName == "Honored 2")
                {
                    gamePrice = 59.99;

                    if (currentBalans >= gamePrice)
                    {
                        currentBalans -= gamePrice;
                        totalSpentMoney += gamePrice;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else if (gameName == "RoverWatch")
                {
                    gamePrice = 29.99;

                    if (currentBalans >= gamePrice)
                    {
                        currentBalans -= gamePrice;
                        totalSpentMoney += gamePrice;
                        Console.WriteLine($"Bought {gameName}");
                    }
                    else
                    {
                        Console.WriteLine("Too Expensive");
                    }

                }
                else 
                {
                    Console.WriteLine("Not Found");
                }

                if (currentBalans == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                gameName = Console.ReadLine();

            }
            Console.WriteLine($"Total spent: ${totalSpentMoney:f2}. Remaining: ${currentBalans:f2}");

        }
    }
}
