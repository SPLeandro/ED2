using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList_Forms
{
    class Contatos
    {
        private readonly List<Contato> agenda = new List<Contato>();

        public bool adicionar(Contato c)
        {
            agenda.Add(c);
            return true;
        }
        public bool remover(Contato c)
        {

            return agenda.Remove(c);
        }

        public bool alterar(Contato c)
        {
            try
            {
                Contato atual = agenda.Find(x => x.Email == c.Email);
                int index = agenda.IndexOf(atual);
                agenda.Remove(atual);
                agenda.Insert(index, c);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public Contato pesquisar(string email)
        {

            Contato response = agenda.Find(x => x.Email == email);
            if (response != null)
            {
                return response;
            }
            else
            {
                return new Contato("-1", "-1", "-1", new Data(0, 0, 0));
            }

        }

        public string listarContatos()
        {
            string total = "";
            foreach (Contato p in agenda)
            {
                total += '#';
                total += p.ToString();
            }

            return total;
        }
    }
}
