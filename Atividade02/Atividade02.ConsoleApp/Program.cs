using System;

class ConversorTemperatura
{
    public static decimal ParaCelsius(decimal fahrenheit) {
        return (fahrenheit - 32) * 5 / 9;
    }
}
class Program
{
    static void Main() {
        Console.Write("Digite a temperatura em Fahrenheit para converter para Celsius: ");
        decimal f = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Em Celsius: " + ConversorTemperatura.ParaCelsius(f).ToString("F1"));
    }
}