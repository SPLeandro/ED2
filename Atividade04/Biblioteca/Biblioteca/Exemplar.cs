using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
   
    class Exemplar
    {
        private int tombo;
        private List<Emprestimo> emprestimos;

        public Exemplar(int tombo)
        {
            this.tombo = tombo;
            emprestimos = new List<Emprestimo>();
        }
    

        public int Tombo
        {
            get { return tombo; }
            set { tombo = value; }
        }

        public List<Emprestimo> Emprestimos
        {
            get { return emprestimos; }
            set { emprestimos = value; }
        }


        public Boolean emprestar()
        {
            if (this.disponivel())
            {
                Emprestimo novoEmprestimo = new Emprestimo(DateTime.Now, new DateTime(0, 0, 0, 0, 0, 0));
                emprestimos.Add(novoEmprestimo);
                return true;
            } 
            else {
                return false;
            }
                       
        }

        public Boolean devolver()
        {  
            if (!this.disponivel())
            {
                Emprestimo attEmprestimo;

                attEmprestimo = emprestimos.FindLast(e => e.DtDevolucao == new DateTime(0, 0, 0, 0, 0, 0));
                emprestimos.Remove(attEmprestimo);
                attEmprestimo.DtDevolucao = DateTime.Now;
                emprestimos.Add(attEmprestimo);
                return true;
            } else { return false; }
            
        }

        public Boolean disponivel()
        {
            return !emprestimos.Exists(e => e.DtDevolucao == new DateTime(0, 0, 0, 0, 0, 0));
        }

        public int qtdeEmprestimos()
        {
            return emprestimos.Count;
        }
    }
}
