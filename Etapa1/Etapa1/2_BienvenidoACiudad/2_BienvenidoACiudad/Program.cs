using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BienvenidoACiudad
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Escribe un programa en C# que calcule el resultado de sumar, restar, multiplicar y dividir dos números introducidos por el usuario.
 Además también debería calcular el resto de la división en la última linea.*/
          
            Console.WriteLine("Ingrese un numero:");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero diferente:");
            int numero2= int.Parse (Console.ReadLine());
            Console.WriteLine("La suma de los dos numeros es  " + (numero1 + numero2));
            Console.WriteLine("la resta es de = " + (numero1 - numero2));
            Console.WriteLine("la multiplicacion es de = " + (numero1 * numero2));
            Console.WriteLine("La division es de = " + (numero1 / numero2));
            Console.WriteLine("El resto de la division es de =" + (numero1 % numero2));
            Console.ReadKey();



        }

    }
}
