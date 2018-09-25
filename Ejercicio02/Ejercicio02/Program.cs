using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int longitudVector = 0;
            Console.Write("Ingrese la cantidad de números que desea utilizar: ");
            longitudVector = int.Parse(Console.ReadLine());
            int[] vectorPrueba = new int[longitudVector];
            for (int incremento1 = 0; incremento1 < longitudVector; incremento1++)
            {
                Console.Write("Ingrese el {0} número: ", incremento1 + 1);
                vectorPrueba[incremento1] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(vectorPrueba);
            Console.WriteLine("El orden inverso en que los números fueron capturados es: ");
            for (int incremento2 = 0; incremento2 < longitudVector; incremento2++)
            {
                Console.WriteLine(vectorPrueba[incremento2]);
            }
            Console.ReadKey();
        }
    }
}