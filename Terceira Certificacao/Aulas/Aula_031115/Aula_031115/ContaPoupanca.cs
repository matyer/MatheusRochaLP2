using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_031115
{
    class ContaPoupanca:ContaBancaria
    {
        private DateTime DiaRendimento { get; set; }

        private void CalcularNovoSaldo(double Rendimento)
        {
            Saldo *= Rendimento / 100;
        }
    }
}
