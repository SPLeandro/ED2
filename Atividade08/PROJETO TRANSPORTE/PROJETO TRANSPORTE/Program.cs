using System;

namespace PROJETO_TRANSPORTE
{
    class Program
    {
        static void Main(string[] args)
        {
            int escolha = 1;

            int veicId, veicLota;
            string veicPlaca;
            Veiculo veiculo;

            Veiculos veiculos = new Veiculos();

            int garId;
            string garLocal;

            Garagem garagem, garDest;
            Garagens garagens = new Garagens();

            int garIdDestino, viagId;
            string garLocalDestino;

            Viagem viagem;
            Viagens viagens = new Viagens();

        

            for(int i = 1; i < 3; i++)
            {
                garagem = new Garagem(i, "local" + i.ToString());
                garagens.incluir(garagem);
            }
    
            for (int i = 1; i <9; i++)
            {
                veiculo = new Veiculo(i, "ABC" + i.ToString(), 0);
                veiculos.incluir(veiculo);
            }

            while (escolha != 0)
            {
                Console.WriteLine("1. Cadastrar veículo");
                Console.WriteLine("2. Cadastrar garagem");
                Console.WriteLine("3. Iniciar jornada");
                Console.WriteLine("4. Encerrar jornada");
                Console.WriteLine("5. Liberar viagem de uma determinada origem para um determinado destino");
                Console.WriteLine("6. Listar veículos em determinada garagem (informando a qtde de veículos e seu potencial de transporte)");
                Console.WriteLine("7. Informar qtde de viagens efetuadas de uma determinada origem para um determinado destino");
                Console.WriteLine("8. Listar viagens efetuadas de uma determinada origem para um determinado destino");
                Console.WriteLine("9. Informar qtde de passageiros transportados de uma determinada origem para um determinado destino");
                Console.Write("Escolha: ");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.Write("Insira o Id do veiculo: ");
                        veicId = int.Parse(Console.ReadLine());
                        Console.Write("Insira a placa do veiculo: ");
                        veicPlaca = Console.ReadLine();
                        Console.Write("Insira a lotacao do veiculo: ");
                        veicLota= int.Parse(Console.ReadLine());

                        veiculo = new Veiculo(veicId, veicPlaca, veicLota);
                        veiculos.incluir(veiculo);

                        break;
                    case 2:
                        Console.Write("Insira o Id da Garagem: ");
                        garId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem: ");
                        garLocal = Console.ReadLine();

                        garagem = new Garagem(garId, garLocal);
                        garagens.incluir(garagem);

                        break;
                    case 3:
                        garagens.iniciarJornada(veiculos);

                        garagens.GaragensList.ForEach(g =>
                        {
                            Console.WriteLine(g.Veiculos.Count);
                        });

                        break;
                    case 4:
                        
                        Transporte listaTrans = new List<Transporte>;

                        listaTrans = garagens.encerrarJornada();

                        foreach (Transporte t in listaTrans){
                            Console.WriteLine("Veiculo: {0}, Qntd transportada: {1}.", t.Veiculo.Placa, t.QtdeTransportada);
                        }


                        break;
                    case 5:
                        Console.Write("Insira o Id do veiculo: ");
                        veicId = int.Parse(Console.ReadLine());
                        Console.Write("Insira a placa do veiculo: ");
                        veicPlaca = Console.ReadLine();
                        Console.Write("Insira a lotacao do veiculo: ");
                        veicLota = int.Parse(Console.ReadLine());

                        veiculo = new Veiculo(veicId, veicPlaca, veicLota);

                        Console.Write("Insira o Id da viagem: ");
                        viagId = int.Parse(Console.ReadLine());


                        Console.Write("Insira o Id da Garagem de origem: ");
                        garId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem de origem: ");
                        garLocal = Console.ReadLine();

                        garagem = new Garagem(garId, garLocal);

                        Console.Write("Insira o Id da Garagem de destino: ");
                        garIdDestino = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem de destino: ");
                        garLocalDestino = Console.ReadLine();

                        garDest = new Garagem(garIdDestino, garLocalDestino);

                        viagem = new Viagem(viagId, garagem, garDest, veiculo);

                        break;
                    case 6:

                        Console.Write("Insira o Id da Garagem que deseja visualizar: ");
                        garId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem que deseja visualizar: ");
                        garLocal = Console.ReadLine();

                        garagem = garagens.GaragensList.Find(g => g.Id == garId && g.Local == garLocal);

                        foreach(Veiculo v in garagem.Veiculos)
                        {
                            Console.WriteLine("Veiculo: {0}, Lotacao: {1}", v.Placa, v.Lotacao);
                        }
                        break;

                    case 7:

                        Console.Write("Insira o Id da Garagem de origem: ");
                        garId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem de origem: ");
                        garLocal = Console.ReadLine();

                        garagem = new Garagem(garId, garLocal);

                        Console.Write("Insira o Id da Garagem de destino: ");
                        garIdDestino = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem de destino: ");
                        garLocalDestino = Console.ReadLine();

                        garDest = new Garagem(garIdDestino, garLocalDestino);

                        int qntdViagens = 0;

                        foreach(Viagem v in viagens.ViagensQueue)
                        {
                            if(v.Origem == garagem)
                            {
                                if (v.Destino == garDest)
                                {
                                    qntdViagens++;
                                }
                            }
                        }

                        Console.WriteLine("Quantidade de viagens: {0}.", qntdViagens);

                        break;
                    case 8:

                        Console.Write("Insira o Id da Garagem de origem: ");
                        garId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem de origem: ");
                        garLocal = Console.ReadLine();

                        garagem = new Garagem(garId, garLocal);

                        Console.Write("Insira o Id da Garagem de destino: ");
                        garIdDestino = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem de destino: ");
                        garLocalDestino = Console.ReadLine();

                        garDest = new Garagem(garIdDestino, garLocalDestino);

                        foreach (Viagem v in viagens.ViagensQueue)
                        {
                            if (v.Origem == garagem)
                            {
                                if (v.Destino == garDest)
                                {
                                    Console.WriteLine("Id: {0}, Origem: {1}, Destino: {2}, Veiculo: {3}.", v.Id, v.Origem.Local, v.Destino.Local, v.Veiculo.Placa);
                                }
                            }
                        }

                        break;
                    case 9:

                        Console.Write("Insira o Id da Garagem de origem: ");
                        garId = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem de origem: ");
                        garLocal = Console.ReadLine();

                        garagem = new Garagem(garId, garLocal);

                        Console.Write("Insira o Id da Garagem de destino: ");
                        garIdDestino = int.Parse(Console.ReadLine());
                        Console.Write("Insira o local da Garagem de destino: ");
                        garLocalDestino = Console.ReadLine();

                        garDest = new Garagem(garIdDestino, garLocalDestino);

                        int qtdeTransportado = 0; 

                        foreach (Viagem v in viagens.ViagensQueue)
                        {
                            if (v.Origem == garagem)
                            {
                                if (v.Destino == garDest)
                                {
                                    qtdeTransportado += v.Veiculo.Lotacao;
                                }
                            }
                        }
                        Console.WriteLine("Quantidade de passageiros transportados: {0}.", qtdeTransportado);

                        break;
                }
            }




        }
    }
}
