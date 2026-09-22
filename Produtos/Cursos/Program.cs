using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Curso> cursos = new List<Curso>();

        int opcao = 0;

        while (opcao != 3)
        {
            Console.WriteLine("===== CADASTRO DE CURSOS =====");
            Console.WriteLine("1 - Cadastrar curso");
            Console.WriteLine("2 - Listar cursos");
            Console.WriteLine("3 - Sair");
            Console.WriteLine("4 - Ver cursos disponíveis");

            Console.Write("Escolha uma opcao: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Curso c = new Curso();

                Console.Write("Digite o nome do curso: ");
                c.Nome = Console.ReadLine();

                Console.Write("Digite a carga horaria: ");
                c.CargaHoraria = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do professor: ");
                c.Professor = Console.ReadLine();

                Console.Write("Digite a modalidade: ");
                c.Modalidade = Console.ReadLine();

                Console.Write("Digite a quantidade de vagas: ");
                c.QuantidadeVagas = int.Parse(Console.ReadLine());

                cursos.Add(c);

                Console.WriteLine("Curso cadastrado com sucesso!");
            }
            else if (opcao == 2)
            {
                Console.WriteLine("===== CURSOS CADASTRADOS =====");

                if (cursos.Count == 0)
                {
                    Console.WriteLine("Nenhum curso cadastrado.");
                }

                foreach (Curso c in cursos)
                {
                    c.MostrarCurso();
                }
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Sistema encerrado!");
            }
            else if (opcao == 4)
            {
                Console.WriteLine("===== CURSOS DISPONIVEIS =====");

                bool encontrado = false;

                foreach (Curso c in cursos)
                {
                    if (c.QuantidadeVagas > 0)
                    {
                        c.MostrarCurso();

                        encontrado = true;
                    }
                }

                if (encontrado == false)
                {
                    Console.WriteLine("Nenhum curso com vagas disponíveis.");
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