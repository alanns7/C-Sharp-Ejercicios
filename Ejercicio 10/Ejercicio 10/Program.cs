using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, i, j;
            string asteriscos = "*";
            int flag2 = 0;
            int flag = 0;
            string espacio = " ";
            int cantEspacio;
            

            Console.Write("Ingrese altura de piramide ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine();
            cantEspacio = altura;
            

            for (i = 0; i < altura; i++)
            {
                if (flag == 0)
                {
                    for (j = 0; j < cantEspacio-1; j++)
                    {
                        Console.Write(espacio); 
                    }
                    
                    Console.WriteLine(asteriscos);
                    
                    flag = 1;
                }
                
                cantEspacio -= 1;
               
                if (flag2 == 1)
                {
                    for (j = 0; j < cantEspacio; j++)
                    { 
                        Console.Write(espacio);
                    }
                    asteriscos = asteriscos + "**";
                    Console.WriteLine(asteriscos);
                }
                flag2 = 1;
            }


            Console.ReadKey();
        }
    }
}
