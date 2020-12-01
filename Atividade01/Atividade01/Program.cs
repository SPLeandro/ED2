using System;

namespace Atividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            Vendedores vendedores = new Vendedores(10);
            int escolha = -1;

            while (escolha != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("0.Sair");
                Console.WriteLine("1.Cadastrar vendedor");
                Console.WriteLine("2.Consultar vendedor");
                Console.WriteLine("3.Excluir vendedor");
                Console.WriteLine("4.Registrar venda");
                Console.WriteLine("5.Listar vendedores");
                Console.Write("Opção selecionada: ");
                escolha = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (escolha)
                {
                    case 0:
                    break;

                    case 1:
                        string nome;
                        if (vendedores.Qtde < 10)
                        {
                            Vendedor vendedor = new Vendedor();
                            Console.Write("Digite o nome do vendedor: ");
                            nome = Console.ReadLine();
                            Console.Write("Digite a comissao do vendedor: ");
                            double percComissao = double.Parse(Console.ReadLine());
                            vendedor.Id = vendedores.Qtde;
                            vendedor.Nome = nome;
                            vendedor.PercComissao = percComissao;

                            Console.WriteLine(vendedores.addVendedor(vendedor) ? "Vendedor cadastrado!" : "Vendedor não cadastrado!");

                        }
                        else
                        {
                            Console.WriteLine("O número de funcionário já está no máximo!");
                        }

                    break;

                    case 2:

                        Console.Write("Digite o nome do vendedor: ");
                        nome = Console.ReadLine();
                        Vendedor vendedorAchado = vendedores.searchVendedor(nome);
                        if (vendedorAchado.Id == -1)
                        {
                            Console.WriteLine("Vendedor não encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("ID: " + vendedorAchado.Id);
                            Console.WriteLine("NOME: " + vendedorAchado.Nome);
                            Console.WriteLine("VALOR DA COMISSÃO(%): " + vendedorAchado.PercComissao);
                            Console.WriteLine("VALOR TOTAL VENDAS: " + vendedorAchado.valorVendas());
                            Console.WriteLine("VALOR TOTAL COMISSÂO: " + vendedorAchado.valorComissao());

                            int dia = 0;
                            foreach (Venda v in vendedorAchado.AsVendas)
                            {
                                dia++;
                                if (v.Qtde > 0)
                                {
                                    Console.WriteLine("Valor Médio de venda do dia " + dia + " foi: " + v.valorMedio());
                                }
                            }
                            dia = 0;
                        }

                    break;

                    case 3:

                        bool permissao = true;
                        Console.Write("Digite o nome do vendedor: ");
                        nome = Console.ReadLine();
                        Vendedor vendedorEncontrado = vendedores.searchVendedor(nome);

                        if (vendedorEncontrado.Id == -1)
                        {
                            Console.WriteLine("Vendedor não encontrado.");
                        }
                        else
                        {
                            foreach (Venda v in vendedorEncontrado.AsVendas)
                            {
                                if (v.Qtde > 0)
                                {
                                    permissao = false;
                                }
                            }

                            if (permissao)
                            {
                                Console.WriteLine(vendedores.delVendedor(vendedorEncontrado) ? "O vendedor foi deletado." : "Vendedor não encontrado!");
                            }
                            else
                            {
                                Console.WriteLine("O vendedor possui alguma venda, portanto não pode ser deletado.");
                            }
                        }

                    break;

                    case 4:

                        Console.Write("Digite o nome do vendedor: ");
                        nome = Console.ReadLine();

                        vendedorEncontrado = vendedores.searchVendedor(nome);
                        if (vendedorEncontrado.Id == -1)
                        {
                            Console.WriteLine("Vendedor não encontrado!");
                        }
                        else
                        {
                            Console.WriteLine("0. Sair");
                            Console.WriteLine("1. Cadastrar uma Venda");
                            int novaVenda = int.Parse(Console.ReadLine());
                            while (novaVenda != 0)
                            {
                                if (novaVenda == 1)
                                {
                                    int dia = -1;
                                    while (dia < 1 || dia >31)
                                    {
                                        Console.Write("Insira o dia:");
                                        dia = int.Parse(Console.ReadLine());
                                    }                                       

                                    Console.Write("Insira a quantidade:");
                                    int qtd = int.Parse(Console.ReadLine());

                                    Console.Write("Insira o valor:");
                                    double valor = double.Parse(Console.ReadLine());

                                    vendedorEncontrado.registrarVenda(dia, new Venda(qtd, valor));

                                }
                                Console.WriteLine("0. Sair");
                                Console.WriteLine("1. Cadastrar uma Venda");
                                novaVenda = int.Parse(Console.ReadLine());
                            }
                        }

                        break;


                    case 5:

                        double totalValor = 0;
                        double totalComissao = 0;

                        foreach (Vendedor v in vendedores.OsVendedores)
                        {
                            if (v.Id != -1)
                            {
                                Console.WriteLine("ID: " + v.Id);
                                Console.WriteLine("NOME: " + v.Nome);

                                Console.WriteLine("VALOR TOTAL DAS VENDAS: " + v.valorVendas());
                                Console.WriteLine("VALOR DA COMISSÂO: " + v.valorComissao());

                                totalValor += v.valorVendas();
                                totalComissao += v.valorComissao();
                            }
                            
                        }

                        Console.WriteLine("O total do Valor de Vendas foi: " + totalValor);
                        Console.WriteLine("O total do Valor das Comissões foram: " + totalComissao);

                        break;

                }               
            }
        }
    }
}
