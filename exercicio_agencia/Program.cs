string[] nomes = new string[10];
float[] saldos = new float[10];
int totalClientes = 0;

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($"=== SISTEMA BANCÁRIO SIMPLES ===");
    Console.WriteLine($"1) Cadastrar Cliente");
    Console.WriteLine($"2) Depositar");
    Console.WriteLine($"3) Sacar");
    Console.WriteLine($"4) Transferir");
    Console.WriteLine($"5) Listar Clientes");
    Console.WriteLine($"0) Sair");
    Console.WriteLine($"Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 0:
            Console.WriteLine($"Encerrando o programa...");
            break;
        case 1:
            CadastrarCliente();
            break;
        case 2:
            Depositar();
            break;
        case 3:
            Sacar();
            break;
        case 4:
            Transferir();
            break;
        case 5:
            ListarClientes();
            break;
        default:
            Console.WriteLine($"Opção Inválida");
            break;
    }

    Console.WriteLine($"Pressione <Enter> para continuar...");
    Console.ReadLine();

} while (opcao != 0);

void CadastrarCliente()
{
    Console.WriteLine($"=== Cadastro de Clientes ===");

    //verificar se eu posso cadastrar
    if (totalClientes >= 10)
    {
        Console.WriteLine($"Limite de clientes atingido");
        return;
    }

    Console.WriteLine($"Nome do cliente: ");
    nomes[totalClientes] = Console.ReadLine();
    saldos[totalClientes] = 0;
    totalClientes++;

    Console.WriteLine($"cliente cadastrado com sucesso!");
}

void Depositar()
{
    int idCliente = BuscarCliente(); //retorna o indice do array que o cliente está armazenado. assim eu posso usar de base para guardar o saldo do cliente

    if (idCliente == -1)
    { //cliente não encontrado
        return; //para a funcao
    }

    //cliente encontrado
    Console.Write($"Valor para depósito: ");
    float Valor = float.Parse(Console.ReadLine());
    saldos[idCliente] += Valor;
    Console.WriteLine($"Depósito de R${Valor:F2} realizado");

}

void Sacar()
{
    int idCliente = BuscarCliente();

    if (idCliente == -1)
    {
        return;
    }

    Console.WriteLine($"Saldo atual: R${saldos[idCliente]:F2}");
    Console.WriteLine($"Informe quanto o senhor deseja sacar:");
    
    float valor = float.Parse(Console.ReadLine());
    
    if (valor > saldos[idCliente] && valor > 0)
    {
        Console.WriteLine($"Saldo para saque indisponível");    
        return;
    }

    saldos[idCliente] -= valor;
    Console.WriteLine($"Saque de R${valor:F2} realizado com sucesso");
    Console.WriteLine($"Novo saldo: R${saldos[idCliente]:F2}");
}

void Transferir()
{
    Console.WriteLine($"Conta de origem: ");
    int idClienteOrigem = BuscarCliente();
    if (idClienteOrigem == -1)
    {//não existe
        return;
    }

    Console.WriteLine($"Conta de Origem: ");
    int idClienteDestino = BuscarCliente();
    if (idClienteDestino == -1)
    {//não existe
        return;
    }
    Console.Write($"Valor para transferir: ");
    float valor = float.Parse(Console.ReadLine());

    if (saldos[idClienteOrigem] >= valor)
    {//tem saldo para transferir
        saldos[idClienteOrigem] -= valor;
        saldos[idClienteDestino] += valor;
        Console.WriteLine($"Transferência concluída com sucesso");
    }
    else
    {//não tem saldo
        Console.WriteLine($"Saldo insuficiente para a transferência");
    }
}

void ListarClientes()
{
    Console.WriteLine($"=== Listagem de Clientes ===");

    for (int t = 0; t < totalClientes; t++)
    {
        Console.WriteLine($"Usuário {t} - {nomes[t]} | R$ {saldos[t]}");
    }
}

int BuscarCliente()
{
    //listar cliente
    ListarClientes(); //mostra a lista de clientes

    //pedir pro usuário escolher o cliente
    Console.Write($"Digite o número do cliente: ");
    int idCliente = int.Parse(Console.ReadLine());

    //retornar ou devolver o id do cliente
    if (idCliente < 0 || idCliente >= totalClientes)
    {
        Console.WriteLine($"Cliente não encontrado");
        return -1;
    }

    return idCliente;
}


