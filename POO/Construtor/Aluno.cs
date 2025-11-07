using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtor
{
    public class Aluno
    {
        public String Nome;
        public float Nota;

        public Aluno()
        {
            Nome = "Sem nome";
            Nota = 0f;
        }

        public Aluno(String n, int i)
        {
            Nome = n;
            Nota = i;
        }

        public void Exibirdados()
        {
            System.Console.WriteLine($"Aluno {Nome} Nota {Nota}");
        }
    }
}