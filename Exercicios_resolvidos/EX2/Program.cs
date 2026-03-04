

       
        Console.Write("Digite x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Digite y1: ");
        double y1 = double.Parse(Console.ReadLine());

  
        Console.Write("Digite x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Digite y2: ");
        double y2 = double.Parse(Console.ReadLine());

        // Cálculo da distância: d = sqrt((x2-x1)² + (y2-y1)²)
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine("Ponto 1: " + x1, y1);
        Console.WriteLine("Ponto 2: " + x2, y2);
        Console.WriteLine("Distância entre os pontos: " + distancia);


