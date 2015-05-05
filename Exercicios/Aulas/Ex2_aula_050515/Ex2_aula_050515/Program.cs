using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_aula_050515
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] x1 = new int[n];
            int[] y1 = new int[n];
            int[] x2 = new int[n];
            int[] y2 = new int[n];

            for (int i = 0; i < n; i++)
            {
                    x1[i] = int.Parse(Console.ReadLine());
                    y2[i] = int.Parse(Console.ReadLine());
                    x2[i] = int.Parse(Console.ReadLine());
                    y2[i] = int.Parse(Console.ReadLine());
            }
           
            double maior = double.MinValue;
            int j;
 
            for (int i = 0; i < n; i++)
            {
                int cat1 = x2[i] - x1[i];
                int cat2 = y1[i] - y2[i];
                double hip = cat1 * cat1 + cat2 * cat2;
                hip = Math.Sqrt(hip);
                if (hip > maior)
	            {
                    maior = hip;
                    j = i;
	            }
            }
            Console.WriteLine("({0},{1}), ({2},{3})", x1[j], y1[j], x2[j], y2[j]);
            Console.WriteLine(maior);
        }
    }
}
