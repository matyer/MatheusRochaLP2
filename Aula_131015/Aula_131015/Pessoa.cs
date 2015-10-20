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
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public string Telefone { get; set; }

    }
}
