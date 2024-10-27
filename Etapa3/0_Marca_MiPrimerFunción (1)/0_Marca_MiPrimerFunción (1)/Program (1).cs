using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Marca_MiPrimerFunción
{
    class Program
    {
        static string y (string x)
        {
            x = "Holaa " + x;
            return x;
        }
        static void Main(string[] args)

        {
            string nombre;
            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine(y(nombre));

            Console.ReadKey();
        }
    }
}
