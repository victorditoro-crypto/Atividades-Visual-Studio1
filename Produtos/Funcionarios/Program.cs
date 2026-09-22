using Produtos.Funcionarios;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Funcionario> funcionarios = new List<Funcionario>();

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("===== CADASTRO DE FUNCIONARIOS =====");
            Console.WriteLine("1 - Cadastrar funcionario");
            Console.WriteLine("2 - Listar funcionarios");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opcao: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Funcionario f = new Funcionario();

                Console.Write("Digite o nome: ");
                f.Nome = Console.ReadLine();

                Console.Write("Digite a idade: ");
                f.Idade = int.Parse(Console.ReadLine());

                Console.Write("Digite o cargo: ");
                f.Cargo = Console.ReadLine();

                Console.Write("Digite o salario: ");
                f.Salario = double.Parse(Console.ReadLine());

                Console.Write("Digite o setor: ");
                f.Setor = Console.ReadLine();

                funcionarios.Add(f);

                Console.WriteLine("Funcionario cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== FUNCIONARIOS CADASTRADOS =====");

                if (funcionarios.Count == 0)
                {
                    Console.WriteLine("Nenhum funcionario cadastrado.");
                }

                foreach (Funcionario f in funcionarios)
                {
                    f.Apresentar();
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