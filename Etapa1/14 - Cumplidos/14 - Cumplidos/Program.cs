using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("¿Cual es tu edad? :");
            edad = int.Parse(Console.ReadLine());
            int año = 1;
            while (año <= edad) 
            {
                Console.WriteLine(("cumpliste ") + año + (" años"));
                año++;
            }
            Console.ReadKey();
        }
    }
}
