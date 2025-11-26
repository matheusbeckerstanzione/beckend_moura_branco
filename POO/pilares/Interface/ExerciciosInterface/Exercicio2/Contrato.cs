using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Contrato : IImprimivel
    {
        public String Nome;

        public String TextoClausulas;

        public void Imprimir()
        {
            
            throw new NotImplementedException();
        }

     public Contrato (string name, string tcx)
    {
        Nome = name;
        TextoClausulas = tcx;
    }
  
   public void CadastrarClausulaContrato()
        {
            System.Console.WriteLine($"Cadastrando o seu relatorio....");
            
        }

    }
}