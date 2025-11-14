using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Cachorro : Animal
    {
        public override void Andar()
        {
           System.Console.WriteLine("poc poc poc");
        }

        

        public override void FazerSom()
        {
            System.Console.WriteLine("auauauauuauau");
        }
    }
}