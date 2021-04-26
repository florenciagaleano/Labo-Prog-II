using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno : Persona
    {
        private short anio;
        private Division division;

        public Alumno(string nombre,string apellido,string documento,short anio,Division division)
            :base(nombre,apellido,documento)
        {
            this.anio = anio;
            this.division = division;
        }

        //La propiedad AnioDivision retornará un string con el siguiente
        //formato: XºZ, siendo X el año que se encuentra cursando y Z la
        //división en letra (A, B, C, D o E).

        public string AnioDivision
        {
            get
            {
                return $"{this.anio}º{this.division}";
            }
        }

        /// <summary>
        /// Muestra los datos de una alumno
        /// </summary>
        /// <returns>Una cadena con los datos del alumno</returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ExponerDatos());
            sb.AppendLine($"Division: {this.AnioDivision}");
            sb.AppendLine("");//para que quede un espacio

            return sb.ToString();
        }

        //a.ValidarDocumentacion dará como válido sólo documentos que tengan
        //el siguiente formato XX-XXXX-X siendo las X números.Caso contrario
        //retornará false y no se asignará el documento, siguiendo luego con el
        //curso normal de la aplicación.
        protected override bool ValidarDocumentacion(string doc)
        {
            if(doc.Length != 9)
            {
                for(int i=0; i < 9; i++)
                {
                    if(doc[2] == '-' && doc[7] == '-')
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }


}
