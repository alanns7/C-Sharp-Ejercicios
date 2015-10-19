using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_22
{
    class Celsius
    {
        private double celsius;
            private const double valor;

            public Celsius(double kelvin)
            {
                this.celsius = kelvin;
            }

            public Celsius()
            {
                this.celsius = 0d;
            }

            public double GetKelvin()
            {
                return celsius;
            }

    }
}
