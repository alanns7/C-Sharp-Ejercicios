using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Geometria;

namespace PruebaGeometria
{
    class PruebaGeometria
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 19";
            Punto uno = new Punto(1, 3);
            Punto tres = new Punto (2,5);
            Rectangulo rect = new Rectangulo(uno, tres);
            rect.mostrar();


            //como llamar a las variables _x y _y siendo privadas y sin los metodos setters?

            
            


            
            
            
          

        }
    }
}




