using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());

            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            CloserToCentre(x1, y1, x2, y2);
        }

        static void CloserToCentre(double x1, double y1, double x2, double y2)
        {
            double firstPointDistance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPointDistance = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (firstPointDistance < secondPointDistance)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
