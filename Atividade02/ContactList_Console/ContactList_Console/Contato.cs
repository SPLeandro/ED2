using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList_Console
{
    class Contato : Data
    {
        private string email;
        private string nome;
        private string telefone;
        private Data dtNasc;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }


        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public Data DtNasc
        {
            get { return dtNasc; }
            set { dtNasc = value; }
        }


        public Contato(string email, string nome, string telefone, Data dtNasc)
        {
            this.email = email;
            this.nome = nome;
            this.telefone = telefone;
            this.dtNasc = dtNasc;
        }

        public Contato()
            : this("", "", "", new Data(0, 0, 0))
        {
        }

        public int getIdade()
        {
            return 1;
        }

        public override string ToString()
        {
            return "Nome: " + this.nome + " - Email: " + this.email + " - Telefone: " + this.telefone + " - Data de nascimento: " + this.dtNasc.ToString();
        }

        public override bool Equals(object obj)
        {
            return this.ToString().Equals(((Contato)obj).ToString());
        }
    }
}
