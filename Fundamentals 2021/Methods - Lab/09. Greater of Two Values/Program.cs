using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            
            if(type == "int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = GetMax(a, b);

                Console.WriteLine(result); 
            }else if(type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char result = GetMax(a, b);

                Console.WriteLine(result);
            }else if (type == "string") 
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();

                string result = GetMax(a, b);
                Console.WriteLine(result);
            }
        }

        static int GetMax(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        static char GetMax(char a, char b)
        {
            if (a > b) return a;
            else return b;
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b)>0) return a;
            else return b;
        }
    }
}
