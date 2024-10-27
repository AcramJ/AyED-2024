using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre,ciudad;
            Console.WriteLine("Dime un nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Dime el nombre de una ciudad:");
            ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + (" bienvenido a ") + ciudad);
            Console.ReadKey();
        }
    }
}
