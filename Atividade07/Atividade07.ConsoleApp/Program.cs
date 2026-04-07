using System;

class Seller
{
    public decimal SalarioBase {get; set;}
    public decimal TotalVendas {get; set;}
    public decimal PercentualComissao {get; set;}
    public decimal CalcularSalarioTotal()
    {
        return SalarioBase + (TotalVendas * PercentualComissao / 100);
    }
}
class Program
{
    static void Main()
    {
        Seller S = new Seller();
        Console.WriteLine("Calculadora de salário de vendedor");
        Console.Write("Digite o salário base: ");
        S.SalarioBase = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o valor total das vendas: ");
        S.TotalVendas = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o percentual de comissão: ");
        S.PercentualComissao = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Salário total: " + S.CalcularSalarioTotal());
    }
}
