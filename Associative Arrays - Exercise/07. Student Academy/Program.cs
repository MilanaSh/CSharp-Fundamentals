using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsData = new Dictionary<string, List<double>>();
            int num = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < num; i++)
            {
               string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!studentsData.ContainsKey(name))
                {
                    studentsData.Add(name, new List<double>());
                    studentsData[name].Add(grade);
                }
                else
                {
                    studentsData[name].Add(grade);
                }
            }
            
            Dictionary<string, double> average = studentsData.ToDictionary(pair => pair.Key, pair => pair.Value.Average());


            foreach (var kvp in average.Where(kvp => kvp.Value >= 4.5).OrderByDescending(kvp => kvp.Value))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:f2}");
            }

        }
    }
}
