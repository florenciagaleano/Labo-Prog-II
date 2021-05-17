using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30_36_46_49
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;

        public CompetenciaNoDisponibleException(string mensaje,string clase,string metodo)
            :this(mensaje,clase,metodo,null)
        {
            
        }

        public CompetenciaNoDisponibleException(string mensaje, string clase, string metodo,Exception innerException)
            : base(mensaje,innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }

        public string NombreClase
        {
            get
            {
                return this.nombreClase;
            }
        }

        public string NombreMetodo
        {
            get
            {
                return this.nombreMetodo;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Exception e;

            sb.AppendLine($"Excepcion en el metodo {this.NombreMetodo} de la clase {this.NombreClase}");
            sb.AppendLine(this.Message);

            do
            {
                e = this.InnerException;
                if(e != null)
                {
                    sb.AppendLine(e.Message);
                }
            }while (e != null) ;

            return sb.ToString();
        }
    }
}
