using System;

namespace task4ExerciseToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.60;
            double talkingDoll = 3.0;
            double teddyBear = 4.10;
            double minion = 8.20;
            double truck = 2.0;

            double tripPrice = double.Parse(Console.ReadLine()); //40.8
            int puzzleNumber = int.Parse(Console.ReadLine()); //20
            int talkingDollsNumber = int.Parse(Console.ReadLine()); //25
            int teddyBearsNumber = int.Parse(Console.ReadLine()); //30
            int minionNumber = int.Parse(Console.ReadLine()); //50
            int truckNumber = int.Parse(Console.ReadLine()); //10

            int total = puzzleNumber + talkingDollsNumber + teddyBearsNumber + minionNumber + truckNumber;

            double totalPrice = puzzleNumber*puzzle + talkingDollsNumber*talkingDoll + teddyBearsNumber*teddyBear + minionNumber*minion + truckNumber*truck;

            if (total >= 50)
            {
                totalPrice = totalPrice - (totalPrice * 0.25);
            }

            totalPrice = totalPrice - (totalPrice * 0.1);

            if (tripPrice <= totalPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - tripPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - totalPrice:F2} lv needed.");
            }
          

        }
    }
}
