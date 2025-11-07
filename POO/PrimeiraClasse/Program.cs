using PrimeiraClasse;

//Console.WriteLine($"==== PROGRAMA PRIMEIRA CLASSE ====");

// Carro mclaren = new Carro();
// mclaren.marca = "Mclaren";
// mclaren.cor = "Laranja";
// mclaren.modelo = "750s";
// mclaren.potencia = 800;

// Console.WriteLine($"Ligando a {mclaren.marca} {mclaren.cor}");
// mclaren.Ligar();
// Console.WriteLine($"Acelerando a {mclaren.marca} de {mclaren.potencia} cv");
// mclaren.Acelerar();


/*Pessoa edu = new Pessoa();
edu.Nome = "Eduardo Mendes";
edu.Idade = 43;
edu.Altura = 166;

edu.Falar();
edu.Dormir();


Garrafa Stanley = new Garrafa();
Stanley.Cor = "Azul Goiaba";
Stanley.Litro = 1000;
Stanley.Marca = "Stanley";
Stanley.Cor = "azul";

Console.WriteLine($"Abrindo a Garrafa Stanley: ");
Stanley.abrir();

Console.WriteLine($"fechando a Garrafa Stanley: ");
Stanley.fechar();*/


Pessoa matheus = new Pessoa();
matheus.Nome = "Matheus becker";
matheus.Idade = 16;
matheus.Altura = 163;
System.Console.WriteLine($"{matheus.Nome} tem {matheus.Idade}");

matheus.Envelhecer();
System.Console.WriteLine($"{matheus.Nome} tem {matheus.Idade}");

