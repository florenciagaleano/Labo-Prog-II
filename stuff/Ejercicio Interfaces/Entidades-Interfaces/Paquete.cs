using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interfaces
{
    public abstract class Paquete
    {
        protected string codigoSeguimiento;
        protected double costoEnvio;
        protected string destino;
        protected string origen;
        protected double peso;

        protected Paquete(double peso,string codigoSeguimiento,string origen,string destino,double costoEnvio)
        {
            this.peso = peso;
            this.codigoSeguimiento = codigoSeguimiento;
            this.destino = destino;
            this.origen = origen;
            this.costoEnvio = costoEnvio;
        }

        public abstract bool Prioridad { get; }

        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Peso:{this.peso}");
            sb.AppendLine($"Codigo de seguimiento: {this.codigoSeguimiento}");
            sb.AppendLine($"Costo envio: {this.costoEnvio}");
            sb.AppendLine($"Destino:{this.destino}");
            sb.AppendLine($"Origen:{this.origen}");
            sb.AppendLine($"Prioridad:{this.Prioridad}");

            return sb.ToString();
        }
    }
}
