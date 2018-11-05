using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3._LopezMedranoJulioAntonio
{
    class Move
    {
        // Captura de los datos de clase
        public int Numero { get; private set; }
        public char Inicial { get; private set; }
        public char Final { get; private set; }
        public char Auxiliar { get; private set; }

        public Move(int num, char inicial, char fin, char aux) // Constructor clase Move
        {
            this.Numero = num;
            this.Inicial = inicial;
            this.Auxiliar = aux;
            this.Final = fin;
        }
        public static void TorreHanoi(int num, char inicial, char fin, char aux) //Método del juego
        {
            var stack = new Stack<Move>(); //Crear una pila
            stack.Push(new Move(num, inicial, fin, aux)); //Añadiendo objeto en la pila para comenzar
            while (stack.Count != 0) // Si la pila tiene al menos un elemento, entrará al while, de otra forma no entra.
            {
                var move = stack.Pop(); //hacerle pop a la pila
                if (move.Numero == 1) // Condicion en caso de acabar
                {
                    Console.WriteLine("Mover un disco de {0} a {1}", move.Inicial, move.Final);
                }
                else // Condición para resolver, agregando 3 objetos a la pila y cambiando las posiciones de los "discos"
                {
                    stack.Push(new Move(move.Numero - 1, move.Auxiliar, move.Final, move.Inicial));
                    stack.Push(new Move(1, move.Inicial, move.Final, move.Auxiliar));
                    stack.Push(new Move(move.Numero - 1, move.Inicial, move.Auxiliar, move.Final));
                }
            }
        }
    }
}
