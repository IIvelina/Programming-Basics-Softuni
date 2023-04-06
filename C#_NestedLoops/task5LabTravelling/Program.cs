using System;

namespace task5LabTravelling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            double sum = 0;

            while (true)
            {
                string place = Console.ReadLine();
                if (place == "End")
                {
                    return;
                }
                else
                {
                    double budget = double.Parse(Console.ReadLine());
                    while (true)
                    {
                        double money = double.Parse(Console.ReadLine());
                        sum += money;
                        if (sum >= budget)
                        {
                            Console.WriteLine($"Going to {place}!");
                            sum = 0;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}
