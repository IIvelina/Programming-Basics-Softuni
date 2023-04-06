using System;

namespace task2ExerciseHalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int max = int.MinValue;
            int min = int.MaxValue;

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int current = int.Parse(Console.ReadLine());
                sum += current;
                if (current > max)
                {
                    max = current;
                }
                if (current < min)
                {
                    min = current;
                }
            }
            int otherNUmbers = sum - max;
            int diff = Math.Abs(max - otherNUmbers);

            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
