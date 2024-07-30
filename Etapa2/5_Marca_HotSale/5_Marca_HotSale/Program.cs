namespace _5_Marca_HotSale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de productos vendidos: ");
            int prodven = int.Parse(Console.ReadLine());
            int[] Productos = new int[prodven];
            for (int i = 0; i < prodven; i++)
            {
                Console.Write("Precio del producto N°" + (i+1) + (": $"));
                Productos[i]= int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < prodven - 1; i++)
            {
                int valormaximo = i;
                for (int j = i + 1; j < prodven; j++)
                {
                    if (Productos[j] > Productos[valormaximo])
                    {
                        valormaximo = j;
                    }
                }

                int temp = Productos[i];
                Productos[i] = Productos[valormaximo];
                Productos [valormaximo] = temp;
            }

            Console.WriteLine("Precio mas alto: " + Productos[0]);
            Console.WriteLine("Precio mas bajo: " + Productos[prodven - 1]);
            Console.ReadKey();
        }
    }
}
