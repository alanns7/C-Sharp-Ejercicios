using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio17
{
    class Program
    {

        
        
        static void Main(string[] args)
        {
            string nombre; 
            long nroCuenta;
            double saldo; 
            //Cuenta.ETipoInteres tipoInteres;
            // string tipo;
            Cuenta.ETipoInteres tipoInteres;

            //Cuenta cuentaOrigen = new Cuenta();
            Cuenta cuentaUno = new Cuenta("Alan", 182, 1500, Cuenta.ETipoInteres.RIR);


            Console.WriteLine(cuentaUno.getNombre());
            cuentaUno.setNombre("Daniel");
            Console.WriteLine(cuentaUno.getNombre());
            
            
            /*nombre = Console.ReadLine();
            
            

            Console.WriteLine("Ingrese numero de cuenta: ");
            nroCuenta = long.Parse(Console.ReadLine());
            cuentaUno.getNroCuenta();

            Console.WriteLine("Ingrese saldo: ");
            saldo = double.Parse(Console.ReadLine());
            cuentaUno.getSaldo();

            Console.WriteLine("Ingrese tipo de interes: 1. TIN / TAE / RIR: ");
            tipoInteres = Console.ReadLine();
            cuentaUno.getTipoInteres();

            switch(tipo)
            {
                case "TIN":
                    
                         tipoInteres = Cuenta.ETipoInteres.TIN;
                        

                case "TAE":

                         tipoInteres = Cuenta.ETipoInteres.TAE;
                        

                case "RIR":

                         tipoInteres = Cuenta.ETipoInteres.RIR;

            }*/


            


            Console.ReadKey();
           
        }
    }
}
