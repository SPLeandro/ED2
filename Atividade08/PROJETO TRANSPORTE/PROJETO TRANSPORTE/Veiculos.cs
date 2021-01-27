using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO_TRANSPORTE
{
    class Veiculos
    {
        private List<Veiculo> veiculos;

        public Veiculos(List<Veiculo> veiculos)
        {
            this.veiculos = veiculos;
        }

        public Veiculos()
            :this(new List<Veiculo>())
        {}

        public List<Veiculo> VeiculosList
        {
            get { return veiculos; }
            set { veiculos = value; }
        }

        public void incluir(Veiculo veiculo)
        {
            this.veiculos.Add(veiculo);
        }
    }
}
