using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The next 20 leap years are: ");
            DateTime currentTime = DateTime.Now;
            int year = currentTime.Year;
            int count = DateTime.IsLeapYear(year) ? 1 : 0;

            while (count <= 20)
            {   
                if(DateTime.IsLeapYear(year))
                {
                    Console.WriteLine(year);
                    count++;
                }
                year++;
            }
        }
    }
}
