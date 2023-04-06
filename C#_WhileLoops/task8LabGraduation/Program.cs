using System;

namespace task8LabGraduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double grade = double.Parse(Console.ReadLine());

            int counter = 1;
            double sum = 0.0;
            int fail = 0;

            while (true)
            {
                if (counter == 12)
                {
                    sum += grade;
                    double avarage = sum / 12;
                    Console.WriteLine($"{name} graduated. Average grade: {avarage:F2}");
                    return;
                }
                if (grade >= 4)
                {
                    sum += grade;
                    grade = double.Parse(Console.ReadLine());
                    counter++;
                }
                else
                {
                    if (grade < 3)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                        return;
                                            }
                    {

                    }
                    fail++;
                    if (fail == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {counter} grade");
                    }
                    else
                    {
                        sum += grade;
                        grade = double.Parse(Console.ReadLine());
                        counter++;
                    }
                }
            }
        }
    }
}
