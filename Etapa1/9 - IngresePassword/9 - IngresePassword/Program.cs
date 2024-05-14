using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9___IngresePassword
{
    class Program
    {
        static void Main(string[] args)

        {
            string Contraseña, intento;
            Contraseña = "tomate";
            Console.WriteLine("Cual es tu contra?");
            intento = (Console.ReadLine());
            if (Contraseña == intento)
            {
                Console.WriteLine("correcto");
            }
            else
            {
                Console.WriteLine("incorrecto");
            }
            Console.ReadKey();
        }
    }
}





