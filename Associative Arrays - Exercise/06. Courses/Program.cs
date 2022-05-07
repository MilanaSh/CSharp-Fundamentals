using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string courseName = input.Split(" : ")[0];
                string studentName = input.Split(" : ")[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }

                else
                {
                    courses[courseName].Add(studentName);
                }

                input = Console.ReadLine();
            }


            foreach (var pair in courses.OrderByDescending(course => course.Value.Count))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Count}");
                List<string> students = pair.Value;
                students.Sort();

                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }

        }
    }
}
