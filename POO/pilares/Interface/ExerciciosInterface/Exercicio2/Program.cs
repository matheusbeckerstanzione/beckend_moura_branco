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
            CadastrarClausula();
            break;

        case 3:
            CadastrarContratos();
            break;

        case 4:
            ListarFaturas();
            break;

        case 5:
            ListarRelatorios();
            break;

        case 6:
            ListarContratos();
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

void CadastrarClausula()
{
    Console.WriteLine($"Digite o nome da Clausula do Relatorio");
    string rel = Console.ReadLine();

    Console.WriteLine($"Digite o texto do relatorio");
    string txr = Console.ReadLine();

   
    
    Relatorio fat = new Relatorio(rel,txr );
    Documentos.Add(fat);
}

void CadastrarContratos()
{
   Console.WriteLine($"Digite o nome da Clausula do Relatorio");
    string name = Console.ReadLine();

    Console.WriteLine($"Digite o texto do relatorio");
    string tcx = Console.ReadLine();

    Contrato contrato = new Contrato(name,tcx );

    
    Documentos.Add(contrato);

    
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
     Console.WriteLine($"Listando Relatorios:");
    foreach (var item in Documentos)
    {
        if (item is Relatorio)
        {
            item.Imprimir();
        }
    }
}

void ListarContratos()
{
     Console.WriteLine($"Listando Contratos:");
    foreach (var item in Documentos)
    {
        if (item is Contrato)
        {
            item.Imprimir();
        }
    }
}




















// Fatura fatbecker = new Fatura();
// Documentos.Add(fatbecker);

// Fatura Ale = new Fatura();
// Documentos.Add(Ale);



// Relatorio relbecker = new Relatorio();
// Documentos.Add(relbecker);

// Relatorio Alex = new Relatorio();
// Documentos.Add(Alex);


// Contrato conbecker = new Contrato();
// Documentos.Add(conbecker);

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