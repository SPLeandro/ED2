using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactList_Forms
{
    public partial class Form1 : Form
    {
        Contatos pessoas = new Contatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
            textBoxNome.Text = "";
            textBoxTel.Text = "";
            textBoxDia.Text = "";
            textBoxMes.Text = "";
            textBoxAno.Text = "";
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Data dtNasc = new Data(int.Parse(textBoxDia.Text), int.Parse(textBoxMes.Text), int.Parse(textBoxAno.Text));

            string emailAtual = pessoas.pesquisar(textBoxEmail.Text).Email;

            if (emailAtual != textBoxEmail.Text)
            {
                pessoas.adicionar(new Contato(textBoxEmail.Text, textBoxNome.Text, textBoxTel.Text, dtNasc));
            }
            else
            {
                pessoas.alterar(new Contato(emailAtual, textBoxNome.Text, textBoxTel.Text, dtNasc));
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Data dtNasc = new Data(int.Parse(textBoxDia.Text), int.Parse(textBoxMes.Text), int.Parse(textBoxAno.Text));
            MessageBox.Show(pessoas.remover(new Contato(textBoxEmail.Text, textBoxNome.Text, textBoxTel.Text, dtNasc)) ? "REMOVIDO!" : "CONTATO NÃO ENCONTRADO");
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            MessageBox.Show(pessoas.pesquisar(email).Email == "-1" ? "Nao encontrado"  : pessoas.pesquisar(email).ToString());

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            listBoxPessoas.Items.Clear();
            string ListPessoas = pessoas.listarContatos();
            var array = ListPessoas.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string a in array)
            {
                listBoxPessoas.Items.Add(a);
            }
        }
    }
}
