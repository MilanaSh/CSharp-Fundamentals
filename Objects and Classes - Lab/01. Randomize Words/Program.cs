using System;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int position = rnd.Next(words.Length);

                string temp = words[i];
                words[i] = words[position];
                words[position] = temp;

            }

            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}
