using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19
{
    class Boligrafo
    {
        

        public Boligrafo(ConsoleColor _color, int _tinta)
        {
            this._color = _color;
            this._tinta = _tinta;
        }
     
     private ConsoleColor _color;
     private int _tinta;
     
     

    

     public bool Pintar(int gasto)
     {
             this._tinta -= gasto;

             if (this._tinta < 100)
             {
                 return false;
             }

             else 
             {
                 return true;
             }
     }

     //Incrementa en 20 unidades el nivel de tinta     
     public void Recargar()
     {
         int auxTinta=this._tinta;

         if ((auxTinta + 20) >= 100)
         {
             Console.WriteLine("Error");
         }
         _tinta += 20;
     }

     public void Mostrar()
    {
        Console.WriteLine("Color: " + _color);
        Console.WriteLine("Nivel de tinta: " + _tinta);
    }
        
     public static void MostrarStatic(Boligrafo unBoligrafo)
     {
         unBoligrafo.Mostrar();
        
         //this.Mostrar(); NO SE PUEDE 
     }
        
    }
}
