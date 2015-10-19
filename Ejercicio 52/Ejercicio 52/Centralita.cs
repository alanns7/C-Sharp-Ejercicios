using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public enum TipoLlamada
{
    Local, Provincial, Todas
}


namespace Ejercicio_52
{
    class Centralita
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;


        public float GananciaPorLocal
        {
            get { return this.CalcularGanacia(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return CalcularGanacia(TipoLlamada.Provincial); }
        }

        public float GananciaTotal
        {
            get { return CalcularGanacia(TipoLlamada.Todas); }
        }


        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }


        public Centralita()
        {
            this._listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this._razonSocial = nombreEmpresa;
        }

        private float CalcularGanacia(TipoLlamada tipo)
        {
            float contLocal = 0;
            float contProvincial = 0;
            foreach (Llamada item in this._listaDeLlamadas)
            {
                if (item is Local)
                {

                    contLocal += ((Local)item).CostoLLamada;
                }

                if (item is Provincial)
                {
                    contProvincial += ((Provincial)item).CostoLlamada;
                }


            }
            switch (tipo)
            {
                case TipoLlamada.Local:
                    return contLocal;

                case TipoLlamada.Provincial:
                    return contProvincial;


                case TipoLlamada.Todas:
                    return contProvincial + contLocal;

            }
            return 0f;


        }
        public void OrdenarLLamadas()
        {
            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

        }


        //Mostrar(Mostrará la razón social, la ganancia total, ganancia por llamados locales y provinciales y
        //el detalle de las llamadas realizadas).
        public void Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("Razon social:{0}\n", this._razonSocial)
                .AppendFormat("Ganancia Total:{0}\n", GananciaTotal).AppendFormat("Ganancia Locales:{0}\n", GananciaPorLocal)
                .AppendFormat("Ganancia Provincia:{0}\n", GananciaPorProvincial);
            Console.WriteLine(mostrar);
            foreach (Llamada item in this._listaDeLlamadas)
            {
                if (item is Provincial)
                {
                    ((Provincial)item).Mostrar();
                }
                if (item is Local)
                {
                    ((Local)item).Mostrar();
                }
            }

        }
    }
}
