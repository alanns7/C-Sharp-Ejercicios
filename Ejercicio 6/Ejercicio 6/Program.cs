using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int año;


            Console.WriteLine("Ingrese año");
            año = int.Parse(Console.ReadLine());

            if(año%4==0)
            {
                Console.WriteLine("El año es bisiesto");
            }

            if (año % 100 == 0 && año % 400 == 0)
            {
                Console.WriteLine("El año es bisiesto");
            }

            else
            {
                Console.WriteLine("El año no es bisiesto");
            }

            Console.ReadKey();
        }
    }
}

