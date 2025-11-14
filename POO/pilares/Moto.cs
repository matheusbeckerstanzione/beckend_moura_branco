using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace heranca
{
    public class Moto : Veiculo
    {
        public int Cilindradas;

        public void SomDaMoto()
        {
            Console.WriteLine($"grrrwnn");
        }

        public void Acelerar()
        {
            Console.WriteLine($"UUUU tu tu tu tu");
            
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Quantidade de portas: {Cilindradas}");

        }
    }
    
}