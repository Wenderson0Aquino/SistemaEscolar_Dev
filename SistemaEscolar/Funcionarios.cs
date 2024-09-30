using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscolar
{
    internal class Funcionarios
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        public Funcionarios(string nome, string cpf, string cargo, double salaio)
        {
            Nome = nome;
            CPF = cpf;  
            Cargo = cargo;
            Salario = salaio;
        }

        public string AumentarSalario(double valor)
        {
            Salario += valor;
            return "Salário Aumentado com Sucesso!";
        }

        public string ConsultarDados()
        {
            return "Nome: " + Nome + "\nCPF: " + CPF + "\nCargo: " + Cargo + "\nSalário: " + Salario.ToString("C2");
        }

        ~Funcionarios()
        {

        }
    }
}
