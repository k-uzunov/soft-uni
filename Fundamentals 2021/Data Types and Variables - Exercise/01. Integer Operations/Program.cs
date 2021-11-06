using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read four integer numbers. Add first to the second, divide(integer) the sum by the third number and multiply the result by the fourth number.
            //Print the result.
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            Console.WriteLine(((num1 + num2) / num3) * num4);

        }
    }
}
