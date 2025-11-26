using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2;

    public class Fatura : IImprimivel
    {
  public string Devedor = "";
        public string Credor = "";
        public float Valor = 0;
        public int DiasAtraso = 0;
        private float Juros = 0.10f;
    private string? rel;
    private string? txr;

    public Fatura(string? rel, string? txr)
    {
        this.rel = rel;
        this.txr = txr;
    }

    public Fatura(string NomeDevedor, string NomeEmpresa, float ValorFatura, int QtdDiasAtraso)
        {
            Devedor = NomeDevedor;
            Credor = NomeEmpresa;
            Valor = ValorFatura;
            DiasAtraso = QtdDiasAtraso;
        }

        public void CalcularValorDivida()
        {
            if (DiasAtraso > 0)
            {
                Valor = Valor + DiasAtraso * Juros;
            }

            if (DiasAtraso >= 5)
            {
                Console.WriteLine($"Dívida encaminhada para o SERASA");
            }

        }

        public void Imprimir()
        {
            CalcularValorDivida();

            Console.WriteLine($@"
            Credor: {Credor}
            Devedor: {Devedor}
            Dias de Atraso: {DiasAtraso}
            Juros: R${Juros * DiasAtraso}
            Valor Total: R${Valor}
            ");
            
        }
}