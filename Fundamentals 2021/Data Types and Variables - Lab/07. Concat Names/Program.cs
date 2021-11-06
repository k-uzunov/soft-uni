using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string fName = Console.ReadLine();
            string lName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine("{0}{1}{2}", fName, delimiter, lName);
        }
    }
}
