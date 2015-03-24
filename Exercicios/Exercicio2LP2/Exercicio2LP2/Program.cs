using System;

namespace Exercicio2LP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int count;
            double sum = 0;
            double smallest = int.MaxValue;
            double greatest = 0;

            Console.Write("Quantos números você quer calcular: ");
            count = int.Parse(Console.ReadLine());

            while (count > 0)
            {
                double number;
                if (double.TryParse(Console.ReadLine(), out number) && number >= 0)
                {
                    count--;
                    sum += number;
                    smallest = Math.Min(smallest, number);
                    greatest = Math.Max(greatest, number);
                }
                else
                {
                    Console.WriteLine("Digiteu um número positivo válido!");
                }
            }

            Console.WriteLine("A soma foi {0}, o maior número foi {1} e o menor {2}", sum, greatest, smallest);
        }
    }
}
