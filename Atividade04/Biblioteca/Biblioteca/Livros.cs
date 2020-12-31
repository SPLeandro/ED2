using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    class Livros
    {
        List<Livro> acervo;

        public Livros()
        {
            acervo = new List<Livro>();
        }

        public void adicionar(Livro livro)
        {
            acervo.Add(livro);
        }

        public Livro pesquisar(Livro livro)
        {

            return acervo.Find(L => L == livro);
        }
    }
}