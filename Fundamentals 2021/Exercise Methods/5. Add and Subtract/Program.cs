using System;

namespace _5._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(subt(add(a, b), c));


        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static int subt(int a, int b)
        {
            return a - b;
        }
    }
}
