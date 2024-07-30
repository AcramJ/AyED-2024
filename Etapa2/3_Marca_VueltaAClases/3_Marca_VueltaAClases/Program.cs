namespace _3_Marca_VueltaAClases
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese la cantidad de TPS:");
            int TPS = Convert.ToInt32(Console.ReadLine());
            int[] tps = new int[TPS];

            // Ingreso de notas de TPs
            for (int i = 0; i < TPS; i++)
            {
                Console.WriteLine("Ingrese la nota del TP N° " + (i + 1));
                tps[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ingrese la cantidad de exámenes:");
            int EXA = Convert.ToInt32(Console.ReadLine());
            int[] examenes = new int[EXA];

            for (int i = 0; i < EXA; i++)
            {
                Console.WriteLine("Ingrese la nota del Examen N° " + (i + 1));
                examenes[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sumaExamenes = 0;
            for (int i = 0; i < EXA; i++)
            {
                sumaExamenes += examenes[i];
            }

            double promedioExamenes = sumaExamenes / EXA;
            Console.WriteLine("El promedio de los exámenes es de " + promedioExamenes);

            int tpsAprobados = 0;
            for (int i = 0; i < TPS; i++)
            {
                if (tps[i] >= 6)
                {
                    tpsAprobados++;
                }
            }

            double porcentajeAprobados = tpsAprobados / TPS * 100;
            bool cumplePorcentajeTPs = porcentajeAprobados >= 75;
            if (porcentajeAprobados >= 75)
            {
                Console.WriteLine("Felicidades!! el 75% de los TPs tienen nota >= 6");
            }
            else
            {
                Console.WriteLine("Mala suerte el 75% de los TPs no tienen nota >= 6");
            }

            if (promedioExamenes >= 6 && cumplePorcentajeTPs)
            {
                Console.WriteLine("Aprobaron!!!!!!");
            }
            else
            {
                Console.WriteLine("Desaprobaron :(");
            }

            Console.ReadKey();

        }

    }
    
    
}
