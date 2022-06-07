using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16ExercicioEnumComposicao.Entiteis
{
    internal class Cliente
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthdate { get; set; }

        public Cliente()
        {
        }
        public Cliente(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Birthdate = date;
        }
        public override string ToString()
        {
            return Name + " " + Birthdate.ToString("dd/MM/yyyy") + " - " + Email;
        }
    }
}
