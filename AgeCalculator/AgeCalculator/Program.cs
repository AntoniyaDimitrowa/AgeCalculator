using System;
using System.Linq;

namespace AgeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a language! Input \"BG\" for bulgarian or \"ENG\" for english.");
            Console.WriteLine("Моля изберете език! Въведете \"BG\" за български или \"ENG\" за английски.");
            string language = Console.ReadLine().ToUpper();
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

            int childsYears = 0;
            int childsMonths = 0;
            int childsDays = 0;

            int daysInFebruary;
            if (year % 4 == 0)
            {
                daysInFebruary = 29;
            }
            else { daysInFebruary = 28; }
            int[] daysInMonth = new int[12] { 31, daysInFebruary, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (month < todaysMonth)
            {
                childsYears = todaysYear - year;
                if (day < todaysDay)
                {
                    childsMonths = todaysMonth - month;
                    childsDays = todaysDay - day;
                }
                else if (day == todaysDay)
                {
                    childsMonths = todaysMonth - month;
                    childsDays = 0;
                }
                else
                {
                    childsMonths = todaysMonth - month - 1;
                    childsDays = (daysInMonth[todaysMonth - 2] - day) + todaysDay;
                }
            }
            else if (month == todaysMonth)
            {
                if (day < todaysDay)
                {
                    childsYears = todaysYear - year;
                    childsMonths = 0;
                    childsDays = todaysDay - day;
                }
                else if (day == todaysDay)
                {
                    childsYears = todaysYear - year;
                    childsMonths = 0;
                    childsDays = 0;
                }
                else
                {
                    childsYears = todaysYear - year - 1;
                    childsMonths = 11;
                    childsDays = (daysInMonth[todaysMonth - 2] - day) + todaysDay;
                }
            }
            else
            {
                if (day < todaysDay)
                {
                    childsYears = todaysYear - year - 1;
                    childsMonths = 12 - (month - todaysMonth);
                    childsDays = todaysDay - day;
                }
                else if (day == todaysDay)
                {
                    childsYears = todaysYear - year - 1;
                    childsMonths = 12 - (month - todaysMonth);
                    childsDays = 0;
                }
                else
                {
                    childsYears = todaysYear - year - 1;
                    childsMonths = 12 - (month - todaysMonth + 1);
                    childsDays = (daysInMonth[todaysMonth - 2] - day) + todaysDay;
                }
            }
            if (language == "BG")
            {
                Console.WriteLine();
                Console.WriteLine($"Днешна дата: {todaysDay:d2}.{todaysMonth:d2}.{todaysYear}");
                Console.WriteLine($"Дата на раждане: {day:d2}.{month:d2}.{year}");
                Console.WriteLine();
                if (childsYears == 0 && childsMonths == 0 && childsDays == 0)
                {
                    Console.WriteLine($"Това дете е новородено.");
                }
                else if (childsYears == 0 && childsMonths == 0 && childsDays != 0)
                {
                    Console.WriteLine($"Днес това дете е на {childsDays} дни.");
                }
                else if (childsYears == 0 && childsMonths != 0 && childsDays == 0)
                {
                    Console.WriteLine($"Днес това дете е на {childsMonths} месеца.");
                }
                else if (childsYears != 0 && childsMonths == 0 && childsDays == 0)
                {
                    Console.WriteLine($"Честит рожден ден! Днес детето навършва {childsYears} години.");
                }
                else if (childsYears == 0 && childsMonths != 0 && childsDays != 0)
                {
                    Console.WriteLine($"Днес това дете е на {childsMonths} месеца и {childsDays} дни.");
                }
                else if (childsYears != 0 && childsMonths == 0 && childsDays != 0)
                {
                    Console.WriteLine($"Днес това дете е на {childsYears} години и {childsDays} дни.");
                }
                else if (childsYears != 0 && childsMonths != 0 && childsDays == 0)
                {
                    Console.WriteLine($"Днес това дете е на {childsYears} години и {childsMonths} месеца.");
                }
                else 
                {
                    Console.WriteLine($"Днес това дете е на {childsYears} години, {childsMonths} месеца и {childsDays} дни.");
                }
                
            }
            else if (language == "ENG")
            {
                Console.WriteLine();
                Console.WriteLine($"Today's date: {todaysDay:d2}.{todaysMonth:d2}.{todaysYear}");
                Console.WriteLine($"Date of birth: {day:d2}.{month:d2}.{year}");
                Console.WriteLine();
                if (childsYears == 0 && childsMonths == 0 && childsDays == 0)
                {
                    Console.WriteLine($"This child is a newborn.");
                }
                else if (childsYears == 0 && childsMonths == 0 && childsDays != 0)
                {
                    Console.WriteLine($"Today this child is {childsDays} days old.");
                }
                else if (childsYears == 0 && childsMonths != 0 && childsDays == 0)
                {
                    Console.WriteLine($"Today this child is {childsMonths} months old.");
                }
                else if (childsYears != 0 && childsMonths == 0 && childsDays == 0)
                {
                    Console.WriteLine($"Happy Birthday! Today this child is {childsYears} years old.");
                }
                else if (childsYears == 0 && childsMonths != 0 && childsDays != 0)
                {
                    Console.WriteLine($"Today this child is {childsMonths} months and {childsDays} days old.");
                }
                else if (childsYears != 0 && childsMonths == 0 && childsDays != 0)
                {
                    Console.WriteLine($"Today this child is {childsYears} years and {childsDays} days old.");
                }
                else if (childsYears != 0 && childsMonths != 0 && childsDays == 0)
                {
                    Console.WriteLine($"Today this child is {childsYears} years and {childsMonths} months old.");
                }
                else
                {
                    Console.WriteLine($"Today this child is {childsYears} years, {childsMonths} months and {childsDays} days old.");
                }
                
            }
        }
    }
}
