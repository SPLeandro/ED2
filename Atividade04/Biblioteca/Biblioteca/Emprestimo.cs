using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Emprestimo
    {
        DateTime dtEmprestimo;
        DateTime dtDevolucao;

        public Emprestimo(DateTime dtEmprestimo, DateTime dtDevolucao)
        {
            this.dtEmprestimo = dtEmprestimo;
            this.dtDevolucao = dtDevolucao;
        }

        public Emprestimo()
            : this( new DateTime(0,0,0,0,0,0), new DateTime(0, 0, 0, 0, 0, 0))
        {         
        }

        public DateTime DtEmprestimo
        {
            get { return dtEmprestimo; }
            set { dtEmprestimo = value; }
        }

        public DateTime DtDevolucao
        {
            get { return dtDevolucao; }
            set { dtDevolucao = value; }
        }
    }
}
