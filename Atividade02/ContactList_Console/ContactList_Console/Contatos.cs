using System;
using System.Collections.Generic;
using System.Text;

namespace ContactList_Console
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
                int index = agenda.IndexOf(c);
                agenda.Remove(c);
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
                return new Contato("", "", "", new Data(0, 0, 0));
            }

        }

        public void listarContatos()
        {
            Console.WriteLine("- Qtde: {0} -----------------------------", agenda.Count);
            foreach (Contato p in agenda)
            {
                Console.WriteLine(p.ToString());
            }
            Console.WriteLine("---------------------------------------");
        }
    }
}
