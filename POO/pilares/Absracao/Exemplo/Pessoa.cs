using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Pessoa : Animal
    {
        
        public string Nome = "";
        public int Idade;
        
        
        
                public override void Andar()
        {
            System.Console.WriteLine("ploft");
        }

        public  void Dormir()
        {
            System.Console.WriteLine("rooooooooooo");
        }

        public override void FazerSom()
        {
            System.Console.WriteLine("ola, paz deus ");
        }

        
        
    }
}