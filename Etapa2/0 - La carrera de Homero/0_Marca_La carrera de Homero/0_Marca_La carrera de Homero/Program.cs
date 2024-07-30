namespace _0_Marca_La_carrera_de_Homero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de obstáculos:");
            int cantidadObstaculos = int.Parse(Console.ReadLine());

            int puntajeTotal = 0;

            for (int i = 1; i <= cantidadObstaculos; i++)
            {
                Console.WriteLine("Por si o por no");
                Console.WriteLine("Supero el obstaculo "+i +":");
                string respuesta = Console.ReadLine();

                if (respuesta == "si")
                {
                    puntajeTotal += 10;
                    Console.WriteLine("+10 puntos");
                }
                else if (respuesta == "no")
                {
                    puntajeTotal -= 5;
                    Console.WriteLine("-5 puntos");
                }
                else
                {
                    Console.WriteLine("ERROR.");
                    i--; 
                }
            }

            Console.WriteLine("Puntaje total de Homero: "+ puntajeTotal);
            Console.ReadKey();
        }
    }
}
