
    
        Console.Write("Digite o valor de A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de B: ");
        int B = int.Parse(Console.ReadLine());

        Console.Write("Digite o valor de C: ");
        int C = int.Parse(Console.ReadLine());

        int R = (int)Math.Pow(A + B, 2);

        int S = (int)Math.Pow(B + C, 2);

   
        int D = R + S;

        Console.WriteLine("R = (A + B)² = " + R);
        Console.WriteLine("S = (B + C)² = " + S);
        Console.WriteLine("D = R + S = " + D);
