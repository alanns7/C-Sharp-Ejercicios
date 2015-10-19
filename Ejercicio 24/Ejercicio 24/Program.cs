using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int[] B = new int[10];
            int i;

            Random r = new Random();

            for (i = 0; i < A.Length; i++)
            {
                A[i] = r.Next(1, 10);
                B[i] = r.Next(1, 10);
            }

            Console.Write("Vector A: ");
            for (i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + ", ");
            }

            Console.Write("\nVector B: " );
            for (i = 0; i < A.Length; i++)
            {
                Console.Write(B[i] + ", ");
            }
            


            int[] C = new int[10];


            C[0] = A.Min();
            C[1] = B.Min();
          Console.WriteLine("\nVector C: {0}, {1}",C[0],C[1]);


          Console.Write("Vector A en forma asc: ");

          Array.Sort(A);

          foreach (int asc in A)
          {
              Console.Write(asc + " ");
          }
          Console.WriteLine("");
          Console.Write("Vector A en forma desc : ");

          Array.Reverse(A);
            
          foreach (int desc in A)
          {
              Console.Write(desc + " ");
          }



          Console.ReadKey();




            
        }
    }
}
