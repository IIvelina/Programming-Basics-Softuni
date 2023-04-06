using System;

namespace task2ExerciseExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            double average = 0.0;
            int counter = 0;
            int counterBadGrades = 0;
            string last = "";

            while (true)
            {
                counter++;
                if (input != "Enough")
                {
                    last = input;
                }
                if (input == "Enough")
                {
                    double ave = average / (double)counter;
                    Console.WriteLine($"Average score: {ave:F2}");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {last}");
                    return;
                }
                if (grade > 4)
                {
                    average += grade;
                }
                else
                {
                    counterBadGrades++;
                    average += badGrades;
                    if (badGrades == counterBadGrades)
                    {
                        Console.WriteLine($"You need a break, {counterBadGrades} poor grades.");
                        return;
                    }
                }
                input = Console.ReadLine();
                if (input == "Enough")
                {
                    counter--;
                    continue;
                }
                else
                {
                    grade = double.Parse(Console.ReadLine());
                }
                
                

            }
        }
    }
}
