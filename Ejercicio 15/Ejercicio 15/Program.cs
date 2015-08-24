using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado;
            char operador;
            char respuesta;


            do
            {

                Console.Write("Introduzca el primer numero de la operacion: ");
                numero1 = double.Parse(Console.ReadLine());

                Console.Write("Introduzca el operador de la operacion: '+', '-', '*', o '/': ");
                operador = char.Parse(Console.ReadLine());

                while (operador != '+' && operador != '-' && operador != '*' && operador != '/')
                {
                    Console.Write("Error, reingrese caracter: '+', '-', '*', o '/': ");
                    operador = char.Parse(Console.ReadLine());
                }

                Console.Write("Introduzca el segundo numero de la operacion: ");
                numero2 = double.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(numero1, numero2, operador);
                Calculadora.Mostrar(resultado);

                Console.Write("Desea seguir con otra cuenta? s/n: ");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');
            




        }
    }
}
