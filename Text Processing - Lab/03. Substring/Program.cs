using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToRemove = Console.ReadLine();
            string input = Console.ReadLine();

            int index = input.IndexOf(wordToRemove);

            
            while (index >= 0)
            {
                input = input.Remove(index, wordToRemove.Length);
                index = input.IndexOf(wordToRemove);
            }
            Console.WriteLine(input);
        }
    }
}
