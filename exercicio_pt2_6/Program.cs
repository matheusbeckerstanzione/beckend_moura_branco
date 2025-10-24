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