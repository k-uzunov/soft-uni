using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine());

            if ((int)letter <= 90 && (int)letter >= 65) Console.WriteLine("upper-case");
            else if ((int)letter <= 122 && (int)letter >= 97) Console.WriteLine("lower-case");
        }
    }
}
