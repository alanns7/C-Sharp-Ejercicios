using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ejercicio17
{
    
    class Cuenta
    {
        private string _nombre;
        private long _nroCuenta;
        private double _saldo;
        private ETipoInteres _tipoInteres;
        

        public Cuenta()
        {
            Console.WriteLine("Cuenta Origen");
        }
        
        public Cuenta(string nombre, long nroCuenta, double saldo, ETipoInteres tipoInteres)
        {
            this._nombre = nombre;
            this._nroCuenta = nroCuenta;
            this._saldo = saldo;
            this._tipoInteres = tipoInteres;
        }


        public enum ETipoInteres
        {
            TIN,
            TAE,
            RIR
        }

        


        public string getNombre()
        {
            //Console.WriteLine("Ingrese nombre: ");
            //this._nombre = Console.ReadLine();
            return this._nombre;
        }

        public long getNroCuenta()
        {
            //Console.WriteLine("Ingrese numero de cuenta: ");
            //this._nroCuenta = long.Parse(Console.ReadLine());
            return this._nroCuenta;
        }

        public double getSaldo()
        {
           // Console.WriteLine("Ingrese saldo: ");
            //this._saldo = double.Parse(Console.ReadLine());
            return this._nroCuenta;
        }

        public ETipoInteres getTipoInteres()
        {
            /*Console.WriteLine("Ingrese tipo de interes: 1. TIN / TAE / RIR: ");//ver
            string tipo = Console.ReadLine();

            switch(tipo)
            {
                case "TIN":
                    
                        return ETipoInteres.TIN;
                        

                case "TAE":

                        return ETipoInteres.TAE;
                        

                case "RIR":

                        return ETipoInteres.RIR;

            }*/
            return _tipoInteres;                     
        }

        
        
        public void setNombre(string nombre)
        {
            if (nombre != null)
            {
                this._nombre = nombre;
            }
        
            else 
                Console.WriteLine("No se indico nombre");
        }

        public void setNroCuenta(long nroCuenta)
        {
            if (nroCuenta > -1)
            {
                this._nroCuenta = nroCuenta;
            }

            else
                Console.WriteLine("No se indico cuenta");
        }



        public void setSaldo(long saldo)
        {
            if (saldo >= 0)
            {
                this._saldo = saldo;
            }

            else
                Console.WriteLine("No se indico saldo");
        }

        public void setTipoInteres(ETipoInteres tipoInteres)
        {
            if ((this._tipoInteres != ETipoInteres.RIR) && (this._tipoInteres != ETipoInteres.TAE) && (this._tipoInteres != ETipoInteres.TIN))
            {
                
                Console.WriteLine("No se indico saldo");
            }

            else
                this._tipoInteres = tipoInteres; 
        }








    }
}
