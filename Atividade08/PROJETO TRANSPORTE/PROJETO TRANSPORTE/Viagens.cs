using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO_TRANSPORTE
{
    class Viagens
    {
        private Queue<Viagem> viagens;

        public Viagens(Queue<Viagem> viagens)
        {
            this.viagens = viagens;
        }

        public Viagens()
            : this(new Queue<Viagem>())
        {}

        public Queue<Viagem> ViagensQueue
        {
            get { return viagens; }
            set { viagens = value; }
        }

        public void incluir(Viagem viagem)
        {
            this.viagens.Enqueue(viagem);
        }
    }
}
