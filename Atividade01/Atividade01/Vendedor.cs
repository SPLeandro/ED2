using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade01
{
    class Vendedor
    {
        private int id;
        private string nome;
        private double percComissao;
        private Venda[] asVendas = new Venda[31];

        public Vendedor()
        {
            this.id = -1;
            this.nome = "";
            this.percComissao = 0.0;

            for (int i = 0; i < 31; ++i)
            {
                this.asVendas[i] = new Venda(0, 0.0);
            }
        }

        public Vendedor(int id, string nome, double percComissao)
        {
            this.id = id;
            this.nome = nome;
            this.percComissao = percComissao;

            for (int i = 0; i < 31; ++i)
            {
                this.asVendas[i] = new Venda(0, 0.0);
            }

        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double PercComissao
        {
            get { return percComissao; }
            set { percComissao = value; }
        }

        public Venda[] AsVendas
        {
            get { return asVendas; }
            set { asVendas = value; }
        }


        public void registrarVenda(int dia, Venda venda)
        {
            if (dia > 0 && dia < 32)
            {
                asVendas[dia-1] = venda;
            }
            
        }

        public double valorVendas()
        {
            double total = 0;

            foreach (Venda v in this.asVendas)
            {
                total += v.Valor;
            }

            return total;

        }

        public double valorComissao()
        {
            double total = 0;

            foreach (Venda v in this.asVendas)
            {
                total += v.Valor;
            }

            return total * (percComissao/100);
        } 
    }

}
