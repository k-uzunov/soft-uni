using System;

namespace _5._Decrypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int numberOfLines = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numberOfLines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                Console.Write((char)(character + key));
            }
        }
    }
}
