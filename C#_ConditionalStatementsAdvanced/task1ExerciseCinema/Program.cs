using System;

namespace task1ExerciseCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            double premiere = 12.00;
            double normal = 7.50;
            double discount = 5.00;

            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double income = 0.0;

            if (type == "Premiere")
            {
                income = rows * columns * premiere;
            }
            else if (type == "Normal")
            {
                income = rows * columns * normal;
            }
            else if (type == "Discount")
            {
                income = rows * columns * discount;
            }
            Console.WriteLine($"{income:F2} leva");
            
        }
    }
}
