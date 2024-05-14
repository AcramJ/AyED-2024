using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_DiezVeces
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            int contador = 0;
            Console.WriteLine("Ingrese una palabra para que la repita 10 veces");
            palabra = (Console.ReadLine());
            Console.WriteLine("Aqui tienes:");
            while (contador < 10)
            {
                Console.WriteLine(palabra);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
