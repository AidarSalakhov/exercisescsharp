using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_types_A___Basic_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"{x} + {y} = {x+y}");
            Console.WriteLine($"{x} - {y} = {x-y}");
            Console.WriteLine($"{x} * {y} = {x*y}");
            Console.WriteLine($"{x} / {y} = {x/y}");
            Console.WriteLine($"{x} mod {y} = {x%y}");
        }
    }
}
