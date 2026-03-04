
        Console.Write("Digite um número inteiro: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Números pares de 0 até " + n + ":");
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    