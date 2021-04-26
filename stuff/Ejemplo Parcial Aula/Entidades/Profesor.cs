using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Profesor : Persona
    {
        private DateTime ingreso;

        //a. Antigüedad devolverá la cantidad de tiempo, en días,
        //desde la fecha de ingreso del profesor hasta la actualidad.
        //b.ValidarDocumentacion dará como válido cuando el documento
        //tenga exactamente 8 caracteres.

        public Profesor(string nombre,string apellido,string documento)
            :base(nombre,apellido,documento)
        {

        }

        public Profesor(string nombre, string apellido, string documento,DateTime fechaIngreso)
            : this(nombre, apellido, documento)
        {
            this.ingreso = fechaIngreso;
        }

        public int Antiguedad
        {
            get
            {
                return DateTime.Now.Subtract(this.ingreso).Days;
            }
        }

        /// <summary>
        /// Muestra los datos de un profesor
        /// </summary>
        /// <returns>Una cadena con los datos del profesor</returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine($"Antigüedad: {this.Antiguedad}");

            return sb.ToString();
        }

        protected override bool ValidarDocumentacion(string doc)
        {
            if (doc.Length != 8)
            {
                return false;
            }

            return true;
        }

    }
}
