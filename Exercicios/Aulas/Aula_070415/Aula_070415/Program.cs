using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_070415
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solucao1();
            Solucao2();
        }

        static void Solucao1()
        {
            Console.WriteLine("Digite uma frase");
            string frase = Console.ReadLine();

            Console.WriteLine("Digite o caracter");
            char caracter = char.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de caracteres");
            int tamanhoDoPedaco = int.Parse(Console.ReadLine());

            int contador = 0;
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == caracter)
                {
                    contador++;
                }
            }

            Console.WriteLine();

            Console.WriteLine(contador);

            for (int i = 1; i < frase.Length; i++)
            {
                Console.Write(frase[i-1]);

                if (i % tamanhoDoPedaco == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
        static void Solucao2()
        {
            string texto = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string tmp = Console.ReadLine();
            char c = tmp.ToLower()[0];

            for (int i = 0; i < texto.Length; i+= n)
            {
                if (i + n > texto.Length)
                {
                    Console.WriteLine(texto.Substring(i));
                }
                else
                {
                    Console.WriteLine(texto.Substring(i, n));
                }
            }

            string[] palavras = texto.ToLower().Split(' ');

            int qtd = 0;
            foreach (var palavra in palavras)
	        {
                if (palavra[0] == c)
                {
                    qtd++;
                }
	        }

            Console.WriteLine(qtd);
        }
    }
}
