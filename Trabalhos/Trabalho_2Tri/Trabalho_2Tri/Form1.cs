using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_2Tri
{
    public partial class Form1 : Form
    {
        List<carro> carros = new List<carro>();
        int quantidadeCarros;
        int quantidadePassageiros;
        int passageirosalvo;
        int id = 0;
        int vagasrest;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            carro car = new carro();

            car.Id = id + 1;
            car.Modelo = modelo.Text;
            car.Marca = marca.Text;
            car.Placa = placa.Text;
            car.Vagas = int.Parse(vagas.Text);

            id += 1;

            carros.Add(car);

            if (id >= quantidadeCarros)
            {
                MessageBox.Show("Todos carros salvos com sucesso!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int idcar = int.Parse(addPassageiro.Text) - 1;


            if (quantidadePassageiros > passageirosalvo)
            {
                if (idcar < 0 || idcar > quantidadeCarros)
                {
                    MessageBox.Show("Carro inexistente.");
                }

                if (carros[idcar].Passageiros < carros[idcar].Vagas)
                {
                    carros[idcar].Passageiros += 1;
                    passageirosalvo += 1;
                }
                else
                {
                    MessageBox.Show("O carro {0} não possui mais vagas.", addPassageiro.Text);
                    
                }
            }
            else
            {
                MessageBox.Show("Todos os passageiros já foram adicionados com sucesso!");

                for (int i = 0; i < quantidadeCarros; i++)
                {
                    vagasrest = carros[i].Vagas - carros[i].Passageiros;

                    MessageBox.Show("Carro " + carros[i].Id + ": " + carros[i].Modelo + " - " + carros[i].Marca + " (" + carros[i].Placa + ") \nPassageiros: " + carros[i].Passageiros + "\nVagas restantes: " + vagasrest + "");
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            quantidadeCarros = int.Parse(quant_Car.Text);
            quantidadePassageiros = int.Parse(quant_pass.Text);
            MessageBox.Show("Salvo com sucesso!");
        }
    }
}
