using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_37
{
    class Banco
    {
        DateTime _fechaInicio;
        List<CuentaCorriente> _listaCuentasCorrientes;
        string _razonSocial;


        public Banco(string razonSocial, DateTime fechaInicio)
        {
            this._razonSocial = razonSocial;
            string.Format("{0: dd/mm/yyyy}", _fechaInicio);
            this._fechaInicio = fechaInicio;
            this._listaCuentasCorrientes = new List<CuentaCorriente>();
        }


        public void MostrarBanco()
        {
            int count = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\nRazon Social: " + this._razonSocial + "\nFecha Inicio de Actividades: " + this._fechaInicio);
            Console.WriteLine(sb);

            Console.WriteLine("Lista de usuarios: \n");
            foreach (CuentaCorriente cuenta in _listaCuentasCorrientes)
            {
                
                Console.WriteLine(Usuario.Mostrar(this._listaCuentasCorrientes[count].Dueño()));
                Console.WriteLine("Saldo: " + cuenta.Saldo + "\n");
                count++;
            }
           
        }


        //SOBRECARGA DE OPERADORES


        public static Banco operator -(Banco unBanco, CuentaCorriente unaCuenta)
        {
            int count = 0;

            foreach (CuentaCorriente cuenta in unBanco._listaCuentasCorrientes)
            {
                count++;

                if (unaCuenta == cuenta)
                {
                    unBanco._listaCuentasCorrientes.RemoveAt(count);
                    Console.WriteLine("Se ha eliminado una cuenta corriente");
                    return unBanco;
                }
               
                    
                
            }
            Console.WriteLine("No existe actualmente esta cuenta");
            return unBanco;
        }


        public static Banco operator +(Banco unBanco, CuentaCorriente unaCuenta)
        {
            

            foreach (CuentaCorriente cuenta in unBanco._listaCuentasCorrientes)
            {

                if (unaCuenta == cuenta)
                {
                    Console.WriteLine("Ya existe una cuenta corriente para el usuario");
                    return unBanco;
                }

            }
            
            Console.WriteLine("Se ha agregado una cuenta corriente");
            unBanco._listaCuentasCorrientes.Add(unaCuenta); 
            return unBanco;
        }



    }
}
