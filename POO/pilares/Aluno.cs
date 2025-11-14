using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pilares
{
    public class Aluno : Pessoa
    {
        public string curso = "";


        public void alunoRegistrado()
        {
            System.Console.WriteLine($"O aluno {Nome} faz curso de {curso} e ele tem {Idade}");
        }
    }
}