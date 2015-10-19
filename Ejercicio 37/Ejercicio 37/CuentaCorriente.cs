using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_37
{
    class CuentaCorriente
    {
        private Usuario _dueño;
        private int _numeroCuenta;
        private double _saldo;

        public Usuario Dueño()
        { 
        return this._dueño;
        }

       /* public Usuario Dueño
        {
            get { return _dueño; }

        }*/
        
       /* public double Saldo()
        {
            return this._saldo;
        }

        public void Saldo(double saldo)
        {
            this._saldo = this._saldo + saldo;     //es igual a hacer el metodo siguiente:
        }*/

        public double Saldo
        {
            get
            {
                return this._saldo;
            }

            set
            {
                this._saldo += value;
            }

        }

        public CuentaCorriente(string apellido, string nombre, double dni, int numero, double saldo)
        {
            _dueño = new Usuario(apellido, nombre, dni);
            this._numeroCuenta=numero;
            this._saldo=saldo;
            
        }

        public CuentaCorriente(Usuario miDueño, int numero, double saldo)
        {
                this._dueño = miDueño; 
                this._numeroCuenta = numero;
                this._saldo = saldo;
            
            
        }
        

        //SOBRECARGA DE OPERADORES


       
        
        public static bool operator ==(CuentaCorriente CC1, CuentaCorriente CC2)
        {
            if (CC1._dueño.Dni() == CC2._dueño.Dni())
            {
                return true;
            }
            return false;
        
        }

        public static bool operator !=(CuentaCorriente CC1, CuentaCorriente CC2)
        {
            return (!(CC1 == CC2));
        
        }


        public static explicit operator double(CuentaCorriente CC)
        {
            return CC._saldo;
        }

        public static implicit operator CuentaCorriente(Usuario miUsuario)
        {
            CuentaCorriente cuenta = new CuentaCorriente(miUsuario, 0, 0);
            return cuenta;
            
        }



    }
}
