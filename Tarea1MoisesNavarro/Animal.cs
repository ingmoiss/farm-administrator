using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1MoisesNavarro
{
    public class Animal
    {
        private int id;
        private string nombre;
        private Finca finca;
        private Raza raza;
        private string sexo;
        private string madre;
        private string padre;

        public Animal(int id, string nombre, Finca finca, Raza raza, string sexo, string madre, string padre)
        {
            this.id = id;
            this.nombre = nombre;
            this.finca = finca;
            this.raza = raza;
            this.sexo = sexo;
            this.madre = madre;
            this.padre = padre;
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

        public Finca Finca
        {
            get { return this.finca; }
            set { this.finca = value; }
        }

        public Raza Raza
        {
            get { return this.raza; }
            set { this.raza = value; }
        }

        public string Sexo
        {
            get { return this.sexo; }
            set { this.sexo = value; }
        }

        public string Madre
        {
            get { return this.madre; }
            set { this.madre = value; }
        }

        public string Padre
        {
            get { return this.padre; }
            set { this.padre = value; }
        }

        public override string ToString()
        {
            return ("Id: " + this.id + "\nNombre: " + this.nombre + "\nRaza:" + this.raza.Codigo + "\nSexo: " + this.sexo + 
                "\nPadre: " + this.padre + "\nMadre: " + this.madre);
        }
    }
}
