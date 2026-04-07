using System;

class ConversorTemperatura
{
    public static decimal ParaFahrenheit(decimal celsius)
    {
        return (celsius * 9 / 5) + 32;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Conversor de Celsius para Fahrenheit");
        Console.Write("Digite a temperatura em Celsius: ");
        decimal c = Convert.ToDecimal(Console.ReadLine());
        Console.WriteLine("Em Fahrenheit: " + ConversorTemperatura.ParaFahrenheit(c).ToString("F2"));
    }
}