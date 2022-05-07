using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            //ВАРИАНТ 1!!!!!!!!!!!!
            string result = age <= 2 ? "baby" : age > 2 && age <= 13 ? "child" : age >13 && age <= 19 ? "teenager" : age >19 && age <= 65 ? "adult" : "elder";

            Console.WriteLine(result);

            //ВАРИАНТ 2!!!!!!!!!!!!!

           //if (age <= 2)
           //{
           //    Console.WriteLine("baby");
           //}
           //
           //else if (age >=3 && age <=13)
           //{
           //    Console.WriteLine("child");
           //}
           //
           //else if (age >=14 && age<= 19)
           //{
           //    Console.WriteLine("teenager");
           //}
           //
           //else if (age>=20 && age <= 65)
           //{
           //    Console.WriteLine("adult");
           //}
           //
           //else
           //{
           //    Console.WriteLine("elder");
           //}
        }
    }
}
