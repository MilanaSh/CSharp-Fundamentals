using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            //5 0 4 1 2
            
            for (int i = numbers.Length; i > 0 ; i--)
            {
                for (int j = 0; j < i-1; j++)
                {
                    numbers[j] = numbers[j] + numbers[j + 1];
                }
            
            }
            Console.WriteLine(numbers[0]);



           //int[] array = Console.ReadLine()
           //    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           //    .Select(int.Parse)
           //    .ToArray();
           //int[] condesedArray = new int[array.Length];
           //
           //if (array.Length == 1)
           //{
           //    Console.WriteLine(array[0]);
           //    return;
           //}
           //
           //for (int i = 0; i < array.Length - 1; i++)
           //{
           //    for (int j = 0; j < condesedArray.Length - 1; j++)
           //    {
           //        condesedArray[j] = array[j] + array[j + 1];
           //    }
           //    array = condesedArray;
           //}
           //
           //
           //Console.WriteLine(condesedArray[0]);
        }  //
        
    }
}
