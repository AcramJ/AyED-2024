namespace _7_Marca_ContratacionSoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de candidatos que realizaron el examen: ");
            int candi = int.Parse(Console.ReadLine());
            int[] candidatos= new int[candi];
            for (int i=0; i<candi; i++)
            {
                Console.Write("Ingrese los puntajes del candidato N°" + (i + 1) + (": "));
                candidatos[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < candi - 1; i++)
            {
                int puntajemenor= i;
                for (int j = i + 1; j < candi; j++)
                {
                    if (candidatos[j] < candidatos[puntajemenor])
                    {
                        puntajemenor= j;
                    }
                }

                int temp = candidatos[i];
                candidatos[i] = candidatos[puntajemenor];
                candidatos[puntajemenor] = temp;
            }

            Console.Write("Ingrese un numero entero: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Los puntajes multiples al numero " + num + " son: ");
            for (int i = 0; i < candi; i++)
            {
                if (candidatos[i] %  num == 0)
                {
                    Console.WriteLine( candidatos[i]);
                }
              
            }
            Console.WriteLine("Puntajes ordenados de menor a mayor:");
            for (int i = 0; i < candi; i++)
            {
                Console.WriteLine( (i + 1) + ": " + candidatos[i]);
            }


            Console.ReadKey();
        }
    }
}
