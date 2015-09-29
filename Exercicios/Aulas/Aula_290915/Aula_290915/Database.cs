using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aula_290915
{
    public class Database
    {
        private MySqlConnection _dbConnection;

        public Database()
        {
            _dbConnection = new MySqlConnection("Server=localhost;Database=gabrieldavidmatheusrocha;UID=root;PWD=");
        }

        public void AddPerson(string name)
        {
            var command = new MySqlCommand("INSERT INTO 29Setembro (Nome) VALUES (@name)", _dbConnection);
            _dbConnection.Open();
            command.Prepare();
            
            command.Parameters.AddWithValue("name", name);            
            command.ExecuteNonQuery();

            _dbConnection.Close();
        }

        public List<Person> GetPersons()
        {
            var persons = new List<Person>();
            var command = new MySqlCommand("SELECT * FROM 29Setembro", _dbConnection);

            _dbConnection.Open();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = int.Parse(reader.GetString("ID"));
                string name = reader.GetString("Nome");

                persons.Add(new Person
                {
                    ID = id,
                    Name = name
                });
            }

            reader.Close();
            _dbConnection.Close();

            return persons;
        }
    }
}
