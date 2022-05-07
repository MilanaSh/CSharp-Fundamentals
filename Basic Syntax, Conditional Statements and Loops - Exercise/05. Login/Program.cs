using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            //ВАРИАНТ 1!!!!!!!
            string password = new string(username.ToCharArray().Reverse().ToArray());
            int count = 0;

            //ВАРИАНТ 2!!!!
            //int count = 0;
            //string password = "";
            //for (int i = username.Length - 1; i >= 0; i--)
            //{
            //    password += username[i];                
            //}

            string input = Console.ReadLine();
            while (input != password)
            {
                count++;

                if (count>3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }

            Console.WriteLine($"User {username} logged in.");
        }
    }
}
