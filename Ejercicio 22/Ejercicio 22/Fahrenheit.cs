using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_22
{
    class Fahrenheit
    {

        private double fahren;
            private const double valor;

            public Fahrenheit (double fahren)
            {
                this.fahren=fahren;
                    
            }

            public Fahrenheit()
            {
                this.fahren = 0d;
            }

            public double GetFahren()
            {
                return fahren;
            }
    }
}
