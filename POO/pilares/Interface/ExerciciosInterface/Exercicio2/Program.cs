using System.Xml;
using Exercicio2;

List<IImprimivel> documentos  =new List<IImprimivel>();

int opcao;

do
{
    System.Console.WriteLine($@"
    
    1)cadastrar fatura
    2)cadastrar relatorio
    3)cadastrar contrato
    4)listar fatura
    5)listar relatorio
    6)listar contrato
    7)sair
    escolha a sua opcao 
");

opcao = int.Parse(System.Console.ReadLine());

    switch (opcao)
    {
        case 1:
        System.Console.WriteLine("Cadastrar sua fatura em desenvolvimento");
        break;

        case 2:
        System.Console.WriteLine("Cadastrar relatorio em desenvolvimento");
        break;

        case 3:
        System.Console.WriteLine("Cadastrar contrato em desenvolvimento");
        break;

        case 4:
        System.Console.WriteLine("Listar fatura em desenvolvimento");
        break;

        case 5:
        System.Console.WriteLine("Listar relatorio em desenvolvimento");
        break;

        case 6:
        System.Console.WriteLine("Listar contratos em desenvolvimento");
        break;

        case 7:
        System.Console.WriteLine("sair");
        break;
    }

    System.Console.WriteLine($"PRECIONE ENTER PARA CONTINUAR");
    System.Console.ReadLine();

} while(true);


void CadastrarFatura()
{
    System.Console.WriteLine("DIGITE");
}
void CadastrarContratos()
{
    
}
void CadastrarRelatorio()
{
    
}
void ListarFatura()
{
    
}
void ListarContratos()
{
    
}
void ListarRelatorios()
{
    
}



































// Fatura fatbecker = new Fatura();
// documentos.Add(fatbecker);

// Fatura fatana = new Fatura();
// documentos.Add(fatana);

// Relatorio rel = new Relatorio();
// documentos.Add(rel);

// Contrato contr = new Contrato();
// documentos.Add(contr);


// System.Console.WriteLine("FATURAS");
// foreach (var fatura in documentos)
// {
//     if (fatura is Fatura)
//     {
//     fatura.Imprimir();
//     }
    
// }

// System.Console.WriteLine("FATURAS");
// foreach (var item in documentos)
// {
//     if (item is Contrato)
//     {
//         item.
//     }
// }

// System.Console.WriteLine("Relatorio");
// foreach (var item in documentos)
// {
//     item.Imprimir();
// }