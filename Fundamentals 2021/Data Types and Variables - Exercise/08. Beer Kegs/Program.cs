using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines.Each three lines will hold information for a single 
            keg.First up is the model of the keg, after that is the radius of the keg, and lastly is the height of the keg. Calculate the volume using the following 
            formula: π* r^2 * h. At the end, print the model of the biggest keg.
            */

            int n = int.Parse(Console.ReadLine());
            string biggest = string.Empty;
            double biggesVol = 0;

            for(int i=0; i<n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if(volume > biggesVol)
                {
                    biggesVol = volume;
                    biggest = model;
                }

            }

            Console.WriteLine(biggest);
        }
    }
}
