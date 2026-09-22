using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Produto> produtos = new List<Produto>();

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("===== CADASTRO DE PRODUTOS =====");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Produto p = new Produto();

                Console.Write("Digite o nome do produto: ");
                p.Nome = Console.ReadLine();

                Console.Write("Digite a categoria: ");
                p.Categoria = Console.ReadLine();

                Console.Write("Digite o preço: ");
                p.Preco = double.Parse(Console.ReadLine());

                Console.Write("Digite a quantidade: ");
                p.Quantidade = int.Parse(Console.ReadLine());

                produtos.Add(p);

                Console.WriteLine("Produto cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== PRODUTOS CADASTRADOS =====");

                if (produtos.Count == 0)
                {
                    Console.WriteLine("Nenhum produto cadastrado.");
                }

                foreach (Produto p in produtos)
                {
                    p.MostrarProduto();
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Sistema encerrado!");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
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