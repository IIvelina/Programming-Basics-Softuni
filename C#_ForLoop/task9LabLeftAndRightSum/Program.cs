using System;

namespace task9LabLeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 0;

            for (int i = 1; i <= n * 2; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i <= n)
                {
                    left += number;
                }
                else
                {
                    right += number;
                }
            }
            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(left - right)}");
            }
        }
    }
}
