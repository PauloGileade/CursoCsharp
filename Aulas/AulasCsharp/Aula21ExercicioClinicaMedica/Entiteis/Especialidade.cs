using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21ExercicioClinicaMedica.Entiteis
{
    internal class Especialidade
    {
        public string EspecialidadeMedico { get; set; }

        public Especialidade(string especialidade)
        {
            EspecialidadeMedico = especialidade;
        }
    }
}
