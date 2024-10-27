using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___MiPrimerMenuObjetivo
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Salir = false;
            string opcion;
            Console.WriteLine("Bienvenido a nuestro programa, te dejo el menu, elige un numero de las opciones");
            Console.WriteLine("---Menu---");
            Console.WriteLine("1.opcion.1");
            Console.WriteLine("2.opcion.2");
            Console.WriteLine("3.opcion.3");
            Console.WriteLine("4.salir");
            while (!Salir)
            { 
            Console.WriteLine("Seleccione una opcion: ");
            opcion = Console.ReadLine();
            if (opcion == "1")
            {
                Console.WriteLine("Elegiste la opcion de la pizza");
            }
            else if (opcion == "2")

            {
                Console.WriteLine("Elegiste la opcion de la hamburguesa");
            }
            else if (opcion == "3")
            {
                Console.WriteLine("Elegiste la opcion de la milanesa");
            }
            else if (opcion == "4")
            {
                Console.WriteLine("¡Hasta luego!");
                   Salir = true;
            } 
             else
            {
                Console.WriteLine("Opcion no valida");
            }

          }
            Console.ReadKey();


        }
    }
}
