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

        /// <summary>
        /// Constructor de persona
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        /// <param name="nombre"></param>
        public Persona(string apellido, int dni, int edad, string nombre)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }

        /// <summary>
        /// Propiedad que devuelve string
        /// </summary>
        public string Apellido 
        { 
            get
            {
                return this.apellido;
            }
        }

        /// <summary>
        /// Propiedad que devuelve string
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        /// <summary>
        /// Propiedad que devuelve int
        /// </summary>
        public int Dni 
        {
            get
            {
                return this.dni;
            } 
        }

        /// <summary>
        /// Propiedad que devuelve int
        /// </summary>
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }

        public abstract bool ValidarAptitud();

        /// <summary>
        /// Metodo que devuelve una cadena
        /// </summary>
        /// <returns>Cadena que se devolverá</returns>
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{this.Nombre} {this.Apellido} {this.Edad} {this.Dni}");

            return sb.ToString();
        }
    }
}
