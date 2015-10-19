using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_22
{
    class Kelvin
    {
            private double kelvin;
            private const double valor;

            public Kelvin(double kelvin)
            {
                this.kelvin = kelvin;
            }

            public Kelvin()
            {
                this.kelvin = 0d;
            }

            public double GetKelvin()
            {
                return kelvin;
            }




            public static explicit operator Kelvin(Fahrenheit f)
            {
                Kelvin aux = (f.GetFahren * 459.67) * 5/9;
                    return aux;

            }

            public static explicit operator Dolar(double dolar)
            {
                Dolar aux = new Dolar(dolar);
                return aux;
            }




            public static Dolar operator +(Dolar d1, Dolar d2)
            {
                Dolar aux = new Dolar();
                aux.dolar = d1.dolar + d2.dolar;
                return aux;

            }
            public static Dolar operator +(Dolar dolar1, Euro euro1)
            {
                Dolar aux = new Dolar();
                aux.dolar = (dolar1.dolar + (euro1.Mostrar() * valor));
                return aux;

            }




            public static Dolar operator -(Dolar d1, Dolar d2)
            {
                Dolar aux = new Dolar();
                aux.dolar = d1.dolar - d2.dolar;
                return aux;
            }
            public static Dolar operator -(Dolar dolar1, Euro euro1)
            {
                Dolar aux = new Dolar();
                aux.dolar = dolar1.dolar + (euro1.Mostrar() * valor);
                return aux;
            }




            public static Dolar operator ++(Dolar dolar1)
            {
                dolar1.dolar++;
                return dolar1;

            }

            public static Dolar operator --(Dolar dolar1)
            {
                dolar1.dolar--;
                return dolar1;

            }



            public static bool operator ==(Dolar dolar1, Dolar dolar2)
            {
                return (dolar1.dolar == dolar2.dolar);
            }


            public static bool operator ==(Dolar dolar1, Euro euro1)
            {
                return (dolar1.dolar == euro1.Mostrar() * valor);

            }


            public static bool operator !=(Dolar dolar1, Dolar dolar2)
            {
                return (dolar1.dolar != dolar2.dolar);
            }


            public static bool operator !=(Dolar dolar1, Euro euro1)
            {
                return (dolar1.dolar != euro1.Mostrar() * valor);

            }


        }

    
}
