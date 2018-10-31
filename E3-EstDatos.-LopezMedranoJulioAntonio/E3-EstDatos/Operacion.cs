using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E3_EstDatos
{
    public class Operacion
    {
        Stack Lista = new Stack();
        Queue Cola = new Queue();
        List<int> Listita = new List<int>();
        LinkedList<int> ListaLigada = new LinkedList<int>();

        public void Ejercicio1()
        {
            //¿Qué valores se devuelven durante la siguiente serie de operaciones de pila,
            //si se ejecutan en una pila inicialmente vacía ?
            //push(5), push(3), pop(), push(2), push(8),
            //pop(), pop(), push(9), push(1), pop(), push(7), push(6), pop(), pop(), push(4),
            //pop(), pop()
            Lista.Push(5); Lista.Push(3); Lista.Pop(); Lista.Push(2); Lista.Push(8);
            Lista.Pop(); Lista.Pop(); Lista.Push(9); Lista.Push(1); Lista.Pop(); Lista.Push(7); Lista.Push(6); Lista.Pop(); Lista.Pop(); Lista.Push(4);
            Lista.Pop(); Lista.Pop();
            foreach(object ej1 in Lista)
            {
                Console.WriteLine(ej1);
            }
        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal
            int cantidad = 0;
            Console.Write("Cuantas palabras ingresará: ");
            cantidad = int.Parse(Console.ReadLine());
            List<string> palabras = new List<string>();
            LinkedList<string> reservadas = new LinkedList<string>();
            LinkedList<string> identLiterales = new LinkedList<string>();
            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine("Ingrese la palabra: ");
                palabras.Add(Console.ReadLine());
            }
            string[] palabReservadas = new string[107] {"abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked","class", "const",
                                               "continue",  "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit",
                                               "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit",
                                                "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null",
                                                "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref",
                                                "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
                                                "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
                                                "using", "using", "static", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "async",
                                                "await", "by", "descending", "dynamic", "equals", "from", "get", "global", "groupo", "into", "join", "let",
                                                "nameof", "on", "orderby", "partial", "remove", "select", "set", "value", "var", "when", "where", "yield"};
            List<string> valPalabras = new List<string>();
            foreach (var item in palabReservadas)
            {
                palabras.Add(item);
            }
            Console.WriteLine("\nPalabras clave: ");
            foreach (var word in palabras)
            {
                identLiterales.AddLast(word);
                foreach (var repetido in palabReservadas)
                {
                    if (word == repetido)
                    {
                        Console.WriteLine(repetido);
                        identLiterales.Remove(word);
                        reservadas.AddLast(repetido);
                    }
                }
            }
            Console.WriteLine("\nIdentificadores y literales: ");
            foreach (var item in identLiterales)
            {
                Console.WriteLine(item);
            }
        }

        public void Ejercicio3()
        {
            //Mida el tiempo entre Un lista ligada y una lista normal en el tiempo de ejecucion de 9876 elementos agregados.
            for (int i = 0; i < 9876; i++)
            {
                Listita.Add(i);
                ListaLigada.AddLast(i);
            }
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);
            foreach(object listanormal in Listita)
            {
                Console.Write(" " + listanormal);
            }
            stop = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("\nTiempo de Ejecución Lista Noraml: " + stop.Subtract(start).TotalMilliseconds + "\nPresione cualquier tecla para mostrar el tiempo de ejecución de lista ligada.");
            Console.ReadKey();
            TimeSpan parar;
            TimeSpan empezar = new TimeSpan(DateTime.Now.Ticks);
            foreach (object listanormal in Listita)
            {
                Console.Write(" " + listanormal);
            }
            parar = new TimeSpan(DateTime.Now.Ticks);
            Console.WriteLine("\nTiempo de Ejecución Lista Ligada: " + parar.Subtract(empezar).TotalMilliseconds);
        }

        public void Ejercicio4()
        {
           // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
           // en un solo curso.Incluir métodos que calculen la nota media, la
           // calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
           // implementación. Minimo 30 Calificaciones, de 30 alumnos.
        }
    }
}
