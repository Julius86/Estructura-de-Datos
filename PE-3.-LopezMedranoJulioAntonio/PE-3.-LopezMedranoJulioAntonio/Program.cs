using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3._LopezMedranoJulioAntonio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0; // Numero discos a elegir y captura de datos
            Console.Write("¿Cuantos discos desea utilizar? ");
            n = int.Parse(Console.ReadLine());
            Move.TorreHanoi(n, 'I', 'F', 'A'); //Llamado al método pasando parámetros.
            Console.ReadKey();
        }
    }
}
