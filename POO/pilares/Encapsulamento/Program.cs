using Encapsulamento;

ContaBancaria conta = new ContaBancaria();

conta.Dpositar(-100);
conta.Dpositar(200);

Console.WriteLine($"Saldo atual  {conta.GetSaldo}");


