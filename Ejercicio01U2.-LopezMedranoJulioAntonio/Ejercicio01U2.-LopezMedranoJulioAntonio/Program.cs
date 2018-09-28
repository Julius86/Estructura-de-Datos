using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01U2._LopezMedranoJulioAntonio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Ingrese el número de factorial que desea calcular: ");
            num = int.Parse(Console.ReadLine());
            Rana objRana = new Rana(num);
            objRana.desplegarRanita();
            Console.ReadKey();
        }
    }

    class Rana
    {
        int num, resultado = 1;
        public Rana(int num)
        {
            this.num = num;
        }

        public int metodoRanita()
        {
            for (int incremento = 1; incremento <= num; incremento++)
            {
                resultado = resultado * incremento;
            }
            return resultado;
        }

        public int metodoReRanita(int num)
        {
            if (num==1)
            {
                return 1;
            }
            else
            {
                return num * metodoReRanita(num-1);
            }
        }

        public void desplegarRanita()
        {
            metodoRanita();            
            Console.WriteLine("El resultado del factorial por el método for es: {0}", resultado);
            desplegarTiempoEjecucion();
            Console.WriteLine("\nEl resultado del factorial por el método recursivo es: {0}", metodoReRanita(num));
            desplegarTiempoEjecucion();
        }

        public void desplegarTiempoEjecucion()
        {
            DateTime tiempo1 = DateTime.Now;
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.Write("Tiempo de Ejecución: " + total.ToString());
        }
    }
}
