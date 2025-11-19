using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Controle : IControle
    {
        public int NivelVolume = 0;
        public int VolumeMaximo = 100;

        

        public void AumentarVolume()
        {
           if (NivelVolume == VolumeMaximo)
            {
                System.Console.WriteLine($"Volume atingido {NivelVolume}");
                return;
            }

            NivelVolume++;
            System.Console.WriteLine($"Volume {NivelVolume}");
        }

        public void Desligar()
        {
            System.Console.WriteLine("tv desligado");
        }

        public void DiminuirVolume()
        {

            if (NivelVolume == 0)
            {
                System.Console.WriteLine($"Volume minimo atingido {NivelVolume}");
                return ;
            }

            NivelVolume--;
            System.Console.WriteLine($"Volume {NivelVolume}");
        }

        public void Ligar()
        {
            System.Console.WriteLine("tv ligada");
        }

      
        }
    }
