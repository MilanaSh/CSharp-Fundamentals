using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine()); 
            double mousePrice = double.Parse(Console.ReadLine()); 
            double keyboardPrice = double.Parse(Console.ReadLine()); 
            double displayPrice = double.Parse(Console.ReadLine());
            double expences = 0.0;

            for (int currGame = 1; currGame <= lostGames; currGame++)
            {
                if (currGame % 2 == 0)
                {
                    expences += headsetPrice;
                }
                if (currGame % 3 == 0)
                {
                    expences += mousePrice;
                }
                if (currGame % 6 == 0)
                {
                    expences += keyboardPrice;
                }
                if (currGame % 12 == 0)
                {
                    expences += displayPrice;
                }
            }
            Console.WriteLine($"Rage expenses: {expences:f2} lv.");
        }
    }
}
