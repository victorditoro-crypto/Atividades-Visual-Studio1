using System;

class Livro
{
    public string Titulo;
    public string Autor;
    public int Ano;
    public string Categoria;
    public bool Disponivel;

    public void MostrarLivro()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Categoria: " + Categoria);

        if (Disponivel == true)
        {
            Console.WriteLine("Status: DISPONÍVEL");
        }
        else
        {
            Console.WriteLine("Status: EMPRESTADO");
        }

        Console.WriteLine("--------------------------");
    }
}