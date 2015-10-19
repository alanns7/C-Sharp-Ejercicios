using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Ejercicio_52
{
    class Local: Llamada
    {
        protected float _costo;


        public Local(Llamada unaLlamada, float costo):base(unaLlamada.nroOrigen, unaLlamada.nroDestino, unaLlamada.duracion)
        {
            this._costo = costo;

        }


        public Local(string origen, float duracion, string destino, float costo):base(origen,destino,duracion)
        {
            this._costo = costo;
        }

        private float CalcularCosto()
        {
            return (base._duracion * this._costo);
        }



        public void Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine("Origen: " + base._nroOrigen).AppendLine("Destino: " + base._nroDestino).AppendLine
                ("Duracion: " + base._duracion).AppendLine("Costo: " + this._costo);
            Console.WriteLine(aux);
        }

        public float CostoLLamada 
        {
            get { return CalcularCosto(); }
        }





    }
}
