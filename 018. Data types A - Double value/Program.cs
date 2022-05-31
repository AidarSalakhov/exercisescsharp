using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018.Data_types_A___Double_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Perimeter: {x + y + x + y}");

            Console.WriteLine($"Area: {x * y}");

            Console.WriteLine($"Diagonal: { Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2))}");
        }
    }
}
