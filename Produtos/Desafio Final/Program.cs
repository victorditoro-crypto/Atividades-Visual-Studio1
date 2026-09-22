using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Jogo> jogos = new List<Jogo>();

        int opcao = 0;

        while (opcao != 7)
        {
            Console.WriteLine("================================");
            Console.WriteLine("     SISTEMA DE CADASTRO DE JOGOS");
            Console.WriteLine("================================");
            Console.WriteLine("1 - Cadastrar");
            Console.WriteLine("2 - Listar");
            Console.WriteLine("3 - Pesquisar");
            Console.WriteLine("4 - Alterar");
            Console.WriteLine("5 - Excluir");
            Console.WriteLine("6 - Relatório");
            Console.WriteLine("7 - Sair");

            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Jogo j = new Jogo();

                Console.Write("Digite o nome do jogo: ");
                j.Nome = Console.ReadLine();

                Console.Write("Digite o gênero: ");
                j.Genero = Console.ReadLine();

                Console.Write("Digite a plataforma: ");
                j.Plataforma = Console.ReadLine();

                Console.Write("Digite o ano de lançamento: ");
                j.Ano = int.Parse(Console.ReadLine());

                Console.Write("Digite a nota do jogo: ");
                j.Nota = double.Parse(Console.ReadLine());

                jogos.Add(j);

                Console.WriteLine("Jogo cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== JOGOS CADASTRADOS =====");

                if (jogos.Count == 0)
                {
                    Console.WriteLine("Nenhum jogo cadastrado.");
                }

                foreach (Jogo j in jogos)
                {
                    j.MostrarJogo();
                }
            }
            else if (opcao == 3)
            {
                Console.Write("Digite o nome do jogo que deseja pesquisar: ");
                string pesquisa = Console.ReadLine().ToLower();

                bool encontrado = false;

                foreach (Jogo j in jogos)
                {
                    if (j.Nome.ToLower().Contains(pesquisa))
                    {
                        j.MostrarJogo();
                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Jogo não encontrado.");
                }
            }
            else if (opcao == 4)
            {
                Console.Write("Digite o nome do jogo que deseja alterar: ");
                string pesquisa = Console.ReadLine().ToLower();

                bool encontrado = false;

                foreach (Jogo j in jogos)
                {
                    if (j.Nome.ToLower() == pesquisa)
                    {
                        Console.Write("Novo nome: ");
                        j.Nome = Console.ReadLine();

                        Console.Write("Novo gênero: ");
                        j.Genero = Console.ReadLine();

                        Console.Write("Nova plataforma: ");
                        j.Plataforma = Console.ReadLine();

                        Console.Write("Novo ano: ");
                        j.Ano = int.Parse(Console.ReadLine());

                        Console.Write("Nova nota: ");
                        j.Nota = double.Parse(Console.ReadLine());

                        Console.WriteLine("Jogo alterado com sucesso!");

                        encontrado = true;
                        break;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Jogo não encontrado.");
                }
            }
            else if (opcao == 5)
            {
                Console.Write("Digite o nome do jogo que deseja excluir: ");
                string pesquisa = Console.ReadLine().ToLower();

                bool encontrado = false;

                for (int i = 0; i < jogos.Count; i++)
                {
                    if (jogos[i].Nome.ToLower() == pesquisa)
                    {
                        jogos.RemoveAt(i);

                        Console.WriteLine("Jogo excluído com sucesso!");

                        encontrado = true;
                        break;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Jogo não encontrado.");
                }
            }
            else if (opcao == 6)
            {
                Console.WriteLine("===== RELATÓRIO DE JOGOS =====");

                Console.WriteLine("Total de jogos cadastrados: " + jogos.Count);

                if (jogos.Count > 0)
                {
                    double soma = 0;

                    foreach (Jogo j in jogos)
                    {
                        soma = soma + j.Nota;
                    }

                    double media = soma / jogos.Count;

                    Console.WriteLine("Média das notas: " + media.ToString("F2"));
                }
                else
                {
                    Console.WriteLine("Não há jogos para gerar a média.");
                }
            }
            else if (opcao == 7)
            {
                Console.WriteLine("Sistema encerrado!");
            }
            else
            {
                Console.WriteLine("Opção inválida!");
            }

            if (opcao != 7)
            {
                Console.WriteLine();
                Console.WriteLine("Pressione ENTER para continuar...");
                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}