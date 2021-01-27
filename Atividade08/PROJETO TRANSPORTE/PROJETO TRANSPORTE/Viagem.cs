using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO_TRANSPORTE
{
    class Viagem
    {
        private int id;
        private Garagem origem;
        private Garagem destino;
        private Veiculo veiculo;

        public Viagem(int id, Garagem origem, Garagem destino, Veiculo veiculo)
        {
            this.id = id;
            this.origem = origem;
            this.destino = destino;
            this.veiculo = veiculo;
        }

        public Viagem()
            : this(0, new Garagem(0, ""), new Garagem(0, ""), new Veiculo(0, "", 0))
        {}

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Garagem Origem
        {
            get { return origem; }
            set { origem = value; }
        }

        public Garagem Destino
        {
            get { return destino; }
            set { destino = value; }
        }

        public Veiculo Veiculo
        {
            get { return veiculo; }
            set { veiculo = value; }
        }
    }
}
