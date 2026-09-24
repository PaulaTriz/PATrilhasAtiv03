using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine(" O número e par: ");
        } else
        {
            Console.WriteLine("O número e impar: ");
        }

    }
}
