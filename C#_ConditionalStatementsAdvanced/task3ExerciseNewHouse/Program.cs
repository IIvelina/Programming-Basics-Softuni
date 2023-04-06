using System;

namespace task3ExerciseNewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            double rose = 5.00;
            double dahlia = 3.80;
            double tulip = 2.80;
            double narcissus = 3.00;
            double gladiolus = 2.50;

            string flowersType = Console.ReadLine();
            int flowersNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.0;

            if (flowersType == "Roses")
            {
                price = rose * flowersNumber;
            }
            else if (flowersType == "Dahlias")
            {
                price = dahlia * flowersNumber;
            }
            else if (flowersType == "Tulips")
            {
                price = tulip * flowersNumber;
            }
            else if (flowersType == "Narcissus")
            {
                price = narcissus * flowersNumber;
            }
            else if (flowersType == "Gladiolus")
            {
                price = gladiolus * flowersNumber;
            }

            double discount = 0.0;

            if (flowersNumber > 80 && flowersType == "Roses")
            {
                discount = price * 0.1;
                price = price - discount;
            }
            else if (flowersNumber > 90 && flowersType == "Dahlias")
            {
                discount = price * 0.15;
                price = price - discount;
            }
            else if (flowersNumber > 80 && flowersType == "Tulips")
            {
                discount = price * 0.15;
                price = price - discount;
            }
            else if (flowersNumber < 120 && flowersType == "Narcissus")
            {
                discount = price * 0.15;
                price = price + discount;
            }
            else if (flowersNumber < 80 && flowersType == "Gladiolus")
            {
                discount = price * 0.2;
                price = price + discount;
            }

            double left = budget - price;

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flowersType} and {left:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(left):F2} leva more.");
            }
        }
    }
}
