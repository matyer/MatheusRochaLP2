using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aula_28042015
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numeros = new int[n];
            int aux = 0;

            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (numeros[i] < numeros[j])
                    {
                        aux = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = aux;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(numeros[i] + " ");
            }
                Console.WriteLine();
        }
    }
}