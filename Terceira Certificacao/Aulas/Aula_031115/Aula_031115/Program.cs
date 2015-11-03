using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_031115
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~ MENU ~");
            Console.WriteLine(" 1 -> Incluir dados relativos a conta de um cliente.");
            Console.WriteLine(" 2 -> Sacar um determinado valor da sua conta.");
            Console.WriteLine(" 3 -> Depositar um determinado valor na sua conta.");
            Console.WriteLine(" 4 -> Mostrar dados da conta de um cliente.");
            int Escolha_menu = int.Parse(Console.ReadLine());
            
            switch (Escolha_menu)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("Escolha a conta de sua escolha. \n 1 -> Conta Bancária. \n 2 -> Conta Poupanca. \n 3 -> Conta Especial.");
                        int escolha_cria_conta = int.Parse(Console.ReadLine());
                        if (escolha_cria_conta == 1)
                        {
                            ContaBancaria conta_bancaria = new ContaBancaria();

                            conta_bancaria.Cliente
                        }
                        return;
                    }
                default:
                    {
                        return;
                    }
            }
        }
    }
}
