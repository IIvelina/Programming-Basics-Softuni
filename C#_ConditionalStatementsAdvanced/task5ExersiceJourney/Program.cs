using System;

namespace task5ExersiceJourney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            //summer winter

            double costs = 0.0;
            string destination = "";
            string place = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                //Bulgaria
                if (season == "summer")
                {
                    costs = budget * 0.3;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    costs = budget * 0.7;
                    place = "Hotel";
                }

            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                //Balkans
                if (season == "summer")
                {
                    costs = budget * 0.4;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    costs = budget * 0.8;
                    place = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                //Europe
                costs = budget * 0.9;
                place = "Hotel";
            }

            //double spend = budget - costs;

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {costs:F2}");
        }
    }
}
