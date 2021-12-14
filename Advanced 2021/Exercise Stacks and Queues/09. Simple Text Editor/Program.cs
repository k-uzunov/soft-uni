using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder text = new StringBuilder();
            int numOfCmd = int.Parse(Console.ReadLine());
            Stack<string> previousVersion = new Stack<string>();
            
            for(int i = 0; i < numOfCmd; i++)
            {
                string input = Console.ReadLine();

                if (input.StartsWith('1'))
                {
                    string commandArg = input.Substring(2);
                    previousVersion.Push(text.ToString());
                    text.Append(commandArg);
                    
                }

                if (input.StartsWith('2'))
                {
                    string commandArg = input.Substring(2);
                    previousVersion.Push(text.ToString());
                    text.Remove(text.Length-int.Parse(commandArg), int.Parse(commandArg));
                }

                if (input.StartsWith('3'))
                {
                    string commandArg = input.Substring(2);
                    string @string = text.ToString();
                    Console.WriteLine(@string[int.Parse(commandArg)-1]);
                }

                if (input.StartsWith('4'))
                {
                    text.Clear();
                    text.Append(previousVersion.Pop());
                    Console.WriteLine("Undo");
                }
            }
        }
    }
}
