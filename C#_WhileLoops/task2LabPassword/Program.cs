using System;

namespace task2LabPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string password = Console.ReadLine();

            string input = Console.ReadLine();

            while (true)
            {
                
                if (input == password)
                {
                    Console.WriteLine($"Welcome {name}!");
                    return;
                }
                else
                {
                    input = Console.ReadLine();
                }    

                       }
        }
    }
}
