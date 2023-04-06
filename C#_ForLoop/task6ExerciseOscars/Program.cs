using System;

namespace task6ExerciseOscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int evaluativePeople = int.Parse(Console.ReadLine());

            for (int i = 0; i < evaluativePeople; i++)
            {
                string currentEvaluate = Console.ReadLine();
                double currentPoints = double.Parse(Console.ReadLine());

                int lengthName = currentEvaluate.Length;

                pointsFromAcademy = pointsFromAcademy + ((lengthName * currentPoints) / 2);


                if (pointsFromAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {pointsFromAcademy:F1}!");
                    return;
                }
            }
            Console.WriteLine($"Sorry, {name} you need {(1250.5 - pointsFromAcademy):F1} more!");
        }
    }
}
