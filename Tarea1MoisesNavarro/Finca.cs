using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1MoisesNavarro
{
    public class Finca
    {
        private int numFinca;
        private string nomFinca;
        private int size;
        private string direccion;
        private int tel;

        //Desclaracion del constructor
        public Finca(int numFinca, string nomFinca, int size, string direccion, int tel)
        {
            this.numFinca = numFinca;
            this.nomFinca = nomFinca;
            this.size = size;
            this.direccion = direccion;
            this.tel = tel;
        }

        //Metodos getters y setter para numero de finca
        public int NumFinca
        {
            get { return this.numFinca; }
            set { this.numFinca = value; }
        }

        //Metodos getters y setter para nombre de finca
        public string NomFinca
        {
            get { return this.nomFinca; }
            set { this.nomFinca = value; }
        }
        //Metodos getters y setter para tamano de finca
        public int Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public string Direccion
        {
            get { return this.direccion; }
            set { this.direccion = value; }
        }

        public int Telefono
        {
            get { return this.tel; }
            set { this.tel = value; }
        }

        public string ToString()
        {
            return ("El nombre es: " + this.nomFinca + "\nEl numero es: " + this.numFinca + "\nHectarias: " + this.size + 
                "\nDireccion: " + this.direccion + "\nTelefono: " + this.tel);
        }         
    }
}
