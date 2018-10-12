using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC3_2._LopezMedranoJulioAntonio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando una nueva pila
            Stack Paquito = new Stack();
            //Introduciendo datos a la pila
            Paquito.Push(9.18);
            Paquito.Push("Julio");
            Paquito.Push(true);
            Paquito.Push(9);
            Paquito.Push(.000312);
            Paquito.Push(23);
            Paquito.Push("Lopez");
            Paquito.Push(false);
            Paquito.Push("Aprobado");
            Paquito.Push("Reprobado");
            int variable = Paquito.Count;
            //Desplegar posicion, tipo y valor
            for (int i = 0; i < variable; i++) 
            {
                Console.WriteLine("Posicion: {0} Tipo: {1} Valor: {2}", i+1, Paquito.GetType(), Paquito.Peek());
                Paquito.Pop();
            }
            //Detener la pantalla
            Console.ReadKey();

        }
    }
}
