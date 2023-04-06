using System;

namespace task5LabAccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            double sum = 0.0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "NoMoreMoney")
                {
                    Console.WriteLine($"Total: {sum:F2}");
                    return;
                }
                double current = double.Parse(input);

                if (current > 0)
                {
                    sum += current;
                    Console.WriteLine($"Increase: {current:F2}");
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum:F2}");
                    return;
                }
            }
        }
    }
}
