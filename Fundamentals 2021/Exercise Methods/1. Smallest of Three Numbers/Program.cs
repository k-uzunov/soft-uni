using System;

namespace _1._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            smallestNumber(a, b, c);

        }

        static void smallestNumber(int n1, int n2, int n3)
        {
           if(n1 < n2 && n1 < n3)
                Console.WriteLine(n1);
           else if(n2 < n1 && n2 < n3)
                Console.WriteLine(n2);
           else
                Console.WriteLine(n3);
        }
    }
}
