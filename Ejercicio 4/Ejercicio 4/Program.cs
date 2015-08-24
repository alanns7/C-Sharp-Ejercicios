using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
         int suma;
         int contador=0;

         Console.WriteLine("Los 4 primeros numeros perfectos son:");
         


            for (int i = 1; i <= 1000; i++)
            {
                suma = 0;
                
                for(int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        suma += j;

                    }

                    if (suma == i)
                    {
                        contador++;
                        suma = 0;
                        Console.WriteLine(i);
                        break;
                    }

                }
                
                if (contador == 4)
                {
                    break;
                }
            }


            
            Console.ReadKey();


        }
    }
}
