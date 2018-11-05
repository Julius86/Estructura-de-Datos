using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3._1_LopezMedranoJulioAnotnio
{
    class Vacas
    {
        public int Cruzar { get; set; }
        public int Mazie = 2, Daisy = 4, Crazy = 10, Lazy = 20;
        public int tiempo=0, contador=0;
        List<int> vaquitas = new List<int>();
        public Vacas()
        {

        }

        public void Inicio()
        {              
            Console.Write("\nElige el número correspondiente a la vaca que desea cruzar:\n1.-Mazie\n2.-Daisy\n3.-Crazy" +
                "\n4.-Lazy\n5.-Mazie y Daisy" + "\n6.-Crazy y Lazy\n7.-Mazie y Crazy\n8.-Daisy y Lazy\n9.-Mazie y Lazy" +
                "\n10.-Daisy y Crazy\n");
            Cruzar = int.Parse(Console.ReadLine());
            Elegir();
        }

        public void Elegir()
        {
            do
            {
                switch (Cruzar)
                {
                    case 1:
                        vaquitas.Add(Mazie);
                        contador++;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {
                            Inicio();
                        }
                        else
                        {
                            if(tiempo==34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }                            
                        }
                        break;

                    case 2:
                        vaquitas.Add(Daisy);
                        contador++;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {                            
                            Inicio();
                        }
                        else
                        {
                            if (tiempo == 34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }
                        }
                        break;

                    case 3:
                        vaquitas.Add(Crazy);
                        contador++;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {
                            Inicio();
                        }
                        else
                        {
                            if (tiempo == 34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }
                        }
                        break;

                    case 4:
                        vaquitas.Add(Lazy);
                        contador++;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {
                            Inicio();
                        }
                        else
                        {
                            if (tiempo == 34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }
                        }
                        break;

                    case 5:
                        Mazie = 0;
                        vaquitas.Add(Mazie);
                        vaquitas.Add(Daisy);
                        contador = contador + 2;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {                            
                            Inicio();
                        }
                        else
                        {
                            if (tiempo == 34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }
                        }
                        break;

                    case 6:
                        Crazy = 0;
                        vaquitas.Add(Crazy);
                        vaquitas.Add(Lazy);
                        contador = contador + 2;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {
                            Inicio();
                        }
                        else
                        {
                            if (tiempo == 34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }
                        }
                        break;

                    case 7:
                        Mazie = 0;
                        vaquitas.Add(Mazie);
                        vaquitas.Add(Crazy);
                        contador = contador + 2;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {
                            Inicio();
                        }
                        else
                        {
                            if (tiempo == 34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }
                        }
                        break;

                    case 8:
                        Daisy = 0;
                        vaquitas.Add(Daisy);
                        vaquitas.Add(Lazy);
                        contador = contador + 2;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {
                            Inicio();
                        }
                        else
                        {
                            if (tiempo == 34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }
                        }
                        break;

                    case 9:
                        Mazie = 0;
                        vaquitas.Add(Mazie);
                        vaquitas.Add(Lazy);
                        contador = contador + 2;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {
                            Inicio();
                        }
                        else
                        {
                            if (tiempo == 34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }
                        }
                        break;

                    case 10:
                        Daisy = 0;
                        vaquitas.Add(Daisy);
                        vaquitas.Add(Crazy);
                        contador = contador + 2;
                        tiempo = vaquitas.Sum();
                        Console.WriteLine("El tiempo al momento es de: {0}", tiempo);
                        if (contador < 4)
                        {
                            Inicio();
                        }
                        else
                        {                            
                            if (tiempo == 34)
                            {
                                Console.WriteLine("El tiempo es de : {0}, ganase. Felicidades!.", tiempo);
                            }
                            else
                            {
                                Console.WriteLine("El tiempo es de : {0}, lo siento, perdiste.", tiempo);
                            }
                        }
                        break;

                    default:
                        break;
                }
            } while (contador < 4);
        }
    }
}
