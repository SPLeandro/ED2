using System;
using System.Collections.Generic;
using System.Text;

namespace Atendimento
{
    class Guiches
    { 
        private List<Guiche> listaGuiches;

        public List<Guiche> ListaGuiches
        {
            get { return listaGuiches; }
            set { listaGuiches = value; }
        }

        public Guiches()
        {
            listaGuiches = new List<Guiche>();
        }

        public void adicionar(Guiche guiche)
        {
            this.listaGuiches.Add(guiche);
        }
    }
}
