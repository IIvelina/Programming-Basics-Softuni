using System;

namespace task4ExerciseCleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());            //10
            double washing = double.Parse(Console.ReadLine()); //170
            int doll = int.Parse(Console.ReadLine());         //6

            double money = 0.0;
            double firstMoney = 10;
            double badBoy = 0.0;
            int games = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    badBoy++; // 5

                    // 2-> 10 +0; 4 ->  10 + 10; 6 -> 20 + 10; 8 -> 30 + 10 ; 10 -> 40+10

                    money += firstMoney;
                    firstMoney += 10;


                }
                else
                {
                    games++;
                }
            }
            
            games = games * doll; // 6 * 5 = 30
            double allMoney = (money + games) - badBoy;

            if (allMoney >= washing)
            {
                double left = allMoney - washing;
                Console.WriteLine($"Yes! {left:F2}");
            }
            else
            {
                double lack = washing - allMoney;
                Console.WriteLine($"No! {lack:F2}");
            }
        }
    }
}
