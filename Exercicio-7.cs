using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número ponto flutuante: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número ponto flutuante: ");
        int num2 = int.Parse(Console.ReadLine());

        bool flutuante = num1 <= num2;
        Console.WriteLine("O primeiro número é menor ou igual ao segundo número: " + flutuante);
    }
}
