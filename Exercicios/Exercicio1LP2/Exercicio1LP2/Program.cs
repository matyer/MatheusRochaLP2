using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1LP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite numeros para calcular a média, para terminar digite 0");
            //Solucao1();
            Solucao2();
        }
        static void Solucao1()
        {
            var numbers = new List<int>();
            var number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                numbers.Add(number);
                number = int.Parse(Console.ReadLine());
            }

            var media = numbers.Sum() / numbers.Count;
            Console.WriteLine("A média dos números é: {0}", media);
        }
        static void Solucao2()
        {
            var sum = 0;
            var count = 0;

            var number = int.Parse(Console.ReadLine());

            while(number != 0)
            {
                sum += number;
                count++;
                number = int.Parse(Console.ReadLine());
            }

            var media = sum / count;
            Console.WriteLine("A média dos números é: {0}", media);
        }
    }
}
