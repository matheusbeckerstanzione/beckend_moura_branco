using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilares
{
    public class Professor : Pessoa
    {
        public string disciplina = "";

        public void professorDiscipli()
        {
            System.Console.WriteLine($"O professor {Nome} a disciplina dele e {disciplina} e a idade dele e {Idade}");
        }
    }
}