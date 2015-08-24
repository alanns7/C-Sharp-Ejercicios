using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_8
{
    class Program
    {
      

        static void Main(string[] args)
        {
            char respuesta;
            Empleado[] emp = new Empleado[100];
            int i=0;
            int size = 0;
            
            
            

            do
            {
                  Console.WriteLine("Ingrese valor por hora de empleado");
                  emp[i].valorHora = int.Parse(Console.ReadLine());

                  Console.WriteLine("Ingrese nombre de empleado");
                  emp[i].nombreEmpleado = (Console.ReadLine());

                  Console.WriteLine("Ingrese antiguedad en años");
                  emp[i].antiguedad = int.Parse(Console.ReadLine());

                  Console.WriteLine("Ingrese cantidad de horas trabajadas en el mes");
                  emp[i].horasEnMes = int.Parse(Console.ReadLine());

                  emp[i].total_bruto = emp[i].valorHora * emp[i].horasEnMes;
                  emp[i].subtotal = emp[i].total_bruto + (emp[i].antiguedad * 150);
                  emp[i].descuentos = (int)(emp[i].total * 0.13);
                  emp[i].total = emp[i].subtotal - emp[i].descuentos;
                  

                  Console.WriteLine("Desea ingresar nuevo empleado?");
                  respuesta = char.Parse(Console.ReadLine());
                  
                  i++;
                  size ++;

            } while (respuesta == 's');


            for (i = 0; i < size; i++)
            {

                Console.WriteLine("Nombre de empleado: " + emp[i].nombreEmpleado);
                Console.WriteLine("Antiguedad en años: " + emp[i].antiguedad);
                Console.WriteLine("Valor por hora de empleado: " + emp[i].valorHora);
                Console.WriteLine("Total a cobrar en bruto: " + emp[i].total_bruto);
                Console.WriteLine("Total de descuentos: " + emp[i].descuentos);
                Console.WriteLine("Valor neto: " + emp[i].total);
                
            }

            Console.ReadKey();
        }
    }
}
