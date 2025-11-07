

namespace Calculadora
{
    public class Calculador
    {
        public double N1, N2;

        public double Resultado;

        public double Somar()
        {
            Resultado = N1 + N2;
        System.Console.WriteLine($"Resultado da conta e {Resultado}");
            return Resultado;
        }
        public double Subtrair()
        {
            Resultado = N1 - N2;
             System.Console.WriteLine($"Resultado da conta e {Resultado}");
            return Resultado;
        }
        public double Dividir()
        {
            Resultado = N1 /  N2;
              System.Console.WriteLine($"Resultado da conta e {Resultado}");
            return Resultado;
        }
        public double Multiplicar()
        {
            Resultado = N1 * N2;
            System.Console.WriteLine($"Resultado da conta e {Resultado}");
            return Resultado;
        }

    }
}