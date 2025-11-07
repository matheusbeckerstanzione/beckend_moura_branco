
namespace ClasseObjeto
{
    public class Agencia
    {
        public string titular = "";

        public float saldo;

        public void depositar(float _valorSaque)
        {
            if (_valorSaque < +1)
            {
                System.Console.WriteLine($"O valor deve ser maior que 0");
                return;
            }

            saldo += _valorSaque;
        }

        public void sacar (float _valorSaque)
        {
            if (_valorSaque <= 0 && _valorSaque < saldo)
            {
                System.Console.WriteLine($"Saldo atual {saldo}");
                System.Console.WriteLine($"Nao e possivel sacar esse valor");
                return;
            }


            saldo -= _valorSaque;

            System.Console.WriteLine($"Saque realizado. Novo saldo {saldo}");
        }
    }
}