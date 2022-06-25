using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21ExercicioClinicaMedica.Entiteis
{
    internal class Paciente
    {
        public string Nome { get; set; }
        public string Rg { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public double Peso { get; set; }
        public char Sexo { get; set; }

        public Paciente(string nome, string rg, DateTime dataDeNascimento, double peso, char sexo)
        {
            Nome = nome;
            Rg = rg;
            DataDeNascimento = dataDeNascimento;
            Peso = peso;
            Sexo = sexo;
        }
    }
}
