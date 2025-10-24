    double salario;
double gastos;
    
    Console.Write($"Informe o salário recebido: ");
    salario = double.Parse(Console.ReadLine());
    
    Console.Write($"Informe o total gasto: ");
    gastos=  double.Parse(Console.ReadLine());

        
            if (gastos <= salario)
            {
                Console.WriteLine($"Gastos dentro do orçamento.");
            }
            else
            {
                Console.WriteLine($"Orçamento estourado!");
            }