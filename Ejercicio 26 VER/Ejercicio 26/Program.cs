using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> vector = new List<int>();
            int i;
            int contPos = 0;
            int contNeg = 0;
            int[] numPos;
            int[] numNeg;
            int num = 0;

            Random r = new Random();

            Console.WriteLine("Numeros en forma original: \n");

            for (i = 0; i < vector.Count; i++)
            {
                num = r.Next(-100, 100);

                while (num == 0)
                {
                    num = r.Next(-100, 100);
                }

                vector.Add(num);
                Console.Write(vector[i] + " ");

                if (vector[i] > 0)
                {
                    contPos++;
                }
                else
                {
                    contNeg++;
                }

            }

          /*  numPos = new int[contPos + 1];
            numNeg = new int[contNeg + 1];

            int contadorPos = 0;
            int contadorNeg = 0;

            for (i = 0; i < vector.Count; i++)
            {
                if (vector[i] > 0)
                {
                    contadorPos++;
                    numPos[contadorPos] = vector[i];
                }

                if (vector[i] < 0)
                {
                    contadorNeg++;
                    numNeg[contadorNeg] = vector[i];

                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("\nNumeros positivos ordenados decrecientes: \n");

            Array.Reverse(numPos);

            foreach (int posi in numPos)
            {
                Console.Write(posi + " ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("\nNumeros negativos ordenados en forma creciente: \n");

            Array.Sort(numNeg);

            foreach (int nega in numNeg)
            {
                Console.Write(nega + " ");
            }

            */
            Console.ReadKey();
        }
    }
}
