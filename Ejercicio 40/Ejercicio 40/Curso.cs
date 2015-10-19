using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Curs
{
    class Curso
    {
        private string _descripcion; 
        private Pibe.Alumno[] _alumnos; 
        private DateTime _fechaComienzo;



        public string Info()
        {
            return ("Descripción: " + this._descripcion + " Alumno: " + this._alumnos + " Fecha de Comienzo: " + this._fechaComienzo);
        }
        
        
        //5
        public Curso() 
        {
            this._alumnos = new Pibe.Alumno[5];
        }


        public Curso(string descrip, DateTime fecha):this()
        {
            this._descripcion = descrip;
            this._fechaComienzo = fecha;
        }


        //6
        public int HayLugar()
        {
            int i;

            for(i=0;i<this._alumnos.Length;i++)
            {
                if (this._alumnos.GetValue(i) == null)
                {
                    return i;
                }
            }
            return -1;
        }

        //7
        public bool ExisteAlumno(Pibe.Alumno alu)
        {
            foreach (Pibe.Alumno aluUno in this._alumnos)
            {
                if (alu == aluUno)
                {
                    return true;
                }
            }
            return false;
        }

        //8
        public static bool operator +(Curso cursoUno, Pibe.Alumno aluUno)
        {
            

                if ((cursoUno.HayLugar() != -1) && (cursoUno.ExisteAlumno(aluUno) == false))
                {
                    cursoUno._alumnos[cursoUno.HayLugar()] = aluUno;
                    return true;
                }
            
            return false;
        
        }




    }
    
}
