using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_14072015
{
    class Cachorro
    {
        private int _tamanhoCm; 
        private string _nome;
        private int _peso;

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public void SetPeso(int peso)
        {
            _peso = peso;
        }

        public void SetTamanhoCm(int tamanho)
        {
            _tamanhoCm = tamanho;
        }

        public int GetRacaoDiariaKg(int RacaoDiariaKg)
        {
            RacaoDiariaKg = _peso / (_tamanhoCm * _tamanhoCm) / 10;
            return RacaoDiariaKg;
        }

        public int Getpeso()
        {
            return _peso;
        }

        public string GetNome()
        {
            return _nome;
        }

        public int GetTamanhoCM()
        {
            return _tamanhoCm;
        }
    }
}
