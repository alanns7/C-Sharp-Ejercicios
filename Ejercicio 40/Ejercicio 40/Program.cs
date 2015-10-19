using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_40
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 6; 
            Pibe.Alumno alumno1 = new Pibe.Alumno(1, "alumno1");
            Pibe.Alumno alumno2 = new Pibe.Alumno(2, "alumno2");
            Pibe.Alumno alumno3 = new Pibe.Alumno(3, "alumno3");
            Pibe.Alumno alumno4 = new Pibe.Alumno(1, "alumno4");
            Pibe.Alumno alumno5 = new Pibe.Alumno(4, "alumno5");
            Pibe.Alumno alumno6 = new Pibe.Alumno(5, "alumno6");
            Pibe.Alumno alumno7 = new Pibe.Alumno(6, "alumno7");
            Pibe.Alumno alumno8 = valor;
            
            Curs.Curso curso = new Curs.Curso("Curso", new DateTime(2012, 1, 1));
            
            bool retorno;
            retorno = curso + alumno1;
            retorno = curso + alumno2;
            retorno = curso + alumno3;
            retorno = curso + alumno4;
            retorno = curso + alumno5;
            retorno = curso + alumno6;
            retorno = curso + alumno7;
            retorno = curso + alumno8;
            Console.WriteLine(curso.Info());
            Console.WriteLine(alumno1.Info());

            Console.ReadKey();
        }
    }
}
