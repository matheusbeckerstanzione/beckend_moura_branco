using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo
{
    public abstract class ContaBancaria
    {

    
        public abstract double Depositar(double ValorDeposito); 
        public abstract double Sacar(double ValorSaque);
    
    }
}