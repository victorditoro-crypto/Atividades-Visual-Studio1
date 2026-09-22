using System;

class Cliente
{
    public string Nome;
    public int Idade;
    public string Cidade;
    public string Email;
    public string Telefone;

    public void ApresentarCliente()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Idade: " + Idade);
        Console.WriteLine("Cidade: " + Cidade);
        Console.WriteLine("Email: " + Email);
        Console.WriteLine("Telefone: " + Telefone);
        Console.WriteLine("--------------------------");
    }
}