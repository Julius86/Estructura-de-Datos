using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] vectorPrueba = new int[3];
            for (int incremento1 = 0; incremento1 < 3; incremento1++)
            {
                Console.Write("Ingrese el {0} número: ", incremento1 + 1);
                vectorPrueba[incremento1] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El número menor de los números capturados es: {0} ", vectorPrueba.Min());
            Console.ReadKey();
        }
    }
}
