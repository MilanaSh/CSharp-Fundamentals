using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeCheck(grade);

        }
        static void GradeCheck(double grade)
        {

            string gradewithWords = null;

            if (grade >=2.00 && grade <=2.99)
            {
                gradewithWords = "Fail";
            }

            else if (grade >= 3.00 && grade <= 3.49)
            {
                gradewithWords = "Poor";
            }

            else if (grade >= 3.50 && grade <= 4.49)
            {
                gradewithWords = "Good";
            }

            else if (grade >= 4.50 && grade <= 5.49)
            {
                gradewithWords = "Very good";
            }

            else if (grade >= 5.50 && grade <= 6.00)
            {
                gradewithWords = "Excellent";
            }

            Console.WriteLine(gradewithWords);
        }
        
    }
}
