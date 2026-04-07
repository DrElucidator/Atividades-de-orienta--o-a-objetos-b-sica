using System;

class Cylinder
{
    public decimal Raio {get; set;}
    public decimal Altura {get; set;}
    public decimal CalcularVolume()
    {
        return (decimal)Math.PI * Raio * Raio * Altura;
    }
}
class Program
{
    static void Main()
    {
        Cylinder cyl = new Cylinder();
        Console.WriteLine("Calculadora de volume de cilindro");
        Console.Write("Digite o raio: ");
        cyl.Raio = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a altura: ");
        cyl.Altura = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Volume do cilindro: " + cyl.CalcularVolume());
    }
}