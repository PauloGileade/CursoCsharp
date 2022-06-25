using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21ExercicioClinicaMedica.Entiteis
{
    internal class ClinicaMedica
    {
        List<Medico> listMedico = new List<Medico>();
        List<Paciente> listPaciente = new List<Paciente>();
        List<Consulta> listConsulta = new List<Consulta>();

        public void addMedico(Medico addMedico)
        {
            listMedico.Add(addMedico);
        }

        public void removerMedico(Medico rmvMedico)
        {
            listMedico.Remove(rmvMedico);
        }

        public void addPaciente(Paciente addPaciente)
        {
            listPaciente.Add(addPaciente);
        }

        public void removerPaciente(Paciente rmvPaciente)
        {
            listPaciente.Remove(rmvPaciente);
        }

        public void addConsulta(Consulta addConsulta)
        {
            listConsulta.Add(addConsulta);
        }

        public void removerConsulta(Consulta rmvConsulta)
        {
            listConsulta.Remove(rmvConsulta);
        }

    }
}
