using System.Data;
using System.Reflection;
using Exercicio2;
// List<Fatura> listafatura = new List<Fatura>();
// List<Relatorio> listaRelatorio = new List<Relatorio>();
// List<Contrato> listaContrato = new List<Contrato>();
List<IImprimivel> Documentos = new List<IImprimivel>();

int opcao;

do
{
    Console.Clear();
    Console.WriteLine($@"====== Menu de opções ======
    
    1) Cadastrar Fatura
    2) Cadastrar Relatório
    3) Cadastrar Contrato
    4) Listas Faturas
    5) Listar Relatórios
    6) Listar Contratos
    0) Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CadastrarFaturas();
            break;

        case 2:
            Console.WriteLine($"Cadastrar Relatório em desenvolvimento");
            break;

        case 3:
            Console.WriteLine($"Cadastrar Contratos em desenvolvimento");
            break;

        case 4:
            ListarFaturas();
            break;

        case 5:
            Console.WriteLine($"Listar Relatórios em desenvolvimento");
            break;

        case 6:
            Console.WriteLine($"Listar Contratos em desenvolvimento");
            break;

        case 0:
            Console.WriteLine($"Sair");
            break;

        default:
            Console.WriteLine($"Opção Inválida");
            break;

    }

    Console.WriteLine($"Pressione <<Enter>> para continuar");
    Console.ReadLine();

} while (opcao != 0);



void CadastrarFaturas()
{
    Console.WriteLine($"Digite o nome do cliente devedor");
    string dev = Console.ReadLine();

    Console.WriteLine($"Digite o nome da empresa");
    string empresa = Console.ReadLine();

    Console.WriteLine($"Digite o valor da fatura");
    float Valor = float.Parse(Console.ReadLine());

    Console.WriteLine($"Dias de atraso da fatura");
    int QtdDiasAtraso = int.Parse(Console.ReadLine());
    
    Fatura fat = new Fatura(dev, empresa, Valor, QtdDiasAtraso);
    Documentos.Add(fat);
}

void CadastrarRelatorios()
{
    
}

void CadastrarContratos()
{
    
}

void ListarFaturas()
{
    Console.WriteLine($"Listando Faturas:");
    foreach (var item in Documentos)
    {
        if (item is Fatura)
        {
            item.Imprimir();
        }
    }
}

void ListarRelatorios()
{
    
}

void ListarContratos()
{
    
}




















// Fatura fatJV = new Fatura();
// Documentos.Add(fatJV);

// Fatura Ale = new Fatura();
// Documentos.Add(Ale);



// Relatorio relJV = new Relatorio();
// Documentos.Add(relJV);

// Relatorio Alex = new Relatorio();
// Documentos.Add(Alex);


// Contrato conJV = new Contrato();
// Documentos.Add(conJV);

// Contrato Edu = new Contrato();
// Documentos.Add(Edu);


// // fatRafa.Imprimir();
// // relRafa.Imprimir();
// // conRafa.Imprimir();


// //Listar os Dados 
// // for(int i = 0; i < listafatura.Count; i++)
// // {
// //     listafatura[i].Imprimir();
// // }
// Console.WriteLine($"FATURAS");
// foreach (var fat in Documentos)
// {
//     if (fat is Fatura)
//     {
//         fat.Imprimir();
//     }

// }

// Console.WriteLine($"");

// Console.WriteLine($"RELATÓRIOS");
// foreach (var rel in Documentos)
// {
//     if (rel is Relatorio)
//     {
//         rel.Imprimir();
//     }

// }

// Console.WriteLine($"");

// Console.WriteLine($"CONTRATOS");
// foreach (var con in Documentos)
// {
//     if (con is Contrato)
//     {
//         con.Imprimir();
//     }

// }