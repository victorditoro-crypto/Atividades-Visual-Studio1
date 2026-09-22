using System;

class Pedido
{
    public int Numero;
    public string Cliente;
    public string Produto;
    public int Quantidade;
    public double ValorUnitario;

    public double CalcularTotal()
    {
        return Quantidade * ValorUnitario;
    }

    public void MostrarPedido()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Pedido: " + Numero.ToString("000"));
        Console.WriteLine("Cliente: " + Cliente);
        Console.WriteLine("Produto: " + Produto);
        Console.WriteLine("Quantidade: " + Quantidade);
        Console.WriteLine("Valor unitário: R$ " + ValorUnitario.ToString("F2"));
        Console.WriteLine("Total: R$ " + CalcularTotal().ToString("F2"));
        Console.WriteLine("--------------------------");
    }
}