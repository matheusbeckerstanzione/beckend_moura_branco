using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor
{
    public class Carro
    {
        public String Marca;
        public String Modelo;
        public int Ano;

        public Carro() // construtor ele nao tem void
        {
            System.Console.WriteLine($"Metodo criado");
        }

        public Carro(String n, String m, int a)
        {
            Marca = n;
            Modelo = m;
            Ano = a;
        }
        
        public void Exibirdados()
        {
            System.Console.WriteLine($"Marca: {Marca}, o modelo do carro e {Modelo}, ano {Ano}");
        }
    }
}