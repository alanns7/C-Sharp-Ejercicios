using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_1
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            int numero;
            double promedio=0;
            int flag = 0;
            int mayor=0;
            int menor=0;

            for (int i = 0; i < 5; i++)
            {

                Console.Write("Ingrese numero :\n");
                numero = int.Parse(Console.ReadLine());
                promedio += numero;

                if (flag == 0)
                {
                    mayor = numero;
                    menor = numero;
                    flag = 1;
                }

                if (numero > mayor)
                {
                    mayor = numero;
                }

                if (numero < menor)
                {
                    menor = numero;
                }

               
            }

            promedio=promedio/5;

            Console.Write("El numero mas alto es " + mayor);
            Console.Write("\n");
            Console.Write("El numero mas bajo es " + menor);
            Console.Write("\n");
            Console.Write("El promedio es: " + promedio);



            Console.ReadKey();



        }
    }
}
