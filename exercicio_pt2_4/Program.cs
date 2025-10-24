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

