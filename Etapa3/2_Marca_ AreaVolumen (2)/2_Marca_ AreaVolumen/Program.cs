﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Marca__AreaVolumen
{
    class Program
    {
        static double area(double x)
        {
            double pi = 3.14;
            x = pi * (x * x); 
            return x;
        }
        static double volumen (double y, double x)
        {
            y = area(y) * x;
            return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el radio del circulo:");
            double radio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el radio del cilindro:");
            double radiocili = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del cilindro:");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine(volumen(radiocili, altura));
            Console.ReadKey();


        }
    }
}
