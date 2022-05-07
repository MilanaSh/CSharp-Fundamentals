using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            double numOfStudents = int.Parse(Console.ReadLine());
            double oneSaberPrice = double.Parse(Console.ReadLine());
            double onerobePrice = double.Parse(Console.ReadLine());
            double onebeltPrice = double.Parse(Console.ReadLine());

            double totalSaberPrice = oneSaberPrice* (Math.Ceiling(numOfStudents + numOfStudents * 0.1));
            double totalRobePrice = numOfStudents * onerobePrice;
            double totalBeltPrice = 0;

            if (numOfStudents >= 6)
            {
                totalBeltPrice = onebeltPrice * (numOfStudents - (Math.Floor(numOfStudents / 6)));
            }
            else
            {
                totalBeltPrice = numOfStudents * onebeltPrice;
            }

            double totalMoneyNeeded = totalBeltPrice + totalRobePrice + totalSaberPrice;

            if (totalMoneyNeeded<= amountOfMoney)
            {
                Console.WriteLine( $"The money is enough - it would cost {totalMoneyNeeded:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {(totalMoneyNeeded-amountOfMoney):f2}lv more.");
            }
        }
    }
}
