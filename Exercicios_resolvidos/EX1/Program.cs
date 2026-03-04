using System.Runtime.Serialization;

Console.Write("Digite o primeiro numero: ");
double A = double.Parse(Console.ReadLine());

Console.Write("Digite o segundo numero: ");
double B = double.Parse(Console.ReadLine());    

double soma = A + B;
double subtracao = A - B;
double multiplicacao = A * B;
double divisao = A / B;

Console.WriteLine("A soma é " + soma);
Console.WriteLine("A subtração é " + subtracao);
Console.WriteLine("A multiplicação é " + multiplicacao);
Console.WriteLine("A divisao é " + divisao);
