using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade01
{
    class Vendedores
    {
        private Vendedor[] osVendedores;
        private int max;
        private int qtde = 0;

        public Vendedores(int max)
        {
            this.max = max;
            this.qtde = 0;
            this.osVendedores = new Vendedor[this.max];

            for (int i = 0; i < this.max; ++i)
            {
                this.osVendedores[i] = new Vendedor(-1, "...", 0.0);
            }
        }

        public int Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public Vendedor[] OsVendedores
        {
            get { return osVendedores; }
            set { osVendedores = value; }
        }


        public bool addVendedor(Vendedor v)
        {
            bool podeAdicionar = (this.qtde < this.max);
            if (podeAdicionar)
            {
                this.osVendedores[this.qtde] = v;
                this.qtde++;
            }
            return podeAdicionar;
        }


        public bool delVendedor(Vendedor vendedor)
        {
            bool temCoisa = false;

            foreach (Vendedor v in this.osVendedores)
            {
                if (v.Equals(vendedor))
                {
                    v.Id = -1;
                    v.Nome = "...";
                    v.PercComissao = 0.0;
                    v.AsVendas = new Venda[31];
                    temCoisa = true;
                }
            }
            return temCoisa;
        }


        public Vendedor searchVendedor(string nome)
        {
            Vendedor vendedorEncontrado = new Vendedor(1, "", 0.2);

            int i = 0;

            while (i < this.max && !this.osVendedores[i].Nome.Equals(nome))
            {
                i++;
            }
            if (i < this.max)
            {
                vendedorEncontrado = this.osVendedores[i];
            }

            return vendedorEncontrado;
 
        }

        public double valorVendas()
        {
            double total = 0.0;

            foreach (Vendedor v in this.osVendedores)
            {
                total += v.valorVendas();
            }

            return total;
        }

        public double valorComissao()
        {
            double total = 0.0;

            foreach (Vendedor v in this.osVendedores)
            {
                total += v.valorComissao();
            }

            return total;
        }
    }
}
