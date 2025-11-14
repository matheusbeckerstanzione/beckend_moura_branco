using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilares
{
    public class ContaBancaria : Conta
    {
        public void CalcularSalario()
        {
            saldo += saldo * 0.02;
        }
        
    }
}