using System;

namespace task5ExerciseSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            double facebook = 150;
            double instagram = 100;
            double reddit = 50;

            int openTabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 0; i < openTabs; i++)
            {

                string open = Console.ReadLine();

                if (open == "Facebook")
                {
                    salary -= facebook;
                }
                else if (open == "Instagram")
                {
                    salary -= instagram;
                }
                else if (open == "Reddit")
                {
                    salary -= reddit;
                }
                else
                {
                    continue;
                }

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine($"{salary}");
        }
    }
}
