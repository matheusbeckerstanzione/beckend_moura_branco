 int opcao = -1;

        do
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("                 MENU DE EXERCÍCIOS                   ");
            Console.WriteLine("-------------------------------------------------------\n");

            Console.WriteLine("Escolha um exercício para executar:\n");
            Console.WriteLine("1) Exercício 1");
            Console.WriteLine("2) Exercício 2");
            Console.WriteLine("3) Exercício 3");
            Console.WriteLine("4) Exercício 4");
            Console.WriteLine("5) Exercício 5");
            Console.WriteLine("6) Exercício 6");
            Console.WriteLine("0) Sair\n");

            Console.Write("Opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Exercicio1();
                    break;
                case 2:
                    Exercicio2();
                    break;
                case 3:
                    Exercicio3();
                    break;
                case 4:
                    Exercicio4();
                    break;
                case 5:
                    Exercicio5();
                    break;
                case 6:
                    Exercicio6();
                    break;
                case 0:
                    Console.WriteLine("Saindo do programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (opcao != 0)
            {
                Console.WriteLine("\nPressione ENTER para voltar ao menu...");
                Console.ReadLine();
            }

        } while (opcao != 0);
    


    static void Exercicio1()
    {
        Console.WriteLine("Executando Exercício 1...");
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
    }

   void Exercicio2()
    {
    Console.WriteLine("Executando Exercício 2...");
        int gols1;
int gols2;

System.Console.WriteLine($"Quantos gols o time 1 fez: ");
gols1 = int.Parse(System.Console.ReadLine());

System.Console.WriteLine($"Quantos gols o time 1 fez: ");
gols2 = int.Parse(System.Console.ReadLine());


if (gols1 > gols2)
{
    System.Console.WriteLine($"Vitoria do time 1");
}

else if (gols1 < gols2)
{
     System.Console.WriteLine($"Vitoria do time 2");
}

else
{
     System.Console.WriteLine($"O jogo terminou empatado");
}
       
    }

    void Exercicio3()
    {
        Console.WriteLine("Executando Exercício 3...");
                double lado1;
        double lado2;
        double lado3;
        
        Console.Write("Digite o valor do primeiro lado: ");
        lado1 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do segundo lado: ");
         lado2 = double.Parse(Console.ReadLine());

        Console.Write("Digite o valor do terceiro lado: ");
         lado3 = double.Parse(Console.ReadLine());

      
        if (lado1 < lado2 + lado3 && lado2 < lado1 + lado3 && lado3 < lado1 + lado2)
        {
           
            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("Triângulo Equilátero: possui os 3 lados iguais.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("Triângulo Isósceles: possui 2 lados iguais.");
            }
            else
            {
                Console.WriteLine("Triângulo Escaleno: possui 3 lados diferentes.");
            }
        }
        else
        {
            Console.WriteLine("As medidas informadas não formam um triângulo válido!");
        }

    }

   void Exercicio4()
    {
        Console.WriteLine("Executando Exercício 4...");
       int senha = 1234;

System.Console.WriteLine($"Ola usuario digite a sua senha:");
senha = int.Parse(System.Console.ReadLine());

if (senha == 1234)
{
    System.Console.WriteLine($"Acesso permitido!!!");
}
else
{
    System.Console.WriteLine($"Acesso negado tente novamente ");
}


    }

   void Exercicio5()
    {
        Console.WriteLine("Executando Exercício 5...");
       int qtdMaca;
double preco;

System.Console.WriteLine($"Ola usuario digite a quantidade de maçã");
qtdMaca = int.Parse(System.Console.ReadLine());

if (qtdMaca < 12)
{
    preco = 0.30;
}

else
{
    preco = 0.25;
}

 double total = qtdMaca * preco;

Console.WriteLine($"O valor total da compra é: R$ {total:F2}");
    }

    void Exercicio6()
    {
        Console.WriteLine("Executando Exercício 6...");
      float media;
float frequencia;

System.Console.WriteLine($"Ola digite a media do aluno do senai");
media = float.Parse(System.Console.ReadLine());

System.Console.WriteLine($"Ola digite a frequancia do aluno do senai");
frequencia = float.Parse(System.Console.ReadLine());




//verificar 

//E aprovado caso apresente média maior ou igual a 7.0 e frequência maior ou igual a 75%


//Se o aluno obtiver a frequência mínima exigida(75) e uma média entre 3 e 7, ainda teria direito a uma última avaliação de recuperação


//Se a frequência for menor que 75% o aluno já estaria reprovado
if (frequencia < 75)
{
    Console.WriteLine("Aluno reprovado por frequência insuficiente!");
}

//Caso a frequência respeite o mínimo exigido, começaríamos a avaliar a média para saber se está aprovado, em recuperação ou reprovado.
else if (frequencia >= 75 && media >= 7)
{
    System.Console.WriteLine($"aprovado");
}
else if (frequencia >= 75 && media >= 3)
{
    System.Console.WriteLine($"recuperação");
}
else
{
    System.Console.WriteLine($"reprovado");
}
    }