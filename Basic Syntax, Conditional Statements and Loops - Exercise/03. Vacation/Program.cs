using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0.0;

            switch (day)
            {
                case "Friday":
                    if (groupType == "Students")
                    {

                        totalPrice = numOfPeople * 8.45;

                        if (numOfPeople>=30)
                        {                            
                            totalPrice = totalPrice - totalPrice * 0.15;                            
                        }
                    }
                    else if (groupType == "Business")
                    {
                        totalPrice = numOfPeople * 10.90;

                        if (numOfPeople>=100)
                        {
                            totalPrice = totalPrice - 10 * 10.90;
                        }
                        
                    }
                    else if (groupType == "Regular")
                    {
                        totalPrice = numOfPeople * 15;
                        if (numOfPeople>=10 && numOfPeople<=20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.05;
                        }
                    }
                    break;

                case "Saturday":
                    if (groupType == "Students")
                    {

                        totalPrice = numOfPeople * 9.80;

                        if (numOfPeople >= 30)
                        {
                            totalPrice = totalPrice - totalPrice * 0.15;
                        }
                    }
                    else if (groupType == "Business")
                    {
                        totalPrice = numOfPeople * 15.60;

                        if (numOfPeople >= 100)
                        {
                            totalPrice = totalPrice - 10 * 15.60;
                        }

                    }
                    else if (groupType == "Regular")
                    {
                        totalPrice = numOfPeople * 20;
                        if (numOfPeople >= 10 && numOfPeople <= 20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.05;
                        }
                    }
                    break;

                case "Sunday":
                    if (groupType == "Students")
                    {

                        totalPrice = numOfPeople * 10.46;

                        if (numOfPeople >= 30)
                        {
                            totalPrice = totalPrice - totalPrice * 0.15;
                        }
                    }
                    else if (groupType == "Business")
                    {
                        totalPrice = numOfPeople * 16;

                        if (numOfPeople >= 100)
                        {
                            totalPrice = totalPrice - 10 * 16;
                        }

                    }
                    else if (groupType == "Regular")
                    {
                        totalPrice = numOfPeople * 22.50;
                        if (numOfPeople >= 10 && numOfPeople <= 20)
                        {
                            totalPrice = totalPrice - totalPrice * 0.05;
                        }
                    }
                    break;  
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
