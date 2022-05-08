using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string input = Console.ReadLine();

            while (input!= "end")
            {
                string[] command = input.Split();

                string firstName = command[0];
                string lastName = command[1];
                int age = int.Parse(command[2]);
                string city = command[3];

                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    City = city
                };

                students.Add(student);

                input = Console.ReadLine();
            }

            string filtredCity = Console.ReadLine();

            List<Student> filtredStudents = students
                .Where(x => x.City == filtredCity)
                .ToList();

            foreach (Student student in filtredStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }


        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string City { get; set; }

        }

    }
}
