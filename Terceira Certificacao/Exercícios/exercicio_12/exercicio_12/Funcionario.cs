using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    class Funcionario:Trabalhador
    {
        public override double v_alimentacao
        {
            get
            {
                if (Salario * (8 / 100) < 750)
                {
                    return Salario * (8 / 100);
                }
                else
                {
                    return 750;
                }
            }
            set { v_alimentacao = value; }
        }
        public override double SalarioFinal
        {
            get
            {
                return Salario + v_alimentacao;
            }

            set
            {
                base.SalarioFinal = value;
            }
        }
    }
}
