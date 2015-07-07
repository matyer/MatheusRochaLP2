using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Apoio
{
    class Program
    {
        static void Main2(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int result;

            for (int i = p; i <= q; i++)
            {
                result = n * i;
                Console.WriteLine(result);
            }
        }
    }
}
