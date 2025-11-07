
namespace ClasseObjeto //herdando da primeira classe
{
    public class Garrafa
    {
        //
        public string Marca;

        public double Litro;

        public string Cor;


        // métodos
        public void abrir()
        {
            Console.WriteLine($"esta aberta");

        }

        public void fechar()
        {
            Console.WriteLine($"esta fechada");
        }

        public void encher()
        {
            System.Console.WriteLine($"enchendo a garrafa");
        }

        public void esvaziar()
        {
            System.Console.WriteLine($"garrafa esvaziando");
        }
        
    }
}