namespace _9_Marca_MiprimerMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el numero de filas que va a tener la matriz: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el numero de columnas que va a tener la matriz: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matriz = new int [n, m];
            for (int fila = 0; fila < n; fila++)
            {
                for (int columna = 0; columna < m; columna++)
                {
                    matriz[fila, columna] = 0;
                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

           
    }
}
}

