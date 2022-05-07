using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int[] temp = new int[array.Length];
                int element = array[0];

                for (int j = 1; j < array.Length; j++)
                {
                    temp[j-1] = array[j];
                }

                temp[temp.Length - 1] = element;
                array = temp;
            }
            Console.WriteLine(String.Join(" ",array));
        }
    }
}
