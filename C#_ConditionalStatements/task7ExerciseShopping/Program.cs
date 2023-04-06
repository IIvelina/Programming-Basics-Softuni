using System;

namespace task7ExerciseShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); //900
            int vidioCards = int.Parse(Console.ReadLine()); //2
            int processors = int.Parse(Console.ReadLine()); //1
            int memoryFrames = int.Parse(Console.ReadLine()); //3

            double vidioCardsPrice = 250.0 * vidioCards; //500
            double processorsPrice = 35 / 100.0 * vidioCardsPrice * processors;//175
            double memoryFramesPrice = 10 / 100.0 * vidioCardsPrice * memoryFrames; //50

            double total = vidioCardsPrice + processorsPrice + memoryFramesPrice;//825

            if (memoryFrames >= processors)
            {
                total = total - (total * 0.15); //825 - 123.75 = 701.25
            }

            double left = Math.Abs(budget - total); //198.75

            if (total <= budget)
            {
                Console.WriteLine($"You have {left:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {left:F2} leva more!");
            }
        }
    }
}
