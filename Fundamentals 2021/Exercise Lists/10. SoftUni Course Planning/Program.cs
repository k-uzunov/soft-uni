using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();
            
            while(input != "course start")
            {
                string[] inputElements = input.Split(":");
                string command = inputElements[0];

                switch (command)
                {
                    case "Add":
                        Add(inputElements[1],lessons);
                        break;
                    case "Insert":
                        Insert(inputElements[1], int.Parse(inputElements[2]), lessons);
                        break;
                    case "Remove":
                        Remove(inputElements[1], lessons);
                        break;
                    case "Swap":
                        Swap(inputElements[1], inputElements[2], lessons);
                        break;
                    case "Exercise":
                        Exercise(inputElements[1], lessons);
                        break;
                }

                input = Console.ReadLine();
            }

            foreach(string lesson in lessons)
            {
                Console.WriteLine($"{lessons.IndexOf(lesson)+1}.{lesson}");
            }
        }

        private static void Exercise(string lessonTitle, List<string> lessons)
        {
            if (lessons.Contains(lessonTitle))
            {
                int lessonIndex = lessons.IndexOf(lessonTitle);
                if (!(lessons[lessonIndex+1] == ($"{lessonTitle}-Exercise")))
                {
                    lessons.Insert(lessonIndex+1, $"{lessonTitle}-Exercise");
                }
            }
            else
            {
                lessons.Add(lessonTitle);
                lessons.Add($"{lessonTitle}-Exercise");
            }
        }

        private static void Swap(string lessonTitle1, string lessonTitle2, List<string> lessons)
        {
            if (lessons.Contains(lessonTitle1) && lessons.Contains(lessonTitle2))
            {
                int index1 = lessons.IndexOf(lessonTitle1);
                int index2 = lessons.IndexOf(lessonTitle2);
                string exercise1 = String.Empty;
                string exercise2 = String.Empty;
                List<string> temp = new List<string>();
                if (lessons.Contains($"{lessonTitle1}-Exercise"))
                {
                    temp.AddRange(lessons.GetRange(index1, 2));
                    lessons.RemoveRange(index1, 2);
                }
                else
                {
                    temp.AddRange(lessons.GetRange(index1, 1));
                    lessons.RemoveAt(index1);
                }

                if (lessons.Contains($"{lessonTitle2}-Exercise"))
                {
                    lessons.InsertRange(index1, lessons.GetRange(index2, 2));
                    lessons.RemoveRange(index2, 2);
                    lessons.InsertRange(index2, temp);
                }
                else
                {
                    lessons.Insert(index1, lessonTitle2);
                    lessons.RemoveAt(index2);
                    lessons.InsertRange(index2, temp);
                }
            }
        }

        private static void Remove(string lessonTitle, List<string> lessons)
        {
            if (lessons.Contains(lessonTitle))
            {
                int index = lessons.IndexOf(lessonTitle);
                if (lessons.Contains($"{lessonTitle}-Exercise"))
                {
                    lessons.RemoveRange(index, 2);
                }
                    lessons.Remove(lessonTitle);
            }
        }

        private static void Insert(string lessonTitle, int index , List<string> lessons)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Insert(index, lessonTitle);
            }
        }

        private static void Add(string lessonTitle, List<string> lessons)
        {
            if (!lessons.Contains(lessonTitle)) {
                lessons.Add(lessonTitle);
            }
        }


    }
}
