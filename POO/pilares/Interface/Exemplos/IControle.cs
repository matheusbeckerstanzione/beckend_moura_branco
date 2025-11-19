using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public interface IControle
    {
        
        void Ligar();

        void Desligar();

        void AumentarVolume();

        void DiminuirVolume();
    }
}