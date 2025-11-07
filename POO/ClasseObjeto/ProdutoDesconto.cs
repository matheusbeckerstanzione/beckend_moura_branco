using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;



namespace ClasseObjeto
{
   public class Produto
    {
        
        public string Nome;
        public double Preco;

        
        public void AplicarDesconto(double percentual)
        {
            double desconto = Preco * (percentual / 100);
            Preco -= desconto;

            System.Console.WriteLine($"Desconto de {percentual}% aplicado com sucesso!");
            System.Console.WriteLine($"Novo preço do produto {Nome}: R${Preco:F2}\n");
        }

    }
}