using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___CentigradosKelvinFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius, kel, fahren;
            Console.WriteLine("decime la cantidad de grados centígrados para convertirlos");
            Celsius = int.Parse(Console.ReadLine());
            kel = 273 + Celsius;
            fahren = Celsius * 18 / 10 + 32;
            Console.WriteLine("kelvin =" + kel);
            Console.WriteLine("fahrenheit =" + fahren);
            Console.ReadKey();
        }
    }
}
