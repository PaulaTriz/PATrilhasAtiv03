using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número flutuante: ");
        float num = float.Parse(Console.ReadLine());

        bool flutuante = num == 0;
        Console.WriteLine("0 número flutuante e igual a zero: " + flutuante);
    }
}
