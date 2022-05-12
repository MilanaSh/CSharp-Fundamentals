using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validUsernames = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                string username = input[i];

                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = true;
                    for (int j = 0; j < username.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(username[j]) || username.Contains('-') || username.Contains('_')))
                        {
                            isValid = false;
                        }
       
                    }
                    if (isValid)
                    {
                        validUsernames.Add(username);
                    }
                    
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, validUsernames));
        }
    }
}
