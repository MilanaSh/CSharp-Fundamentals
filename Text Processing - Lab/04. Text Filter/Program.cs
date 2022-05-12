using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsToBan = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            foreach (var bannedword in wordsToBan)
            {
                text = text.Replace(bannedword, new string('*', bannedword.Length));
            }
            Console.WriteLine(text);
        }
    }
}
