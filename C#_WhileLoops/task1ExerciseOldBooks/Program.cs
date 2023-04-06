using System;

namespace task1ExerciseOldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string loveBook = Console.ReadLine();
            string current = Console.ReadLine();
            int counter = 0;

            while (true)
            {
                
                
                if (current == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                    return;
                }
                if (current == loveBook)
                {
                    Console.WriteLine($"You checked {counter} books and found it.");
                    return;
                }
                else
                {
                    counter++;
                    current = Console.ReadLine();
                }

            }
        }
    }
}
