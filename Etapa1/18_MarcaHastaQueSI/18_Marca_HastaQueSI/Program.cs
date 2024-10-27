using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___HastaQueSI
{
    class Program
    {
        static void Main(string[] args)
        {
            string SI;
            Console.WriteLine("Ingrese SI para terminar el programa");
            SI = Console.ReadLine();
            while (SI != "SI")
            {
                Console.WriteLine("Desea terminar el programa");
                SI = Console.ReadLine();
            }
            if (SI == "SI") 
            {
                Console.WriteLine("¡Hasta la vista!");
            }
            Console.ReadKey();
        }
    }
}
