using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ02U2._LopezMedranoJulioAntonio
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFib, num1=0, num2=1, temp=0, opc, menu;
            do
            {
                Console.Write("¿Cuántos números Fibonacci desea calcular?: ");
                numFib = int.Parse(Console.ReadLine());
                Console.Write("¿Qué opción desea realizar?:\n1.- Método For\n2.- Método Recursivo ");
                menu = int.Parse(Console.ReadLine());
                Fibonacci objFibonacci = new Fibonacci(numFib, num1, num2, temp);
                switch(menu)
                {
                    case 1:
                        objFibonacci.metodoFibonacci();
                        objFibonacci.desplegarTiempoEjecucion();
                        break;
                    case 2:
                        Console.WriteLine("La secuencia Fibonacci por el método recursivo es: ");
                        objFibonacci.metodoReFibonacci(numFib);
                        objFibonacci.desplegarTiempoEjecucion();
                        break;
                }
                Console.WriteLine("\n\n¿Desea realizar la secuencia nuevamente?\n1.-Si\n2.-No");
                opc = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opc==1);
        }
    }

    class Fibonacci
    {
        int numFib, num1, num2, temp;
        public Fibonacci(int numFib, int num1, int num2, int temp)
        {
            this.numFib = numFib;
            this.num1 = num1;
            this.num2 = num2;
            this.temp = temp;
        }

        public void metodoFibonacci()
        {
            Console.WriteLine("La secuencia Fibonacci por el método for es: ");
            for (int incremento = 0; incremento < numFib; incremento++)  
            {
                temp = num1;
                num1 = num2; 
                num2 = temp + num1;
                Console.WriteLine(num2);
            }
        }

        public int metodoReFibonacci(int numFib)
        {            
            while (numFib>0)
            {
                temp = num1;
                num1 = num2;
                num2 = temp + num1;
                Console.WriteLine(num2);
                return metodoReFibonacci(numFib - 1);
            }
            return 0;
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
