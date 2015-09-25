using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    class Gerente:Trabalhador
    {
        public string Area{ get; set; }
        public double Adicional { get; set; }
        public double SalarioTotal
        {
            get
            {
                return Salario + Adicional;
            }
        }
        public override double v_alimentacao
        {
            get
            {
                if (SalarioTotal * (6.5/100) < 750)
                {
                    return SalarioTotal * (6.5/100);
                }
                else
                {
                    return 750;
                } 
            }
            set { v_alimentacao = value;}
        }
        public override double SalarioFinal
        {
            get
            {
                return SalarioTotal + v_alimentacao;
            }

            set
            {
                base.SalarioFinal = value;
            }
        }

    }
}
