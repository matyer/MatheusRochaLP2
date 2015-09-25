using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_12
{
    class Trabalhador
    {
        public string Nome {get; set; }
        public string Cpf { get; set; }
        public int DataNascimento { get; set; }
        public double Salario { get; set; }
        public int Matricula{ get; set; }
        virtual public double SalarioFinal { get; set; }

        virtual public double v_alimentacao
        {
            get
            {
                if (Salario * (8/100) < 750)
                {
                    return Salario * (8/100);
                }
                else
                {
                    return 750;
                }
            }
            set { v_alimentacao = value; }
        }



    }
}
