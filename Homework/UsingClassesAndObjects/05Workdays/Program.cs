using System;
using System.Collections.Generic;
/////////Write a method that calculates the number of workdays between today and given date, passed as parameter.
///Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
namespace _05Workdays
{
    class Program
    {
        static void Main()
        {
            List<DateTime> holidays = new List<DateTime>() { 
            new DateTime(2015,1,1),
            new DateTime(2015,3,3),
            new DateTime(2015,4,10),new DateTime(2015,4,13),
            new DateTime(2015,5,1),new DateTime(2015,5,6),
            new DateTime(2015,5,24),new DateTime(2015,9,6),
            new DateTime(2015,9,22),
            new DateTime(2015,12,24),new DateTime(2015,12,25),
            new DateTime(2015,12,26)
            };

            Console.WriteLine("Enter date to which you want to calculate work days(mm/dd/yyyy):");
            int res = Calc(DateTime.Parse(Console.ReadLine()), holidays);
            Console.WriteLine("It has {0} work days",res);

        }
        static int Calc(DateTime endDate,List<DateTime> holidays)
        {
            DateTime start = DateTime.Now;
            int counter = 0;
            while(start<=endDate)
            {
                if (!((int)start.DayOfWeek == 0 || (int)start.DayOfWeek == 6 || holidays.Contains(start)))
                    counter++;
                start =start.AddDays(1);
            }
            return counter;

        }
    }
}
