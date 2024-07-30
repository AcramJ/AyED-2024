namespace _14_Marca_CalificacionesEstudiantiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de estudiantes:");
            int n = int.Parse(Console.ReadLine());
            object[,] estudiantes = new object[n, 3];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Ingrese los datos del estudiante {i + 1}:");

                Console.Write("Nombre: ");
                estudiantes[i, 0] = Console.ReadLine();

                Console.Write("Edad: ");
                estudiantes[i, 1] = int.Parse(Console.ReadLine());

                Console.Write("Calificación: ");
                estudiantes[i, 2] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\nInformación de los estudiantes:\n");
            Console.WriteLine("Nombre\tEdad\tCalificación");
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(estudiantes[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
    }
}

}

