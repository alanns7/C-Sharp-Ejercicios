using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12
{
    class ValidarRespuesta
    {
     public static bool ValidaS_N()
    {
       char respuesta;
       bool valid;


               do{
                  Console.WriteLine("Desea continuar? S/N");
                  valid = char.TryParse(Console.ReadLine(), out respuesta);
                  respuesta= Char.ToUpper(respuesta);

                  if (((respuesta != 'S') || (respuesta != 'N')) && (!valid))
                  {
                      Console.WriteLine("Error,reingrese");
                  }
                
                 }while(((respuesta != 'S') || (respuesta != 'N')) && (!valid));
                
                if(respuesta == 'S')
                {
                    return true;
                }
   
                else 

                return false;


    }
    }
}
