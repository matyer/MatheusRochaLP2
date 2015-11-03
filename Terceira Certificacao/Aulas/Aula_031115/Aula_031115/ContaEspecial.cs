using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_031115
{
    class ContaEspecial:ContaBancaria
    {
        private double limite { get; set; }

        protected override void Sacar(double valor)
        {
            if (Saldo + limite < valor)
            {
                Console.WriteLine("Saldo (incluindo o valor negativo limite) insuficiente.");
            }
            else
            {
                Saldo += valor;
            }
        }
        protected override void Transferencia(double valor, ContaEspecial conta)
        {
            if (Saldo + limite < valor)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Saldo -= valor;
                conta.Saldo += valor;
            }
        }
    }
}
