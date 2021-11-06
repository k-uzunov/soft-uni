using System;

namespace _6._Middle_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            middle(input);
        }

        static void middle(char[] input)
        {
            if(input.Length % 2 == 0)
            {
                int mid = input.Length / 2;
                Console.WriteLine("{0}{1}",input[mid - 1], input[mid]);
            }

            else
            {
                int mid = input.Length / 2;
                Console.WriteLine(input[mid]);
            }
        }
    }
}
