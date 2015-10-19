using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum Franja
{
franja_1, franja_2, franja_3
}



namespace Ejercicio_52
{
    
    class Provincial: Llamada
    {
        protected Franja _franjaHoraria;


        private float CalcularCosto()
        {
            switch (this._franjaHoraria)
            {
                case Franja.franja_1:
                    {
                        return (base._duracion * (float)0.99);
                    }

                case Franja.franja_2:
                    {
                        return (base._duracion * (float)1.25);
                    }

                case Franja.franja_3:
                    {
                        return (base._duracion * (float)0.66);
                    }
            }

            return 0;
            
        }

        
        public void Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendLine("Origen: " + base._nroOrigen).AppendLine("Destino: " + base._nroDestino).AppendLine
                ("Duracion: " + base._duracion).AppendLine("Costo: " + this.CalcularCosto()).AppendLine
                ("Franja Horaria: " + this._franjaHoraria);
            Console.WriteLine(aux);
            
        }


        public Provincial(Franja miFranja, Llamada unaLlamada):base(unaLlamada.nroOrigen,unaLlamada.nroDestino,
        unaLlamada.duracion)
        {
            this._franjaHoraria = miFranja;
        }


        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(origen,destino,duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        
        }

    }
}
