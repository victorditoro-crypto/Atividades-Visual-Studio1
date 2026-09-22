using System;

class Jogo
{
    public string Nome;
    public string Genero;
    public string Plataforma;
    public int Ano;
    public double Nota;

    public void MostrarJogo()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Gênero: " + Genero);
        Console.WriteLine("Plataforma: " + Plataforma);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Nota: " + Nota);
        Console.WriteLine("-----------------------------");
    }
}