using System;

namespace task8ExerciseTennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfTournaments = int.Parse(Console.ReadLine());
            int initialNumberOfPoints = int.Parse(Console.ReadLine());
            int firstPoint = initialNumberOfPoints;

            int w = 0;

            for (int i = 0; i < numberOfTournaments; i++)
            {
                string tournamentStageReached = Console.ReadLine();

                if (tournamentStageReached == "W")
                {
                    initialNumberOfPoints += 2000;
                    w++;
                }
                else if (tournamentStageReached == "F")
                {
                    initialNumberOfPoints += 1200;
                }
                else if (tournamentStageReached == "SF")
                {
                    initialNumberOfPoints += 720;
                }
            }
            int average = (initialNumberOfPoints - firstPoint) / numberOfTournaments;

            double win = (double)w / numberOfTournaments * 100;

            Console.WriteLine($"Final points: {initialNumberOfPoints}");
            Console.WriteLine($"Average points: {average}");
            Console.WriteLine($"{win:F2}%");
        }
    }
}
