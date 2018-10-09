using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace EJ01_U3._LopezMedranoJulioAntonio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numClases=0, cantAlumnos=0;
            string nombre="", calificacion="";
            Console.Write("Ingrese la cantidad de clases: ");
            numClases = int.Parse(Console.ReadLine());
            Console.Clear();            
            RanaLista objRana = new RanaLista(numClases, cantAlumnos, nombre, calificacion);
            objRana.Ranita();
            Console.ReadKey();
        }
    }    
}
