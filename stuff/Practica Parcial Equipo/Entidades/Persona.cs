using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;

        public Persona(string apellido, int dni, int edad, string nombre)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }

        public string Apellido 
        { 
            get
            {
                return this.apellido;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Dni 
        {
            get
            {
                return this.dni;
            } 
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public abstract bool ValidarAptitud();

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Nombre} {this.Apellido} {this.Edad} {this.Dni}");

            return sb.ToString();
        }
    }
}
