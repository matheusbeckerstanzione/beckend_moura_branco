float  nota1, nota2, nota3, nota4, media;


Console.WriteLine("ola qual e a primeira nota");
nota1 = float.Parse(Console.ReadLine());//ele vai receber o valor 

Console.WriteLine("agora a segunda nota");
nota2 =float.Parse(Console.ReadLine());//ele vai receber o valor 

Console.WriteLine("agora a terceira nota");
nota3 =float.Parse(Console.ReadLine());//ele vai receber o valor 

Console.WriteLine("agora a quarta nota");
nota4 =float.Parse(Console.ReadLine());//ele vai receber o valor

media = (nota1 + nota2 + nota3 + nota4) / 4;

Console.WriteLine($"Media: {media}" );

if (media >= 7)
{
    Console.WriteLine($"Aprovado parabens");
}

else if (media >=5)
{
    Console.WriteLine($"Recuperação");
}

else  
{
    Console.WriteLine($"Reprovado");
}
