using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class ContaBancaria
    {
        private float Saldo;

    public ContaBancaria()
        {
            Saldo = 0;
        }

        public ContaBancaria(float SaldoInicial)
        {
            if (SaldoInicial > 0 )
            {
                Saldo = SaldoInicial;
            }

            else
            {
                Saldo = 0;
            }
        }
















        public void Dpositar(float Valor)
        {

            if (Valor <= 0)
            {
                Console.WriteLine($"nao e permitido valores negativos");
                

            }
            else
            {
                Saldo += Valor;
            }
            
        }

        public void Sacar(float Valor)
        {

            if (Valor <= 0)
            {
                 Saldo -= Valor;
                Console.WriteLine($"so pode sacar valores positivos");
                
            }

            else
            {
               Console.WriteLine($"so pode sacar valores positivos");
            }
            
        }

        public float GetSaldo()
        {
            return Saldo;
        }
    }
}