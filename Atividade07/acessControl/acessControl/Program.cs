using System;

namespace acessControl
{
    class Program
    {
        static void Main(string[] args)
        {

            Cadastro cadastro = new Cadastro();

            cadastro.download();

            int userId, ambienteId;
            string userName, ambiente;

            Ambiente amb;
            Usuario user;

            Usuario a = new Usuario(1, "a");
            Usuario b = new Usuario(2, "b");
            Usuario c = new Usuario(3, "c");
            cadastro.adicionarUsuario(a);
            cadastro.adicionarUsuario(b);
            cadastro.adicionarUsuario(c);

            Ambiente sala = new Ambiente(1, "sala");
            Ambiente quarto = new Ambiente(2, "quarto");

            cadastro.adicionarAmbiente(sala);
            cadastro.adicionarAmbiente(quarto);

            int escolha = 1;
            while (escolha != 0)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine("0. Sair");
                Console.WriteLine("1. Cadastrar ambiente");
                Console.WriteLine("2. Consultar ambiente");
                Console.WriteLine("3. Excluir ambiente");
                Console.WriteLine("4. Cadastrar usuario");
                Console.WriteLine("5. Consultar usuario ");
                Console.WriteLine("6. Excluir usuario");
                Console.WriteLine("7. Conceder permissão de acesso ao usuario (informar ambiente e usuário - vincular ambiente ao usuário)");
                Console.WriteLine("8. Revogar permissão de acesso ao usuario (informar ambiente e usuário - desvincular ambiente do usuário)");
                Console.WriteLine("9. Registrar acesso (informar o ambiente e o usuário - registrar o log respectivo");
                Console.WriteLine("10. Consultar logs de acesso (informar o ambiente e listar os logs - filtrar por logs autorizados / negados / todos)");
                Console.Write("Escoha: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("Qntd de ambientes: {0}", cadastro.Ambientes.Count);
                        Console.Write("Insira o id do ambiente: ");
                        ambienteId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do ambiente: ");
                        ambiente = Console.ReadLine();

                        amb = new Ambiente(ambienteId, ambiente);
                        cadastro.adicionarAmbiente(amb);
                        Console.WriteLine("Qntd de ambientes: {0}", cadastro.Ambientes.Count);

                        break;

                    case 2:
                        Console.Write("Insira o id do ambiente a ser consultado: ");
                        ambienteId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do ambiente a ser consultado: ");
                        ambiente = Console.ReadLine();

                        amb = new Ambiente(ambienteId, ambiente);
                        Console.WriteLine("Pesquisando: id={0} - nome={1}.", amb.Id, amb.Nome);
                        amb = cadastro.pesquisarAmbiente(amb);
                        if (amb.Id == -1){
                            Console.WriteLine("Resultado: não encontrado.");
                        } else { Console.WriteLine("Resultado: id={0} - nome={1}.", amb.Id, amb.Nome); }
                                          
                        break;

                    case 3:
                        Console.WriteLine("Qntd de ambientes: {0}", cadastro.Ambientes.Count);
                        Console.Write("Insira o id do ambiente a ser excluido: ");
                        ambienteId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do ambiente a ser excluido: ");
                        ambiente = Console.ReadLine();

                        amb = new Ambiente(ambienteId, ambiente);
                        Console.WriteLine(cadastro.removerAmbiente(amb));
                        Console.WriteLine("Qntd de ambientes: {0}", cadastro.Ambientes.Count);
                        break;

                    case 4:
                        Console.WriteLine("Qntd de usuarios: {0}", cadastro.Usuarios.Count);
                        Console.Write("Insira o id do usuario: ");
                        userId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do usuario: ");
                        userName = Console.ReadLine();

                        user = new Usuario(userId, userName);

                        cadastro.adicionarUsuario(user);
                        Console.WriteLine("Qntd de usuarios: {0}", cadastro.Usuarios.Count);

                        break;

                    case 5:
                        Console.Write("Insira o id do usuario a ser consultado: ");
                        userId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do usuario a ser consultado: ");
                        userName = Console.ReadLine();

                        user = new Usuario(userId, userName);

                        Console.WriteLine("Pesquisando: id={0} - nome={1}.", user.Id, user.Name);
                        user = cadastro.pesquisarUsuario(user);
                        if (user.Id == -1)
                        {
                            Console.WriteLine("Resultado: não encontrado.");
                        }
                        else { Console.WriteLine("Resultado: id={0} - nome={1}.", user.Id, user.Name); }
                        break;

                    case 6:
                        Console.WriteLine("Qntd de usuarios: {0}", cadastro.Usuarios.Count);
                        Console.Write("Insira o id do usuario a ser excluido: ");
                        userId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do usuario a ser excluido: ");
                        userName = Console.ReadLine();

                        user = new Usuario(userId, userName);
                        Console.WriteLine(cadastro.removerUsuario(user));
                        Console.WriteLine("Qntd de usuarios: {0}", cadastro.Usuarios.Count);
                        break;
                    case 7:

                        Console.Write("Insira o id do usuario: ");
                        userId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do usuario: ");
                        userName = Console.ReadLine();

                        user = new Usuario(userId, userName);

                        Console.Write("Insira o id do ambiente: ");
                        ambienteId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do ambiente: ");
                        ambiente = Console.ReadLine();

                        amb = new Ambiente(ambienteId, ambiente);
                        
                        Console.WriteLine(cadastro.pesquisarUsuario(user).Ambientes.Count);
                        Console.WriteLine(cadastro.pesquisarUsuario(user).concederPermissao(cadastro.pesquisarAmbiente(amb)));
                        Console.WriteLine(cadastro.pesquisarUsuario(user).Ambientes.Count);

                        break;
                    case 8:
                        Console.Write("Insira o id do usuario: ");
                        userId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do usuario: ");
                        userName = Console.ReadLine();

                        user = new Usuario(userId, userName);

                        Console.Write("Insira o id do ambiente: ");
                        ambienteId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do ambiente: ");
                        ambiente = Console.ReadLine();

                        amb = new Ambiente(ambienteId, ambiente);

                        Console.WriteLine(cadastro.pesquisarUsuario(user).revogarPermissao(cadastro.pesquisarAmbiente(amb)));
                        break;
                    case 9:
                        Console.Write("Insira o id do usuario: ");
                        userId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do usuario: ");
                        userName = Console.ReadLine();

                        user = new Usuario(userId, userName);

                        Console.Write("Insira o id do ambiente: ");
                        ambienteId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o nome do ambiente: ");
                        ambiente = Console.ReadLine();

                        amb = new Ambiente(ambienteId, ambiente);

                        Console.WriteLine("Insira o status do acesso: ");
                        Console.WriteLine("1. Autorizado ");
                        Console.WriteLine("2. Negado ");
                        int acesstp = int.Parse(Console.ReadLine());



                        Log log = new Log(user, (acesstp == 1 ? true : false));

                        cadastro.pesquisarAmbiente(amb).registrarLog(log);


                        break;
                    case 10:
                        Console.WriteLine(cadastro.Ambientes.Count);
                        foreach (Ambiente am in cadastro.Ambientes)
                        {
                            Console.WriteLine(am.Nome);
                            foreach (Log l in am.Logs)
                            {
                                Console.WriteLine(l.DtAcesso + " - " + l.Usuario.Name + " - " + (l.TipoAcesso == true ? "Autorizado" : "Negado"));
                            }
                        }
                        break;
                }
            }

            if (escolha == 0)
            {
                cadastro.upload();
            }

        }
    }
}
