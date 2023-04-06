using System;

namespace task2ExerciseEqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFirst = int.Parse(Console.ReadLine());
            int numSecond = int.Parse(Console.ReadLine());

            int even = 0;
            int odd = 0;

            for (int number = numFirst; number <= numSecond; number++)
            {
                string current = number.ToString();

                for (int i = 0; i < current.Length; i++)
                {
                    int firstDigit = (int)(current[0]);
                    int secondDigit = (int)(current[1]);
                    int thirdDigit = (int)(current[2]);
                    int forthDigit = (int)(current[3]);
                    int fifthDigit = (int)(current[4]);
                    int sixthDigit = (int)(current[5]);

                    even = firstDigit + thirdDigit + fifthDigit;
                    odd = secondDigit + forthDigit + sixthDigit;

                }
                if (even == odd)
                {
                    Console.Write(number + " ");
                }
                else
                {
                    even = 0;
                    odd = 0;
                    continue;
                }
            }
        }
    }
}
