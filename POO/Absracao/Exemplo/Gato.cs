using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public class Gato : Animal
    {
        public override void Andar()
        {
           System.Console.WriteLine( "puc poc poc");
        }

        

        public override void FazerSom()
        {
            System.Console.WriteLine("miauuu");
        }
    }
}