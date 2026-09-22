using System;

class Produto
{
    public string Nome;
    public string Categoria;
    public double Preco;
    public int Quantidade;

    public void MostrarProduto()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Categoria: " + Categoria);
        Console.WriteLine("Preço: R$ " + Preco);
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Valor total em estoque: R$ " + (Preco * Quantidade));
        Console.WriteLine("--------------------------");
    }
}