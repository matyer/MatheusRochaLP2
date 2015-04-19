using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections;

namespace Lista_exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercicio1();
            //exercicio2();
            //exercicio3();
            //exercicio4();
            //exercicio5();
            //exercicio6naofeito();
            //exercicio7naoconcluido();
            //exercicio8();
        }

        #region utilidades
        static long fatorial(int numero)
        {
            long resultado = 1;
            for (int i = numero; i > 0; i--)
            {
                resultado *= i;
            }
            return resultado;
        }

        static double Mersenne(int n)
        {
            return Math.Pow(2, n) - 1;
        }
        #endregion utilidades

        #region exercicios
        static void exercicio1()
        {
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine(fatorial(numero));
        }
        static void exercicio2()
        {
            int numero = int.Parse(Console.ReadLine());
            double result = 0;

            for (int i = 1; i <= numero; i++)
            {

                var division = fatorial(i) / Mersenne(i);
                if (i % 2 == 0)
                {
                    result -= division;
                }
                else
                {
                    result += division;
                }
            }
            Console.WriteLine(result);
        }
        static void exercicio3()
        {
            int funcionarios = int.Parse(Console.ReadLine());
            string[] nomes = new string[funcionarios];
            int[] salarios = new int[funcionarios];
            int[] newsalario = new int[funcionarios];

            for (int i = 0; i < funcionarios; i++)
            {
                var nome = Console.ReadLine();
                int salario = int.Parse(Console.ReadLine());

                salarios[i] = salario;
                nomes[i] = nome;
            }
            for (int i = 0; i < funcionarios; i++)
            {
                if (salarios[i] <= 2999)
                {
                    newsalario[i] = (salarios[i] * 25 / 100) + salarios[i];
                }
                if (salarios[i] >= 3000 && salarios[i] <= 3999)
                {
                    newsalario[i] = (salarios[i] * 20 / 100) + salarios[i];
                }
                if (salarios[i] >= 4000 && salarios[i] <= 4999)
                {
                    newsalario[i] = (salarios[i] * 15 / 100) + salarios[i];
                }
                if (salarios[i] >= 5000)
                {
                    newsalario[i] = (salarios[i] * 10 / 100) + salarios[i];
                }
            }
            for (int i = 0; i < funcionarios; i++)
            {
                Console.WriteLine(nomes[i]);
                Console.WriteLine(salarios[i]);
                Console.WriteLine(newsalario[i]);
            }
        }
        static void exercicio4()
        {
            int jogador1 = 0;
            int jogador2 = 0;
            for (int i = 1; i > 0; i++)
            {
                Console.WriteLine("quem fez ponto?");
                string ponto = Console.ReadLine();
                if (ponto == "1")
                {
                    jogador1 += 1;
                }
                if (ponto == "2")
                {
                    jogador2 += 1;
                }
                if (jogador1 >= 21 && jogador1 - jogador2 >= 2)
                {
                    Console.WriteLine("O Jogador 1 venceu!");
                    break;
                }
                if (jogador2 >= 21 && jogador2 - jogador1 >= 2)
                {
                    Console.WriteLine("O Jogador 2 venceu!");
                    break;
                }
            }
        }
        static void exercicio5()
        {
            int distancia = 0;
            double combustivel = 0;
            while (true)
            {
                distancia += int.Parse(Console.ReadLine());
                combustivel += int.Parse(Console.ReadLine());

                if (combustivel > 50)
                {
                    Console.WriteLine("O carro parou antes de chegar por falta de combustível");
                    break;
                }
                if (distancia >= 600)
                {
                    Console.WriteLine("O carro chegou ao seu destino.");
                    break;
                }
            }
            double desempenho = distancia / combustivel;
            Console.WriteLine(desempenho + "km/l");

        }
        static void exercicio6naofeito()
        {   
     
        }
        static void exercicio7naoconcluido()
        {
            /*int provas = 0;
            int nadadores = 0;

            while (true)
            {
                provas = int.Parse(Console.ReadLine());
                nadadores = int.Parse(Console.ReadLine());
                if (provas == 9999 && nadadores ==0)
                {
                    break;
                }
            }

            int[] nadador = new int[nadadores];
            string[] nome = new string[nadadores];
            int[] classific = new int[nadadores];
             int[] tempo = new int[nadadores];
             string[] clube = new string[nadadores];

            for (int i = 0; i < nadadores; i++)
                {
                 nome[i] = Console.ReadLine();
                classific[i] = int.Parse(Console.ReadLine());
                tempo[i] = int.Parse(Console.ReadLine());
                clube[i] = Console.ReadLine();

                nadador[i] 

                }
            */
        }
        static void exercicio8()
        {
            int numero = int.Parse(Console.ReadLine());
            int resultado = 0;
            for (int i = 1; i < numero; i++)
            {
                resultado += i;
            }
            resultado += numero;
            Console.WriteLine(resultado);
        }
        #endregion exercicios
    }
}
