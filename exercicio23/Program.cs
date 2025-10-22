/*int qtdLetras = 0;

Console.WriteLine($"Olá usuario, quantas letras tem o seu nome?");
qtdLetras = int.Parse(Console.ReadLine());
string nome = "";

for (int i = 1; i <= qtdLetras; i++)
{
    Console.WriteLine($"Qual é a {i}ª letra?");
    nome += Console.ReadLine();  
}

Console.WriteLine($"Seu nome é: {nome}");*/


System.Console.WriteLine($"Quantos numeros vc quer digitar");
int qtdNumero = int.Parse(Console.ReadLine());
string pares = "Pares";
string impar = "impares";

for (int i = 1; i < qtdNumero; i++)
{
  System.Console.WriteLine($"Digite o {i} numero");
  int numeroDigitado = int.Parse(Console.ReadLine());

  if (numeroDigitado % 2 == 0)
  {
    pares += numeroDigitado.ToString() + ",";
  }
  else
  {
        impar += numeroDigitado.ToString() + ",";
    }
}
