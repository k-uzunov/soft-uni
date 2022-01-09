using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            GetSign(num1, num2, num3);
        }

        private static void GetSign(int num1, int num2, int num3)
        {
            bool isNegative = false;

            int[] numbers = new int[3]
            {
                num1, num2, num3
            };

            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] == 0)
                {
                    Console.WriteLine("zero");
                    return;
                }
                else if (numbers[i] < 0)
                {
                    if (isNegative)
                    {
                        isNegative = false;
                    }
                    else
                    {
                        isNegative = true;
                    }
                }
            }

            if (isNegative)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
}
