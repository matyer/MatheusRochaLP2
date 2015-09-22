using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Aula_220915
{
    class Program
    {
        static void Main(string[] args)
        {
            string strconn = "Server=localhost;Database=test;Uid=root;Pwd=";

            string nome = Console.ReadLine();

            MySqlConnection conn = new MySqlConnection(strconn);

            MySqlCommand command = new MySqlCommand();

            command.Connection = conn;

            command.CommandText = string.Format("INSERT INTO PESSOA (Nome) VALUES ('{0}')", nome);

            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();

        }
    }
}
