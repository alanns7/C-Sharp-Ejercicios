using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_36
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   List<Producto> lista = new List<Producto>();
            Producto produ1 = new Producto();
            Producto produ2 = new Producto();
            
           //agregar productos a la lista
            lista.Sort(Producto.OrdenarPorCodigoAsc);

            foreach (Producto aux in lista)
            {
            //    aux.mostrar();
            }*/

            Producto ProductoUno = new Producto(666,"JamonDelDiablo", eTipoComestible.Solido,2); 
            Producto ProductoDos = new Producto(33, "JamonDeDios", eTipoComestible.Solido,10); 
            Producto ProductoTres = new Producto(55, "Sprite", eTipoComestible.Liquido, 10); 
            Producto ProductoCuatro = new Producto(666, "JamonDelDiablo", eTipoComestible.Solido); 
            Container ContenerdorUno = new Container(2, "Skanka"); 
            Container ContenerdorDos = new Container(3, "Skanka"); 
            List<Producto> listaProducto = new List<Producto>(); 
            ContenerdorUno.Agregar(ProductoUno); 
            ContenerdorUno.Agregar(ProductoDos); 
            
            if(! ContenerdorUno.Agregar(ProductoTres)) 
            { 
                Console.WriteLine("No se pudo"); 
            } ContenerdorDos.Agregar(ProductoUno); 
            
            ContenerdorDos.Agregar(ProductoDos); 
            
            if (!ContenerdorDos.Agregar(ProductoCuatro)) 
            { 
                Console.WriteLine("No se pudo"); 
            } 
            
            ContenerdorDos.Agregar(ProductoTres);

            Container.Mostrar(ContenerdorUno); 
            Container.Mostrar(ContenerdorDos); 
            listaProducto = ContenerdorDos - eTipoComestible.Liquido; 
            Console.WriteLine(" Lista Extraida "); 
            
            foreach (Producto item in listaProducto) 
            { 
                item.mostrar(); 
            } 
            
            Console.ReadLine();

            
            
        }
    }
}
