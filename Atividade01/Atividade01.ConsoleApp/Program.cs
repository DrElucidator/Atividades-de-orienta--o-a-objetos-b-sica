using System;

class Box
{
    public decimal Altura {get; set;}
    public decimal Largura {get; set;}
    public decimal Profundidade {get; set;}

    public decimal CalcularVolume()
    {
        return Altura * Largura * Profundidade;
    }
}
class Program {
    static void Main()
    {
        Box Crate = new Box();

        Console.WriteLine("Calculadora de Volume de Caixa");

        Console.Write("Digite a altura: ");
        Crate.Altura = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a largura: ");
        Crate.Largura = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Digite a profundidade: ");
        Crate.Profundidade = Convert.ToDecimal(Console.ReadLine());

        Console.WriteLine("Altura informada: " + Crate.Altura);
        Console.WriteLine("Volume da caixa: " + Crate.CalcularVolume());
    }
}