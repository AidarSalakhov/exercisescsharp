using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic___Order_of_priority
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(-6 +(x * 5));
            Console.WriteLine((13 - 2) * x);
            Console.WriteLine((x + (-2)) * (20 / 10));
            Console.WriteLine((12 + x)/(5 - 4));
        }
    }
}
