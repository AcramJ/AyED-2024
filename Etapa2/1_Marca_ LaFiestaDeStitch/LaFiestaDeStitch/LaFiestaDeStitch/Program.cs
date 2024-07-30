using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaFiestaDeStitch
{
    class Program
    {
        static void Main(string[] args)
        {

            int invitados;
            Console.WriteLine("ingresa la cantidad de invitados");
            invitados = int.Parse(Console.ReadLine());
            int[] losInvitados = new int[invitados];
            int comida = 0;
            bool p = true;
            for (int i = 0; i < invitados; i++)
            {
                while (p)
                {
                    Console.WriteLine("Cuanta cantidad va a consumir el invitado " + (i + 1) + " del 1 al 100?");
                    int cantidad = int.Parse(Console.ReadLine());
                    if (cantidad < 1 || cantidad > 100)
                    {
                        p = true;
                    }

                    else if (cantidad > 1 || cantidad < 100)
                    {
                        p = false;
                        losInvitados[i] = cantidad;
                    }
                }
                p = true;
                comida = comida + losInvitados[i];
            }
            Console.WriteLine("El promedio que comera cada invitado es: " + (comida / invitados));
            Console.ReadKey();


        }
    }
}
