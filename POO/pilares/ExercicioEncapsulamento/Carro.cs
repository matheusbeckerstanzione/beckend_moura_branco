using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioEncapsulamento
{
    public class Carro
    {
        private String Marca;

        private String Modelo;

        private int VelocidadeAtual;

         public void DefinirMarcas(String valor)
        {
            Marca = valor;
        }

        public string ObterMarca()
        {
            return Marca;
        }

         public void DefinirModelo(String valor)
        {
            Modelo = valor;
        }

        public string ObterModelo()
        {
            return Modelo;
        }


        public int ObterVelocidade()
        {
            return VelocidadeAtual;
        }

        public void Acelerar (int valor)
        {
            if (valor < 0)
            {
                Console.WriteLine($"velocidade invalida");
            }
            else
            {
                VelocidadeAtual = VelocidadeAtual + valor;
                Console.WriteLine($"Nova velocidade cidadao {VelocidadeAtual}");
                
            }
        }


        public void Desacelerar(int valor)
        {
            if (valor < 0)
            {
               Console.WriteLine($"calma aiiiiiiiiiiiiiii freio de mais ");
            }

            else
            {
                VelocidadeAtual = VelocidadeAtual - valor;
                if(VelocidadeAtual < 0)
                {
                    VelocidadeAtual = 0;
                }
            }

            Console.WriteLine($"Velocidade atual  {VelocidadeAtual}");
            

        }


    }


   
}
