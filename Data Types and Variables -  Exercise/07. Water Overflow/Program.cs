using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < numOfLines; i++)
            {
                int litersIn = int.Parse(Console.ReadLine());
                sum += litersIn;
                if (sum>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= litersIn;
                    continue;
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
