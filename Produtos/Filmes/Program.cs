using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Filme> filmes = new List<Filme>();

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("===== CADASTRO DE FILMES =====");
            Console.WriteLine("1 - Cadastrar filme");
            Console.WriteLine("2 - Listar filmes");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opcao: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Filme f = new Filme();

                Console.Write("Digite o título do filme: ");
                f.Titulo = Console.ReadLine();

                Console.Write("Digite o gênero: ");
                f.Genero = Console.ReadLine();

                Console.Write("Digite o ano: ");
                f.Ano = int.Parse(Console.ReadLine());

                Console.Write("Digite a duração em minutos: ");
                f.Duracao = int.Parse(Console.ReadLine());

                Console.Write("Digite a nota do filme: ");
                f.Nota = double.Parse(Console.ReadLine());

                filmes.Add(f);

                Console.WriteLine("Filme cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== FILMES CADASTRADOS =====");

                if (filmes.Count == 0)
                {
                    Console.WriteLine("Nenhum filme cadastrado.");
                }

                foreach (Filme f in filmes)
                {
                    f.ExibirInformacoes();
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Sistema encerrado!");
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