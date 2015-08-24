using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_11
{
    class Validacion
    {
        public static bool validar(int rangoMinimo, int rangoMaximo, int numero)
        {
            if (numero > rangoMinimo && numero < rangoMaximo)
            {
                return true;
            }


            return false;
            
        
        }




    }
}
