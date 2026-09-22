using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Veiculo> veiculos = new List<Veiculo>();

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("===== CADASTRO DE VEICULOS =====");
            Console.WriteLine("1 - Cadastrar veiculo");
            Console.WriteLine("2 - Listar veiculos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("4 - Pesquisar veiculo");

            Console.Write("Escolha uma opcao: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Veiculo v = new Veiculo();

                Console.Write("Digite a marca: ");
                v.Marca = Console.ReadLine();

                Console.Write("Digite o modelo: ");
                v.Modelo = Console.ReadLine();

                Console.Write("Digite o ano: ");
                v.Ano = int.Parse(Console.ReadLine());

                Console.Write("Digite a cor: ");
                v.Cor = Console.ReadLine();

                Console.Write("Digite a placa: ");
                v.Placa = Console.ReadLine();

                veiculos.Add(v);

                Console.WriteLine("Veiculo cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== VEICULOS CADASTRADOS =====");

                if (veiculos.Count == 0)
                {
                    Console.WriteLine("Nenhum veiculo cadastrado.");
                }

                foreach (Veiculo v in veiculos)
                {
                    v.MostrarVeiculo();
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Sistema encerrado!");
            }
            else if (opcao == 4)
            {
                Console.Write("Digite a marca ou modelo para pesquisar: ");
                string pesquisa = Console.ReadLine().ToLower();

                bool encontrado = false;

                foreach (Veiculo v in veiculos)
                {
                    if (v.Marca.ToLower().Contains(pesquisa) ||
                        v.Modelo.ToLower().Contains(pesquisa))
                    {
                        v.MostrarVeiculo();
                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Nenhum veiculo encontrado.");
                }
            }
            else
            {
                Console.WriteLine("Opcao invalida!");
            }

            if (opcao != 3)
            {
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}