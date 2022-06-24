using System;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input year of birth: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input month of birth(1,2...12): ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input day of birth: ");
            int day = int.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;

            int todaysYear = now.Year;
            int todaysDay = now.Day;
            int todaysMonth = now.Month;

            int kidsYears = 0;
            int kidsMonths = 0;
            int kidsDays = 0;

            int daysInFebruary;
            if (year % 4 == 0)
            {
                daysInFebruary = 29;
            }
            else { daysInFebruary = 28; }
            int[] daysInMonth = new int[12] { 31, daysInFebruary, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month < todaysMonth)
            {
                kidsYears = todaysYear - year;
                if (day < todaysDay)
                {
                    kidsMonths = todaysMonth - month;
                    kidsDays = todaysDay - day;
                }
                else if (day == todaysDay)
                {
                    kidsMonths = todaysMonth - month;
                    kidsDays = 0;
                }
                else
                {
                    kidsMonths = todaysMonth - month - 1;
                    kidsDays = (daysInMonth[todaysMonth - 2] - day) + todaysDay;
                }
            }
            else if (month == todaysMonth)
            {
                if (day < todaysDay)
                {
                    kidsYears = todaysYear - year;
                    kidsMonths = 0;
                    kidsDays = todaysDay - day;
                }
                else if (day == todaysDay)
                {
                    kidsYears = todaysYear - year;
                    kidsMonths = 0;
                    kidsDays = 0;
                }
                else
                {
                    kidsYears = todaysYear - year - 1;
                    kidsMonths = 11;
                    kidsDays = (daysInMonth[todaysMonth - 2] - day) + todaysDay;
                }
            }
            else
            {
                if (day < todaysDay)
                {
                    kidsYears = todaysYear - year - 1;
                    kidsMonths = 12 - (month - todaysMonth);
                    kidsDays = todaysDay - day;
                }
                else if (day == todaysDay)
                {
                    kidsYears = todaysYear - year - 1;
                    kidsMonths = 12 - (month - todaysMonth);
                    kidsDays = 0;
                }
                else
                {
                    kidsYears = todaysYear - year - 1;
                    kidsMonths = 12 - (month - todaysMonth + 1);
                    kidsDays = (daysInMonth[todaysMonth - 2] - day) + todaysDay;
                }
            }
            Console.WriteLine($"Years: {kidsYears}");
            Console.WriteLine($"Months: {kidsMonths}");
            Console.WriteLine($"Days: {kidsDays}");
        }
    }
}
