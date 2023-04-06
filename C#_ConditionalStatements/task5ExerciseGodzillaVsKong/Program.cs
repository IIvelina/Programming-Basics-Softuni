using System;

namespace task5ExerciseGodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine()); //15437.62
            int numPeople = int.Parse(Console.ReadLine()); //186
            double moneyForClothes = double.Parse(Console.ReadLine()); //57.99

            double decor = budget * 10 / 100.0;

            //•	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10%.

            double clothes = numPeople * moneyForClothes; // 10786.14

            if (numPeople > 150)
            {
                double discount = clothes * 10 / 100.0; //1078.614
                clothes = clothes - discount; //9707.5

            }

            double total = clothes + decor; // 9707.5 + 1543.762 = 11251.262

            if (total > budget)
            {
                double lack = Math.Abs(total - budget);
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {lack:F2} leva more.");
            }
            else
            {
                double residue = budget - total;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {residue:F2} leva left.");
            }
        }
    }
}
