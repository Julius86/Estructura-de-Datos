using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {            
            bool condicion = true;            
            do
            {
                int num, rem, sum = 0, temp;
                Console.Write("Ingrese un número de 5 dígitos: ");
                num = int.Parse(Console.ReadLine());
                temp = num;
                if (num<=99999&&num>=10000)
                {
                    while (num > 0)
                    {
                        rem = num % 10;
                        num = num / 10;
                        sum = sum * 10 + rem;
                    }
                    Console.WriteLine("El número escrito inversamente es: {0} \n", sum);
                    if (temp == sum)
                    {
                        Console.WriteLine("El número ingresado es palíndromo.");
                        condicion = false;
                    }
                    else
                    {
                        Console.WriteLine("El número ingresado no es palíndromo.");
                        condicion = false;
                    }                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("El número ingresado no es válido. Por favor ingrese un entero de 5 dígitos.");
                }
            } while (condicion == true);
            Console.ReadKey();
        }
    }
}
