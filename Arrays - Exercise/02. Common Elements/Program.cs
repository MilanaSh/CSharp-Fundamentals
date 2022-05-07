using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] arrTwo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < arrTwo.Length; i++)           
            //{
            //    string elementTwo = arrTwo[i];
            //    for (int j = 0; j < arrOne.Length; j++)
            //    {
            //        string elementOne = arrOne[j];
            //        if (elementTwo == elementOne)
            //        {
            //            Console.Write(elementOne + " ");
            //        }
            //    }
            //}

            foreach (var elementtwo in arrTwo)
            {
                foreach (var elementOne in arrOne)
                {
                    if (elementOne == elementtwo)
                    {
                        Console.Write(elementtwo + " ");
                    }
                }
            }
        }  
    }
}
