using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula17ExercicioHerancaEPolimorfismo.Entiteis
{
    internal class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePorHour { get; set; }

        public Employee()
        {

        }

        public Employee(string name, int hours, double valuePorHour)
        {
            Name = name;
            Hours = hours;
            ValuePorHour = valuePorHour;
        }

        public virtual double Payment()
        {
            return ValuePorHour * Hours;
        }
    }
}
