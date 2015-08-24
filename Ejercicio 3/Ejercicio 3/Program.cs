using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLos numeros primos entre 1 y su numero son:");

            for (int i = 1; i <= numero; i++)
            {
                if (i % 3 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();

        }
    }
}

