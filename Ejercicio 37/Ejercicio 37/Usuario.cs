using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_37
{
    class Usuario
    {
        private string _apellido;
        private double _dni;
        private string _nombre;


        public double Dni()
        {
            return this._dni;
        }

        private string DevolverDatosFormatoString()
        {
            string aux=("Dni: " + (Convert.ToString(this._dni)));
            aux+=("\nNombre: " + this._nombre + "\nApellido: " + this._apellido);
            return aux;
        }

        public static string Mostrar(Usuario usuarioActual)
        {
            string aux;
            aux=usuarioActual.DevolverDatosFormatoString();
            return aux;
        }
        
        
        public Usuario(string apellido, string nombre, double dni)
        {
            this._apellido = apellido;
            this._dni = dni;
            this._nombre = nombre;
        
        }




    }
}
