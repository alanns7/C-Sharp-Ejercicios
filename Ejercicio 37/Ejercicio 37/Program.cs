﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_37
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Usuario uno = new Usuario("Agua", "Rogelio", 111); 
            Usuario dos = new Usuario("Mercurio", "Alfredo", 222); 

            //Instancia de la clase Banco: unBanco("Santander Rio", 13/02/2005) 
            Banco unBanco = new Banco("Santander Rio", new DateTime().AddDays(13).AddMonths(02).AddYears(2005)); 
            
            CuentaCorriente objCC1 = new CuentaCorriente(uno, 789, 1000); 
            CuentaCorriente objCC2 = new CuentaCorriente("Jorge", "Miguel", 333, 798, 5000); 
            CuentaCorriente objCC3 = new CuentaCorriente(uno, 799, 1000); 
            
            CuentaCorriente objCC4 = dos;
            unBanco += objCC1;
            unBanco += objCC2; 
            unBanco += objCC3; 
            Console.WriteLine("***********************************"); 
            Console.WriteLine("Elimino una cuenta del banco "); 
            unBanco -= objCC4; 
            Console.WriteLine("***********************************"); 
            Console.WriteLine("Agrego una Cuenta al banco: "); 
            unBanco += objCC4; 
            Console.WriteLine("***********************************"); 
            Console.WriteLine("Incremento el saldo del cliente Mercurio, Alfredo: "); 
            objCC4.Saldo = 1000; 
            Console.WriteLine("Incremento el saldo del cliente Jorge, Miguel: "); 
            objCC2.Saldo =7000; 
            Console.WriteLine("***********************************"); 
            Console.WriteLine("Elimino una cuenta del banco "); 
            unBanco -= objCC1;
            Console.WriteLine("***********************************"); 
            Console.WriteLine("Muestro los datos del banco: "); 
            unBanco.MostrarBanco(); 
            
            Console.ReadLine();


        }
    }
}
