using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha;

            Console.WriteLine("Ingrese fecha de nacimiento de la manera DD-MM-AAAA");
            fecha = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(fecha);

            
            DateTime fechaActual = DateTime.Now.ToShortDateString();

            DateTime diasVividos = fechaActual - fecha;


            
            

            Console.ReadKey();
        }
    }
}
