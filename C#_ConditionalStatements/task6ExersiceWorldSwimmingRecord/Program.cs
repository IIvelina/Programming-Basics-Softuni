using System;

namespace task6ExersiceWorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double rocordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double swim = distanceInMeters * timeInSeconds;
            double delay = Math.Floor(distanceInMeters / 15);
            delay = delay * 12.5;

            double toatalTIme = delay + swim;

            if (toatalTIme < rocordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {toatalTIme:F2} seconds.");
            }
            else
            {
                double residue = Math.Abs(rocordInSeconds - toatalTIme);
                Console.WriteLine($"No, he failed! He was {residue:F2} seconds slower.");
            }
        }
    }
}
