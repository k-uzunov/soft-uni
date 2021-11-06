using System;

namespace _2._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split();
            string[] arrayTwo = Console.ReadLine().Split();

            for(int i = 0; i<arrayOne.Length; i++)
            {
                for(int j = 0; j<arrayTwo.Length; j++)
                {
                    if (arrayTwo[j] == arrayOne[i])
                        Console.Write(arrayTwo[j] + " ");
                }
            }
        }
    }
}
