using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Aula_131015
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> Pessoas = new List<Pessoa>();
            int check = 1;
            Console.WriteLine(" ~ MENU ~ ");
            Console.WriteLine();
            Console.WriteLine("1 - Inserir novo");
            Console.WriteLine("2 - Consultar");
            Console.WriteLine("0 - Fechar");
            Console.WriteLine();
            int switchREF = int.Parse(Console.ReadLine());

            switch (switchREF)
            {
                case 1:
                    if (check == 1)
                    {
                        Pessoa Pessoa = new Pessoa();
                        Console.Write("Nome: ");
                        Pessoa.Nome = Console.ReadLine();
                        Console.Write("Sobrenome: ");
                        Pessoa.Sobrenome = Console.ReadLine();
                        Console.Write("Peso: ");
                        Pessoa.Peso = double.Parse(Console.ReadLine());
                        Console.Write("Altura: ");
                        Pessoa.Altura = double.Parse(Console.ReadLine());
                        Console.Write("Telefone: ");
                        Pessoa.Telefone = Console.ReadLine();

                        Pessoas.Add(Pessoa);

                        Console.WriteLine("Salvo com sucesso!");

                        ConectarBD bd = new ConectarBD();
                        string conn = string.Format(new CultureInfo("en"), "INSERT INTO Pessoa(Nome,Sobrenome,Peso,Altura,Telefone) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", Pessoa.Nome, Pessoa.Sobrenome, Pessoa.Peso, Pessoa.Altura, Pessoa.Telefone);
                        bd.InserirRegistro(conn);

                        Console.WriteLine("Desenha adicionar mais uma pessoa?");
                        Console.WriteLine("1- Sim");
                        Console.WriteLine("2- Não");
                        check = int.Parse(Console.ReadLine());
                    }
                break;
                default:
                    {
                        Environment.Exit(0);
                    }
                    break;
            }
        }
    }
}
