using System;
using System.Linq;

namespace task5ExerciseTopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
                .Select(int.Parse)
                .ToArray();

            int topInt = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int current = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    int compare = arr[j];
                    if (current > compare)
                    {
                        if (j == arr.Length - 1)
                        {
                            Console.Write(current + " ");
                        }
                        else
                        {
                            continue;
                        }


                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.Write(arr[arr.Length - 1]);
        }
    }
}
