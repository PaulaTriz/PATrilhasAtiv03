using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int num3 = int.Parse(Console.ReadLine());

        bool condicao = (num1 > num2) && (num2 > num3);
        Console.WriteLine("o primerio e menor que segundo e maior que o terceiro: " + condicao);
    }
}
