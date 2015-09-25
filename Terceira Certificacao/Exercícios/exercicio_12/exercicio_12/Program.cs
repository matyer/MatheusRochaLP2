using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> Funcionarios = new List<Funcionario>();
            List<Gerente> Gerentes = new List<Gerente>();
            List<Terceirizado> Terceirizados = new List<Terceirizado>();

            double folha_pagG = 0;
            double folhapagF = 0;
            Console.WriteLine("Quantidade de trabalhadores");
            int quantdade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantdade; i++)
            {
                Console.WriteLine("Cargo");
                string cargo = Console.ReadLine();

                if (cargo == "Funcionario" || cargo == "Funcionário" || cargo == "funcionario" || cargo == "funcionáro")
                {
                    Funcionario Funcionario = new Funcionario();
                    Console.WriteLine("Nome: ");
                    Funcionario.Nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    Funcionario.Cpf = Console.ReadLine();
                    Console.Write("Data de nascimento: ");
                    Funcionario.DataNascimento = int.Parse(Console.ReadLine());
                    Console.Write("Matricula: ");
                    Funcionario.Matricula = int.Parse(Console.ReadLine());
                    Console.Write("Salário: ");
                    Funcionario.Salario = double.Parse(Console.ReadLine());

                    Funcionarios.Add(Funcionario);
                }

                if (cargo == "Gerente" || cargo == "gerente")
                {
                    Gerente Gerente = new Gerente();
                    Console.WriteLine("Nome: ");
                    Gerente.Nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    Gerente.Cpf = Console.ReadLine();
                    Console.Write("Data de nascimento: ");
                    Gerente.DataNascimento = int.Parse(Console.ReadLine());
                    Console.Write("Matricula: ");
                    Gerente.Matricula = int.Parse(Console.ReadLine());
                    Console.Write("Salário: ");
                    Gerente.Salario = double.Parse(Console.ReadLine());
                    Console.Write("Área: ");
                    Gerente.Area = Console.ReadLine();
                    Console.WriteLine("Adicional: ");
                    Gerente.Adicional = int.Parse(Console.ReadLine());

                    Gerentes.Add(Gerente);
                }

                if (cargo == "Terceirizado" || cargo == "terceirizado")
                {
                    Terceirizado Terceirizado = new Terceirizado();
                    Console.WriteLine("Nome: ");
                    Terceirizado.Nome = Console.ReadLine();
                    Console.Write("CPF: ");
                    Terceirizado.Cpf = Console.ReadLine();
                    Console.Write("Data de nascimento: ");
                    Terceirizado.DataNascimento = int.Parse(Console.ReadLine());
                    Console.Write("Matricula: ");
                    Terceirizado.Matricula = int.Parse(Console.ReadLine());
                    Console.WriteLine("CNPJ: ");
                    Terceirizado.Cnpj = Console.ReadLine();

                    Terceirizados.Add(Terceirizado);
                }

                Console.Clear();

                for (int j = 0; j < Funcionarios.Count; j++)
                {
                    folhapagF += Funcionarios[j].SalarioFinal;
                }
                for (int k = 0; k < Gerentes.Count; k++)
                {
                    folha_pagG += Gerentes[k].SalarioFinal;
                }
                double folhapag_geral = folhapagF + folha_pagG;
                Console.WriteLine("Folha de pagamento da empresa: ");
                Console.WriteLine(folhapag_geral);
            }

        }
    }
}
