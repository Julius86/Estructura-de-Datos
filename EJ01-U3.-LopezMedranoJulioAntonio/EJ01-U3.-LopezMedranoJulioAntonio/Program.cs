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
            //Se declaran las variables            
            int numClases=0, cantAlumnos=0;
            string nombre="", calificacion="";
            //Se capturan los datos y se limpia con un clear para tener una pantalla más limpia
            Console.Write("Ingrese la cantidad de clases: ");
            numClases = int.Parse(Console.ReadLine());
            Console.Clear();   
            //Se declara un objeto y se pasan los parámetros
            RanaLista objRana = new RanaLista(numClases, cantAlumnos, nombre, calificacion);
            //Se manda a llamar el método Ranita
            objRana.Ranita();
            Console.ReadKey();
        }
    }    
}
