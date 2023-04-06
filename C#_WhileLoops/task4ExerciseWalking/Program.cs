using System;

namespace task4ExerciseWalking
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sum = 0;

            while (true)
            {
                if (input == "Going home")
                {
                    int last = int.Parse(Console.ReadLine());
                    sum += last;
                    if (sum >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        if (sum > 10000)
                        {
                            int over = sum - 10000;
                            Console.WriteLine($"{over} steps over the goal!");
                            return;
                        }
                    }
                    else
                    {
                        int more = 10000 - sum;
                        Console.WriteLine($"{more} more steps to reach goal.");
                        return;
                    }
                }
                else
                {
                    int steps = int.Parse(input);
                    sum += steps;
                    if (sum >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        if (sum > 10000)
                        {
                            int over = sum - 10000;
                            Console.WriteLine($"{over} steps over the goal!");
                            return;
                        }
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
