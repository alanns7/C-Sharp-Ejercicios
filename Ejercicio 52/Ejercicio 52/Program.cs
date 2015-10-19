using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_52
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3) En el Main() se creará una Centralita(―Telefónica‖) y cuatro llamadas.La primera llamada será de tipo Local, 
                 con una duración de 30 seg.y un costo de 2.65. La segunda será Provincial(en la franja 1 y con duración de 21 seg.) 
                 y las restantes: Local(45 seg.y 1.99) y Provincial(que recibe la segunda llamada y franja 3).
              4) Las llamadas se irán registrando en la Centralita.Registrar una llamada consiste en agregar a la lista genérica de tipo
                 Llamada una llamada Provincial o una llamada Local.
                 La centralita mostrará por pantalla todas las llamadas según las vaya registrando (método Mostrar). Luego, se ordenarán
                 las llamadas(método OrdenarLlamadas) y se volverá a mostrar por pantalla el contenido de la Centralita.*/


            Centralita central = new Centralita("Telefonica");
            Local llamada1 = new Local(new Llamada("bs as", "cordoba", 0.30f), 2.65f);
            Provincial llamada2 = new Provincial(Franja.franja_1, new Llamada("Rio Negro", "Formosa", 0.21f));
            Local llamada3 = new Local(new Llamada("bs as", "cordoba", 0.45f), 1.99f);
            Provincial llamada4 = new Provincial(Franja.franja_3, new Llamada("Rio Negro", "Formosa", 0.21f));
            central.Llamadas.Add(llamada1);
            central.Llamadas.Add(llamada2);
            central.Llamadas.Add(llamada3);
            central.Llamadas.Add(llamada4);
            central.Mostrar();
            central.OrdenarLLamadas();
            central.Mostrar();
            Console.ReadKey();
            

        }
    }
}
