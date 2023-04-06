using System;

namespace task5ExerciseSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int first = i / 1000;
                int second = i / 100 % 10;
                int third = i / 10 % 10;
                int forth = i % 10;


                Boolean check1 = first != 0 && n % first == 0;
                Boolean check2 = second != 0 && n % second == 0;
                Boolean check3 = third != 0 && n % third == 0;
                Boolean check4 = forth != 0 && n % forth == 0;

                if (check1 && check2 && check3 && check4)
                {
                    Console.Write(i + " ");
                }
            }
                
        }
    }
}
