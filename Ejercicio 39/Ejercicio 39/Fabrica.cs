using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_39
{
    class Fabrica
    {
        private Operario[] _operarios;
        private string _razonSocial;
        private int lugarEnFab=0;


        public Fabrica()
        {
            this._operarios = new Operario[5];
            this._razonSocial = "";
        
        }

        public Fabrica(string razonSocial)
        {
            this._operarios = new Operario[5];
            this._razonSocial = razonSocial;
        }

        public string Mostrar()
        {
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("Razon Social: " + this._razonSocial);

            foreach (Operario ope in this._operarios)
            {
                aux.AppendLine(ope.Mostrar());
            }
            return aux.ToString();
        }


        public static void MostrarCosto(Fabrica fbr)
        {
            Console.WriteLine("Costos Totales: " + fbr.RetornarCostos());
        }


        private string MostrarOperarios()
        {
            string aux="";
            
            foreach (Operario op in this._operarios)
            {
               aux += op.Mostrar(); 
            }

            return aux;
        }


        private int ObtenerIndice()
        { 
            int i;

            for (i = 0; i < this._operarios.Length; i++)
            {
                if (this._operarios[i] == null)
                {
                    return i;
                }
            }

            return -1;
            
        }


        private int ObtenerIndice(Operario op)
        {
           int i; 
            for(i=0;i<this._operarios.Length;i++)
            {
                if (op == this._operarios[i])
                {
                    return i;
                }
            }
            
            return -1;

        }


        public static bool operator ==(Fabrica fbr, Operario op)
        {
            foreach (Operario oper in fbr._operarios)
            {
                if (oper == op)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Fabrica fbr, Operario op)
        {
            if(!(fbr==op))
                {
                    return true;
                }
            
            return false;
        }

        public static Fabrica operator +(Fabrica fbr, Operario op)
        {
            if ((fbr.lugarEnFab < fbr._operarios.Length) && (fbr.ObtenerIndice(op)==-1))
            {
                fbr._operarios[fbr.ObtenerIndice()] = op;
            }

            return fbr;
        }

        public static Fabrica operator -(Fabrica fbr, Operario op)
        {
            if (!(fbr.ObtenerIndice(op) == -1))
            {
                fbr._operarios[fbr.ObtenerIndice(op)] = null;
            }

            return fbr;
        }

        private float RetornarCostos()
        {
            float aux=0;
            int i;

            for (i = 0; i < this._operarios.Length; i++)
            {
                aux+=this._operarios[i].getSalario;
            }
            return aux;
        }


    }
}
