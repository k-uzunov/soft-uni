using System;
using System.Numerics;

namespace _03._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger[] fibunaci = new BigInteger[n];

            for(int i = 0; i<n; i++)
            {
                if(i == 0 || i == 1)
                {
                    fibunaci[i] = 1;
                }
                else
                {
                    fibunaci[i] = fibunaci[i - 1] + fibunaci[i - 2];
                }
            }

            Console.WriteLine(fibunaci[n-1]);
        }
    }
}
