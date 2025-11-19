using System.Xml;
using Exercicio1;


Console.Clear();
System.Console.WriteLine("---------BEM VINDO AO MUNDO GEOMETRICO------------");
System.Console.WriteLine();

System.Console.WriteLine("Vamos calcular a area do retangulo");
System.Console.Write("Informe a aultura");
float Altura = float.Parse(System.Console.ReadLine());
System.Console.WriteLine("Informe a sua largura");
float Largura = float.Parse(System.Console.ReadLine());


Retangulo ret = new Retangulo (Largura, Altura);
System.Console.WriteLine();

System.Console.WriteLine("Bora calcular o circulo");
System.Console.WriteLine("Informe a area do circulo");
float raio = float.Parse(System.Console.ReadLine());

Circulo cir = new Circulo();
cir.Raio = raio;


ret.CalcularArea();
cir.CalcularArea();
