using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // DateTime //
            var date = new DateTime(2015, 1, 1);           
            DateTime now = DateTime.Now;                             //---now object DateTime---//
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tommorow = now.AddDays(1);         //----DateTime is immutable----//
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now);
            Console.WriteLine(tommorow);
            Console.WriteLine(yesterday);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));    // DateTime format specifiers //

            // Creating TimeSpan //
            var timeSpan = new TimeSpan(1, 2, 3);      
            Console.WriteLine("TimeSpan =" + timeSpan);

            // 2 ways ways creating a TimesSpan //
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);          // FromHours static methods of TimeSpan //

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties //
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add //
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            // Subtract //
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));        // TimeSpan is immutable //

            // Parse // 
            var timeSpanFromParse = TimeSpan.Parse("01:02:03");         // String to TimeSpan //
            Console.WriteLine("Parse: " + timeSpanFromParse);

        }
    }
}
