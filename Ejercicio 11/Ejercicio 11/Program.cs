using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int i;
            int minimo=0, maximo=0, suma = 0, promedio = 0, flag = 0;

            Console.WriteLine("Ingrese numeros");

            for (i = 0; i < 10; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());

                while (Validacion.validar(-100, 100, numeros[i]) == false)
                {
                    Console.WriteLine("El numero en la posicion " + i + " se encuentra fuera del parametro, reingrese");
                    numeros[i] = int.Parse(Console.ReadLine());

                }

                suma += numeros[i];

                if (flag == 0)
                {
                    minimo = numeros[i];
                    maximo = numeros[i];
                    flag = 1;
                }

                if (numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }

                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }

            }
            

            Console.WriteLine("Todos los numeros son correctos");

            
            promedio= suma/10;

            Console.WriteLine("El numero maximo es: " + maximo);
            Console.WriteLine("El numero minimo es: " + minimo);
            Console.WriteLine("El promedio es: " + promedio);

           
            Console.ReadKey();
        }
    }
}
