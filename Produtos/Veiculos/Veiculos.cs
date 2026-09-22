using System;

class Veiculo
{
    public string Marca;
    public string Modelo;
    public int Ano;
    public string Cor;
    public string Placa;

    public void MostrarVeiculo()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Ano: " + Ano);
        Console.WriteLine("Cor: " + Cor);
        Console.WriteLine("Placa: " + Placa);
        Console.WriteLine("--------------------------");
    }
}