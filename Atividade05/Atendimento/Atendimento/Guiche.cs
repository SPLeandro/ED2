using System;
using System.Collections.Generic;
using System.Text;

namespace Atendimento
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimentos;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Queue<Senha> Atendimentos
        {
            get { return atendimentos; }
            set { atendimentos = value; }
        }

        public Guiche()
        {
            this.id = 0;
            atendimentos = new Queue<Senha>();
        }

        public Guiche(int id)
        {
            this.id = id;
            atendimentos = new Queue<Senha>();
        }

        public Boolean chamar(Queue<Senha> filaSenhas)
        {
            try
            {
                filaSenhas.Peek().DataAtend = DateTime.Now;
                atendimentos.Enqueue(filaSenhas.Peek());
                filaSenhas.Dequeue();
                return true;
            }
            catch
            {
                return false;
            }        
        }
    }
}
