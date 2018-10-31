using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    class Calificaciones
    {
        public int calif { get; set; }
        public int cantidad { get; set; }
        List<int> notas = new List<int>();
        int temp;
        public Calificaciones()
        {

        }
        public void Capturar()
        {
            Console.Write("Ingrese la cantidad de calificaciones a capturar: ");
            cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese la calificación del alumno {0}: ", i+1);
                calif = int.Parse(Console.ReadLine());
                notas.Add(calif);
            }
        }
        public void CalifAlta()
        {
            notas.Sort();
            notas.Reverse();
            Console.WriteLine("La nota más alta es de: " + notas.ElementAt(0));
        }
        public void CalifBaja()
        {
            notas.Sort();
            Console.WriteLine("La nota más baja es de: " + notas.ElementAt(0));
        }
        public void NotaMedia()
        {
            var resultado = notas.Sum();
            temp = resultado / cantidad;
            Console.WriteLine("La nota media es de: " + temp);
        }
        public void Imprimir()
        {
            Capturar();
            CalifAlta();
            CalifBaja();
            NotaMedia();
        }
        
    }
}
