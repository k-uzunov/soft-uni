using System;
using System.Linq;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(text, count));
        }

        static string RepeatString(string text, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += text;
            }

            return result;
        }
    }
}
