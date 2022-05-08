using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    Add(numberOne, numberTwo);
                        break;
                case "multiply":
                    Multiply(numberOne, numberTwo);
                    break;
                case "subtract":
                    Subtract(numberOne, numberTwo);
                    break;
                case "divide":
                    Divide(numberOne, numberTwo);
                    break;

                default:
                    break;
            }


        }

        static void Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
        }

        static void Multiply(int num1, int num2)
        {
            int sum = num1 * num2;
            Console.WriteLine(sum);
        }

        static void Subtract(int num1, int num2)
        {
            int sum = num1 - num2;
            Console.WriteLine(sum);
        }

        static void Divide(int num1, int num2)
        {
            int sum = num1 / num2;
            Console.WriteLine(sum);
        }
    }
}
