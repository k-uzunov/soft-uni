using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            //Джъдж не минава тестове 2 и 3
            //Резултат 80/100
            

            double lineOneStartX = double.Parse(Console.ReadLine());
            double lineOneStartY = double.Parse(Console.ReadLine());
            double lineOneEndX = double.Parse(Console.ReadLine());
            double lineOneEndY = double.Parse(Console.ReadLine());


            double lineTwoStartX = double.Parse(Console.ReadLine());
            double lineTwoStartY = double.Parse(Console.ReadLine());
            double lineTwoEndX = double.Parse(Console.ReadLine());
            double lineTwoEndY = double.Parse(Console.ReadLine());


            double lineOneLength = LineLength(lineOneStartX, lineOneStartY, lineOneEndX, lineOneEndY);
            double lineTwoLength = LineLength(lineTwoStartX, lineTwoStartY, lineTwoEndX, lineTwoEndY);

            if (lineOneLength >= lineTwoLength)
            {
                CloserToCentre(lineOneStartX, lineOneStartY, lineOneEndX, lineOneEndY);
            }
            else
            {
                CloserToCentre(lineTwoStartX, lineTwoStartY, lineTwoEndX, lineTwoEndY);
            }

        }

        static double LineLength(double x1, double y1, double x2, double y2)
        {
            double a = Math.Abs(x1 - x2);
            double b = Math.Abs(y1 - y2);

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return c;
        }

        static void CloserToCentre(double x1, double y1, double x2, double y2)
        {
            double firstPointDistance = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double secondPointDistance = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (firstPointDistance < secondPointDistance)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}
