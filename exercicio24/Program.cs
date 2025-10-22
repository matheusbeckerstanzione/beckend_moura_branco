int contador = 1;

System.Console.WriteLine($"Quantas vezes vc quer rodar o while");

int qtdVezes = int.Parse(Console.ReadLine());

while (contador <= 3)
{
    System.Console.WriteLine($"Contador e {contador}");
    contador++;
}

