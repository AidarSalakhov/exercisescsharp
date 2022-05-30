using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introduction_to_CSarp___Store_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string x = Console.ReadLine();
            Console.WriteLine("Nice to meet you, " + x);
        }
    }
}
