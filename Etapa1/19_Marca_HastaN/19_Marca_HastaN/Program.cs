using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, n;
            num = 0;
            Console.WriteLine("Dame un numero");
            n = int.Parse(Console.ReadLine());
            while (num <= n) 
            {
                if (num % 2 == 0)
                { 
                    Console.WriteLine(num);
                }
                num++;
            }
            Console.ReadKey();



        }
    }
}
