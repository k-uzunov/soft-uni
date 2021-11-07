using System;

namespace _6._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            bool balanced = true;
            bool opened = false;

            for (int i = 0; i<numberOfLines; i++)
            {
                string input = Console.ReadLine();

                if(input == "(")
                {
                    if (!opened)
                    {
                        opened = true;
                    }
                    else
                    {
                        balanced = false;
                    }
                }else if(input == ")")
                {
                    if (opened)
                    {
                        opened = false;
                    }
                    else
                    {
                        balanced = false;
                    }
                }
            }

            Console.WriteLine(balanced && !opened ?"BALANCED":"UNBALANCED");
        }
    }
}
