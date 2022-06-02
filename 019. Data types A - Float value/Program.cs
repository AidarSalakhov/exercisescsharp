using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019.Data_types_A___Float_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input distance in meters");
            float meters = int.Parse(Console.ReadLine());

            Console.WriteLine("Input time in hours");
            int hours = int.Parse(Console.ReadLine());

            Console.WriteLine("Input time in minutes");
            int minutes = int.Parse(Console.ReadLine());

            Console.WriteLine("Input time in seconds");
            int seconds = int.Parse(Console.ReadLine());

            TimeSpan timespan = new TimeSpan(hours, minutes, seconds);

            Console.WriteLine($"Speed in meters/sec is {meters / timespan.TotalSeconds}");

            Console.WriteLine($"Speed in km/h is {(meters/1000) / timespan.TotalHours}");

            Console.WriteLine($"Speed in miles/h is {(meters/1609) / timespan.TotalHours}");
        }
    }
}
