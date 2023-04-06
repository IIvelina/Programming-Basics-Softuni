using System;

namespace task4ExerciseFishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double spring = 3000;
            double summerAndAutumn = 4200;
            double winter = 2600;

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (season == "Summer")
            {
                price = summerAndAutumn;
            }
            else if (season == "Spring")
            {
                price = spring;
            }
            else if (season == "Autumn")
            {
                price = summerAndAutumn;
            }
            else if (season == "Winter")
            {
                price = winter;
            }

            double discount = 0.0;

            if (fishermen <= 6)
            {
               discount = price * 0.1; 
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                discount = price * 0.15;
            }
            else
            {
                discount = price * 0.25;
            }

            price = price - discount;

            if (fishermen % 2 == 0 && (season == "Summer" || season == "Spring" || season == "Winter"))
            {
                price = price - (price * 0.05);
                //5%
            }

            
            double left = budget - price;

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {left:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(left):F2} leva.");
            }
        }
        
    }
}
