using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_52
{
    class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;


        public float duracion
        {
            get {return this._duracion;}
        }

        public string nroDestino
        {
            get { return this._nroDestino;}
        }

        public string nroOrigen
        {
            get { return this._nroOrigen; }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        
        }

        public void Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.Append("Origen: " + this._nroOrigen).AppendLine("Destino: " + this._nroDestino).AppendLine
                ("Duracion: " + this._duracion);
            Console.WriteLine(s);
        }

        public static int OrdenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
        {
            if (llamadaUno._duracion > llamadaDos._duracion)
            { return 1;}

            if (llamadaUno._duracion == llamadaDos._duracion)
            { return 0;}

            if(llamadaUno._duracion < llamadaDos._duracion)
            { return -1; }

            return 0;
        }





    }
}
