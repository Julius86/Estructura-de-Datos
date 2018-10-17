using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_2._LopezMedranoJulioAntonio
{
    class Program
    {
        static void Main(string[] args)
        {
            // En este programa veremos las diferencias en los métodos que existen entre pilas y colas
            // Las pilas utilizan la forma LIFO que significa Last-In-First-Out que significa el ultimo que entra es el primero que sale
            // Las colas utilizan la forma FIFO que significa First-In-First-Out que significa el primero que entra es el primero que sale
            // Para demostrar esto, se ejecutará el programa mostrando la forma en que cada una de las clases despliegan los elementos que contienen.

            // Esta es la manera en que se declaran las pilas y colas
            Stack pilita = new Stack(5);
            Queue colita = new Queue(5);
            // Aquí se crea un for para ir agregando elementos tanto a la pila como a la cola
            for (int i = 0; i < 5; i++)
            {
                // Para agregar elementos a la pila se utiliza el nombre de la pila con .Push
                pilita.Push(i);
                // Para la cola se utiliza el nombre de la cola con .Enqueue
                colita.Enqueue(i);
                // Cabe mencionar que la función es la misma, únicamente se escriben de forma diferente.
            }
            // Aquí declaramos otro for que nos imprimirá los datos de la pila y cola en el orden en el que los manejan.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("-----------------------Ciclo #{0}--------------------------", i + 1);
                // Aquí se muestra cuantos elementos tiene la pila al llegar a este paso.
                Console.WriteLine("El tamaño de pilita en este ciclo es de: {0} elementos.", pilita.Count);
                Console.WriteLine("El tamaño de colita en este ciclo es de: {0} elementos.", colita.Count);
                // Las Pilas regresan el valor que entró al final, y se puede ver con nombre.Peek
                Console.WriteLine("El elemento en la posición {0} de la pila es: {1}", i, pilita.Peek());
                // Para poder observar el siguiente valor, hay que remover el último valor de la pila, por lo que usamos el .Pop                
                pilita.Pop();
                // En las colas, se regresa el valor que entró al inicio, y se ve con nombre.Peek
                Console.WriteLine("El elemento en la posición {0} de la cola es: {1}", i, colita.Peek());
                // De manera similar que en la pila, la cola debe remover el primer valor, para eso utilizamos nombre.Dequeue
                colita.Dequeue();
            }
            /* Existen otros métodos que comparten la clase Pila y la clase Cola que cumplen las mismas funciones para ambos.
            Clear()	                    Quita todos los objetos de la colección Stack o Queue.
            Clone()                     Crea una copia superficial de la colección Stack o Queue.
            Contains(Object)            Determina si un elemento se encuentra en Stack o Queue.
            CopyTo(Array, Int32)        Copia Stack o Queue en una Array unidimensional existente, a partir del índice especificado de la matriz.
            Equals(Object)              Determina si el objeto especificado es igual al objeto actual. (Heredado de  Object)
            GetEnumerator()             Devuelve una interfaz IEnumerator para la interfaz Stack o Queue.
            GetHashCode()               Sirve como la función hash predeterminada. (Heredado de Object)
            GetType()                   Obtiene el Type de la instancia actual. (Heredado de Object)
            MemberwiseClone()           Crea una copia superficial del Object actual. (Heredado de Object)
            Peek()                      Devuelve el objeto situado al principio de Stack sin eliminarlo.
            Synchronized(Stack)         Devuelve un contenedor sincronizado(seguro para subprocesos) para la clase Stack o Queue.
            ToArray()                   Copia Stack o Queue en una nueva matriz.
            ToString()                  Devuelve una cadena que representa el objeto actual. (Heredado de Object)*/

            // Sin embargo uno de los métodos que tienen las Colas y que no poseen las Pilas es el método TrimToSize()
            // Este establece la capacidad en el número real de elementos que hay en la colección Cola, es decir, remueve
            // los espacios vacíos en la cola para ajustar el tamaño de la misma y reducir espacio en la memoria.
            Console.ReadKey();            
        }
    }
}
