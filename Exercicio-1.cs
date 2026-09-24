using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int num2 = int.Parse(Console.ReadLine());

        bool eMaior = num1 > num2;
        Console.WriteLine("O primeiro número e maior que o segundo? " + eMaior);
    }
}
