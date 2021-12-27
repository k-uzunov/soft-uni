using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Grades(grade);
        }
        static void Grades(double grade)
        {
            if (grade >= 2.00 && grade <= 2.99 )
            {
                //Fail
                Console.WriteLine("Fail");
            }
            else if (grade >= 3.00 && grade <= 3.49)
            {
                //Poor
                Console.WriteLine("Poor");
            }
            else if (grade >= 3.50 && grade <= 4.49)
            {
                //Good
                Console.WriteLine("Good");
            }
            else if (grade >= 4.50 && grade <= 5.49)
            {
                //Very good
                Console.WriteLine("Very good");
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                ///Excellent
                Console.WriteLine("Excellent");
            }
        }
    }
}
