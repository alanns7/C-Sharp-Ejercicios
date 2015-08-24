using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_13
{
    class Conversor
    {

       public string decimalBinario(double numDecimal)
        {
            

            string numeroD= Convert.ToString(numDecimal);
            int digitos= numeroD.Length;
            

            for (int i = 0; i < digitos;i++)
            {
                string n = "";
                int aux;
                while (numDecimal > 0)
                {
                    aux = (int)numDecimal % 2;
                    numDecimal /= 2;
                    //Console.WriteLine(aux);
                    n = aux + n;
                }


            }
        
        }


    }
}
