Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Livro> livros = new List<Livro>();

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("===== CADASTRO DE LIVROS =====");
            Console.WriteLine("1 - Cadastrar livro");
            Console.WriteLine("2 - Listar livros");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Livro l = new Livro();

                Console.Write("Digite o título do livro: ");
                l.Titulo = Console.ReadLine();

                Console.Write("Digite o autor: ");
                l.Autor = Console.ReadLine();

                Console.Write("Digite o ano: ");
                l.Ano = int.Parse(Console.ReadLine());

                Console.Write("Digite a categoria: ");
                l.Categoria = Console.ReadLine();

                Console.Write("O livro está disponível? (true/false): ");
                l.Disponivel = bool.Parse(Console.ReadLine());

                livros.Add(l);

                Console.WriteLine("Livro cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== LIVROS CADASTRADOS =====");

                if (livros.Count == 0)
                {
                    Console.WriteLine("Nenhum livro cadastrado.");
                }

                foreach (Livro l in livros)
                {
                    l.MostrarLivro();
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