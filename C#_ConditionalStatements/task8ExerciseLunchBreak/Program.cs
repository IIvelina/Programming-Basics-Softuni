using System;

namespace task8ExerciseLunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameSeries = Console.ReadLine();
            double episodeDuration = double.Parse(Console.ReadLine());
            double breakDuration = double.Parse(Console.ReadLine());

            double timeForLunch = breakDuration * 0.125;
            double timeFree = breakDuration * 0.25;

            double timeLeft = breakDuration - timeForLunch - timeFree;

            if (timeLeft >= episodeDuration)
            {
                Console.WriteLine($"You have enough time to watch {nameSeries} and left with {timeLeft-episodeDuration:F0} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {nameSeries}, you need {Math.Ceiling(episodeDuration - timeLeft):F0} more minutes.");
            }
        }
    }
}
