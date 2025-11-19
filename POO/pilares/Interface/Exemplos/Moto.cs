using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Moto : IMotor // Estou herdando da classe IMotor
    {

        // Criei propiedades para a moto 
        public String Cor;

        public String Marca;

        public String Modelo;

        public int Ano;

    // Metodos 
    public Moto (String c, String m, String mo, int a)
        {
            Cor = c; 
           Marca = m; 
           Modelo = mo; 
           Ano = a; 
        }

    // Metodos de acelerar e freiar
        public void Acelerar()
        {
            System.Console.WriteLine($"Moto acelerando ..... vrunnnn");
        }

        public void Frear()
        {
            System.Console.WriteLine($"Moto freiando ....... irrrrrrrr");
        }

 public void ExibirInformacoes()// Estou chamando um metodo para exibir as informações para o veiculo  
        {
 System.Console.WriteLine($@"Informacoes do Veiculo:

Cor: {Cor}
Marca: {Marca}
Modelo: {Modelo}
Ano: {Ano}
                        "); // dei um @ para eu conseguir pular linha e o c# reconhecer
                    }
    }
}