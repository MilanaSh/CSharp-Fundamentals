using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> companiesData = new Dictionary<string, List<string>>();

            while (input !="End")
            {
                string[] inputdata = input.Split(" -> ");

                string companyName = inputdata[0];
                string employeeId = inputdata[1];

                if (!companiesData.ContainsKey(companyName))
                {
                    companiesData.Add(companyName, new List<string>());
                    companiesData[companyName].Add(employeeId);
                }
                else
                {
                    if (!companiesData[companyName].Contains(employeeId))
                    {
                        companiesData[companyName].Add(employeeId);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in companiesData.OrderBy(pair => pair.Key))
            {
                Console.WriteLine(pair.Key);

                List<string> ids = pair.Value;
                //ids.Sort();

                foreach (var emploeesId in ids)
                {
                    Console.WriteLine($"-- {emploeesId}");
                }
            }
        }
    }
}
