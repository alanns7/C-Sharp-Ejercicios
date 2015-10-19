using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Conversion
{
    
    class Dolar 
    {
        private double dolar;
        private const double valor = 1.3642;
        
        public Dolar (double dolar)
        {
           this.dolar = dolar;
        }

        public Dolar()
        {
            this.dolar = 0d;
        }

        public double GetDolar()
        {
            return dolar;
        }



        
        public static explicit operator Dolar(Euro e)
        {
            Dolar aux = new Dolar(e.Mostrar() * valor);
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
            aux.dolar  = (dolar1.dolar + (euro1.Mostrar() * valor));
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
            return (dolar1.dolar == dolar2.dolar );
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


    
    class Euro
        {
         private double euro;
         private const double valor = 1.3642;

         public double Mostrar()
         {
             return euro;
         }
        
         public Euro(double euro)
         {
           this.euro = euro;
         }


          public static explicit operator double(Euro e)
          {
              Euro aux = new Euro(e.euro);
              return aux.euro;
          }

          public static implicit operator Euro(Dolar d)
          {
              Euro euro = new Euro(d.GetDolar() / valor);
              return euro;
          }


          public static implicit operator Euro(double num)
          {
              Euro aux = new Euro(num);
              return aux;
          
          }


          public static Euro operator +(Euro e1, Dolar d2)
          {
              Euro aux = new Euro(0);
              aux = e1.euro + (d2.GetDolar() / valor);
              return aux;

          }

          public static Euro operator +(Euro e1, Euro e2)
          {
              Euro aux = new Euro(0);
              aux = e1.euro + e2.euro;
              return aux;

          }


          public static Euro operator -(Euro e1, Dolar d2)
          {
              Euro aux = new Euro(0);
              aux = e1.euro - (d2.GetDolar() / valor);
              return aux;

          }

          public static Euro operator -(Euro e1, Euro e2)
          {
              Euro aux = new Euro(0);
              aux = e1.euro - e2.euro;
              return aux;

          }


          public static Euro operator ++(Euro e1)
          {
              e1.euro++;
              return e1;

          }

          public static Euro operator --(Euro e1)
          {
              e1.euro--;
              return e1;

          }



          public static bool operator ==(Euro e1, Euro e2)
          {
              return (e1.euro == e2.euro);
          }


          public static bool operator ==(Euro e1, Dolar d2)
          {
              return (e1.euro == (d2.GetDolar() / valor));

          }


          public static bool operator !=(Euro e1, Euro e2)
          {
              return (e1.euro != e2.euro);
          }


          public static bool operator !=(Euro e1, Dolar d2)
          {
              return (e1.euro != (d2.GetDolar() / valor));

          }


        }



    }

