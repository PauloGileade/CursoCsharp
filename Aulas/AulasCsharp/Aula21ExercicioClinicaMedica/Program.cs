using System;
using Aula21ExercicioClinicaMedica.Entiteis;
using System.Globalization;

namespace Aula21ExercicioClinicaMedica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClinicaMedica clinicaMedica = new ClinicaMedica();
            int opcao = 1;

            do
            {
                Console.WriteLine("(1) Cadastra Médico");
                Console.WriteLine("(2) Cadastra Paciente");
                Console.WriteLine("(3) Marcar consulta");
                Console.WriteLine("(4) Desmarcar consulta");
                Console.WriteLine("(5) Listar consultas por dia");
                Console.WriteLine("(6) Listar consultas por médico");
                Console.WriteLine("(7) Listar consultas por especilidade");
                Console.WriteLine("(8) Listar consultas por paciente");
                Console.WriteLine("(9) Calcular total em caixa do dia");
                Console.WriteLine("(0) Encerrar");

                Console.Write("\nInforme a opção: ");
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe o nome do médico: ");
                        string nomeMedico = Console.ReadLine();
                        Console.Write("Informe a especialidade do médico: ");
                        string especialidadeMedico = Console.ReadLine();

                        Especialidade especialidade = new Especialidade(especialidadeMedico);
                        Medico medico = new Medico(nomeMedico, especialidade);
                        clinicaMedica.addMedico(medico);
                        break;

                    case 2:
                        Console.Write("Informe o nome do paciente: ");
                        string nomePaciente = Console.ReadLine();
                        Console.Write("informe o RG: ");
                        string rgPaciente = Console.ReadLine();
                        Console.Write("Informe a data de nascimento (dd/mm/YYYY): ");
                        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
                        Console.Write("Informe seu peso: ");
                        double pesoPaciente = double.Parse(Console.ReadLine());
                        Console.Write("Informe o sexo do Paciente: ");
                        char sexoPaciente = char.Parse(Console.ReadLine());

                        Paciente paciente = new Paciente(nomePaciente, rgPaciente, dataNascimento, pesoPaciente, sexoPaciente);
                        clinicaMedica.addPaciente(paciente);
                        break;

                    case 3:
                        Console.Write("Informe o nome do paciente: ");
                        string consultaNomePaciente = Console.ReadLine();
                        Console.WriteLine("Informe o RG do paciente: ");
                        string consultaRgPaciente = Console.ReadLine();

                }
            } while (opcao != 0);
        }
    }
}
