using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_310315
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de x (coeficiente)");
            var coefficient = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de y (expoente)");
            var exponent = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(coefficient,exponent));
        }

        static long Power (int coefficient, int exponent)
        {
            var result = coefficient;
            for (int i = 0; i < (exponent - 1); i++)
            {
                result *= coefficient;
            }

            return result;
        }
    }
}
