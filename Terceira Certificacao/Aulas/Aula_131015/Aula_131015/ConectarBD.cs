﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Aula_131015
{
    class ConectarBD
    {
        public void InserirRegistro(string query)
        {
            MySqlConnection conn = new MySqlConnection("Server = localhost ; Database = test ; uid = root ; pwd = ");
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = query;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            string conn = string.Format("INSERT INTO Pessoa(Nome,Sobrenome,Peso,Altura,Telefone) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", Pessoa.Nome, Pessoa.Sobrenome, Pessoa.Peso, Pessoa.Altura, Pessoa.Telefone);
        }
    }
}
