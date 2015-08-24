using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double cuadrado)
        {
            cuadrado = cuadrado * cuadrado;
            return cuadrado;
        }


        
        public static double CalcularTriangulo(double baseT, double altura)
        {
            double triangulo;
            
            triangulo = (baseT * altura)/2;
            return triangulo;
        }

        
        
        public static double CalcularCirculo(double radio)
        {
            double circulo;

            circulo = Math.PI * (radio * radio); ;
            return circulo; 
        }









    }
}
