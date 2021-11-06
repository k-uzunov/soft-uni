using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program, which sums the ASCII codes of n characters and prints the sum on the console.
            //Input
                //On the first line, you will receive n – the number of lines, which will follow
                //On the next n lines – you will receive letters from the Latin alphabet

            int numLines = int.Parse(Console.ReadLine());
            char letter;
            int totalSum = 0;

            for (int i = 0; i < numLines; i++)
            {
                letter = char.Parse(Console.ReadLine());
                totalSum += (int)letter;
            }

            Console.WriteLine($"The sum equals: {totalSum}");
        }
    }
}
