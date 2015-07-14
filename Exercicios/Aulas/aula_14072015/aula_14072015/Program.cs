using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_14072015
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro fido = new Cachorro();
            fido.SetTamanhoCm = 95;
            fido.SetNome = ("Fido");
            fido.SetPeso(42.3);

            Console.WriteLine("Nome: {0}", fido.GetNome());
            Console.WriteLine("Peso: {0}", fido.Getpeso());
            Console.WriteLine("Tamanho : {0}", fido.GetTamanhoCM());
            Console.WriteLine("Quantidade diária de ração: {0}", fido.GetRacaoDiariaKg());
        }
    }
}
