using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aula_290915
{
    class Program
    {
        private static Database _database = new Database();
        private static List<Person> _persons { 
            get 
            {
                return _database.GetPersons();
            }
        }

        public Program()
        {
            _database = new Database();
        }
        static void Main(string[] args)
        {
            ShowMenu();
            int code;
            while(true)
            {
                ShowMenu();
                code = int.Parse(Console.ReadLine());                
                switch (code)
                {
                    default:
                        break;
                    case 0:
                        return;
                    case 1:
                        AddEntry();
                        break;
                    case 2:
                        UpdateEntry();
                        break;
                    case 3:
                        ListEntries();
                        break;
                    case 4:
                        RemoveEntry();
                        break;
                }                
            }                
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Selecione uma opção:\n 1) Adicionar\n 2) Atualizar\n 3) Listar\n 4) Remover\n 0) Sair\n");
        }
        static void AddEntry()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome da pessoa:");
            var name = Console.ReadLine();

            if (_persons.Any(p => p.Name == name))
            {
                Console.WriteLine("Já existe uma pessoa com o nome {0}", name);
                return;
            }

            _database.AddPerson(name);
        }

        static void RemoveEntry()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome que quer remover:");
            var name = Console.ReadLine();
            var _personsearch = _persons.Where(p => p.Name == name);

            if (_personsearch.Any())
            {
                _persons.Remove(_personsearch.First());
                return;
            }

            Console.WriteLine("Não existe uma pessoa com esse nome!");
            Console.ReadKey();
        }

        static void ListEntries()
        {
            Console.Clear();
            Console.WriteLine("Nomes cadastrados:\n");
            foreach (var person in _persons)
            {
                Console.WriteLine("[{0}] {1}", person.ID, person.Name);
            }

            Console.ReadKey();
        }

        static void UpdateEntry()
        {
            Console.Clear();
            Console.WriteLine("Digite o nome que quer atualiar:");
            var name = Console.ReadLine();
            var _personsearch = _persons.Where(p => p.Name == name);

            if (_personsearch.Any())
            {
                Console.WriteLine("Digite o novo nome:");
                var newName = Console.ReadLine();
                if (_persons.Any(p => p.Name == newName))
                {
                    Console.WriteLine("Já existe uma pessoa com o nome {0}", newName);
                    return;
                }

                var person = _personsearch.First();
                person.Name = newName;
                return;
            }

            Console.WriteLine("Não existe uma pessoa com esse nome!");
            Console.ReadKey();
        }
    }

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
