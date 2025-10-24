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