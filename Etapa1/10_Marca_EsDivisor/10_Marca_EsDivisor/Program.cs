using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int divi, divisor,resultado;
            Console.WriteLine("Decime dos numeros");
            divi= int.Parse(Console.ReadLine());
            divisor = int.Parse(Console.ReadLine());
            if (divisor == 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                resultado = divi / divisor;
                Console.WriteLine(("el resultado es = ") + resultado);
            }
            Console.ReadKey();

        }
    }
}
