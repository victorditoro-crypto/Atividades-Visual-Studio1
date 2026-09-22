using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Equipamento> equipamentos = new List<Equipamento>();

        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("===== CADASTRO DE EQUIPAMENTOS =====");
            Console.WriteLine("1 - Cadastrar equipamento");
            Console.WriteLine("2 - Listar equipamentos");
            Console.WriteLine("3 - Pesquisar equipamento");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("5 - Equipamentos em manutencao");

            Console.Write("Escolha uma opcao: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Equipamento e = new Equipamento();

                Console.Write("Digite o patrimonio: ");
                e.Patrimonio = Console.ReadLine();

                Console.Write("Digite o tipo: ");
                e.Tipo = Console.ReadLine();

                Console.Write("Digite a marca: ");
                e.Marca = Console.ReadLine();

                Console.Write("Digite o modelo: ");
                e.Modelo = Console.ReadLine();

                Console.Write("Digite o numero de serie: ");
                e.NumeroSerie = Console.ReadLine();

                Console.WriteLine("Status:");
                Console.WriteLine("Disponivel");
                Console.WriteLine("Em uso");
                Console.WriteLine("Manutencao");

                Console.Write("Digite o status do equipamento: ");
                e.Status = Console.ReadLine();

                equipamentos.Add(e);

                Console.WriteLine("Equipamento cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== EQUIPAMENTOS CADASTRADOS =====");

                if (equipamentos.Count == 0)
                {
                    Console.WriteLine("Nenhum equipamento cadastrado.");
                }

                foreach (Equipamento e in equipamentos)
                {
                    e.MostrarEquipamento();
                }
            }
            else if (opcao == 3)
            {
                Console.Write("Digite o patrimonio para pesquisar: ");
                string pesquisa = Console.ReadLine();

                bool encontrado = false;

                foreach (Equipamento e in equipamentos)
                {
                    if (e.Patrimonio.ToLower().Contains(pesquisa.ToLower()))
                    {
                        e.MostrarEquipamento();
                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Equipamento nao encontrado.");
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Sistema encerrado!");
            }
            else if (opcao == 5)
            {
                Console.WriteLine("===== EQUIPAMENTOS EM MANUTENCAO =====");

                bool encontrado = false;

                foreach (Equipamento e in equipamentos)
                {
                    if (e.Status.ToLower() == "manutenção" ||
                        e.Status.ToLower() == "manutencao")
                    {
                        e.MostrarEquipamento();
                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Nenhum equipamento em manutencao.");
                }
            }
            else
            {
                Console.WriteLine("Opcao invalida!");
            }

            if (opcao != 4)
            {
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}