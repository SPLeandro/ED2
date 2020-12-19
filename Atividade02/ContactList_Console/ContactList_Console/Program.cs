using System;

namespace ContactList_Console
{
    class Program
    {
        static void Main(string[] args)
        {

            Contatos pessoas = new Contatos();

            pessoas.adicionar(new Contato("jorgeeduardo@hotmail.com", "Jorgin", "1542", new Data(12, 09, 2012)));
            pessoas.adicionar(new Contato("pedrocar@gmail.com", "Pedrao", "5123", new Data(04, 11, 1998)));
            pessoas.adicionar(new Contato("leandro@outlook.com", "Leandru", "1398877", new Data(03, 07, 2001)));

            Console.WriteLine(pessoas.pesquisar("paulo@outlook.com").Email != "paulo@outlook.com" ? "Nao encontrado" : "Encontrado");
            Console.WriteLine(pessoas.pesquisar("leandro@outlook.com").Email != "leandro@outlook.com" ? "Nao encontrado" : "Encontrado");


            pessoas.listarContatos();
            Console.WriteLine(pessoas.remover(new Contato("jorgeeduardo@hotmail.com", "Jorgin", "1542", new Data(12, 09, 2012))) ? "Removido" : "Não Encontrado");
            pessoas.listarContatos();
            Console.WriteLine(pessoas.remover(new Contato("pedrocar@gmail.com", "Pedrao", "5123", new Data(04, 11, 1998))) ? "Removido" : "Não Encontrado");
            pessoas.listarContatos();

            int opcao = -1;
            string email, nome, telefone;
            int dia, mes, ano;
            Data dtNasc;

            while (opcao != 0)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("0.Sair");
                Console.WriteLine("1.Adicionar contato");
                Console.WriteLine("2.Pesquisar contato");
                Console.WriteLine("3.Alterar contato");
                Console.WriteLine("4.Remover contato");
                Console.WriteLine("5.Listar contatos");
                Console.Write("Opção escolhida: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        break;

                    case 1:
                        Console.Write("Insira o email: ");
                        email = Console.ReadLine();
                        Console.Write("Insira o nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Insira o telefone : ");
                        telefone = Console.ReadLine();
                        Console.Write("Insira o dia que você nasceu: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Insira o mes que você nasceu: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ano que você nasceu: ");
                        ano = int.Parse(Console.ReadLine());

                        dtNasc = new Data(dia, mes, ano);
                        pessoas.adicionar(new Contato(email, nome, telefone, dtNasc));

                        break;

                    case 2:
                        Console.Write("Insira o email a ser pesquisado: ");
                        email = Console.ReadLine();
                        Console.WriteLine(pessoas.pesquisar(email).Email != email ? "Nao encontrado" : pessoas.pesquisar(email).ToString());
                        break;


                    case 3:
                        Console.Write("Insira o email: ");
                        email = Console.ReadLine();
                        Console.Write("Insira o nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Insira o telefone : ");
                        telefone = Console.ReadLine();
                        Console.Write("Insira o dia que você nasceu: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Insira o mes que você nasceu: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ano que você nasceu: ");
                        ano = int.Parse(Console.ReadLine());

                        dtNasc = new Data(dia, mes, ano);
                        pessoas.alterar(new Contato(email, nome, telefone, dtNasc));

                        break;
                    case 4:
                        Console.Write("Insira o email: ");
                        email = Console.ReadLine();
                        Console.Write("Insira o nome: ");
                        nome = Console.ReadLine();
                        Console.Write("Insira o telefone : ");
                        telefone = Console.ReadLine();
                        Console.Write("Insira o dia que você nasceu: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.Write("Insira o mes que você nasceu: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.Write("Insira o ano que você nasceu: ");
                        ano = int.Parse(Console.ReadLine());

                        dtNasc = new Data(dia, mes, ano);

                        Console.WriteLine(pessoas.remover(new Contato(email, nome, telefone, dtNasc)) ? "Removido" : "Não Encontrado");

                        break;
                    case 5:
                        pessoas.listarContatos();
                        break;
                }
            }
        }
    }
}
