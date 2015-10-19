using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pibe
{
    class Alumno
    {

        private string _apellido;
        private string _nombre;
        private string _dni;
        private int _legajo;

       //2
        public string Info() 
        { 
            return "Legajo: "+ _legajo + ", Apellido: " + _apellido + ", Nombre: " + _nombre + ", DNI: " + _dni; 
        } 
        
        //3
        public Alumno(int legajo, string apellido) 
        { 
            this._legajo = legajo; 
            this._apellido = apellido;
            this._dni="";
            this._nombre="";
        }

        public Alumno(string apellido, string nombre)
        {
            this._apellido = apellido;
            this._nombre = nombre;
            this._dni = "";
            this._legajo = -1;
        }
    
        
        public Alumno(string apellido, string nombre, string dni, int legajo):this(legajo, apellido)
        {
            this._nombre = nombre;
            this._dni = dni;
        }


        public static bool operator ==(Alumno alu1, Alumno alu2)
        {
            if (((object)alu1 != null) && ((object)alu2 != null))
            {
                if (alu1._legajo == alu2._legajo)
                {
                    return true;
                }
                return false;
            } return false;
        }

        public static bool operator !=(Alumno alu1, Alumno alu2)
        {
            return (!(alu1 == alu2));
        }


        public static implicit operator Alumno(int valor)
        {
            Alumno alu;
            alu = new Alumno(valor, "");
            alu._legajo = valor;
            return alu;
        
        }



    }
}
