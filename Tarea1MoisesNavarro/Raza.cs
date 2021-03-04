using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1MoisesNavarro
{
    public class Raza
    {
        private string codigo;
        private string descripcion;
        
        public Raza(string codigo, string descripcion)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
        }

        public string Codigo
        {
            get { return this.codigo; }
            set { this.codigo = value; }
        }

        public string Descripcion
        {
            get { return this.descripcion; }
            set { this.descripcion = value; }
        }

        public string ToString()
        {
            return "Codigo: " + this.codigo + "\nDescripcion: " + this.descripcion;
        }

    }
}
