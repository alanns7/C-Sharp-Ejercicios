using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
               //genero un boligrafo
              Boligrafo colorAzul = new Boligrafo(ConsoleColor.Blue,100);
              Boligrafo colorRojo = new Boligrafo(ConsoleColor.Red,50);
              Boligrafo unBoligrafo = new Boligrafo(ConsoleColor.Cyan , 30);// unBoligrafo es una referencia de un objeto

              
              colorRojo.Recargar();
              //colorRojo.Recargar();

              Boligrafo.MostrarStatic(unBoligrafo);
            

              Console.ReadKey();


        }
    }
}
