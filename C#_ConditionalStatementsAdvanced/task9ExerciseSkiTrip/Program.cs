using System;

namespace task9ExerciseSkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double roomForOnePerson = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;

            //пример: 11 дни = 10 нощувки

            int daysNumber = int.Parse(Console.ReadLine());
            string place = Console.ReadLine();
            string grade = Console.ReadLine();

            double price = 0.0;

            if (place == "room for one person")
            {
                price = roomForOnePerson * (daysNumber - 1);
            }
            else if (place == "apartment")
            {
                price = apartment * (daysNumber - 1);
                if (daysNumber < 10)
                {
                    price = price - (price * 0.3);
                }
                else if (daysNumber <= 15)
                {
                    price = price - (price * 0.35);
                }
                else
                {
                    price = price - (price * 0.5);
                }
            }
            else if (place == "president apartment")
            {
                price = presidentApartment * (daysNumber - 1);
                if (daysNumber < 10)
                {
                    price = price - (price * 0.1);
                }
                else if (daysNumber <= 15)
                {
                    price = price - (price * 0.15);
                }
                else
                {
                    price = price - (price * 0.2);
                }
            }

            if (grade =="positive")
            {
                price = price + (price * 0.25);
            }
            else if (grade == "negative")
            {
                price = price - (price * 0.1);
            }

            Console.WriteLine($"{price:F2}");
        }
    }
}
