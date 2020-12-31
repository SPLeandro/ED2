using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Livro
    {

        private int isbn;
        private string titulo;
        private string autor;
        private string editora;
        private List<Exemplar> exemplares;

        public Livro (int isbn, string titulo, string autor, string editora)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.exemplares = new List<Exemplar>();
            
        }

        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Editora
        {
            get { return editora; }
            set { editora = value; }
        }

        public List<Exemplar> Exemplares
        {
            get { return exemplares; }
            set { exemplares = value; }
        }

        public void adicionarExemplar(Exemplar exemplar)
        {
            exemplares.Add(exemplar);
        }

        public int qtdeExemplares()
        {
            int qtde = exemplares.Count;
            if (qtde > 0)
            {
                return exemplares.Count;
            }
            else { return 0; }
            
        }

        public int qtdeDisponiveis()
        {
            int total = 0;
            foreach (Exemplar ex in exemplares)
            {
                if (ex.disponivel())
                {
                    total++;
                }                
            }
            return total;
        }

        public int qtdeEmprestimos()
        {
            int total = 0;
            foreach(Exemplar ex in exemplares)
            {
                total += ex.qtdeEmprestimos();
            }
            return total;
        }

        public double percDisponibilidade()
        {
            return this.qtdeDisponiveis() / this.qtdeExemplares();
        }
    }
}