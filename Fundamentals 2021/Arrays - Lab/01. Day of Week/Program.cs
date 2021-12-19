using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            int input = int.Parse(Console.ReadLine());
            if(input <=daysOfWeek.Length && input > 0)
                Console.WriteLine(daysOfWeek[input-1]);
            else
                Console.WriteLine("Invalid day!");
        }
    }
}
