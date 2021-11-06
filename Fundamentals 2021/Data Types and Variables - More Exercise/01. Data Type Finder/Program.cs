using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                int resultInt;
                float resultFloat;
                char resultChar;
                bool resultBool;

                if (int.TryParse(input, out resultInt)) Console.WriteLine("{0} is integer type", input);
                else if (float.TryParse(input, out resultFloat)) Console.WriteLine("{0} is floating point type", input);
                else if (char.TryParse(input, out resultChar)) Console.WriteLine("{0} is character type", input);
                else if (bool.TryParse(input, out resultBool)) Console.WriteLine("{0} is boolean type", input);
                else Console.WriteLine("{0} is string type", input);

                input = Console.ReadLine();
            }

        }
    }
}
