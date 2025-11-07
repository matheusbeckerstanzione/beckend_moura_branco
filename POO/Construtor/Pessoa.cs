using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;

namespace Construtor
{
    public class Pessoa
    {

   public string Nome;
        public int Idade;

        public Pessoa() // construtor ele nao tem void
        {
            System.Console.WriteLine($"Metodo criado");
        }

        public Pessoa(String n, int i,String xpto)
        {
            Nome = n;
            Idade = i;
           System.Console.WriteLine($"O seu texto e {xpto}");
        }
     
        public Pessoa(String n, int i)
        {
            Nome = n;
            Idade = i;
        }
        public void Exibirdados()
        {
            System.Console.WriteLine($"NOME: {Nome}, vc tem {Idade} anos");
        }

    }
}


//para ser construtor ele tem que ter o mesmo nome da classe