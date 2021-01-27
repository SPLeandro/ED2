using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO_TRANSPORTE
{
    class Veiculo
    {
        private int id;
        private string placa;
        private int lotacao;

        public Veiculo(int id, string placa, int lotacao)
        {
            this.id = id;
            this.placa = placa;
            this.lotacao = lotacao;
        }

        public Veiculo()
            : this(0, "", 0)
        {}

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public int Lotacao
        {
            get { return lotacao; }
            set { lotacao = value; }
        }
    }
}
