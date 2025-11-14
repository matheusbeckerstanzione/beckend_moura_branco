using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Carro : Veiculo
    {
        public int QtdPortas;
        
        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantidade de portas: {QtdPortas}");

        }
    }
}