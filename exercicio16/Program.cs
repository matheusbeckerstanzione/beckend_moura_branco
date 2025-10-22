using System.Security.Cryptography;

string cargo;
double salario, novoSalario;

Console.WriteLine("Digite o cargo do funcionário (producao, administrativo ou diretoria):");
cargo = Console.ReadLine();

Console.WriteLine("Digite o salário atual do funcionário:");
salario = double.Parse(Console.ReadLine());

if (cargo == "producao")
{
    novoSalario = salario + (salario * 0.065);
}
else if (cargo == "administrativo")
{
    novoSalario = salario + (salario * 0.075);
}
else if (cargo == "diretoria")
{
    novoSalario = salario + (salario * 0.12);

}
else
{
    Console.WriteLine("Cargo inválido!");
    return;
}

Console.WriteLine($"O novo salário reajustado é: R$ {novoSalario}");



/*switch (cargo)
{
    case "producao":
        //intrucao
        break;

    case "administrativo":
        //intrucao

        break;

    case "diretoria":
        //intrucao

        break;
    default:
        //intrucao
        break;
}*/