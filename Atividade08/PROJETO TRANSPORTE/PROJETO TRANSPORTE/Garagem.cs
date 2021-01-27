using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO_TRANSPORTE
{
    class Garagem
    {
        private int id;
        private string local;
        private Stack<Veiculo> veiculos;

        public Garagem(int id, string local)
        {
            this.id = id;
            this.local = local;
            this.veiculos = new Stack<Veiculo>();
        }

        public Garagem()
            : this(0, "") 
        { }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Local
        {
            get { return local; }
            set { local = value; }
        }

        public Stack<Veiculo> Veiculos
        {
            get { return veiculos; }
            set { veiculos = value; }
        }

        public int qtdeDeVeiculos()
        {

            return this.veiculos.Count;
        }

        public int potencialDeTransporte()
        {
            int total = 0;
            foreach (Veiculo v in this.veiculos)
            {
                total += v.Lotacao;
            }
            return total;
        }
    }
}
