using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        bool eMenor = num1 < num2;
        Console.WriteLine(" O primeiro número e menor que o segundo: " + eMenor);
    }
}
