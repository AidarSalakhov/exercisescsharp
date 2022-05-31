using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017.Data_types_A___Celsius_to_Kelvin_and_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int celsius = int.Parse(Console.ReadLine());

            int kelvin = celsius + 273;

            int fahrenheit = celsius * 18 / 10 + 32;

            Console.WriteLine($"kelvin = {kelvin}");

            Console.WriteLine($"fahrenheit = {fahrenheit}");
        }
    }
}
