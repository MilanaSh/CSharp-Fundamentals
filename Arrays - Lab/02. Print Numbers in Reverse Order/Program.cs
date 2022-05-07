using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           int[] arr = new int[n];
           
           for (int i = 0; i <arr.Length ; i++)
           {    
               arr[i] = int.Parse(Console.ReadLine());
           }
           for (int i = arr.Length - 1; i >= 0; i--)
           {
               Console.Write(arr[i] + " ");
           }
           Console.WriteLine();
        }
    }
}
