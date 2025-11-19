using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public interface IMotor
    {
        void Acelerar(); // void pq ele nao vai retornar um valor 

        void Frear(); // void ele nao retorna valor
    }
}