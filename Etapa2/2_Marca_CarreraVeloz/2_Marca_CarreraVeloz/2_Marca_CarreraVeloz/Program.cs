namespace _2_Marca_CarreraVeloz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la cantidad de vueltas completadas por el Rayo McQueen: ");
            int cantidadVueltas = Convert.ToInt32(Console.ReadLine());
            int[] tiemposVueltas = new int[cantidadVueltas];
            for (int i = 0; i < cantidadVueltas; i++)
            {
                Console.Write("Ingrese el tiempo de la vuelta N°" + (i + 1) + " en segundos: ");
                tiemposVueltas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int tiempoTotal = 0;
            int mejorTiempo = tiemposVueltas[0];
            int mejorvuelta = 1;
            for (int i = 0; i < cantidadVueltas; i++)
            {
                tiempoTotal += tiemposVueltas[i];
                if (tiemposVueltas[i] < mejorTiempo)
                {
                    mejorTiempo = tiemposVueltas[i];
                    mejorvuelta = i + 1;
                }
            }

            double tiempoPromedio = tiempoTotal / cantidadVueltas;
            Console.WriteLine("Tiempo total de la carrera: " + tiempoTotal );
            Console.WriteLine("Promedio de tiempo por vuelta: " + tiempoPromedio );
            Console.WriteLine("La mejor vuelta es la N°" + mejorvuelta + " = " + mejorTiempo + " segundos" );

            Console.ReadKey();
        }

    }
}

