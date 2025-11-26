using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Relatorio : IImprimivel
    { 
        public String NomeResponsavel;

        public String TextoRelatorio;


         public Relatorio(string rel, string txr)
    {
        NomeResponsavel = rel;
        TextoRelatorio = txr;
    }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimindo o relatório");
        }


          public void CadastrarClausulaRelatorios()
        {
            System.Console.WriteLine($"Imprimindo o seu relatorio....");
            
        }

    }
}