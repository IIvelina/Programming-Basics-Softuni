using System;

namespace task6ExerciseCake
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            int total = length * width;

            string input = Console.ReadLine();

            while (true)
            {
                if (input == "STOP")
                {
                    Console.WriteLine($"{total} pieces are left.");
                    return;
                }
                else
                {
                    int nubmer = int.Parse(input);

                    total -= nubmer;

                    if (total <= 0)
                    {
                        Console.WriteLine($"No more cake left! You need {Math.Abs(total)} pieces more.");
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
