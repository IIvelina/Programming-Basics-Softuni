using System;

namespace task7ExerciseHotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            double studioMayOctober = 50;
            double studioJuneSeprember = 75.20;
            double studioJulyAugust = 76;

            double apartmentMayOctober = 65;
            double apartmentJuneSeprember = 68.70;
            double apartmentJulyAugust = 77;

            string month = Console.ReadLine();
            int numberOfNight = int.Parse(Console.ReadLine());

            double priceStudio = 0.0;
            double priceApartment = 0.0;

            if ((month == "May" || month == "October") && (numberOfNight > 7 && numberOfNight <= 14))
            {
                priceStudio = (numberOfNight * studioMayOctober) - (numberOfNight * studioMayOctober * 0.05);
            }
            else if ((month == "May" || month == "October") && (numberOfNight > 14))
            {
                priceStudio = (numberOfNight * studioMayOctober) - (numberOfNight * studioMayOctober * 0.3);
            }
            else if ((month == "June" || month == "September") && (numberOfNight > 14))
            {
                priceStudio = (numberOfNight * studioJuneSeprember) - (numberOfNight * studioJuneSeprember * 0.2);
            }
            else 
            {
                if (month == "May" || month == "October")
                {
                    priceStudio = studioMayOctober * numberOfNight;
                }
                else if (month == "June" || month == "September")
                {
                    priceStudio = studioJuneSeprember * numberOfNight;
                }
                else if (month == "July" || month == "August")
                {
                    priceStudio = studioJulyAugust * numberOfNight;
                }
            }

            if (numberOfNight > 14)
            {
                if (month == "May" || month == "October")
                {
                    priceApartment = (apartmentMayOctober * numberOfNight) - (apartmentMayOctober * numberOfNight * 0.1);
                }
                else if (month == "June" || month == "September")
                {
                    priceApartment = (apartmentJuneSeprember * numberOfNight) - (apartmentJuneSeprember * numberOfNight * 0.1);
                }
                else if (month == "July" || month == "August")
                {
                    priceApartment = (apartmentJulyAugust * numberOfNight) - (apartmentJulyAugust * numberOfNight * 0.1);
                }
            }
            else
            {
                if (month == "May" || month == "October")
                {
                    priceApartment = apartmentMayOctober * numberOfNight;
                }
                else if (month == "June" || month == "September")
                {
                    priceApartment = apartmentJuneSeprember * numberOfNight;
                }
                else if (month == "July" || month == "August")
                {
                    priceApartment = apartmentJulyAugust * numberOfNight;
                }
            }
            Console.WriteLine($"Apartment: {priceApartment:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        }
    }
}
