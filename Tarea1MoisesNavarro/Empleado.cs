using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1MoisesNavarro
{
    public class Empleado : Persona
    {
        private double salario;

        public Empleado(int id, string nombre, string primerApe, string segundoApe, double salario)
            : base(id, nombre, primerApe, segundoApe)
        {
            this.salario = salario;
        }

        public double Salario
        {
            get { return this.salario; }
            set { this.salario = value; }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalario  : " + this.salario;
        }

    }
}
