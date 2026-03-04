
        Console.Write("Digite o primeiro número: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        double c = double.Parse(Console.ReadLine());

if (a > 0 && b > 0 && c > 0)
{
    double soma = a + b + c;
    Console.WriteLine("Todos os números são positivos!");
    Console.WriteLine("Soma = " + soma);
}
else
{
    Console.WriteLine("Erro: todos os números devem ser positivos!");
}
        