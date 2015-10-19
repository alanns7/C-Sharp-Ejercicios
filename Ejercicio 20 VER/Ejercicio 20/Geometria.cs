using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{

    public class Punto
    {
        private int _x;
        private int _y;

        public Punto(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        
        
        
        public int getX()
        {
            return _x;
        }

        public int getY()
        {
            return _y;
        }


    }




    public class Rectangulo
    {
       
        //atributos
        public float area, ladoHorizontal, ladoVertical, perimetro;
        public Punto vertice1, vertice2, vertice3, vertice4;
        public double distancia;

        

        //constructor
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            //Math.sqrt = raiz cuadrada  // math.pow= potencia 

            this.ladoVertical = Math.Abs(vertice1.getX() - vertice3.getX());
            this.ladoHorizontal = Math.Abs(vertice1.getY() - vertice3.getY());
            this.perimetro = (this.ladoVertical * 2) + (this.ladoHorizontal * 2);
            this.area = ladoVertical * ladoHorizontal;

        }

        public void mostrar()
        {
           
            Console.WriteLine("El lado Mayor es: " + this.ladoHorizontal +
                            "\nEl lado Menor es: " + this.ladoVertical +
                            "\nEl Area es: " + this.area +
                            "\nEl Perimetro es: " + this.perimetro);
            Console.ReadLine();
        }

    }
}