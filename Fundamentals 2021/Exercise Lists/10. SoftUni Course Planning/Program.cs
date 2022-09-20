using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lessons = Console.ReadLine().Split(", ").ToList();

            string input = Console.ReadLine();

            while (input != "course start")
            {
                string[] inputElements = input.Split(":");
                string command = inputElements[0];

                switch (command)
                {
                    case "Add":
                        Add(inputElements[1], lessons);
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

            foreach (string lesson in lessons)
            {
                Console.WriteLine($"{lessons.IndexOf(lesson) + 1}.{lesson}");
            }
        }

        private static void Exercise(string lessonTitle, List<string> lessons)
        {
            if (lessons.Contains(lessonTitle) && !lessons.Contains($"{lessonTitle}-Exercise"))
            {
                int lessonIndex = lessons.IndexOf(lessonTitle);
                lessons.Insert(lessonIndex + 1, $"{lessonTitle}-Exercise");
            }
            else if (!lessons.Contains(lessonTitle))
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

                string temp = lessons[index1];
                lessons[index1] = lessons[index2];
                lessons[index2] = temp;

                if (lessons.Contains($"{lessonTitle1}-Exercise"))
                {
                    lessons.Insert(index2 + 1, lessons[index1 + 1]);
                    lessons.RemoveAt(index1 + 1);
                }

                if(lessons.Contains($"{lessonTitle2}-Exercise"))
                {
                    index1 = lessons.IndexOf(lessonTitle2);
                    index2 = lessons.IndexOf($"{lessonTitle2}-Exercise");

                    lessons.Insert(index1 + 1, lessons[index2]);
                    lessons.RemoveAt(index2+1);
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

        private static void Insert(string lessonTitle, int index, List<string> lessons)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Insert(index, lessonTitle);
            }
        }

        private static void Add(string lessonTitle, List<string> lessons)
        {
            if (!lessons.Contains(lessonTitle))
            {
                lessons.Add(lessonTitle);
            }
        }


    }
}
