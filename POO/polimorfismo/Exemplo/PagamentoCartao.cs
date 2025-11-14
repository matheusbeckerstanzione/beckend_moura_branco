namespace Exemplo
{


    public class PagamentoCartao : Pagamento
    {
        private float Desconto = 5;
        public float ValorCompra;
        public override float CalcularTotal()
        {
            float valorAcrescimo = ValorCompra / 100 * Desconto;

            ValorCompra = ValorCompra + valorAcrescimo;

            return 0;
        }

    }
}