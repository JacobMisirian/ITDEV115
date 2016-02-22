// Written by Jacob Misirian
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Info().ToString() + "\n");
            new StudentUI().MainMethod();
            Console.Read();
        }
    }
}
