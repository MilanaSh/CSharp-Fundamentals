using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            string input = Console.ReadLine();

            int bestLenght = 1;
            int bestStartIndex = 0;
            int BestSequanceSum = 0;
            int bestSeqIndex = 0;

            int[] bestSequans = new int[number];

            int counter = 0;

            while (input != "Clone them!")
            {
                int [] currentSequane = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                counter++;

                int lenght = 1;
                int bestCurrentLenght = 1;

                int startIndex = 0;
                int CurrentSequanceSum = 0;

                for (int i = 0; i < currentSequane.Length-1; i++)
                {
                    if (currentSequane[i] == currentSequane[i+1])
                    {
                        lenght++;
                    }

                    else
                    {
                        lenght = 1;
                    }

                    if (lenght>bestCurrentLenght)
                    {
                        bestCurrentLenght = lenght;
                        startIndex = i;
                    }

                    CurrentSequanceSum +=currentSequane[i];
                }

                CurrentSequanceSum += currentSequane[number - 1];

                if (bestCurrentLenght > bestLenght)
                {
                    bestLenght = bestCurrentLenght;
                    bestStartIndex = startIndex;
                    BestSequanceSum = CurrentSequanceSum;
                    bestSeqIndex = counter;
                    bestSequans = currentSequane.ToArray();

                }
                else if (bestCurrentLenght == bestLenght)
                {
                    if (startIndex<bestStartIndex)
                    {
                        bestLenght = bestCurrentLenght;
                        bestStartIndex = startIndex;
                        BestSequanceSum = CurrentSequanceSum;
                        bestSeqIndex = counter;
                        bestSequans = currentSequane.ToArray();

                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (CurrentSequanceSum > BestSequanceSum)
                        {
                            bestLenght = bestCurrentLenght;
                            bestStartIndex = startIndex;
                            BestSequanceSum = CurrentSequanceSum;
                            bestSeqIndex = counter;
                            bestSequans = currentSequane.ToArray();

                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSeqIndex} with sum: {BestSequanceSum}.");
            Console.WriteLine(String.Join(" ", bestSequans));
        }
    }
}
