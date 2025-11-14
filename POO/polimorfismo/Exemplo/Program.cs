using Exemplo;



PagamentoPix CompraPix = new PagamentoPix();
CompraPix.ValorCompra = 15000;
float ValorPagar = CompraPix.CalcularTotal();
Console.WriteLine($"Produto Iphone 17 PRO MAX");
Console.WriteLine($"Pagar {CompraPix.ValorCompra}");
Console.WriteLine($"Pagamento com desconto {ValorPagar}");



PagamentoCartao CompraCartao = new PagamentoCartao();
CompraCartao.ValorCompra = 20000;

