using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public string RG { get; set; }
        public DateTime Nascimento { get; set; }
        public Turma Turma { get; set; }    

        public Aluno(string nome, string rg, DateTime nascimento, Turma turma)
        {
            Nome = nome;
            RG = rg;
            Nascimento = nascimento;
            Turma = turma;
        }

        public void MostrarDados()
        {
            Console.WriteLine(Nome + RG + Nascimento);
            Turma.MostrarTurma();
        }
    }
}
