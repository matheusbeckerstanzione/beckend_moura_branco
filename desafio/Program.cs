
        float numero1, numero2;

        Console.WriteLine("=============================");
        Console.WriteLine("=== COMPARADOR DE NÚMEROS ===");
        Console.WriteLine("=============================");
        
        Console.Write("Digite o primeiro número: ");
        while (!float.TryParse(Console.ReadLine(), out numero1))
        {
            Console.Write("Valor inválido, Digite um número: ");
        }

        Console.Write("Digite o segundo número: ");
        while (!float.TryParse(Console.ReadLine(), out numero2))
        {
            Console.Write("Valor inválido, Digite um número: ");
        }

        
        if (numero1 > numero2)
        {
            Console.WriteLine($"{numero1} é maior que {numero2}");
        }
        else if (numero1 < numero2)
        {
            Console.WriteLine($"{numero1} é menor que {numero2}");
        }
        else
        {
            Console.WriteLine("Os números são iguais!");
        }