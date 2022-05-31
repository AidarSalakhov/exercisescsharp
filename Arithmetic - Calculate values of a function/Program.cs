using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic___Calculate_values_of_a_function
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            for (int i = x; i <= y; i++)
            {
                Console.Write(" " + ((x * x) - (2 * x) + 1));
                x++;
            }

            Console.WriteLine();
        }
    }
}
