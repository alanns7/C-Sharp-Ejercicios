using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase_2
{
    class Alumno
    {
    
            public int legajo;
            public string apellido;
            public string nombre;
            private byte _nota1;
            private byte _nota2;
            private float _notaFinal; 

        
        /// <summary>
        /// l método CalcularFinal deberá colocar la nota del final sólo si 
        /// las notas 1 y 2 son mayores o iguales a 4, caso contrario la 
        /// inicializará con -1. Para darle un valor a la nota final utilice 
        /// el método de instancia Next de la clase Random.
        /// </summary>
        
        
        private void CalcularFinal()
        {
            if (this._nota1 >= 4 && this._nota2 >= 4)
            {
                this._notaFinal = 10;
            }
            else 
            {
                this._notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this._nota1 = notaUno;
            this._nota2 = notaDos;
        
        }

        /// <summary>
        /// el método Mostrar, expondrá en la consola todos los 
        ///datos de los alumnos, a excepción de la nota final. Este valor se 
        ///mostrará sólo si es distinto de -1.
        /// </summary>
        /// <param name="?"></param>
        public void Mostrar()
        {
         Console.WriteLine("Apellido: " + this.apellido);
         Console.WriteLine("Nombre: " + this.nombre);
         Console.WriteLine("Legajo: " + this.legajo);
         Console.WriteLine("Nota 1: " + this._nota1);
         Console.WriteLine("Nota 2: " + this._nota2);

         if (_notaFinal != -1)
         {
             Console.WriteLine("Nota Final: " +_notaFinal);
         }

        }

    }

        
}
