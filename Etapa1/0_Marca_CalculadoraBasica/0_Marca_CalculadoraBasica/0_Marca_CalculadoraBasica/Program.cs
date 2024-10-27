namespace _0_Marca_CalculadoraBasica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el primer número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;
            int resta = num1 - num2;
            int multiplicacion = num1 * num2;
            float division = num1 / num2;
            int resto = num1 % num2;

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicación: " + multiplicacion);
            Console.WriteLine("División: " + division);
            Console.WriteLine("Resto: " + resto);


        }
    }
}
