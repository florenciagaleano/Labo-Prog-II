using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        protected Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        public string Patente
        {
            get
            {
                return this.patente;
            }
            set
            {
                if(value.Length == 6)
                {
                    this.patente = value;
                }
            }
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.ToString());
            sb.AppendLine($"Ingreso: {this.ingreso}");

            return sb.ToString();

        }

        public override string ToString()
        {
            return string.Format("Patente: {0}", this.patente);
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            if(v1.Patente == v2.patente && v1.Equals(v2))
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
