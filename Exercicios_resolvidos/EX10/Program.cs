using System;

class Exercicio10
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Exercício 10 - Tabuada (for) ===\n");

        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nTabuada do {numero}:\n");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{numero} x {i,2} = {numero * i,3}");
        }
    }
}
