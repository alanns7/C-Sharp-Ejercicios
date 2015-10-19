using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_39
{
    class Operario
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _salario;

        
        public float getSalario
        {
            get
            {
                return _salario;
            }
        }

        public string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat(ObtenerNombreYApellido()).AppendLine
                ("Legajo: " + this._legajo).AppendLine("Salario: " + this._salario + "\n");
           
            return aux.ToString();

        }

        public static string Mostrar(Operario op)
        {
            string aux = op.Mostrar();
            return aux;
        }



        public string ObtenerNombreYApellido()
        {
            string aux;
            aux = ("Nombre: " + this._nombre + ", Apellido: " + this._apellido);
            return aux;
        }

        public Operario()
        {
            this._apellido = "";
            this._legajo = -1;
            this._nombre = "";
            this._salario = 1500;
            
        }

        public Operario(string nombre, string apellido)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._salario = 1500;
            this._legajo = -1;
        }

        public Operario(string nombre, string apellido, int legajo):this(nombre, apellido)
        {
            this._legajo = legajo;
            this._salario = 1500;
        }


        public static bool operator ==(Operario op1, Operario op2)
        {
           //op1=new Operario();
            //op2=new Operario();
            //if((op1._nombre == op2._nombre) && (op1._apellido == op2._apellido) && (op1._legajo==op2._legajo))
            if (op1.Mostrar() == op2.Mostrar())
            {
                return true;
            }
            return false;
        
        }


        public static bool operator !=(Operario op1, Operario op2)
        {
            return (!(op1 == op2));
        }

        
        
        
        //Porcentaje del aumento pasado como parámetro.
        public void setAumentarSalario(float aumento)
        { 
         this._salario = this._salario + (this._salario / aumento);
        }




    }
}
