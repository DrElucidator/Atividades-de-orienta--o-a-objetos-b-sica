using System;

class MediaPonderada
{
    public static decimal Calcular(decimal nota1, decimal peso1, decimal nota2, decimal peso2)
    {
        return ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora de da média ponderada sobre duas notas de um aluno");
        Console.Write("Digite a primeira nota: ");
        decimal n1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o peso da primeira nota: ");
        decimal p1 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite a segunda nota: ");
        decimal n2 = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Digite o peso da segunda nota: ");
        decimal p2 = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Média ponderada: " + MediaPonderada.Calcular(n1, p1, n2, p2).ToString("F2"));
    }
}