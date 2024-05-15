using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un numero entero y positivo ");
            num = int.Parse(Console.ReadLine()); 
            if (num <= 0 )
            {
                Console.WriteLine("El numero que ingreso no es correcto");
            }
            while (num >= 0 )
            {
                Console.WriteLine(num);
                num--;
            }
            Console.ReadKey();
        }
    }
}
