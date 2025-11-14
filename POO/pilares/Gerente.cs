using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilares
{
    public class Gerente : Funcionario
    {
        public int Bonus = 1200;

        public int NovoSalario ;

        public void CalcularSalario()
        {
            NovoSalario = salarioBase + Bonus;

            System.Console.WriteLine($"Seu salario atual e {NovoSalario}");
        }
    }
}