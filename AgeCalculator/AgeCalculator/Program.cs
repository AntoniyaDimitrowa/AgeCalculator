using System;
using System.Linq;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a language! Input \"BG\" for bulgarian or \"ENG\" for english.");
            string language = Console.ReadLine();
            if(language == "BG")
            {
                Console.WriteLine("Въведете дата на раждане(05.06.2005): ");
            }
            else if(language == "ENG")
            {
                Console.WriteLine("Input date of birth(05.06.2005): ");
            }
          
            int[] date =Console.ReadLine().Split('.').Select(int.Parse).ToArray();
            int day = date[0];
            int month = date[1];
            int year = date[2];

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
            if (language == "BG")
            {
                Console.WriteLine();
                Console.WriteLine($"Днешна дата: {todaysDay:d2}.{todaysMonth:d2}.{todaysYear}");
                Console.WriteLine($"Дата на раждане: {day:d2}.{month:d2}.{year}");
                Console.WriteLine();
                Console.WriteLine($"Днес това дете е на {kidsYears} години {kidsMonths} месеца и {kidsDays} дни.");
            }
            else if (language == "ENG")
            {
                Console.WriteLine();
                Console.WriteLine($"Today's date: {todaysDay:d2}.{todaysMonth:d2}.{todaysYear}");
                Console.WriteLine($"Date of birth: {day:d2}.{month:d2}.{year}");
                Console.WriteLine();
                Console.WriteLine($"Today this kid is {kidsYears} years {kidsMonths} months and {kidsDays} days old.");
            }
        }
    }
}
