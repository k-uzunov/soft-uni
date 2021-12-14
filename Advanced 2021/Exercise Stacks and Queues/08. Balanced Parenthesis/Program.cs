using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> brackets = new Stack<char>();

            foreach(char bracket in input)
            {
                if(brackets.Count == 0)
                {
                    brackets.Push(bracket);
                }
                else
                {
                    if( bracket == '}' && brackets.Peek() == '{')
                    {
                        brackets.Pop();
                    }else if(bracket == ']' && brackets.Peek() == '[')
                    {
                        brackets.Pop();
                    }
                    else if(bracket == ')' && brackets.Peek() == '(')
                    {
                        brackets.Pop();
                    }
                    else
                    {
                        brackets.Push(bracket);
                    }

                }
            }

            if (brackets.Count == 0) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}
