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
            int altura, i;
            string asteriscos="*";
            int flag2 = 0;
            int flag = 0;
            
            Console.Write("Ingrese altura de piramide ");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine();


            for (i = 0; i < altura; i++)
            {
                if (flag == 0)
                {
                    Console.WriteLine(asteriscos);
                    flag = 1;
                }
                
                if(flag2 == 1)
                {
                    asteriscos = asteriscos + "**";
                    Console.WriteLine(asteriscos);   
                }
                flag2 = 1;
            }
            

            Console.ReadKey();
        }
    }
}
