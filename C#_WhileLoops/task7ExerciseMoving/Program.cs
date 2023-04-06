using System;

namespace task7ExerciseMoving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int free = width * length * height;

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "Done")
                {
                    Console.WriteLine($"{free} Cubic meters left.");
                    return;
                }
                else
                {
                    int number = int.Parse(Console.ReadLine());
                    free -= number;

                    if (free <= 0)
                    {
                        Console.WriteLine($"No more free space! You need {Math.Abs(free)} Cubic meters more.");
                        return;
                    }
                    else
                    {
                        input = Console.ReadLine();
                    }
                }
            }
        }
    }
}
