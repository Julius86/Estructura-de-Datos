using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen02._LopezMedranoJulioAntonio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, temp=0;
            Console.Write("Ingrese un número de 7 o más dígitos: ");
            numero = int.Parse(Console.ReadLine());
            RanaExamen objRanaExamen = new RanaExamen(numero, temp);
            Console.WriteLine("La suma de cada dígito del número es de: {0}", objRanaExamen.Sumar(numero, temp));
            Console.ReadKey();
        }
    }

    class RanaExamen
    {
        int numero;
        public RanaExamen(int numero, int temp)
        {
            this.numero = numero;
        }

        public int Sumar(int numero, int temp)
        {
            if(numero>0)
            {                
                return Sumar(numero / 10, temp = numero % 10 + temp); ;
            }
            else
            {
                return temp;
            }
            
        }
    }
}
