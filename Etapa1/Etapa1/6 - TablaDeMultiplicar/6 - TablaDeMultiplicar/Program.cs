using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___TablaDeMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Decime un numero cualquiera");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("1 * " + num + (" =") + (num * 1));
            Console.WriteLine("2 * " + num + (" =") + (num * 2));
            Console.WriteLine("3 * " + num + (" =") + (num * 3));
            Console.WriteLine("4 * " + num + (" =") + (num * 4));
            Console.WriteLine("5 * " + num + (" =") + (num * 5));
            Console.WriteLine("6 * " + num + (" =") + (num * 6));
            Console.WriteLine("7 * " + num + (" =") + (num * 7));
            Console.WriteLine("8 * " + num + (" =") + (num * 8));
            Console.WriteLine("9 * " + num + (" =") + (num * 9));
            Console.WriteLine("10 * " + num + (" =") + (num * 10));
            Console.ReadKey();
        }
    }
}
