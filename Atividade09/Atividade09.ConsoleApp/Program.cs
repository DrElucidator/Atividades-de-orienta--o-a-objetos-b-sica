using System;

class MediaHarmonica
{
    public static decimal Calcular(decimal[] notas)
    {
        decimal soma = 0;
        for (int i = 0; i < notas.Length; i++)
        {
            soma += 1 / notas[i];
        }
        return notas.Length / soma;
    }
}
class Program
{
    static void Main() {
        Console.WriteLine("Calculadora de média harmônica");
        Console.Write("Digite a quantidade de notas: ");
        int qtd = Convert.ToInt32(Console.ReadLine());
        decimal[] notas = new decimal[qtd];
        for (int i = 0; i < qtd; i++) {
            Console.Write("Digite a nota " + (i+1) + ": ");
            notas[i] = Convert.ToDecimal(Console.ReadLine());
        }
        Console.WriteLine("Média harmônica: " + MediaHarmonica.Calcular(notas).ToString("F2"));
    }
}