using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1MoisesNavarro
{
    public class Persona
    {
        private int id;
        private string nombre;
        private string primerApe;
        private string segundoApe;

        public Persona(int id, string nombre, string primerApe, string segundoApe)
        {
            this.id = id;
            this.nombre = nombre;
            this.primerApe = primerApe;
            this.segundoApe = segundoApe;
        }


        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string PrimerApe
        {
            get { return this.primerApe; }
            set { this.segundoApe = value; }
        }

        public string SegundoApe
        {
            get { return this.segundoApe; }
            set { this.segundoApe = value; }
        }

        public override string ToString()
        {
            return ("La id es: " + this.id + "\nNombre: " + this.nombre + 
                "\nPrimer Apellido: " + this.primerApe + "\nSegundo Apellido: "+ this.segundoApe);
        }
    }
}
