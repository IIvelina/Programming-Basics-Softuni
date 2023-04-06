using System;

namespace task1ExerciseNumberPyramid1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //7  
            int current = 1;
            for (int rows = 1; rows <= n; rows++) // въртим от 1 до 7 //2
            {
                for (int cols = 1; cols <= rows; cols++) // rows = 1; cols = 1; въртим до сегашното rows = 1; // 1,2
                {
                    if (current > n) //1 > 7 => fause //fause
                    {
                        break;
                    }
                    Console.Write(current + " "); // print 1  // print 2, 
                    current++; // current = 2 // current = 3 => we return to 2 cycle 
                }
                Console.WriteLine(); // new row
            }
        }
    }
}
