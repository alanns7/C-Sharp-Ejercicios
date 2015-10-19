using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Ejercicio_18_clases.Computadora Compu1 = new Ejercicio_18_clases.Computadora(true,Ejercicio_18_enums.Computadora.EMarca.Apple,18.3F,Ejercicio_18_enums.Computadora.EProcesador.ADM_Athlon_II);

            Compu1.informarEstado();
            Console.ReadKey();
        }
    }
}
