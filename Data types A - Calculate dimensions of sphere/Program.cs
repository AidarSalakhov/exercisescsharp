using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_A___Calculate_dimensions_of_sphere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine($"Surface: {4 * Math.PI * Math.Pow(x, 2)}");
            Console.WriteLine($"Volume: {(4 / 3) * Math.PI * Math.Pow(x, 3)}");
        }
    }
}
