using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//a.ExponerDatos tendrá implementación en todas las clases y podrá ser sobre sobreescrita en las clases derivadas.
//b. ValidarDocumentacion no tendrá implementación dentro de Persona.

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string documento;
        private string apellido;

        public Persona(string nombre, string apellido, string documento)
        {
            this.nombre = nombre;
            this.documento = documento;
            this.apellido = apellido;
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }

        public string Documento
        {
            get
            {
                return this.documento;
            }set
            {
                if(this.ValidarDocumentacion(value))
                {
                    this.documento = value;
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        protected abstract bool ValidarDocumentacion(string doc);

        /// <summary>
        /// Muestra los datos de una persona
        /// </summary>
        /// <returns>Una cadena con los datos de la persona</returns>
        public virtual string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Alumno: {this.Nombre} {this.Apellido}");
            sb.Append($"Documento: {this.Documento}");

            return sb.ToString();
        }
    }
}
