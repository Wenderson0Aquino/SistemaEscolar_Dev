using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    internal class Turma
    {
        private string Turno { get; set; }
        private string Serie { get; set; }
        private string Sigla { get; set; }
        private string TipoEnsino { get; set; }

        public Turma(string turno, string serie, string sigla, string tipoensino) 
        {
            Turno = turno;
            Serie = serie;
            Sigla = sigla;
            TipoEnsino = tipoensino;
        }
        public void MostrarTurma() 
        {
        Console.WriteLine(Turno + " " + Serie + " " + Sigla + " " + TipoEnsino);
        }  
        ~Turma() 
        {
        }
    }
}
