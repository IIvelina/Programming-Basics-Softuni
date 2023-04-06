using System;

namespace task8LabCinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string Monday = "12";
            string Tuesday = "12";
            string Wednesday = "14";
            string Thursday = "14";
            string Friday = "12";
            string Saturday = "16";
            string Sunday = "16";

            string day = Console.ReadLine();

            if (day == "Monday")
            {
                Console.WriteLine(Monday);
            }
            else if (day == "Tuesday")
            {
                Console.WriteLine(Tuesday);
            }
            else if (day == "Wednesday")
            {
                Console.WriteLine(Wednesday);
            }
            else if (day == "Thursday")
            {
                Console.WriteLine(Thursday);
            }
            else if (day == "Friday")
            {
                Console.WriteLine(Friday);
            }
            else if (day == "Saturday")
            {
                Console.WriteLine(Saturday);
            }
            else if (day == "Sunday")
            {
                Console.WriteLine(Sunday);
            }
        }
    }
}
