using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc=0;
            Operacion objOperacion = new Operacion();
            Console.Write("Elija un número del 1 al 4 para mostrar ejercicios de examen: ");
            opc=int.Parse(Console.ReadLine());            
            switch(opc)
            {
                case 1:
                    objOperacion.Ejercicio1();
                    Console.ReadKey();
                    break;

                case 2:
                    objOperacion.Ejercicio2();
                    Console.ReadKey();
                    break;

                case 3:
                    objOperacion.Ejercicio3();
                    Console.ReadKey();
                    break;

                case 4:
                    Calificaciones objCalificaciones = new Calificaciones();
                    objCalificaciones.Imprimir();
                    Console.ReadKey();
                    break;
            }
        }
    }
}
