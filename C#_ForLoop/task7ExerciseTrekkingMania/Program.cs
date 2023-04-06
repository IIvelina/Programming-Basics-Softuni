using System;

namespace task7ExerciseTrekkingMania
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int allPeople = 0;

            int Musala = 0;
            int Monblan = 0;
            int Kilimandjaro = 0;
            int k2 = 0;
            int Everest = 0;

            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                allPeople += people;

                if (people <= 5)
                {
                    Musala += people;
                }
                else if (people <= 12)
                {
                    Monblan += people;
                }
                else if (people <= 25)
                {
                    Kilimandjaro += people;
                }
                else if (people <= 40)
                {
                    k2 += people;
                }
                else
                {
                    Everest += people;
                }
            }

            double MusalaPercent = (double)Musala / allPeople * 100;
            double MonblanPercent = (double)Monblan / allPeople * 100; 
            double KilimandjaroPercent = (double)Kilimandjaro / allPeople * 100; 
            double k2Percent = (double)k2 / allPeople * 100; 
            double EverestPercent = (double)Everest / allPeople * 100;

            Console.WriteLine($"{MusalaPercent:F2}%");
            Console.WriteLine($"{MonblanPercent:F2}%");
            Console.WriteLine($"{KilimandjaroPercent:F2}%");
            Console.WriteLine($"{k2Percent:F2}%");
            Console.WriteLine($"{EverestPercent:F2}%");
        }
    }
}
