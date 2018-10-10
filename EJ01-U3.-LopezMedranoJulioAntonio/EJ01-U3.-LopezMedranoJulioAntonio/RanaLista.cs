using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ01_U3._LopezMedranoJulioAntonio
{
    class RanaLista
    {
        //Se declaran los campos con su respectivo nivel de seguridad
        public int numClases, cantAlumnos;
        public string nombre, calificacion;
        //Se crea el constructor, el cual recibe los parámetros enviados através del objeto 
        //y se utiliza "this" para mantener las mismas variables
        public RanaLista(int numClases, int cantAlumnos, string nombre, string calificacion)
        {
            this.numClases = numClases;
            this.cantAlumnos = cantAlumnos;
            this.nombre = nombre;
            this.calificacion = calificacion;
        }
        //Se crea el método Ranita
        public void Ranita()
        {
            //Se crea una lista, seguido, se crea un for para capturar los nombres de la clase, añadirlos a la lista
            //y capturar la cantidad de alumnos en cada una de las clases capturadas
            List<String> NombreClase = new List<String>();
            for (int i = 0; i < numClases; i++)
            {
                Console.Write("Ingrese el nombre de la clase: ");
                nombre = Console.ReadLine();
                NombreClase.Add(nombre);
                Console.Write("Ingrese la cantidad de alumnos en la clase de {0}: ", nombre);
                cantAlumnos = int.Parse(Console.ReadLine());
                //Se crea un for anidado para capturar las calificaciones de los alumnos asignados por el usuario y los agrega a la lista
                for (int j = 0; j < cantAlumnos; j++)
                {
                    Console.Write("Ingrese la calificación del alumno: ");
                    calificacion = Console.ReadLine();
                    NombreClase.Add(calificacion);
                }
                Console.Clear();
            }
            Console.Clear();
            //Se crea un foreach para desplegar cada dato de la lista
            foreach (string nombClase in NombreClase)
            {
                Console.WriteLine(nombClase);
            }
        }
    }
}
