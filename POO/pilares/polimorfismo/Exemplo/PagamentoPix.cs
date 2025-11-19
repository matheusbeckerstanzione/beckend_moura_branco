namespace Exemplo
{
    public class PagamentoPix : Pagamento
    {
       //desconto a vista 5%
        private float Desconto = 5;
        public float ValorCompra;
        public override
         float CalcularTotal()
        {
            float valorDesconto = ValorCompra / 100 * Desconto;

            ValorCompra = ValorCompra - valorDesconto;
            return 0;
        }
        
    }
}