
         Console.Write("Digite o primeiro número: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double b = double.Parse(Console.ReadLine());

        if (a > b)
            Console.WriteLine("O maior número é: " + a);
        else if (b > a)
            Console.WriteLine("O maior número é: "  + b);
        else
            Console.WriteLine("Números iguais");
