using System;
using System.Linq;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //string reversed = new string(input.ToCharArray().Reverse().ToArray());
            //
            //Console.WriteLine(reversed);

            string input = Console.ReadLine();
            string reversed = "";

            for (int i = input.Length - 1; i>= 0; i--)
            {
                reversed += input[i];
            }
            Console.WriteLine(reversed);
        }
    }
}
