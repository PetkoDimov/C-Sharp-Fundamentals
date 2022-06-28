using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> lessons = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] cmdArgs = command
                    .Split(":")
                    .ToArray();

                string firstCommand = cmdArgs[0];
                string lessonTitel = cmdArgs[1];

                if (firstCommand == "Add")
                {
                    if (!lessons.Contains(lessonTitel))
                    {
                        lessons.Add(lessonTitel);
                    }
                }

                else if (firstCommand == "Insert")
                {
                    int index = int.Parse(cmdArgs[2]);
                    if (!lessons.Contains(lessonTitel))
                    {
                        lessons.Insert(index, lessonTitel);
                    }

                }

                else if (firstCommand == "Remove")
                {
                    lessons.Remove(lessonTitel);

                }

                else if (firstCommand == "Swap")
                {
                    string seconLessonTitel = cmdArgs[2];
                    int indexOfFirstLesson = lessons.IndexOf(lessonTitel);
                    int indexOfSecondLesson = lessons.IndexOf(seconLessonTitel);

                    if (indexOfFirstLesson != -1 && indexOfSecondLesson != -1)
                    {
                        lessons[indexOfFirstLesson] = seconLessonTitel;
                        lessons[indexOfSecondLesson] = lessonTitel;

                        string firstLessonExercise = $"{lessonTitel}-Exercise";
                        int indexOfFirstExersice = indexOfFirstLesson + 1;

                        if (indexOfFirstLesson < lessons.Count && lessons[indexOfFirstExersice] == firstLessonExercise)
                        {
                            lessons.RemoveAt(indexOfFirstExersice);
                            indexOfFirstExersice = lessons.IndexOf(lessonTitel);
                            lessons.Insert(indexOfFirstLesson, firstLessonExercise);
                        }

                        string secondLessonExercise = $"{seconLessonTitel}-Exercise";

                        int indexOfSecondExercise = indexOfSecondLesson + 1;

                        if (indexOfSecondExercise < lessons.Count && lessons[indexOfSecondExercise] == secondLessonExercise)
                        {
                            lessons.RemoveAt(indexOfSecondLesson + 1);
                            indexOfSecondLesson = lessons.IndexOf(seconLessonTitel);
                            lessons.Insert(indexOfSecondLesson + 1, secondLessonExercise);
                        }

                    }
                }
                else if (firstCommand == "Exercise")
                {
                    int index = lessons.IndexOf(lessonTitel);
                    string exercise = $"{lessonTitel}-Exercise";

                    bool isThereLesson = lessons.Contains(lessonTitel);
                    bool isThereExercise = lessons.Contains(exercise);

                    if (isThereExercise && !isThereLesson)
                    {
                        lessons.Insert(index + 1, exercise);
                    }

                    else if (!isThereLesson)
                    {
                        lessons.Add(lessonTitel);
                        lessons.Add(exercise);
                    }
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < lessons.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lessons[i]}");
            }

        }
    }
}
