using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOfPeople = double.Parse(Console.ReadLine());//if we use int
            int capacity = int.Parse(Console.ReadLine());

            double result = Math.Ceiling(numOfPeople / capacity);
            //int result = (int)Math.Ceiling((double)numOfPeople/capacity))
            Console.WriteLine(result);

        }
    }
}
