using System;

namespace task3ExerciseZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] arr1 = new string[n];
            string[] arr2 = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] arr = Console.ReadLine().Split(' ');

                string first = arr[0];
                string second = arr[1];

                if (i % 2 == 0)
                {
                    arr1[i] = first;
                    arr2[i] = second;
                }
                else
                {
                    arr1[i] = second;
                    arr2[i] = first;
                }
            }
            foreach (var item in arr1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            foreach (var item in arr2)
            {
                Console.Write(item + " ");
            }


        }
    }
}
