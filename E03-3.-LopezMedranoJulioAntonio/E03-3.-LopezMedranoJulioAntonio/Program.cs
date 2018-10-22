using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_3._LopezMedranoJulioAntonio
{
    class Program // El programa no me salió, se me acabaron las ideas para hecharlo a andar. 
    {
        static void Main(string[] args)
        {
            int opc;// Declaramos las variables que utilizaremos para el programa            
            BlackJack JugarBJ = new BlackJack(); // Creamos el objeto 
            JugarBJ.Jugar();// Llamamos a los métodos que utilizaremos
            JugarBJ.Jalar();
            JugarBJ.Jalar();
            do // Creamos un Do-While para llevar a cabo un ciclo
            {
                Console.Write("¿Desea otra carta?\n1.-Si\n2.-No\nR: ");
                opc = int.Parse(Console.ReadLine());
                if (opc == 1)
                {
                    JugarBJ.Jalar(); // Si la opcion es 1 se jala una carta nueva
                }
                else
                {
                    Console.WriteLine("Presione cualquier tecla para salir."); // si la opción es diferente a 1 se sale del programa
                }
            } while (opc==1);          
            Console.ReadKey();            
        }
    }
}
