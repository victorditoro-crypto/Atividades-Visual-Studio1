using System;

class Equipamento
{
    public string Patrimonio;
    public string Tipo;
    public string Marca;
    public string Modelo;
    public string NumeroSerie;
    public string Status;

    public void MostrarEquipamento()
    {
        Console.WriteLine("--------------------------");
        Console.WriteLine("Patrimônio: " + Patrimonio);
        Console.WriteLine("Tipo: " + Tipo);
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Número de série: " + NumeroSerie);
        Console.WriteLine("Status: " + Status);
        Console.WriteLine("--------------------------");
    }
}