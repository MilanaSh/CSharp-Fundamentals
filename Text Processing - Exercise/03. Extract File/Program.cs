using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            var file = input[input.Length - 1].Split(".");

            Console.WriteLine($"File name: {file[0]}");
            Console.WriteLine($"File extension: {file[1]}");
        }
    }
}
