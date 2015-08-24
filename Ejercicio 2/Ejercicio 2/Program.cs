using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;

            Console.Write("Ingrese numero ");
            numero = int.Parse(Console.ReadLine());

            if (numero <= 0)
            {
                Console.Write("Error, reingrese numero");
                numero = int.Parse(Console.ReadLine());
            }

            cuadrado =  Math.Pow(numero,2);
            cubo = Math.Pow(numero, 3);

            Console.Write("El cuadrado de " + numero + " es " + cuadrado + "\n");
            Console.WriteLine("El cubo de " + numero + " es " + cubo);

            Console.ReadKey();
        }
    }
}
