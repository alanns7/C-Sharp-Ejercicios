using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_36
{
    class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos;
        

        public Container(int capacidad, string empresa)
        {
            this._capacidad = 0;
            this._empresa = empresa;
            this._listaProductos = new List<Producto>();
        }

        public void Mostrar(Container contenedor)
        {
           
            StringBuilder aux = new StringBuilder();
            aux.AppendFormat("Capacidad: " + _capacidad).AppendLine();
            aux.AppendFormat("Empresa: " + _empresa).AppendLine();
            Console.WriteLine(aux);

            foreach (Producto produ in contenedor._listaProductos)
            {
                produ.mostrar();
            }
            
        }


        public bool Agregar(Producto produUno)//punto 7 terminar
        {
            this._capacidad++;
            if(this._capacidad > this._listaProductos.Count && (!(this == produUno)))
            {
            
            this._listaProductos.Add(produUno);
            

            return true;
            }
            return false;
        }

        public static void Mostrar(Container contenedor)
        { 
              
            Console.WriteLine("Capacidad: " + contenedor._capacidad);
            Console.WriteLine("Empresa: " + contenedor._empresa);

            foreach (Producto producto in contenedor._listaProductos)
            {
                Console.WriteLine("Productos: " + producto);
            }

        }

        
        
        public static bool operator ==(Container contenedor, Producto produ)
        {
            foreach (Producto produc in contenedor._listaProductos)//recorre los productos de la lista.
            {
                if (produ.GetCodigo() == produc.GetCodigo())
                {
                    return true;
                }
            }
            return false;
        }

        
        public static List<Producto> operator -(Container contenedorUno, eTipoComestible tipo)
        {
            List<Producto> listaAux = new List<Producto>();

            foreach (Producto produ in contenedorUno._listaProductos)
            {
                if (produ == tipo)
                {
                    listaAux.Add(produ);
                    return listaAux;
                }
            
            }
            return listaAux;
        }








    }
}
