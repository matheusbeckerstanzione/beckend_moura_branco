using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor
{
    public class Produto
    {
        public String Nome;
        public int Estoque;
        public float Preco;

        public Produto()
        {
            System.Console.WriteLine($"Metodo criado");
        }

        public Produto(String n, int e, float p)
        {
            Nome = n;
            Estoque = e;
            Preco = p;
        }

        public void Exibirdados()
        {
            System.Console.WriteLine($"Produto {Nome}, quantidade de estoque {Estoque} o preco do produto e {Preco}");
        }

    }
}