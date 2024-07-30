namespace _13_Marca_ObtenerDiagonalPrincipal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el tamaño de la matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            int[] diagonalPrincipal = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }
            for (int i = 0; i < n; i++)
            {
                diagonalPrincipal[i] = matriz[i, i];
            }

            Console.WriteLine("Matriz generada:");
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < n; columna++)
                {

                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nDiagonal principal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(diagonalPrincipal[i] + "\t");
            }
            Console.ReadKey();
        }
    }
}
