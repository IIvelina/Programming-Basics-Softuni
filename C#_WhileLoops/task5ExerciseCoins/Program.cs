using System;

namespace task5ExerciseCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double changeInSt = change * 100;

            int cointCount = 0;

            while (changeInSt > 0)
            {
                if (changeInSt >= 200)
                {
                    changeInSt -= 200;
                    cointCount++;
                }
                else if (changeInSt >= 100)
                {
                    changeInSt -= 100;
                    cointCount++;
                }
                else if (changeInSt >= 50)
                {
                    changeInSt -= 50;
                    cointCount++;
                }
                else if (changeInSt >= 20)
                {
                    changeInSt -= 20;
                    cointCount++;
                }
                else if (changeInSt >= 10)
                {
                    changeInSt -= 10;
                    cointCount++;
                }
                else if (changeInSt >= 5)
                {
                    changeInSt -= 5;
                    cointCount++;
                }
                else if (changeInSt >= 2)
                {
                    changeInSt -= 2;
                    cointCount++;
                }
                else if (changeInSt == 1)
                {
                    changeInSt -= 1;
                    cointCount++;
                }
            }
            Console.WriteLine(cointCount);
        }
    }
}
