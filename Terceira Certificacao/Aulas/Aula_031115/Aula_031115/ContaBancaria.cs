using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_031115
{
    class ContaBancaria
    {
        protected string Cliente { get; set; }
        protected int Num_conta { get; set; }
        protected double Saldo { get; set; }

        protected virtual void Sacar(double valor)
        {
            if (Saldo < 0 || Saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente.");
            }
            else
            {
                Saldo -= valor;
            }
        }
        protected void Depositar(double valor)
        {
            Saldo += valor;
        }
        private void Transferencia(double valor, ContaBancaria conta)
        {
            if (Saldo < 0 || Saldo < valor)
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
