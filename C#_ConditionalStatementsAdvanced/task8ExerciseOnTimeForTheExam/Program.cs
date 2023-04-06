using System;

namespace task8ExerciseOnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());  //9
            int examMinutes = int.Parse(Console.ReadLine());  //00
            int arrivedHour = int.Parse(Console.ReadLine());  //10 
            int arrivedMinutes = int.Parse(Console.ReadLine()); //30

            int exam = examHour * 60 + examMinutes; //540
            int arrived = arrivedHour * 60 + arrivedMinutes; //630

            int difference = 0;

            if (exam > arrived) // 14:00 > 13:55 // 30 мин преди часа е на време, при повече подранява
            {
                difference = exam - arrived;
                if (difference <= 30 && (exam != arrived))
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else // подранява
                {
                    Console.WriteLine("Early");
                    if (difference < 60)
                    {
                        Console.WriteLine($"{difference} minutes before the start");
                    }
                    else 
                    {
                        int h = difference / 60;
                        int m = difference % 60;
                        if (m < 10)
                        {
                            Console.WriteLine($"{h}:0{m} hours before the start");
                        }
                        else
                        {
                            Console.WriteLine($"{h}:{m} hours before the start");
                        }
                    }
                }
            }
            else if (exam == arrived) // точно в часа
            {
                Console.WriteLine("On time");
            }
            else if (exam < arrived) // 9:30 < 9:50 когато закъснява
            {
                Console.WriteLine("Late");
                difference = arrived - exam;
                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    int h = difference / 60;
                    int m = difference % 60;

                    if (m < 10)
                    {
                        Console.WriteLine($"{h}:0{m} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{h}:{m} hours after the start");
                    }
                }
            }

        }
    }
}
