using System;

namespace task4ExerciseArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string first = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = first;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
    }
}
