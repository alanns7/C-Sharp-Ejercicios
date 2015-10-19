using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_18_enums
{
     class Computadora
    {
        
        public enum EMarca
        { 
        Asus, Apple, Samsung, Toshiba, IBM
        }

        public enum EProcesador
        {
            Intel_Core_i7, ADM_Phenom_II, ADM_Athlon_II, Intel_Celeron_430, ADM_Sempron_145
        }
         
    }
       
}  
   
    
    namespace Ejercicio_18_clases
    {
     class Computadora
     {

        private bool _estaEncendida;
        private Ejercicio_18_enums.Computadora.EMarca _marca;
        private float _peso;
        private Ejercicio_18_enums.Computadora.EProcesador _procesador;

        public Computadora(bool estaEncendida, Ejercicio_18_enums.Computadora.EMarca marca, float peso, Ejercicio_18_enums.Computadora.EProcesador procesador)
        {
            this._estaEncendida = estaEncendida;
            this._marca = marca;
            this._peso = peso;
            this._procesador = procesador;
        }
         
        //GET
        
        public bool getEstaEncendida()
        {
            return _estaEncendida;
        }

        public Ejercicio_18_enums.Computadora.EMarca getMarca()
        {
            return _marca;
        }

        public float getPeso()
        {
            return _peso;
        }

        public Ejercicio_18_enums.Computadora.EProcesador getProcesador()
        {
            return _procesador;
        }

       
        
        //SET
        
         
        public void setEstaEncendida(bool encender)
        {
            this._estaEncendida = encender;

        }

        public void setMarca(Ejercicio_18_enums.Computadora.EMarca marca)
        {
            this._marca = marca;
        }

        public void setPeso(float peso)
        {
            this._peso = peso;
        }

        public void setProcesador(Ejercicio_18_enums.Computadora.EProcesador procesador)
        {
            this._procesador = procesador;
        }

        // INFORMES

        public void informarEstado()
        {
            Console.WriteLine("Encendida: " + this._estaEncendida + "\nMarca: " + this._marca + "\nPeso: " + this._peso + "\nProcesador: " + this._procesador);
            
        }

        public void encender()
        {
            this._estaEncendida = true;
        }

        public void apagar ()
        { 
        this._estaEncendida=false;
        }
    }

}
