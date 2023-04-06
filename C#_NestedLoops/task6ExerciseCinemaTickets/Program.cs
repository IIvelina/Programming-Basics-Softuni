using System;

namespace task6ExerciseCinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();

            int count = 0;
            int currentCount = 0;
            double student = 0.0;
            double standart = 0.0;
            double kid = 0.0;
            while (filmName != "Finish")
            {
                int freePlace = int.Parse(Console.ReadLine());

                while (true)
                {
                    string type = Console.ReadLine();
                    if (type == "End")
                    {
                        break;
                    }
                    else
                    {
                        currentCount++;
                        count++;
                        if (type == "student")
                        {
                            student++;
                        }
                        else if (type == "standart")
                        {
                            standart++;
                        }
                        else if (type == "kid")
                        {
                            kid++;
                        }
                    }
                }
                double current = (double)currentCount / freePlace * 100;
                Console.WriteLine($"{filmName} - {current:F2}% full.");
                currentCount = 0;
                filmName = Console.ReadLine();
            }
            Console.WriteLine($"");
            Console.WriteLine($"Total tickets: {count}");

        }
    }
}
