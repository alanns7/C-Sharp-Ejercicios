using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_15
{
    public class Calculadora
    {
        public static double Calcular(double num1, double num2, char caracter)
        {
           double resultado;
            
            
            if (caracter == '+')
            {
                resultado = num1 + num2;
                return resultado;
            }

            if (caracter == '-')
            {
                resultado = num1 - num2;
                return resultado;
            }

            if (caracter == '*')
            {
                resultado = num1 * num2;
                return resultado;
            }

            if (caracter == '/' && Validar(num2)==true)
            {
               resultado = num1 / num2;
                return resultado;
            }

            return 0;
        }

            private static bool Validar(double num2)
            {
             
                if(num2!=0)
                {
                 return true;
                }
                return false;
            }


            public static void Mostrar(double resultado)
            {
                Console.WriteLine("El resultado es: " + resultado);
            }


    }
}
