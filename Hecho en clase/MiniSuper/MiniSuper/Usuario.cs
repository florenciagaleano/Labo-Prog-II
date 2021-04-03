using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper
{
    public class Usuario
    {
        string nombre;
        string apellido;
        long dni;
        string[] formasPago;//checkboxes asi q pueden ser varias por eso []
        string formaPago;//radiobutton so 1 sola
        string provincia;

        public Usuario(string nombre, string apellido, long dni,string[] formasPago,string formaPago,string provincia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.formasPago = formasPago;
            this.formaPago = formaPago;
            this.provincia = provincia;
        }

        public override string ToString()
        {
            return this.MostrarNombres();
        }

        public string MostrarNombres()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.nombre);
            sb.Append(this.apellido);
            sb.Append(this.dni);
            foreach (string item in this.formasPago)
            {
                sb.AppendFormat(" {0} ", item);
            }
            sb.Append(this.formaPago);
            sb.Append(this.provincia);

            return sb.ToString();
        }

    }
}
