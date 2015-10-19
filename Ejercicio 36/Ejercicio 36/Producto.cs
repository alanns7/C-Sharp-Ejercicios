using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_36
{
    enum eTipoComestible {Solido, Liquido}
    
    class Producto
    {
       
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible _tipo;

        public Producto()
        {
            this._codigoDeBarra = 0;
            this._nombre = "";
            this._precio = 0;
        }

        private Producto(int codigoDeBarra)
        {
            this._codigoDeBarra = codigoDeBarra;
        }

        public Producto(int codigoBarra, string nombre, eTipoComestible tipo): this(codigoBarra)
        {
            this._nombre = nombre;
            this._tipo = tipo;
        }
        
        
        
        public Producto(int codigoBarra, string nombre, eTipoComestible tipo, double precio):this(codigoBarra,nombre,tipo)
        {
            this._precio = precio;
        }

        

        public int GetCodigo()
        {
            return _codigoDeBarra;
        }
        

        public void mostrar()
        {
            Console.WriteLine("Codigo de barra: " + this._codigoDeBarra);
            Console.WriteLine("Nombre: " + this._nombre);
            Console.WriteLine("Precio: " + this._precio);
            Console.WriteLine("Tipo: " + this._tipo);
        }



        public static bool operator ==(Producto proUno, eTipoComestible tipo)
        {
            if (proUno._tipo == tipo)
            {
                return true;
            }
            return false;
        }


        public static bool operator ==(Producto proUno, Producto proDos)
        {
            if (proUno._codigoDeBarra==proDos._codigoDeBarra)
            {
                return true;
            }
            return false;
        }


       

        
        public static int OrdenarPorCodigoAsc(Producto prod1, Producto prod2)
        {
            return (prod1._codigoDeBarra.CompareTo(prod2._codigoDeBarra));
            //compara y devuelve <0, ==0, >0
        }

        


       /* public static int OrdenarPorCodigoDesc(Producto prod1, Producto prod2)
        {
           
          
        }*/
    }
}
