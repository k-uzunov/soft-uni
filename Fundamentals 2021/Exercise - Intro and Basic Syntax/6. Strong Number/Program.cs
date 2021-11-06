using System;

namespace _6._Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = number; i >= 1 ; i/=10)
            {
                int digit = i % 10;
                int fact = 1;
                for(int j = 1; j<=digit; j++)
                {
                    fact *= j;
                }
                sum += fact;
            }

            if (number == sum) Console.WriteLine("yes");
            else Console.WriteLine("no"); 
        }
    }
}
