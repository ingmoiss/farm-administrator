using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1MoisesNavarro
{
    public class Dueno : Persona
    {
        private string correo;
        private int celular;
        private Finca finca;

        public Dueno(int id, string nombre, string primerApe, string segundoApe, string correo, int celular, Finca finca)
            : base(id, nombre, primerApe, segundoApe)
        {
            this.correo = correo;
            this.celular = celular;
            this.finca = finca;
        }   

        public string Correo
        {
            get { return this.correo; }
            set { this.correo = value; }
        }

        public int Celular
        {
            get { return this.celular; }
            set { this.celular = value; }
        }

        public Finca Finca
        {
            get { return this.finca; }
            set { this.finca = value; }
        }

        public override string ToString()
        {
            return (base.ToString() + "\nCorreo: " + this.correo + "\nCelular: " + this.celular + "\nEL numero de finca es: " + this.finca.NumFinca);
        }

    }
}
