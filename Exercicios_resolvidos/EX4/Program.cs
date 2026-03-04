


        
        Console.Write("Digite a Nota 1 (peso 2): ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a Nota 2 (peso 3): ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a Nota 3 (peso 5): ");
        double nota3 = double.Parse(Console.ReadLine());

        
        int peso1 = 2;
        int peso2 = 3;
        int peso3 = 5;
        int somaPesos = peso1 + peso2 + peso3; 

        
        double mediaPonderada = (nota1 * peso1 + nota2 * peso2 + nota3 * peso3) / somaPesos;

        
        Console.WriteLine("Nota 1: " + nota1 + "Peso: " + peso1);
        Console.WriteLine("Nota 2: " + nota2 + "Peso: " + peso2);
        Console.WriteLine("Nota 3: " + nota3 + "Peso: " + peso3);
        Console.WriteLine("Média Ponderada = " + nota1 + "  × " + peso1 + nota2 + " × " + peso2 + nota3 + " × " + peso3 + " / " + somaPesos);
        Console.WriteLine("Média Ponderada = " + mediaPonderada);
   