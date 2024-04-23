using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
           double altura, ancho, peri, area, diagonal;
            Console.WriteLine("Dime la altura de un rectangulo :");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Cual es el ancho de ese rectangulo :");
            ancho = int.Parse(Console.ReadLine());
            peri = ((altura * 2) + (ancho * 2));
            area = altura * ancho;
            diagonal = Math.Sqrt((ancho * ancho) + (altura * altura));
            Console.WriteLine("perimetro = " + peri);
            Console.WriteLine("area = " + area);
            Console.WriteLine("diagonal = " + diagonal);
            Console.ReadKey();
        }
    }
}
