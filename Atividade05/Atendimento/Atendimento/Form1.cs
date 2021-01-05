using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atendimento
{
    public partial class Form1 : Form
    {
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();
        int id = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelQtdeGuiches.Text = guiches.ListaGuiches.Count().ToString();
        }

        private void buttonGerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            Guiche guiche = new Guiche(id);
            id++;
            guiches.adicionar(guiche);
            labelQtdeGuiches.Text = guiches.ListaGuiches.Count().ToString();
        }

        private void buttonChamar_Click(object sender, EventArgs e)
        {
            if(textBoxGuiche.Text == "")
            {
                MessageBox.Show("Por favor, insira um guichê!", "ERROR");
            }
            else
            {
                if(int.Parse(textBoxGuiche.Text) > guiches.ListaGuiches.Count || int.Parse(textBoxGuiche.Text) == 0)
                {
                    MessageBox.Show("Guichê inexistente!", "ERROR");
                    
                } else
                {
                    int idGuiche = int.Parse(textBoxGuiche.Text);
                    idGuiche--;

                    guiches.ListaGuiches.Find(s => s.Id == idGuiche).chamar(senhas.FilaSenhas);
                }               
            }     
        }

        private void buttonListarSenhas_Click(object sender, EventArgs e)
        {
            AtualizarListaGeradas();
        }

        private void buttonListarAtendimentos_Click(object sender, EventArgs e)
        {
            AtualizarListaAtendimentos();
        }

        private void AtualizarListaGeradas()
        {
            // ATUALIZANDO LISTA DE SENHAS
            listViewSenhasListadas.Items.Clear();

            foreach (Senha s in senhas.FilaSenhas)
            {
                listViewSenhasListadas.Items.Add(s.dadosParciais());
            }
        }

        private void AtualizarListaAtendimentos()
        {
            // ATUALIZANDO LISTA DE ATENDIMENTOS
            listViewListaAtendimentos.Items.Clear();

            List<Senha> itens = new List<Senha>();

            foreach (Guiche g in guiches.ListaGuiches)
            {
                foreach (Senha s in g.Atendimentos)
                {
                    itens.Add(s);                   
                }
            }

            List<Senha> SortedList = itens.OrderBy(o => o.Id).ToList();

            foreach (Senha s in SortedList)
            {
                listViewListaAtendimentos.Items.Add(s.dadosCompletos());
            }
        }
    }
}



