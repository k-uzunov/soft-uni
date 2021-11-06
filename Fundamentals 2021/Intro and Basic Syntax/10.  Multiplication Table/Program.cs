using System;

namespace _10.__Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Multiplication Table 1.0
            int theInteger = int.Parse(Console.ReadLine());
            int product = 0;

            for(int times = 1; times<=10; times++)
            {
                product = theInteger * times;
                Console.WriteLine("{0} X {1} = {2}", theInteger, times, product);
            }
            */

            //Multiplication Table 2.0
            int theInteger = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product = 0;
            if (multiplier <= 10)
            {
                for (int times = multiplier; times <= 10; times++)
                {
                    product = theInteger * times;
                    Console.WriteLine("{0} X {1} = {2}", theInteger, times, product);
                }
            } else
            {
                product = theInteger * multiplier;
                Console.WriteLine("{0} X {1} = {2}", theInteger, multiplier, product);
            }
        }
    }
}
