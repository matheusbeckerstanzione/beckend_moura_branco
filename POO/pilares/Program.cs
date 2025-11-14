using heranca;
using pilares;

/*Carro Fusca = new Carro();
Veiculo Generic = new Veiculo();
Fusca.Marca = "Volkswagen";
Fusca.Modelo = "Fusca";
Fusca.Ano = 1959;
Fusca.QtdPortas = 2;
Fusca.Acelerar();
Fusca.ExibirInfo();

Thread.Sleep(2250);

Console.Clear();

Moto Honda = new Moto();
Honda.Marca = "Honda";
Honda.Modelo = "Honda CB 650R";
Honda.Ano = 2023;
Honda.Cilindradas = 649;
Honda.SomDaMoto();
Honda.Acelerar();
Honda.ExibirInfo();

Thread.Sleep(2250);

Console.Clear();

Aviao Boeing = new Aviao();
Boeing.Modelo = "Boeing 737 MAX 8";
Boeing.Marca = "Boeing";
Boeing.Ano = 2023;
Boeing.QTDAsas = 2;
Boeing.Voar();
Boeing.ExibirInfo();*/


// exercico 1
/*Cachorro Thor = new Cachorro();
Thor.fazerSomCachorro();

Gato salfado = new Gato();
salfado.fazerSomgato();*/

/*Gerente cleber = new Gerente();
cleber.CalcularSalario(); */

/*Aluno pablo = new Aluno();
pablo.Nome = "Pablo";
pablo.curso = "desenvolvimento de sistema";
pablo.Idade = 16;

Professor armando = new Professor();
armando.Nome = "Armando";
armando.disciplina = "Desenvolvimento de sistema";
armando.Idade = 45;*/

ContaBancaria cp = new ContaBancaria();
        cp.numero = 1;

        Console.WriteLine("Saldo inicial: " + cp.saldo);

        cp.Depositar(1000);
        Console.WriteLine("Após depósito: " + cp.saldo);

        cp.CalcularSalario();
        Console.WriteLine("Após rendimento de 2%: " + cp.saldo);

        Console.ReadLine();

