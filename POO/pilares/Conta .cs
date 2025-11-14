using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilares
{
    public class Conta
    {
        public int numero;
        public double saldo;


        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
            }

            else
            {
                System.Console.WriteLine($"Saldo insuficiente kkkkkkkkkkkk");
            }
        }
    }
    

}