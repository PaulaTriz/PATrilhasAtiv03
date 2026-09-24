using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num >= 0)
        {
            Console.WriteLine("O número e positivo: ");
        }
        else
        {
            Console.WriteLine("O número e negativo: ");
        }
    }
}