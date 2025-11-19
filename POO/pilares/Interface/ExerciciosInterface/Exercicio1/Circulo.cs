using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pilares.Interface.ExerciciosInterface;

namespace Exercicio1
{
    public class Circulo : IForma
    {

        public float Raio;

        private float PI = 3.14F;

        public void CalcularArea()
        {
            float Area = PI * Raio * Raio;
           System.Console.WriteLine($"O CALCULO DO CIRCULO E  {Area}" ); 
        }
    }
}