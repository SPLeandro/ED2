using System;

namespace Biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            int isbn, tombo;
            int escolha = 1;
            string titulo, autor, editora;
            Livros listLivros = new Livros();           
            Exemplar exemplar;

            for (int i =0; i < 5; i++)
            {
                Livro livro = new Livro(i, "MeuLivro", "Escritor", "QueEditou");
                listLivros.adicionar(livro);
            }
            

            while (escolha != 0)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("0.Sair");
                Console.WriteLine("1.Adicionar livro");
                Console.WriteLine("2.Pesquisar livro(sintético)");
                Console.WriteLine("3.Pesquisar livro(analítico)");
                Console.WriteLine("4.Adicionar exemplar");
                Console.WriteLine("5.Registrar empréstimo");
                Console.WriteLine("6.Registrar devolução");
                Console.Write("Escolha uma opção: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 0:
                    break;
                    case 1:

                        Console.Write("Insira o isbn do livro: ");
                        isbn = int.Parse(Console.ReadLine());
                        Console.Write("Insira o título do livro: ");
                        titulo = Console.ReadLine();
                        Console.Write("Insira o autor do livro: ");
                        autor = Console.ReadLine();
                        Console.Write("Insira a editora do livro: ");
                        editora = Console.ReadLine();

                        Livro livro = new Livro(isbn, titulo, autor, editora);
                        listLivros.adicionar(livro);

                        break;
                    case 2:

                        Console.Write("Insira o isbn do livro a ser pesquisado: ");
                        isbn = int.Parse(Console.ReadLine());
                        Console.Write("Insira o título do livro: ");
                        titulo = Console.ReadLine();
                        Console.Write("Insira o autor do livro: ");
                        autor = Console.ReadLine();
                        Console.Write("Insira a editora do livro: ");
                        editora = Console.ReadLine();

                        livro = new Livro(isbn, titulo, autor, editora);

                        livro = listLivros.pesquisar(livro);
                 
                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("Número de exemplares: {0}", livro.qtdeExemplares());
                        Console.WriteLine("Quantidade disponível: {0}", livro.qtdeDisponiveis());
                        Console.WriteLine("Quantidade de empréstimos: {0}", livro.qtdeEmprestimos());
                        Console.WriteLine("Percentual de disponibilidade: {0}", livro.percDisponibilidade());

                        break;
                    case 3:

                        Console.Write("Insira o isbn do livro a ser pesquisado: ");
                        isbn = int.Parse(Console.ReadLine());
                        Console.Write("Insira o título do livro: ");
                        titulo = Console.ReadLine();
                        Console.Write("Insira o autor do livro: ");
                        autor = Console.ReadLine();
                        Console.Write("Insira a editora do livro: ");
                        editora = Console.ReadLine();

                        livro = new Livro(isbn, titulo, autor, editora);

                        livro = listLivros.pesquisar(livro);

                        Console.WriteLine("-----------------------------");
                        Console.WriteLine("Número de exemplares: {0}", livro.qtdeExemplares());
                        Console.WriteLine("Quantidade disponível: {0}", livro.qtdeDisponiveis());
                        Console.WriteLine("Quantidade de empréstimos: {0}", livro.qtdeEmprestimos());
                        Console.WriteLine("Percentual de disponibilidade: {0}", livro.percDisponibilidade());

                        foreach(Exemplar ex in livro.Exemplares)
                        {
                            Console.WriteLine("Exemplar: {0}", ex.Tombo);
                            foreach(Emprestimo emp in ex.Emprestimos)
                            {
                                Console.WriteLine("Data de emprestimo: {0}. Data de devolucao: {1}.", emp.DtEmprestimo, emp.DtDevolucao);
                            }
                        }
                        break;
                    case 4:

                        Console.Write("Insira o isbn do livro a ser pesquisado: ");
                        isbn = int.Parse(Console.ReadLine());
                        Console.Write("Insira o título do livro: ");
                        titulo = Console.ReadLine();
                        Console.Write("Insira o autor do livro: ");
                        autor = Console.ReadLine();
                        Console.Write("Insira a editora do livro: ");
                        editora = Console.ReadLine();

                        Console.Write("Insira o tombo do livro: ");
                        tombo = int.Parse(Console.ReadLine());
                        exemplar = new Exemplar(tombo);

                        livro = new Livro(isbn, titulo, autor, editora);                       

                        livro = listLivros.pesquisar(livro);

                        livro.adicionarExemplar(exemplar);


                        break;
                    case 5:

                        Console.Write("Insira o isbn do livro: ");
                        isbn = int.Parse(Console.ReadLine());
                        Console.Write("Insira o título do livro: ");
                        titulo = Console.ReadLine();
                        Console.Write("Insira o autor do livro: ");
                        autor = Console.ReadLine();
                        Console.Write("Insira a editora do livro: ");
                        editora = Console.ReadLine();

                        Console.Write("Insira o tombo do livro: ");
                        tombo = int.Parse(Console.ReadLine());
                        exemplar = new Exemplar(tombo);

                        livro = new Livro(isbn, titulo, autor, editora);

                        livro = listLivros.pesquisar(livro);

                        exemplar = livro.Exemplares.Find(ex => ex.Tombo == tombo);
                        exemplar.emprestar();

                        break;
                    case 6:

                        Console.Write("Insira o isbn do livro: ");
                        isbn = int.Parse(Console.ReadLine());
                        Console.Write("Insira o título do livro: ");
                        titulo = Console.ReadLine();
                        Console.Write("Insira o autor do livro: ");
                        autor = Console.ReadLine();
                        Console.Write("Insira a editora do livro: ");
                        editora = Console.ReadLine();

                        Console.Write("Insira o tombo do livro: ");
                        tombo = int.Parse(Console.ReadLine());
                        exemplar = new Exemplar(tombo);

                        livro = new Livro(isbn, titulo, autor, editora);

                        livro = listLivros.pesquisar(livro);

                        exemplar = livro.Exemplares.Find(ex => ex.Tombo == tombo);
                        exemplar.devolver() ;
                        break;
                }
            }
        }
    }
}
