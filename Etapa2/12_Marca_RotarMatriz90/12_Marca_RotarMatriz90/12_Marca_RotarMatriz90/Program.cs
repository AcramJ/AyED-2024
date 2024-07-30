namespace _12_Marca_RotarMatriz90
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matriz = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese el valor de la matriz: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Matriz Original:");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {

                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }

            int n = matriz.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[j, i];
                    matriz[j, i] = temp;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    int temp = matriz[i, j];
                    matriz[i, j] = matriz[i, n - j - 1];
                    matriz[i, n - j - 1] = temp;
                }
            }

            Console.WriteLine("Matriz rotada 90 grados en sentido horario:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
