using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_CobrarBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, ingre;
            Console.WriteLine("¿Cual es tu edad?");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("¿cuanto es tu ingreso mensual?");
            ingre = int.Parse(Console.ReadLine());
            if ((edad >= 19) && (ingre >= 100000))
            {
                Console.WriteLine("podes cobrar");
            }
            else
            {
                Console.WriteLine("No podes cobrar");
            }
            Console.ReadKey();
        }
    }
}
