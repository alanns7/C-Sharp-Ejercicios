using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double cuadrado;
            double trianguloBase, trianguloAltura, triangulo;
            double circulo;

            do
            {
                Console.WriteLine("Ingrese opcion:");
                Console.WriteLine("1. Calculo de area de cuadrado\n2. Calculo de area de triangulo\n3. Calculo de area de circulo\n4.Salir\n");
                op = int.Parse(Console.ReadLine());


            
                switch (op)
                {
            
                    case 1:
                            Console.WriteLine("Ingrese medida en cm de lado del cuadrado");
                            cuadrado = double.Parse(Console.ReadLine());

                            cuadrado= CalculoDeArea.CalcularCuadrado(cuadrado);
                            Console.WriteLine("El area del cuadrado es " + cuadrado + "\n");

                            break;

                    case 2:
                            Console.WriteLine("Ingrese medida en cm de la base del triangulo");
                            trianguloBase = double.Parse(Console.ReadLine());

                            Console.WriteLine("Ingrese medida en cm de la altura del triangulo");
                            trianguloAltura = double.Parse(Console.ReadLine());

                            triangulo = CalculoDeArea.CalcularTriangulo(trianguloBase, trianguloAltura);
                            Console.WriteLine("El area del triangulo es " + triangulo + "\n");

                            break;

                    case 3:
                            Console.WriteLine("Ingrese medida en cm del radio del circulo");
                            circulo = double.Parse(Console.ReadLine());
                          
                            circulo = CalculoDeArea.CalcularCuadrado(circulo);
                            Console.WriteLine("El area del cuadrado es " + circulo + "\n");


                            break; 
            
                  }
              
            }while(op!=4);

            Console.ReadKey();
        }
    }
}
