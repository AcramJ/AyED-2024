namespace _4_Marca__PixelDreams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la cantidad de participantes en el torneo: ");
            int cantidadParticipantes = int.Parse(Console.ReadLine());
            int[] puntajes = new int[cantidadParticipantes];

            for (int i = 0; i < cantidadParticipantes; i++)
            {
                Console.Write("Ingrese el puntaje del participante " + (i + 1) +(":"));
                puntajes[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cantidadParticipantes - 1; i++)
            {
                int valormaximo = i;
                for (int j = i + 1; j < cantidadParticipantes; j++)
                {
                    if (puntajes[j] > puntajes[valormaximo])
                    {
                        valormaximo = j;
                    }
                }

                int temp = puntajes[i];
                puntajes[i] = puntajes[valormaximo];
                puntajes[valormaximo] = temp;
            }

            Console.WriteLine("\nPuntajes ordenados de mayor a menor:");
            for (int i = 0; i < cantidadParticipantes; i++)
            {
                Console.WriteLine("Puesto " + (i + 1) + ": " + puntajes[i]);
            }

            Console.WriteLine("\nPrimer lugar: " + puntajes[0]);
            Console.WriteLine("Último lugar: " + puntajes[cantidadParticipantes - 1]);

           
            Console.ReadKey();
        }
    }
}
