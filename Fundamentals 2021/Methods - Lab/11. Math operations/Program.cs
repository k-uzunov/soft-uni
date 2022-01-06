using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char @operator = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(a, @operator, b));
        }

        static double Calculate(int a, char @operator, int b)
        {
            double result = 0;
            switch (@operator)
            {
                case '*':
                    //multiply
                    result = a * b;
                    break;
                case '/':
                    //divide
                    result = (double)a / (double)b;
                    break;
                case '+':
                    //add
                    result = a + b;
                    break;
                case '-':
                    //subtract
                    result = a - b;
                    break;
            }

            return result;
        }
    }
}
