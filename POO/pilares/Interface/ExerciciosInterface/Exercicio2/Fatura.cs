using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Fatura : IImprimivel
    {
public int DiasAtraso;
public float juros = 0.10f;



public Fatura(String nomeDevedor, String NomeEmpresa, float valorFatura, int qtdDias)
        {
            
        }

        public void Imprimir()
        {
            throw new NotImplementedException();
        }
    }
}