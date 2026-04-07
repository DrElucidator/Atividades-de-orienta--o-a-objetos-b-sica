using System;

class Gas
{
    public decimal KmInicial {get; set;}
    public decimal KmFinal {get; set;}
    public decimal LitrosConsumidos {get; set;}
    public decimal CalcularConsumoPorKm()
    {
        return LitrosConsumidos / (KmFinal - KmInicial);
    }
}
class Program
{
    static void Main()
    {
        Gas G = new Gas();
        Console.WriteLine("Calculadora de consumo de combustível por quilometro percorrido");
        Console.Write("Digite a quilometragem inicial: ");
        G.KmInicial = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a quilometragem final: ");
        G.KmFinal = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite os litros consumidos: ");
        G.LitrosConsumidos = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Consumo por km: " + G.CalcularConsumoPorKm().ToString("F2"));
    }
}
