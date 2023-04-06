using System;
using System.Linq;

namespace task6ExerciseEqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            int left = 0;
            int right = 0;

            if (arr.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                int current = arr[i];

                for (int j = 0; j < current; j++)
                {
                    left += arr[j];
                }
                for (int k = current + 1; k < arr.Length; k++)
                {
                    right += arr[k];
                }

                if (left == right)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
