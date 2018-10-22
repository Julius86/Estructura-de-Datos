using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_3._LopezMedranoJulioAntonio
{
    class BlackJack
    {
        public void Jugar() // Creamos método jugar para realizar la carga de la baraja
        {
            List<Carta> ListaCartas = new List<Carta>(); // Creamos una lista
            Carta naipe = new Carta(); // Creamos dos objetos, uno para el numero del naipe y el otro para el simbolo
            Carta simbolo = new Carta();
            simbolo.corazon = "♥";
            simbolo.diamante = "♦";
            simbolo.trebol = "♣";
            simbolo.espada = "♠";
            for (int i = 0; i <11; i++) // Creamos un for para ir cargando los números a los naipes
            {                
                naipe.numero = i+1; 
                if(i==9)
                {
                    for (int j = 0; j < 4; j++) // El segundo for es para agregar K, Q y J así mismo con el 10
                    {
                        ListaCartas.Add(naipe);
                    }
                }
                else
                {
                    ListaCartas.Add(naipe);
                }
            }            
        }    
        
        public void Jalar() // Creamos el método Jalar, que nos permitirá sacar otra carta
        {            
            Random aleatorio = new Random(); // Creamos un objeto para el número aleatorio que irá del 1 al 10, y el otro será del 1 al 4 para el símbolo 
            Carta naipe = new Carta();
            int jalarcarta = aleatorio.Next(1, 10);
            int simbolocarta = aleatorio.Next(1, 4);
            if (jalarcarta == 1) // Creamos la condición para el az
            {
                int opcJalar;
                Console.Write("Obtuvo un Az, ¿prefiere usarlo como 1 o como 11?\n1.- 1\n2.- 11\nR: ");
                opcJalar = int.Parse(Console.ReadLine());
                if (opcJalar == 1)
                {
                    naipe.numero = 1;
                }
                else
                {
                    naipe.numero = 11;
                }
            }
            else // En caso de no obtener un 1, que sería el Az, vamos directo a escribir el numero junto al simbolo
            {
                if (simbolocarta == 1)
                {
                    Console.WriteLine(naipe.numero + " " + naipe.corazon);
                }
                else if (simbolocarta == 2)
                {
                    Console.WriteLine(naipe.numero + " " + naipe.diamante);
                }
                else if (simbolocarta == 3)
                {
                    Console.WriteLine(naipe.numero + " " + naipe.trebol);
                }
                else
                {
                    Console.WriteLine(naipe.numero + " " + naipe.espada);
                }
            }
        }
    }
}
