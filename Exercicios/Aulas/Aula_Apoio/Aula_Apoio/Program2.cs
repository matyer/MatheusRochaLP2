using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Apoio
{
    class Program2
    {
        static void Main(string[] args)
        {
            int quant = int.Parse(Console.ReadLine());

            for (int i = 0; i < quant; i++)
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());

                if (a == b && a == c)
                {
                    Console.WriteLine("É triângulo equilátero");
                }

                if (a == b && a != c || a == c && a != c || b == c && b != a)
                {
                    Console.WriteLine("É triângulo isósceles");
                }
                if (a != b && a !=c)
                {
                    Console.WriteLine("É triângulo Escaleno.");
                }
            }
        }
    }
}
