using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios firmino = new Funcionarios("Firmino", "123.321.123-55", "Zelador", 5000);
            Turma ctds = new Turma("Noturno", "2", "CTDS", "HT");
            Aluno wenderson = new Aluno("Wenderson", "123423421", Convert.ToDateTime("29/03/2006"), ctds);

            wenderson.MostrarDados();

            Console.ReadKey();
        }
    }
}
