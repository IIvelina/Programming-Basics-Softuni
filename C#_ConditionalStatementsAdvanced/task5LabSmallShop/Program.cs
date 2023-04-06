using System;

namespace task5LabSmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double coffeeSofia = 0.50;
            double coffeePlovdiv = 0.40;
            double coffeeVarna = 0.45;

            double waterSofia = 0.80;
            double waterPlovdiv = 0.70;
            double waterVarna = 0.70;

            double beerSofia = 1.20;
            double beerPlovdiv = 1.15;
            double beerVarna = 1.10;

            double sweetsSofia = 1.45;
            double sweetsPlovdiv = 1.30;
            double sweetsVarna = 1.35;

            double peanutsSofia = 1.60;
            double peanutsPlovdiv = 1.50;
            double peanutsVarna = 1.55;

            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0.0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    price = quantity * coffeeSofia;
                }
                else if (product == "water")
                {
                    price = quantity * waterSofia;
                }
                else if (product == "beer")
                {
                    price = quantity * beerSofia;
                }
                else if (product == "sweets")
                {
                    price = quantity * sweetsSofia;
                }
                else if (product == "peanuts")
                {
                    price = quantity * peanutsSofia;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = quantity * coffeePlovdiv;
                }
                else if (product == "water")
                {
                    price = quantity * waterPlovdiv;
                }
                else if (product == "beer")
                {
                    price = quantity * beerPlovdiv;
                }
                else if (product == "sweets")
                {
                    price = quantity * sweetsPlovdiv;
                }
                else if (product == "peanuts")
                {
                    price = quantity * peanutsPlovdiv;
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    price = quantity * coffeeVarna;
                }
                else if (product == "water")
                {
                    price = quantity * waterVarna;
                }
                else if (product == "beer")
                {
                    price = quantity * beerVarna;
                }
                else if (product == "sweets")
                {
                    price = quantity * sweetsVarna;
                }
                else if (product == "peanuts")
                {
                    price = quantity * peanutsVarna;
                }
            }
            Console.WriteLine(price);
        }
    }
}
