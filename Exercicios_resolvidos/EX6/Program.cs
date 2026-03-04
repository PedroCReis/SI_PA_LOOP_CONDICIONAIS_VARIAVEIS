

        Console.Write("Digite o primeiro número: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro número: ");
        int c = int.Parse(Console.ReadLine());

        int maior;

        if (a > b && a > c)
            maior = a;
        else if (b > c)
            maior = b;
        else
            maior = c;

        Console.WriteLine("O maior número é: " + maior);
