using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = Console.ReadLine()
                .Split(", ")
                .ToList();

            var commands = Console.ReadLine();

            while (commands != "course start")
            {
                var tokens = commands.Split(":");

                var command = tokens[0];
                var lessonTitle = tokens[1];

                if (command == "Add")
                {
                    if (!courses.Contains(lessonTitle))
                    {
                        courses.Add(lessonTitle);
                    }
                }
                else if (command == "Insert")
                {
                    var index = int.Parse(tokens[2]);
                    if (!courses.Contains(lessonTitle))
                    {
                        courses.Insert(index, lessonTitle);
                    }
                }
                else if (command == "Remove")
                {
                    if (courses.Contains(lessonTitle))
                    {
                        courses.Remove(lessonTitle);
                    }
                }
                else if (command == "Swap")
                {
                    var lessonTitleTwo = tokens[2];
                    if (courses.Contains(lessonTitle) && courses.Contains(lessonTitleTwo))
                    {
                        if (courses.Contains(lessonTitle) && courses.Contains(lessonTitle + "-Exercise"))
                        {
                            int indexOfFirst = courses.IndexOf(lessonTitle);
                            int indexOfFirstExer = courses.IndexOf(lessonTitle + 1);
                            int indexOfSecond = courses.IndexOf(lessonTitleTwo);

                            courses.RemoveAt(indexOfFirst);
                            courses.RemoveAt(indexOfFirstExer);
                            courses.Insert(indexOfFirst, lessonTitleTwo);
                            courses.RemoveAt(indexOfSecond);
                            courses.Insert(indexOfSecond, lessonTitle);
                            courses.Insert(indexOfSecond + 1, lessonTitle + "-Exercise");

                        }
                        else if (courses.Contains(lessonTitleTwo) && courses.Contains(lessonTitleTwo + "-Exercise"))
                        {
                            int indexOfSecond = courses.IndexOf(lessonTitleTwo);
                            int indexOfSecondExcr = courses.IndexOf(lessonTitleTwo);
                            int indexOfFirst = courses.IndexOf(lessonTitle);

                            courses.RemoveAt(indexOfSecond);
                            courses.RemoveAt(indexOfSecondExcr);
                            courses.Insert(indexOfSecond, lessonTitle);
                            courses.RemoveAt(indexOfFirst);
                            courses.Insert(indexOfFirst, lessonTitleTwo);
                            courses.Insert(indexOfFirst + 1, lessonTitleTwo + "-Exercise");
                        }
                        else
                        {
                            int indexFirst = courses.IndexOf(lessonTitle);
                            int indexSecond = courses.IndexOf(lessonTitleTwo);

                            courses.RemoveAt(indexFirst);
                            courses.Insert(indexFirst, lessonTitleTwo);
                            courses.RemoveAt(indexSecond);
                            courses.Insert(indexSecond, lessonTitle);
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    if (courses.Contains(lessonTitle + "-" + command))
                    {
                       
                    }
                    else if (courses.Contains(lessonTitle))
                    {
                        int index = courses.IndexOf(lessonTitle);
                        courses.Insert(index + 1, lessonTitle + "-Exercise");
                    }
                    else
                    {
                        courses.Add(lessonTitle);
                        courses.Add(lessonTitle + "-" + command);
                    }
                }

                commands = Console.ReadLine();
            }

            foreach (var course in courses)
            {
                int indexOf = courses.IndexOf(course);

                Console.WriteLine($"{indexOf + 1}.{course}");
            }
        }
    }
}
