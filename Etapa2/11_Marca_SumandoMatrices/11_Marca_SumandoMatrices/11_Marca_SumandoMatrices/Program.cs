namespace _11_Marca_SumandoMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese el valor de la matriz A: ");
                    matrizA[i, j] = int.Parse(Console.ReadLine());
                }
            }
           
            Console.WriteLine("Ingreso de datos Matriz B: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese los valores: ");
                    matrizB[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Suma de matrices");
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
                }
            }
            Console.Clear();
            Console.WriteLine("Los valores de la matriz A:");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {

                    Console.Write(matrizA[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Los valores de la matriz B:");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {

                    Console.Write(matrizB[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("La suma de las matrices A y B: ");
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    
                    Console.Write(matrizC[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
