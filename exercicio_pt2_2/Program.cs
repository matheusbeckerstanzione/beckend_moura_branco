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
