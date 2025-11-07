namespace PrimeiraClasse
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public int Altura;//em centímetros

        public void Falar()
        {
            Console.WriteLine($"Olá, eu sou {Nome} e tenho {Idade} anos!");
        }
        public void Dormir()
        {
            Console.WriteLine($"ZZZzzzz ...");
        }

        public void Envelhecer(int id = 0)
        {
            if (id > 0)
            {
                Idade += id;
            }

            else
            {
               Idade++; 
            }
           
        }
    }
}