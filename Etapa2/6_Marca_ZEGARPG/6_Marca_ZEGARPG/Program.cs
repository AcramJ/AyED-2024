namespace _6_Marca_ZEGARPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de elementos ");
            int Canti = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor minimo que deben tener los objetos para ser considerados en el filtro ");
            int valormin = int.Parse(Console.ReadLine());
            int[] valores = new int[Canti];
            for (int i = 0; i < Canti; i++)
            {
                Console.WriteLine("Ingrese el valor del objeto N°" + (i + 1));
                valores[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Posiciones de los objetos con valor mayor al número especificado:");
            for (int i = 0; i < Canti; i++)
            {
                if (valores[i] > valormin)
                {
                    Console.WriteLine("Objeto N° "+ (i + 1) + ": Valor " + (valores[i]));
                }
            }

            Console.ReadKey();

        }
    }
}
