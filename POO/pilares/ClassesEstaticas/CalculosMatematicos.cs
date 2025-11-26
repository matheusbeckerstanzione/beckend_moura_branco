using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    public class CalculosMatematicos
    {
        public double PI = 3.14159265359;
        

        public static float Somar(float x, float y)
        {
            //System.Console.WriteLine($"Somar é igual a {x + y}");

            return x + y;
        }



 public static float Subtrair(float x, float y)
        {
            

            return x - y;
        }


  public static float Multiplicacao(float x, float y)
        {
            

            return x * y;
        }

         public static float Dividir(float x, float y)
        {
            

        if (y == 0)
            {
                System.Console.WriteLine($"O RESULTADO DA SUA DIVISAO E {Dividir}");

               
            }
            return x / y;
        }



    }
}