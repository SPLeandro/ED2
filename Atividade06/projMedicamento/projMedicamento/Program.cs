using System;

namespace projMedicamento
{
    class Program
    {
        static void Main(string[] args)
        {

            int escolha = 1;
            int medId, id, qtde, dia, mes, ano;
            string medNome, medLaboratorio;

            Medicamentos meds = new Medicamentos();

            Medicamento dipirona = new Medicamento(1, "dipirona", "panvel");
            Medicamento coronaVac = new Medicamento(2, "CoronaVac", "butãtã");

            for (int i = 1; i < 6; i++)
            {
                Lote newlote = new Lote(i, i * 15, DateTime.Now);
                dipirona.comprar(newlote);
            }

            meds.adicionar(dipirona);
            meds.adicionar(coronaVac);


            Medicamento med;

            while (escolha != 0)
            {
                Console.WriteLine("\n--------------------------------------------------------------");
                Console.WriteLine("0. Finalizar processo");
                Console.WriteLine("1. Cadastrar medicamento");
                Console.WriteLine("2. Consultar medicamento (sintético: informar dados1)");
                Console.WriteLine("3. Consultar medicamento (analítico: informar dados1 + lotes2)");
                Console.WriteLine("4. Comprar medicamento (cadastrar lote)");
                Console.WriteLine("5. Vender medicamento (abater do lote mais antigo) ");
                Console.WriteLine("6. Listar medicamentos (informando dados sintéticos)");
                Console.Write("Escolhido: ");
                escolha = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (escolha)
                {
                    case 0:
                        break;
                    case 1:
                        Console.Write("Insira o id do medicamento: ");
                        medId = int.Parse(Console.ReadLine());

                        Console.Write("Insira o nome do medicamento: ");
                        medNome = Console.ReadLine();

                        Console.Write("Insira o nome do laboratorio do medicamento: ");
                        medLaboratorio = Console.ReadLine();

                        med = new Medicamento(medId, medNome, medLaboratorio);
                        meds.adicionar(med);
                        break;

                    case 2:
                        Console.Write("Insira o id do medicamento a ser pesquisado: ");
                        medId = int.Parse(Console.ReadLine());
                        med = new Medicamento(medId, "", "");

                        Console.WriteLine(meds.pesquisar(med).toString());

                        break;
                    case 3:
                        Console.Write("Insira o id do medicamento a ser pesquisado: ");
                        medId = int.Parse(Console.ReadLine());
                        med = new Medicamento(medId, "", "");

                        if (meds.pesquisar(med).Id != 0)
                        {
                            Console.WriteLine(meds.pesquisar(med).toString());

                            foreach (Lote l in meds.pesquisar(med).Lotes)
                            {
                                Console.WriteLine(l.toString());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Não há medicamento com este ID!");
                        }

                        break;


                    case 4:

                        Console.Write("Insira o id do medicamento: ");
                        medId = int.Parse(Console.ReadLine());

                        med = new Medicamento(medId, "", "");

                        if (meds.pesquisar(med).Id == medId)
                        {
                            Console.Write("Insira o id do lote: ");
                            id = int.Parse(Console.ReadLine());

                            Console.Write("Insira a qtde no lote: ");
                            qtde = int.Parse(Console.ReadLine());

                            Console.Write("Insira o dia da data de vencimento do lote: ");
                            dia = int.Parse(Console.ReadLine());

                            Console.Write("Insira o mes da data de vencimento do lote: ");
                            mes = int.Parse(Console.ReadLine());

                            Console.Write("Insira o ano da data de vencimento do lote: ");
                            ano = int.Parse(Console.ReadLine());

                            Lote newlote = new Lote(id, qtde, new DateTime(ano, mes, dia));
                            meds.ListaMedicamentos.Find(m => m.Id == medId).comprar(newlote);
                        }

                        break;
                    case 5:
                        Console.Write("Insira o nome do medicamento a ser vendido: ");
                        medNome = Console.ReadLine();

                        Console.Write("Insira a qtde a ser vendida: ");
                        qtde = int.Parse(Console.ReadLine());

                        Console.WriteLine(meds.ListaMedicamentos.Find(md => md.Nome == medNome).vender(qtde) == true ? "Vendido" : "Não há quantidades suficientes disponível!");
                        break;
                    case 6:
                        foreach (Medicamento md in meds.ListaMedicamentos)
                        {
                            Console.WriteLine(md.toString());
                        }
                        break;
                }

            }

        }
    }
}
