namespace _10_Marca_MatrizAleatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el num de filas de la matriz: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el num de columnas de la matriz: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n, m];
            Random aleatorio = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = aleatorio.Next(1, 101);
                }
            }
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < m; columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t"); 
                }
                Console.WriteLine(); 
            }

        }
    }
}

