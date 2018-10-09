using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01_U3._LopezMedranoJulioAntonio
{
    class RanaLista
    {
        public int numClases, cantAlumnos;
        public string nombre, calificacion;

        public RanaLista(int numClases, int cantAlumnos, string nombre, string calificacion)
        {
            this.numClases = numClases;
            this.cantAlumnos = cantAlumnos;
            this.nombre = nombre;
            this.calificacion = calificacion;
        }

        public void Ranita()
        {
            List<String> NombreClase = new List<String>();
            for (int i = 0; i < numClases; i++)
            {
                Console.Write("Ingrese el nombre de la clase: ");
                nombre = Console.ReadLine();
                NombreClase.Add(nombre);
                Console.Write("Ingrese la cantidad de alumnos en la clase de {0}: ", nombre);
                cantAlumnos = int.Parse(Console.ReadLine());
                for (int j = 0; j < cantAlumnos; j++)
                {
                    Console.Write("Ingrese la calificación del alumno: ");
                    calificacion = Console.ReadLine();
                    NombreClase.Add(calificacion);
                }
                Console.Clear();
            }
            Console.Clear();
            foreach (string nombClase in NombreClase)
            {
                Console.WriteLine(nombClase);
            }
        }
    }
}
