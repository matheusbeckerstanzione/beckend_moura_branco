using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estaticas
{
    public static class Produto
{
    // Método utilitário (não precisa de objeto)
    public static double CalcularDesconto(double preco, double porcentagem)
    {
        return preco - (preco * (porcentagem / 100));
    }

    public static void ExibirComDesconto(string nome, double preco, double desconto)
    {
        double precoFinal = CalcularDesconto(preco, desconto);
        Console.WriteLine($"{nome} com {desconto}% off: R$ {precoFinal:F2}");
    }
}
}

