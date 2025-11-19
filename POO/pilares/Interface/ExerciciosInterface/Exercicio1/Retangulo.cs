using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pilares.Interface.ExerciciosInterface;

namespace Exercicio1
{
    public class Retangulo : IForma
    {
        //Parametro
        public float Largura;
        public float Altura;

        public void CalcularArea()
        {
            float Area = Largura * Altura;
          System.Console.WriteLine($"calculo da area e de {Area}");
        }

    //Construtor
        public  Retangulo(float Largura, float Altura)
        {
                Largura = Largura;
                Altura = Altura;
        }
    }

}