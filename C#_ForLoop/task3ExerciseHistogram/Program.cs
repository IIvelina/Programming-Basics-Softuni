using System;

namespace task3ExerciseHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number < 200)
                {
                    p1++;
                }
                else if (number < 400)
                {
                    p2++;
                }
                else if (number < 600)
                {
                    p3++;
                }
                else if (number < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }
            double per = 100.0 / n;

            double p11 = p1 * per;
            double p22 = p2 * per;
            double p33 = p3 * per;
            double p44 = p4 * per;
            double p55 = p5 * per;

            Console.WriteLine($"{p11:F2}%");            
            Console.WriteLine($"{p22:F2}%");            
            Console.WriteLine($"{p33:F2}%");            
            Console.WriteLine($"{p44:F2}%");            
            Console.WriteLine($"{p55:F2}%");            
        }
    }
}
