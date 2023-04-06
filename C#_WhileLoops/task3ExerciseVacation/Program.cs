using System;

namespace task3ExerciseVacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacationMoney = double.Parse(Console.ReadLine());
            double herMoney = double.Parse(Console.ReadLine());

            string action = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());

            int spendCount = 0;
            int countDays = 0;

            while (true)
            {
                countDays++;
                if (action == "spend")
                {
                    spendCount++;
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine($"{countDays}");
                        return;
                    }
                    else
                    {
                        herMoney -= money;
                    }
                }
                if (action == "save")
                {
                    herMoney += money;
                   
                }
                if (herMoney >= vacationMoney)
                {
                    Console.WriteLine($"You saved the money for {countDays} days.");
                    return;
                }

                action = Console.ReadLine();
                 money = double.Parse(Console.ReadLine());

            }
        }
    }
}
