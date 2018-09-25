using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new Random();
            int[] numeros = new int[100];            
            for (int incremento1=0; incremento1 < numeros.Length; incremento1++)
            {
                numeros[incremento1] = numAleatorio.Next(1, 100);
            }
            Console.WriteLine("Los números no ordenados son: ");
            for (int incremento2 = 0; incremento2 < numeros.Length; incremento2++)
            {
                Console.WriteLine(numeros[incremento2]);
            }
            Array.Sort(numeros);
            Console.WriteLine("Los números ordenados son: ");
            for (int incremento3 = 0; incremento3 < numeros.Length; incremento3++)
            {
                Console.WriteLine(numeros[incremento3]);
            }
            Console.ReadKey();
        }
    }
}
