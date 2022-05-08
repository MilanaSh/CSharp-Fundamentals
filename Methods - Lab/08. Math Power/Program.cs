using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(Pow(num, power));
        }

        static double Pow(double num, double power)
        {
            double result = 0.0;
            result = Math.Pow(num, power);
            return result;
        }
    }
}
