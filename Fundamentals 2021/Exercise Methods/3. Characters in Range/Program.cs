using System;

namespace _3._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());

            charactersInRange((int)a, (int)b);
        }

        static void charactersInRange(int a, int b)
        {

            int start = 0, end = 0;
            if (a > b)
            {
                start = b + 1;
                end = a;
            }
            else
            {
                start = a + 1;
                end = b;
            }

            for(int i = start; i<end; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
