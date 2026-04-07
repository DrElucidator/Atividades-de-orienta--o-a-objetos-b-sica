using System;

class Sphere
{
    public decimal Raio {get; set;}
    public decimal CalcularVolume()
    {
        return (4m / 3m) * (decimal)Math.PI * Raio * Raio * Raio;
    }
}
class Program
{
    static void Main()
    {
        Sphere S = new Sphere();
        Console.WriteLine("Calculadora de volume de esfera");
        Console.Write("Digite o raio: ");
        S.Raio = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Volume da esfera: " + S.CalcularVolume());
    }
}