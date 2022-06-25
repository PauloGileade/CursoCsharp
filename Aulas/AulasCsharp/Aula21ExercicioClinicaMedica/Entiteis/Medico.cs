using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21ExercicioClinicaMedica.Entiteis
{
    internal class Medico
    {
        public string Nome { get; set; }
        public Especialidade especialidade { get; set; }

        public Medico(string nome, Especialidade especialidade)
        {
            Nome = nome;
            this.especialidade = especialidade;
        }
    }
}
