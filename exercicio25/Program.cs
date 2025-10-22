int qtdUsuario = 0;
int contador = 1;
System.Console.WriteLine($"Quantos numeros vc quer digitar");
qtdUsuario = int.Parse(System.Console.ReadLine());



while (contador <= qtdUsuario)
{
    System.Console.WriteLine($"Digite um numero");
    int batata = int.Parse(System.Console.ReadLine());

    if (batata % 2 == 0)
    {
        System.Console.WriteLine($"numero digitado e par {batata}");
    }
    contador++;
}
