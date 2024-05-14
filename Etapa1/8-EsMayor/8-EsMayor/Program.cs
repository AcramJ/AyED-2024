using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("¿Cuantos años tenes?");
            edad = int.Parse(Console.ReadLine());
            {
                if (edad >= 18)
                {
                    Console.WriteLine("Sos mayor de edad");
                }
                else if (edad < 18)
                {
                    Console.WriteLine("Sos menor de edad");
                }
                


                Console.ReadKey();
            }
        }
    }
}

