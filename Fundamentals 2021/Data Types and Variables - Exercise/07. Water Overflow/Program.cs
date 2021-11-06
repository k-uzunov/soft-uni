using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            You have a water tank with capacity of 255 liters.On the next n lines, you will receive liters of water, which you have to pour in your tank. 
            If the capacity is not enough, print "Insufficient capacity!" and continue reading the next line. On the last line, print the liters in the tank.
            */

            int n = int.Parse(Console.ReadLine());
            int liters;
            int totalLiters = 0;
            for (int i = 0; i<n; i++)
            {
                liters = int.Parse(Console.ReadLine());
                if ((totalLiters + liters) > 255) Console.WriteLine("Insufficient capacity!");
                else totalLiters += liters;
            }

            Console.WriteLine(totalLiters);
        }
    }
}
