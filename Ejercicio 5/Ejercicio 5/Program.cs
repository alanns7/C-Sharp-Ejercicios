using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_5       //NO FUNCIONA
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int sumaIzq=0;
            int sumaDer = 0;
            int i, j, k;
            int aux = 0;


            Console.WriteLine("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

             Console.WriteLine("Los centros numericos que existen hasta su numero son: ");

             for (i = 1; i < numero; i++)
             {

                 for (j = 1; j < numero - 1; j++)
                 {
                     sumaIzq += j;  //se crea la suma izquierda
                 }

                 
                 for (k = numero; k < numero + 10; k++)
                 {


                     if (k != numero && sumaDer < sumaIzq && aux < sumaIzq )
                         {
                             sumaDer += k; //se crea la suma derecha
                         }
                        
                     aux = sumaDer + k + k + 1;
                     
                 }


                 if (sumaIzq == sumaDer)
                 {
                     Console.WriteLine(i); //muestra el centro numerico
                 }

             }


             Console.ReadKey();

        }
    }
}
