using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Pedido> pedidos = new List<Pedido>();

        int opcao = 0;
        int numeroPedido = 1;

        while (opcao != 3)
        {
            Console.WriteLine("===== CADASTRO DE PEDIDOS =====");
            Console.WriteLine("1 - Cadastrar pedido");
            Console.WriteLine("2 - Listar pedidos");
            Console.WriteLine("3 - Sair");

            Console.Write("Escolha uma opcao: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Pedido p = new Pedido();

                p.Numero = numeroPedido;

                Console.Write("Digite o nome do cliente: ");
                p.Cliente = Console.ReadLine();

                Console.Write("Digite o nome do produto: ");
                p.Produto = Console.ReadLine();

                Console.Write("Digite a quantidade: ");
                p.Quantidade = int.Parse(Console.ReadLine());

                Console.Write("Digite o valor unitario: ");
                p.ValorUnitario = double.Parse(Console.ReadLine());

                pedidos.Add(p);

                numeroPedido++;

                Console.WriteLine("Pedido cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== PEDIDOS CADASTRADOS =====");

                if (pedidos.Count == 0)
                {
                    Console.WriteLine("Nenhum pedido cadastrado.");
                }

                foreach (Pedido p in pedidos)
                {
                    p.MostrarPedido();
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