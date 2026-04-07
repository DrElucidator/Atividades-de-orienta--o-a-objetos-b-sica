using System;

class LataDeOleo
{
    public decimal Raio {get; set;}
    public decimal Altura {get; set;}
    public decimal CalcularVolume()
    {
        return (decimal)Math.PI * Raio * Raio * Altura;
    }
    public decimal CalcularLitros()
    {
        return CalcularVolume() / 1000;
    }
}
class Program
{
    static void Main()
    {
        LataDeOleo l = new LataDeOleo();
        Console.Write("Digite o raio da lata (cm): ");
        l.Raio = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a altura da lata (cm): ");
        l.Altura = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Volume da lata de óleo (cm³): " + l.CalcularVolume().ToString("F2"));
        Console.WriteLine("Volume da lata de óleo (litros): " + l.CalcularLitros().ToString("F2"));
    }
}