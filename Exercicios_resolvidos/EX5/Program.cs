
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
            Console.WriteLine($"\nO número {numero} é PAR.");
        else
            Console.WriteLine($"\nO número {numero} é ÍMPAR.");
