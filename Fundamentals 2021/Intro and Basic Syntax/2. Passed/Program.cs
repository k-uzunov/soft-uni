using System;

namespace _2._Passed
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            /*
            if (grade >= 3.00)
                Console.WriteLine("Passed!"); */

            //Modified for 3. Passed of Failed
            if (grade > 2.99)
                Console.WriteLine("Passed!");
            else
                Console.WriteLine("Failed!");
        }
    }
}
