using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Interfaces
{
    public class Pesado : Paquete, IAduana,IAfip
    {
        private bool prioridad;

        public Pesado(double peso, string codigoSeguimiento, string origen, string destino, double costoEnvio, bool prioridad)
            : base(peso, codigoSeguimiento, origen, destino, costoEnvio)
        {
            this.prioridad = prioridad;
        }

        public override bool Prioridad
        {
            get
            {
                return this.prioridad;
            }
        }

        double IAduana.CalcularImpuesto()
        {
            return base.costoEnvio * 0.35;
        }
        double IAfip.CalcularImpuesto()
        {
            return base.costoEnvio * 0.25;
        }

        public override string Informacion()
        {
            string impAduana = ((IAduana)this).CalcularImpuesto().ToString();
            string impAfip = ((IAfip)this).CalcularImpuesto().ToString();
            return base.Informacion() + "Costo envio aduana: " + impAduana + "Costo envio Afip:" + impAfip;
        }
    }
}
