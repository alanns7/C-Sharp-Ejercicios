using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Conversion;


namespace Ejercicio_21
{
    class Program
    {

        static void Main(string[] args)
        {
        //Parte del Euro
            Euro euro1 = new Euro(2);
            euro1--;
            Euro euro2 = new Euro(4);
            euro2++;
            Euro euro3 = euro1 + euro2;
            Euro euro = (Euro)5d;
            Console.WriteLine("suma de euro {0}",euro3.Mostrar());
            Euro euro4 = euro1 - euro2;
            Console.WriteLine("resta de euro {0}\n\n\n", euro4.Mostrar());
            
        
        
            //Parte del Dolar

            Dolar dolar2 = new Dolar(1);
            Dolar dolar1=(Dolar)5d;

            dolar1--;
            dolar2++;
            Dolar dolar3 = dolar1 + dolar2;
            Console.WriteLine("suma de dolar {0}",dolar3);
            dolar3 = dolar1 - dolar2;
            Console.WriteLine("resta de dolar {0}",dolar3);
            


            //Parte del Euro y Dolar

            Euro nEuro = new Euro(4);
            Dolar nDolar = new Dolar(3);
            Euro EuDo = nEuro +nDolar;
            Console.WriteLine("la suma de dolar y euro {0}", EuDo.Mostrar());
            EuDo = nEuro - nDolar;
            Console.WriteLine("la resta de dolar y euro {0}", EuDo.Mostrar());

            //Parte del Dolar y Euro
            Dolar Eudo = nDolar+nEuro;
            Console.WriteLine("la suma de dolar y euro {0}",Eudo.GetDolar());
            Eudo = nDolar - nEuro;
            Console.WriteLine("la suma de dolar y euro {0}", Eudo.GetDolar());
            Dolar aux = (Dolar)nEuro;
            Console.ReadKey();
        }
    }
}
