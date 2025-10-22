string nome;
string sobrenome;
int idade;
float saldoBancario;
float investimentos;


Console.WriteLine("ola qual e o seu nome");
nome = Console.ReadLine();//ele vai receber o valor 

Console.WriteLine("digite o seu sobrenome");
sobrenome =Console.ReadLine();//ele vai receber o valor 

Console.WriteLine("digite o sua idade");
idade =int.Parse (Console.ReadLine());//ele vai receber o valor 

Console.WriteLine("digite o seu saldoBancario");
saldoBancario = float.Parse (Console.ReadLine());//ele vai receber o valor 

Console.WriteLine("digite o seu investimentos");
investimentos = float.Parse   (Console.ReadLine());//ele vai receber o valor 



Console.Clear();//limpar o console

Console.WriteLine($"Nome: {nome} {sobrenome}");//exibindo o nome e sobrenome 
Console.WriteLine($"idade do {nome} é {idade}");//exibindo o nome e a idade 
Console.WriteLine($"Saldo Bancario: {saldoBancario}");//exibindo o saldo bancario
Console.WriteLine($"investimento este ano: {investimentos}");//exibindo o investimento
