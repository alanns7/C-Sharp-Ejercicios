using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numero1, numero2;
            int suma=0;

            
                Console.WriteLine("Ingrese numero a sumar");
                numero1 = int.Parse(Console.ReadLine());
                suma=numero1;

                do
                {
                    Console.WriteLine("Ingrese numero siguiente a sumar");
                    numero2 = int.Parse(Console.ReadLine());
                    suma += numero2;
                    

                } while (ValidarRespuesta.ValidaS_N() == true);


                Console.WriteLine("El total de la suma es: " + suma);
                Console.WriteLine("Presione una tecla para continuar");
                Console.ReadKey();
            


        }
    }
}
