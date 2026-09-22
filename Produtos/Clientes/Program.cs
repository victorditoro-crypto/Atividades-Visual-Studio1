using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Cliente> clientes = new List<Cliente>();

        int opcao = 0;

        while (opcao != 4)
        {
            Console.WriteLine("===== CADASTRO DE CLIENTES =====");
            Console.WriteLine("1 - Cadastrar cliente");
            Console.WriteLine("2 - Listar clientes");
            Console.WriteLine("3 - Pesquisar cliente");
            Console.WriteLine("4 - Sair");

            Console.Write("Escolha uma opcao: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Cliente c = new Cliente();

                Console.Write("Digite o nome: ");
                c.Nome = Console.ReadLine();

                Console.Write("Digite a idade: ");
                c.Idade = int.Parse(Console.ReadLine());

                Console.Write("Digite a cidade: ");
                c.Cidade = Console.ReadLine();

                Console.Write("Digite o email: ");
                c.Email = Console.ReadLine();

                Console.Write("Digite o telefone: ");
                c.Telefone = Console.ReadLine();

                clientes.Add(c);

                Console.WriteLine("Cliente cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== CLIENTES CADASTRADOS =====");

                if (clientes.Count == 0)
                {
                    Console.WriteLine("Nenhum cliente cadastrado.");
                }

                foreach (Cliente c in clientes)
                {
                    c.ApresentarCliente();
                }
            }
            else if (opcao == 3)
            {
                Console.Write("Digite o nome do cliente: ");
                string pesquisa = Console.ReadLine().ToLower();

                bool encontrado = false;

                foreach (Cliente c in clientes)
                {
                    if (c.Nome.ToLower().Contains(pesquisa))
                    {
                        c.ApresentarCliente();

                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Cliente nao encontrado.");
                }
            }
            else if (opcao == 4)
            {
                Console.WriteLine("Sistema encerrado!");
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