using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{

    
    public class Carro : IMotor // Estou herdando da interface motor 
    {

        //Propriedades

        //Estou dando caracteristica do carro chamando na string para texto e int para numero 
       public String Cor;
       public String Marca;
       public String Modelo;
       public int Ano;

       //Construtores
        public Carro(String c, String m, String mo, int a)// Estou dando nome para eu chamar por letra depois
        {
           Cor = c; 
           Marca = m; 
           Modelo = mo; 
           Ano = a; 
        }

        //Metodos 
        public void ExibirInformacoes()// Estou chamando um metodo para exibir as informações para o veiculo  
        {
 System.Console.WriteLine($@"Informacoes do Veiculo:

Cor: {Cor}
Marca: {Marca}
Modelo: {Modelo}
Ano: {Ano}
                        "); // dei um @ para eu conseguir pular linha e o c# reconhecer
                    }

       
        

        // Medodos
        public void Acelerar()// Estou implemtando da outra classe

        {
            // Dei uma mensagem para aparecer no terminal quando eu chamar no program
            System.Console.WriteLine($"Carro acelerando ........ vrum vrum "); 
        }

        public void Frear()// Estou implemtando da outra classe
        {
            // Dei uma mensagem para aparecer no terminal quando eu chamar no program
            System.Console.WriteLine($"Carro freiando ....... irrrrrrrr");
        }
    }
}