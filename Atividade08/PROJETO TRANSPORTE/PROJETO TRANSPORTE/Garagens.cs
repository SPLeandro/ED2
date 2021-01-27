using System;
using System.Collections.Generic;
using System.Text;

namespace PROJETO_TRANSPORTE
{
    class Garagens
    {
        private List<Garagem> garagens;
        private Boolean jornadaAtiva;

        public Garagens(List<Garagem> garagens, Boolean jornadaAtiva)
        {
            this.garagens = garagens;
            this.jornadaAtiva = jornadaAtiva;
        }

        public Garagens()
            : this(new List<Garagem>(), false)
        { }

        public List<Garagem> GaragensList
        {
            get { return garagens; }
            set { garagens = value; }
        }

        public Boolean JornadaAtiva
        {
            get { return jornadaAtiva; }
            set { jornadaAtiva = value; }
        }

        public void incluir(Garagem garagem)
        {
            if (!jornadaAtiva)
            {
                this.garagens.Add(garagem);
            }
            
        }

        public void iniciarJornada(Veiculos veiculos)
        {            
            Veiculos veiculosRest = veiculos;

            double totalVeic = veiculos.VeiculosList.Count;
            double totalGar = garagens.Count;
            double totalDist = totalVeic / totalGar;
            totalDist = Math.Ceiling(totalDist);

            for (int i = 0; i < totalDist; i++)
            {
                garagens.ForEach(g =>
                {
                    if(veiculosRest.VeiculosList.Count == 0)
                    {

                    } else
                    {
                        g.Veiculos.Push(veiculosRest.VeiculosList[0]);
                        veiculosRest.VeiculosList.Remove(veiculosRest.VeiculosList[0]);
                    }

                });
            }

            this.jornadaAtiva = true;

        }

        public List<Transporte> encerrarJornada()
        {           
            List<Transporte> lista = new List<Transporte>();
            Transporte transporte = new Transporte();

            foreach (Garagem g in garagens)
            {
                foreach(Veiculo v in g.Veiculos)
                {
                    transporte = new Transporte(v, v.Lotacao);
                    lista.Add(transporte);
                }               
            }
            this.jornadaAtiva = false;
            return lista;
        }
    }
}
