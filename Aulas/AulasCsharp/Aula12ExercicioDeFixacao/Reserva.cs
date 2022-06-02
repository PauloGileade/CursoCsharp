using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula12ExercicioDeFixacao
{
    internal class Reserva
    {
        public string Name { get; set; }
        public string Email { get; set; }


        public Reserva(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return Name + ", " + Email;
        }
    }
}
