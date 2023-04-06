using System;

namespace task4ExerciseTrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int evaluative = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();

            double currentSum = 0;
            double sum = 0;
            int count = 0;

            while (presentation != "Finish")
            {
                for (int i = 0; i < evaluative; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    count++;
                    currentSum += grade;
                    sum += grade;

                }
                double currentAverage = currentSum / evaluative;
                Console.WriteLine($"{presentation} - {currentAverage:F2}.");
                currentSum = 0;

                presentation = Console.ReadLine();
            }
            double averageAllPPT = sum / count;
            Console.WriteLine($"Student's final assessment is {averageAllPPT:F2}.");
        }
    }
}
